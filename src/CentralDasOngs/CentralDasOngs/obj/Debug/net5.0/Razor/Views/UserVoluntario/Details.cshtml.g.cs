#pragma checksum "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35ba458ed493c92101366eb9632276fb61dd91db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserVoluntario_Details), @"mvc.1.0.view", @"/Views/UserVoluntario/Details.cshtml")]
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
#nullable restore
#line 1 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\_ViewImports.cshtml"
using CentralDasOngs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\_ViewImports.cshtml"
using CentralDasOngs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35ba458ed493c92101366eb9632276fb61dd91db", @"/Views/UserVoluntario/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33a001fba48666793a78f2f373dd6b7c3037e100", @"/Views/_ViewImports.cshtml")]
    public class Views_UserVoluntario_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CentralDasOngs.Models.UserVoluntarioModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>UserVoluntarioModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DateBirthDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayFor(model => model.DateBirthDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Age));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address.StateId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address.District));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address.District));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address.Number));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 76 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address.Complement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 79 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address.Complement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35ba458ed493c92101366eb9632276fb61dd91db13361", async() => {
                WriteLiteral("Deletar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 85 "C:\Users\simit\OneDrive\Favoritos\Documentos\Visual Studio 2019\Projetos\Congs\src\CentralDasOngs\CentralDasOngs\Views\UserVoluntario\Details.cshtml"
                             WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35ba458ed493c92101366eb9632276fb61dd91db15578", async() => {
                WriteLiteral(" Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CentralDasOngs.Models.UserVoluntarioModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
