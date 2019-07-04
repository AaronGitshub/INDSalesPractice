#pragma checksum "C:\WorkProjects\SaleExplorer\SaleExplorer\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcdda060372b3ebc3b4acf173fbb63ddd10a2529"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SaleExplorer.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(SaleExplorer.Pages.Pages_Index), null)]
namespace SaleExplorer.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\WorkProjects\SaleExplorer\SaleExplorer\Pages\_ViewImports.cshtml"
using SaleExplorer;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcdda060372b3ebc3b4acf173fbb63ddd10a2529", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3048405fa8a20efe6ccd3262580eff8c0e55baf2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 27, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(53, 816, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "906395fb30884c98842744855fbacb91", async() => {
                BeginContext(59, 803, true);
                WriteLiteral(@"
    <meta charset='utf-8' />
    <title>Sales Explorer</title>
    <meta name='viewport' content='initial-scale=1,maximum-scale=1,user-scalable=no' />
    <script src='https://api.mapbox.com/mapbox-gl-js/v1.1.0-beta.1/mapbox-gl.js'></script>

    <link href='https://api.mapbox.com/mapbox-gl-js/v1.1.0-beta.1/mapbox-gl.css' rel='stylesheet' />
    <link href=""https://cdn.jsdelivr.net/npm/tailwindcss/dist/tailwind.min.css"" rel=""stylesheet"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"" />

    <style>
        body {
            margin: 0;
            padding: 0;
        }

        #map {
            position: absolute;
            top: 0;
            bottom: 0;
            width: 100%;
        }
    </style>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(869, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(871, 5192, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "70194f9a7ba441468755053747c90a57", async() => {
                BeginContext(877, 869, true);
                WriteLiteral(@"
    <div id=""selections""></div>
    <div id='map'></div>

    <div id=""info-card"" class=""absolute pin-t pin-l mt-4 ml-4 rounded shadow-lg bg-white"" style=""max-width: 400px; display: none;"">
        <div>
            <span class=""absolute pin-t pin-r px-4 py-3"">
                <i id=""info-card-close-button"" class=""fa fa-times"" role=""button"" aria-hidden=""true""></i>
            </span>
            <img class="""" src=""http://via.placeholder.com/400x200?text=No+Picture+Found"" />
        </div>
        <div class=""px-6 py-4"">
            <div id=""sale-street"" class=""font-bold text-l"">Sale Address goes here</div>
            <div id=""sale-price"" class=""font-bold text-l"">Price goes here</div>
            <div id=""sale-buyer1"" class=""font-bold text-l"">Buyer 1 goes here</div>
        </div>
    </div>

    <script>
        mapboxgl.accessToken = '");
                EndContext();
                BeginContext(1747, 23, false);
#line 49 "C:\WorkProjects\SaleExplorer\SaleExplorer\Pages\Index.cshtml"
                           Write(Model.MapboxAccessToken);

#line default
#line hidden
                EndContext();
                BeginContext(1770, 4286, true);
                WriteLiteral(@"';
        var map = new mapboxgl.Map({
            container: 'map',
            style: 'mapbox://styles/mapbox/streets-v11',
            center: [-86.158066, 39.768402],
            zoom: 10
        });

        var nav = new mapboxgl.NavigationControl();
map.addControl(nav, 'bottom-right');

        map.on('load',
            () => {
    // Code to be executed after the map has loaded
     map.addSource(""sales"",
    {
        type: ""geojson"",
        data: ""?handler=Sales"",
        cluster: true, // Enable clustering
        clusterRadius: 50, // Radius of each cluster when clustering points
        clusterMaxZoom: 6 // Max zoom to cluster points on
});

        map.addLayer({
    id: 'sales',
    type: 'circle',
    source: 'sales',
                paint: {
                    'circle-color': {
                        property: 'point_count',
                        type: 'interval',
                        stops: [
                            [0, '#41A337'],
             ");
                WriteLiteral(@"               [100, '#2D7026'],
                            [750, '#0B5703'],
                        ]
                    },
                    'circle-radius': {
                        property: 'point_count',
                        type: 'interval',
                        stops: [
                            [0, 20],
                            [100, 30],
                            [750, 40]
                        ]
                    }
                }
        });
            map.addLayer({
                id: 'cluster-count',
                type: 'symbol',
                source: 'sales',
                filter: ['has', 'point_count'],
                layout: {
                    'text-field': '{point_count}',
                    'text-font': ['DIN Offc Pro Medium', 'Arial Unicode MS Bold'],
                    'text-size': 12
                }
            });

            map.addLayer({
                id: 'sales',
                type: 'circle',
               ");
                WriteLiteral(@" source: 'sales',
                filter: ['!has', 'point_count'],
                paint: {
                    'circle-color': '#1EF008',
                    'circle-radius': 6,
                    'circle-stroke-width': 1,
                    'circle-stroke-color': '#fff'
                }
            });

            var popup = new mapboxgl.Popup({
            closeButton: false,
            closeOnClick: false
            });
                    map.on('mouseenter', 'sales', function(e) {
            // Change the cursor style as a UI indicator.
            map.getCanvas().style.cursor = 'pointer';

            // Populate the popup and set its coordinates
            // based on the feature found.
            popup.setLngLat(e.features[0].geometry.coordinates)
                .setHTML(e.features[0].properties.saleStreet)
                .addTo(map);
        });

        map.on('mouseleave', 'sales', function() {
            map.getCanvas().style.cursor = '';
            popup.");
                WriteLiteral(@"remove();
        });
                map.on('click', 'sales', e => {
                    var saleStreet = e.features[0].properties.saleStreet;
                    var salesPrice = e.features[0].properties.salesPrice;
                    var saleCity = e.features[0].properties.saleCity;
                    var buyer1 = e.features[0].properties.buyer1;
                    var lat = e.features[0].geometry.coordinates[1];
                    var longitude = e.features[0].geometry.coordinates[0];
                    //Display Sale info
                    document.querySelector('#sale-street').innerText = saleStreet + "", "" + saleCity + "", IN"";
                    document.querySelector('#sale-price').innerText = ""Sale Price: "" + salesPrice;
                    document.querySelector('#sale-buyer1').innerText = ""Buyer 1: "" + buyer1;
                    //Ensure the info box is visible
                    document.querySelector('#info-card').style.display = '';
                });
            });
 ");
                WriteLiteral("       document.querySelector(\'#info-card-close-button\').addEventListener(\'click\', function(event) {\r\n    document.querySelector(\'#info-card\').style.display = \'none\';\r\n});\r\n    </script>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6063, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
