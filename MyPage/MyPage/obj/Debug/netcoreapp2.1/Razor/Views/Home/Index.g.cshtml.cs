#pragma checksum "E:\Projects\MyPage\MyPage\MyPage\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cff6131e1aa8a23aaae3c4866c972100975baea7"
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
#line 1 "E:\Projects\MyPage\MyPage\MyPage\Views\_ViewImports.cshtml"
using MyPage;

#line default
#line hidden
#line 2 "E:\Projects\MyPage\MyPage\MyPage\Views\_ViewImports.cshtml"
using MyPage.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cff6131e1aa8a23aaae3c4866c972100975baea7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a81ad0979f29c6bc8554041958600b33a1e9bb67", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/MyProfile.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "MyStory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Resume", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "E:\Projects\MyPage\MyPage\MyPage\Views\Home\Index.cshtml"
  
    var years = ((new DateTime(1, 1, 1)) + (DateTime.Now - (new DateTime(1996, 9, 17)))).Year - 1;

#line default
#line hidden
            BeginContext(107, 376, true);
            WriteLiteral(@"<!--  <partial name=""../Carousel/_CarouselPartial"" />  -->

    <div @*class=""container-fluid""*@>
        <div class=""row padding-top-increased"">

            <!-- Photo and social media links -->
            <div id=""PhotoAndSocialMedia"" class=""col-lg-6"">
                <section id=""Photo"">
                    <div id=""AppearAfter05Secs"">
                        ");
            EndContext();
            BeginContext(483, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e1b101dca0e3488faa50ad24b1b98c4b", async() => {
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
            BeginContext(554, 2185, true);
            WriteLiteral(@"
                    </div>
                </section>
                <section id=""Social"">
                    <div id=""AppearAfter1Secs"" class=""container-fluid"">
                        <div class=""row text-center social"">
                            <div class=""col-xs-6 col-sm-4 col-md-2"">
                                <a href=""https://mail.google.com/mail/?view=cm&fs=1&to=georgecosminmorosanu@gmail.com"" target=""_blank""><i class=""far fa-envelope""></i></a>
                            </div>

                            <div class=""col-xs-6 col-sm-4 col-md-2"">
                                <a href=""https://www.linkedin.com/in/george-cosmin-morosanu-58272115a/"" target=""_blank""><i class=""fab fa-linkedin""></i></a>
                            </div>

                            <div class=""col-xs-6 col-sm-4 col-md-2"">
                                <a href=""https://github.com/GeorgeMorosanu"" target=""_blank""><i class=""fab fa-github""></i></a>
                            </div>

            ");
            WriteLiteral(@"                <div class=""col-xs-6 col-sm-4 col-md-2"">
                                <a href=""https://www.facebook.com/georgecosmin.morosanu"" target=""_blank""><i class=""fab fa-facebook""></i></a>
                            </div>

                            <div class=""col-xs-6 col-sm-4 col-md-2"">
                                <a href=""https://steamcommunity.com/id/GadoZ/"" target=""_blank""><i class=""fab fa-steam""></i></a>
                            </div>

                            <div class=""col-xs-6 col-sm-4 col-md-2"">
                                <a href=""https://www.instagram.com/george.morosanu1067/"" target=""_blank""><i class=""fab fa-instagram""></i></a>
                            </div>

                        </div>
                    </div>
                </section>
            </div>

            <!-- Some info about me -->
            <div id=""Short-About"" class=""col-lg-6"">
                <div id=""AppearAfter05Secs2"">
                    <h1 class=""text-center""><sp");
            WriteLiteral("an id=\"Greeting\"></span></h1>\r\n                    <p class=\"text-size-130\">\r\n                        &nbsp;&nbsp;My name is George, I\'m ");
            EndContext();
            BeginContext(2740, 5, false);
#line 53 "E:\Projects\MyPage\MyPage\MyPage\Views\Home\Index.cshtml"
                                                      Write(years);

#line default
#line hidden
            EndContext();
            BeginContext(2745, 1075, true);
            WriteLiteral(@" years old, I'm from Romania, and currently I'm living in Reykjavik, Iceland.
                    </p>
                    <p class=""text-size-130"">
                        &nbsp;&nbsp;I have finished my undergraduate studies in Romania at <a class=""a-text-normal"" href=""http://www.uaic.ro/en/"" target=""_blank"">""Alexandru Ioan Cuza"" University of Iasi</a>, and I have a B.Sc. degree in <a class=""a-text-normal"" href=""https://www.info.uaic.ro/en/home-page-2/"" target=""_blank"">Computer Science</a>.
                    </p>
                    <p class=""text-size-130"">
                        &nbsp;&nbsp;I am an open-minded and competitive person who will always keep my word, and I will go the extra mile to do a great job!
                    </p>
                    <p class=""text-size-130"">
                        &nbsp;&nbsp;Beside my passion for IT, I am interested in Design, Sports, Nutrition, Music and Games.
                    </p>
                    <p class=""text-size-130"">
                    ");
            WriteLiteral("    &nbsp;&nbsp;You can find more details about me ");
            EndContext();
            BeginContext(3820, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d13cd635022b48209bd8bff1ca0d28af", async() => {
                BeginContext(3879, 4, true);
                WriteLiteral("here");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3887, 61, true);
            WriteLiteral(", or if you\'re intrested in my resume, you can find it right ");
            EndContext();
            BeginContext(3948, 66, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cab52ad67f8644c8ad7a58c1bb6bebc3", async() => {
                BeginContext(4006, 4, true);
                WriteLiteral("here");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(4014, 2519, true);
            WriteLiteral(@".
                    </p>
                </div>
                <div id=""AppearAfter1Secs2"">
                    <div id=""Dates"">
                        <div id=""LastUpdate"" class=""text-right"">Last update: 18 April 2019</div>

                        <div id=""DateTime"" class=""text-right""></div>
                    </div>
                </div>

            </div>

        </div>
    </div>
    <script type=""text/javascript"">

        refreshClock();

        refreshGreetingText();

        function refreshGreetingText() {

            var greeting = """";

            var currentdate = new Date();

            if (currentdate.getHours() < 12) {
                greeting = ""Good morning!""
            }
            else if (currentdate.getHours() < 18) {
                greeting = ""Good afternoon!""
            }
            else {
                greeting = ""Good evening!""
            }
            //console.log(greeting + ""\n The time is: "" + currentdate);

            doc");
            WriteLiteral(@"ument.getElementById(""Greeting"").innerHTML = greeting;

            setTimeout(refreshGreetingText, 50000);
        }
        function refreshClock() {

            const NameOfMonths = [""January"", ""February"", ""March"", ""April"", ""May"", ""June"", ""July"", ""August"", ""September"", ""October"", ""November"", ""December""];
            var currentdate = new Date();

            var currentDate = /*""Current date: "" +*/ currentdate.getDate() + "" ""
                + NameOfMonths[currentdate.getMonth()] + "" ""
                + currentdate.getFullYear();

            var currentTime = /*""Current time: "";*/"""";

            if (currentdate.getHours() < 10) {
                currentTime = currentTime + ""0"";
            }
            currentTime = currentTime + currentdate.getHours() + "":"";

            if (currentdate.getMinutes() < 10) {
                currentTime = currentTime + ""0"";
            }
            currentTime = currentTime + currentdate.getMinutes() + "":"";

            if (currentdate.getSecon");
            WriteLiteral(@"ds() < 10) {
                currentTime = currentTime + ""0"";
            }
            currentTime = currentTime + currentdate.getSeconds();

            //document.getElementById(""Date"").innerHTML = currentDate;
            //document.getElementById(""Time"").innerHTML = currentTime;
            document.getElementById(""DateTime"").innerHTML = ""Current time: ""+currentDate+"", ""+currentTime;

            setTimeout(refreshClock, 1000);
        }
    </script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
