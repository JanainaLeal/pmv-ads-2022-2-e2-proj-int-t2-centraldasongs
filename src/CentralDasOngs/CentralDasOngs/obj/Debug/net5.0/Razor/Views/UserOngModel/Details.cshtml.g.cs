#pragma checksum "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37f77a28bab488afbd128d75149f39e720bbf38d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserOngModel_Details), @"mvc.1.0.view", @"/Views/UserOngModel/Details.cshtml")]
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
#line 1 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\_ViewImports.cshtml"
using CentralDasOngs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\_ViewImports.cshtml"
using CentralDasOngs.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37f77a28bab488afbd128d75149f39e720bbf38d", @"/Views/UserOngModel/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33a001fba48666793a78f2f373dd6b7c3037e100", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_UserOngModel_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CentralDasOngs.Models.UserOngModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>UserOngModel</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayFor(model => model.Contact));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.UserType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayFor(model => model.UserType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 41 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdressModel.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 44 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdressModel.State));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 47 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdressModel.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 50 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdressModel.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 53 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdressModel.District));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 56 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdressModel.District));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 59 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdressModel.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 62 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdressModel.Street));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 65 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdressModel.HouseNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 68 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdressModel.HouseNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 71 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AdressModel.Complement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 74 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayFor(model => model.AdressModel.Complement));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OngBankInformation.Bank.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayFor(model => model.OngBankInformation.Bank.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OngBankInformation.Agency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayFor(model => model.OngBankInformation.Agency));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OngBankInformation.AccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayFor(model => model.OngBankInformation.AccountNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OngBankInformation.AccountType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
       Write(Html.DisplayFor(model => model.OngBankInformation.AccountType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n");
#nullable restore
#line 106 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
     if (User.Identity.IsAuthenticated)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
         if (User.IsInRole("Ong") && Model.Cnpj.ToString() == User.Claims.ElementAt(2).Value)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37f77a28bab488afbd128d75149f39e720bbf38d18196", async() => {
                WriteLiteral("Editar");
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
#line 110 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
                                   WriteLiteral(Model.Cnpj);

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
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37f77a28bab488afbd128d75149f39e720bbf38d20463", async() => {
                WriteLiteral("Deletar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 111 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
                                     WriteLiteral(Model.Cnpj);

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
            WriteLiteral("\r\n");
#nullable restore
#line 112 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 112 "C:\Users\Matheus Estevam\OneDrive\Documentos\projetos\visual-studio\PUC\pmv-ads-2022-2-e2-proj-int-t2-centraldasongs\src\CentralDasOngs\CentralDasOngs\Views\UserOngModel\Details.cshtml"
         
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37f77a28bab488afbd128d75149f39e720bbf38d23319", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CentralDasOngs.Models.UserOngModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
