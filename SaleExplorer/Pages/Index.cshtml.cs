using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using CsvHelper.Configuration;
using GeoJSON.Net.Feature;
using GeoJSON.Net.Geometry;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;

namespace SaleExplorer.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IHostingEnvironment _hostingEnvironment;
        public string MapboxAccessToken { get; }

        public IndexModel(IConfiguration configuration, IHostingEnvironment hostingEnvironment)

        {
            _hostingEnvironment = hostingEnvironment;

            MapboxAccessToken = configuration["Mapbox:AccessToken"];
        }

        public IActionResult OnGetSales()
        {
            var configuration = new Configuration
            {
                BadDataFound = context => {}
            };
            
            using (var sr = new StreamReader(Path.Combine(_hostingEnvironment.WebRootPath, "2018MarionCountyIND_xlsWLatLong.dat")))
            using (var reader = new CsvReader(sr, configuration))
            {
                FeatureCollection featureCollection = new FeatureCollection();

                while (reader.Read())
                {
                    string saleDisclosureId = reader.GetField<string>(0);
                    string parcelNumber = reader.GetField<string>(1);
                    string numberOfParcels = reader.GetField<string>(2);
                    string saleStreet = reader.GetField<string>(3);
                    string saleCity = reader.GetField<string>(4);
                    string saleZip = reader.GetField<string>(5);
                    string saleConveyanceDate = reader.GetField<string>(6);
                    string salesPrice = reader.GetField<string>(7);
                    string buyer1 = reader.GetField<string>(8);
                    string seller1 = reader.GetField<string>(15);
                    string propertyClassCode = reader.GetField<string>(27);
                    string saleParcelAcreage = reader.GetField<string>(30);
                    string saleDate = reader.GetField<string>(31);
                    string dateRecieved = reader.GetField<string>(32);
                    string transferDate = reader.GetField<string>(33);
                    double lat = reader.GetField<double>(56);
                    double longitude = reader.GetField<double>(57);

                    featureCollection.Features.Add(new Feature(
                        new Point(new Position(lat, longitude)),
                        new Dictionary<string, object>
                        {
                            {"saleDisclosureId", saleDisclosureId},
                            {"parcelNumber", parcelNumber},
                            {"numberOfParcels", numberOfParcels},
                            {"saleStreet", saleStreet},
                            {"saleCity", saleCity},
                            {"saleZip", saleZip},
                            {"saleConveyanceDate", saleConveyanceDate},
                            {"salesPrice", salesPrice},
                            {"buyer1", buyer1},
                            {"seller1", seller1},
                            {"propertyClassCode", propertyClassCode},
                            {"saleParcelAcreage", saleParcelAcreage},
                            {"saleDate", saleDate},
                            {"dateRecieved", dateRecieved},
                            {"transferDate", transferDate},
                        }));
                }
            return new JsonResult(featureCollection);
            }


        }
        // TODO: 
        public void OnGet()
        {

        }
    }
}