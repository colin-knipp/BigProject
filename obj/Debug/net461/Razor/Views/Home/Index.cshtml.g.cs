#pragma checksum "C:\Users\colin\source\repos\WebApplication4\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "27458ea96954bfbcfbc609502478d5e4f3ad01e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\colin\source\repos\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4;

#line default
#line hidden
#line 2 "C:\Users\colin\source\repos\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"27458ea96954bfbcfbc609502478d5e4f3ad01e1", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fff4eb847734ec2c3f91807e9b1a08bbda85e45", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\colin\source\repos\WebApplication4\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(49, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e7676b66dc7b49428437b95ead630384", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(96, 2361, true);
            WriteLiteral(@"

<h1 id=""bootstrap-overrides"" style=""height: 35px;width: 125%;color: #0f9d58"">Share Price Checker (Yfinance / Google Charts)</h1>


<div id=""div""
     class=""row"" 
     style=""
        padding: 20px;
        background-color: #2f3036"">
    <div class=""col-md-3"">

        <div class=""row form-group form-inline"" style=""margin-top:5px"">
            <!-- ticker input field -->
            <label class=""col-sm-5 control-label"" for=""ticker"">Ticker:</label>
            <div class=""col-sm-7"">
                <input id=""ticker"" type=""text"" class=""form-control input-sm"" style=""height:35px;width:100%;color:#2f3036"" value=""QQQ"" />
            </div>
        </div>

        <div class=""row form-group form-inline"" style=""margin-top:-5px"">
            <!-- start date input field -->
            <label class=""col-sm-5 control-label"" for=""startDate"">Start Date:</label>
            <div class=""col-sm-7"">
                <input id=""startDate"" type=""date"" class=""form-control input-sm""
                  ");
            WriteLiteral(@"     style=""height:35px;width: 125%;color:#2f3036"" value=""2020-01-01"" />
            </div>
        </div>

        <div class=""row form-group form-inline"" style=""margin-top:-5px"">
            <!-- end date input field-->
            <label class=""col-sm-5 control-label"" for=""endDate"">End Date:</label>
            <div class=""col-sm-7"">
                <input id=""endDate"" type=""date"" class=""form-control input-sm""
                       style=""height:35px;width:125%"" value=""2021-01-01"" />
            </div>
        </div>

        <div class=""row form-group form-inline"" style=""margin-top:20px"">
            <!-- create chart button-->
            <div class=""col-sm-5""></div>
            <div class=""col-sm-7"">
                <button id=""btnCreateChart"" class=""btn btn-primary"">Create Chart</button>
            </div>
        </div>
    </div>

    <div class=""col-md-9"">
        <div id=""chart"" style=""width:100%;height:700px;overflow:hidden;padding:10px"">
            <!-- dashboard div -->");
            WriteLiteral(@"

            <div id=""candlestick"" style=""height:55%""></div> <!-- chart 1 div -->
            <div id=""volume"" style=""height:30%;margin-top:-1%""></div> <!-- chart 2 div -->
            <div id=""filter"" style=""height:15%;margin-top:1%""></div> <!-- chart control div -->
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2474, 8264, true);
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>  <!-- Load google.charts functionality -->

    <script>
        createStockChart();

        $('#btnCreateChart').click(function () {
            createStockChart();
        });

        function createStockChart() {
            google.charts.load('current', { 'packages': ['corechart', 'controls'] }); // load current version of corechart from google api
            // https://developers.google.com/chart/interactive/docs

            google.charts.setOnLoadCallback(drawChart);


            //bind user input fields
            var chart_div = document.getElementById('chart');
            var ticker = document.getElementById('ticker').value;
            var startDate = document.getElementById('startDate').value;
            var endDate = document.getElementById('endDate').value;
            var viewStartDate = (new Date(endDate));
            viewStartDate.setMonth(viewStartDate.getMonth() - 3);");
                WriteLiteral(@"
            var viewEndDate = new Date(endDate);







            function drawChart() // build charts inside a dashboard
            {



                var data = new google.visualization.DataTable();  // build DataTable format
                data.addColumn('date', 'Date');
                data.addColumn('number', 'Open');
                data.addColumn('number', 'High');
                data.addColumn('number', 'Low');
                data.addColumn('number', 'Close');
                data.addColumn('number', 'Volume');

                // AJAX call for Stock data
                $.ajax({
                    url: '/api/apiStockData/' + ticker + '/' + startDate + '/' + endDate + '/daily',
                    method: 'GET',
                    dataType: 'json'
                }).done(function (d) {     // add stock info to DataTable row by row
                    d.forEach(function (di) {
                        data.addRow([{ v: new Date(di.date), f: di.date.Date }, di.open,");
                WriteLiteral(@"
                        di.high, di.low, di.close, di.volume]);
                    });

                    var dashboard = new google.visualization.Dashboard(
                        {
                            chart_div
                        });  // build dashboard containing 1 control filter + 2 charts

                    var control = new google.visualization.ControlWrapper({        // build range selector wrapper
                        controlType: 'ChartRangeFilter',
                        containerId: 'filter',
                        options: {


                            vAxis: { textStyle: { color: 'white' } },

                            filterColumnIndex: 0,
                            ui: {
                                chartType: 'LineChart',
                                chartOptions:
                                {
                                    animation:
                                    {
                                        startup: true,");
                WriteLiteral(@"
                                        duration: 15000,
                                        easing: 'out'
                                    },
                                    color: '#0f9d58',
                                    chartArea:
                                    {
                                        height: '100%', width: '100%',
                                        backgroundColor: { stroke: '#0f9d58', strokeWidth: 1 },
                                        backgroundColor: { fill: '#2f3036' },
                                        

                                    },
                                    hAxis: { baselineColor: '#2f3036', textStyle: { color: 'white' } },
                                },
                                chartView: { columns: [0, 1] },
                            }
                        },
                        state: {
                            range: {
                                start: viewStartDate,
   ");
                WriteLiteral(@"                             end: viewEndDate
                            }
                        }
                    });

                    var chart = new google.visualization.ChartWrapper({     // build stock chart
                        chartType: 'CandlestickChart',
                        containerId: 'candlestick',
                        options: {
                            animation: {
                                startup: true,
                                duration: 4000,
                                easing: 'out'
                            },

                            backgroundColor: { fill: '#2f3036' },
                            chartArea: {
                                height: '80%', width: '85%', left: 100,
                                backgroundColor: { stroke: '#0f9d58', strokeWidth: 1 }
                            },

                            vAxis: { textStyle: { color: 'white' } },
                            hAxis: {
                ");
                WriteLiteral(@"                type: 'category', slantedText: false, maxTextLines: 1,
                                maxAlternation: 1,
                                textStyle: { color: 'white' }
                            },
                            legend: { position: 'none' },
                            candlestick: {
                                fallingColor: { strokeWidth: 0, fill: '#a52714' },
                                risingColor: { strokeWidth: 0, fill: '#0f9d58' }
                            },


                            title:
                                'Stock Price: ' + ticker,

                            titleTextStyle: {
                                color: '#0f9d58',
                                bold: true,
                                fontSize: 30,
                            }


                        },
                        view: { columns: [0, 3, 1, 4, 2] }
                    });

                    var volume = new google.visualization.Chart");
                WriteLiteral(@"Wrapper( // build volume chart
                        {
                            chartType: 'ColumnChart',
                            containerId: 'volume',
                            options:
                            {
                                animation: {
                                    startup: true,
                                    duration: 6000,
                                    easing: 'out'
                                },

                                backgroundColor: '#2f3036',

                                chartArea:
                                {
                                    height: '80%', width: '85%', left: 100, top: 40, bottom: 30,
                                    backgroundColor:
                                    {
                                        stroke: '#0f9d58', strokeWidth: 1

                                    }
                                },


                                vAxis: { textStyle: { color:");
                WriteLiteral(@" 'white' } },
                                hAxis:
                                {
                                    type: 'category', slantedText: false, maxTextLines: 1,
                                    maxAlternation: 1,
                                    textStyle: { color: 'white' }
                                },

                                legend: { position: 'none' },

                                title: ""Volume: "" + ticker,

                                titleTextStyle: {
                                    color: '#0f9d58',
                                    bold: true,
                                    fontSize: 30,
                                }
                            },

                            view: { columns: [0, 1] }
                        });

                    dashboard.bind(control, [chart, volume]);
                    dashboard.draw(data);

                }).fail(function () {
                    alert('Chart drawing fail");
                WriteLiteral("ed.\');\r\n                });\r\n            }\r\n        }\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
