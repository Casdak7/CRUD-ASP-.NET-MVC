#pragma checksum "C:\Users\Cassio\source\repos\Teste Pratico\Teste Pratico\Views\Categoria\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47a389a0c5c621e2b1bfbddccf7efa3d42d44fef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoria_Details), @"mvc.1.0.view", @"/Views/Categoria/Details.cshtml")]
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
#line 1 "C:\Users\Cassio\source\repos\Teste Pratico\Teste Pratico\Views\_ViewImports.cshtml"
using Teste_Pratico;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cassio\source\repos\Teste Pratico\Teste Pratico\Views\_ViewImports.cshtml"
using Teste_Pratico.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47a389a0c5c621e2b1bfbddccf7efa3d42d44fef", @"/Views/Categoria/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaac1eb8143c2ef6eb7098fee38bded03aa73877", @"/Views/_ViewImports.cshtml")]
    public class Views_Categoria_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teste_Pratico.Models.Categoria>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Cassio\source\repos\Teste Pratico\Teste Pratico\Views\Categoria\Details.cshtml"
  
    ViewData["Title"] = "Detalhes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Head", async() => {
                WriteLiteral("\r\n    <link href=\"https://cdn.datatables.net/1.10.21/css/dataTables.bootstrap4.min.css\" rel=\"stylesheet\" />\r\n    <link href=\"https://cdn.datatables.net/responsive/2.2.5/css/responsive.bootstrap.min.css\" rel=\"stylesheet\" />\r\n");
            }
            );
            WriteLiteral("\r\n\r\n<h1>Detalhes</h1>\r\n\r\n<div class=\"card mt-4\">\r\n    <div class=\"card-body\">\r\n        <h4 class=\"card-title\">Categoria</h4>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 21 "C:\Users\Cassio\source\repos\Teste Pratico\Teste Pratico\Views\Categoria\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 24 "C:\Users\Cassio\source\repos\Teste Pratico\Teste Pratico\Views\Categoria\Details.cshtml"
           Write(Html.DisplayFor(model => model.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 27 "C:\Users\Cassio\source\repos\Teste Pratico\Teste Pratico\Views\Categoria\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 30 "C:\Users\Cassio\source\repos\Teste Pratico\Teste Pratico\Views\Categoria\Details.cshtml"
           Write(Html.DisplayFor(model => model.nome));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </dd>
        </dl>
    </div>
</div>

<div class=""card mt-4"">
    <div class=""card-body"">
    <h4 class=""card-title"">Produtos desta Categoria</h4>
    <hr />
        <table class=""table table-striped responsive"" id=""myTable"">
            <thead>
                <tr>
                    <th>
                        Nome
                    </th>
                    <th>
                        Categoria
                    </th>
                    <th>
                        Preço
                    </th>
                    <th>
                        Ativo
                    </th>
                    <th>Ações</th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 59 "C:\Users\Cassio\source\repos\Teste Pratico\Teste Pratico\Views\Categoria\Details.cshtml"
                 foreach (var item in Model.GetProdutos())
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 63 "C:\Users\Cassio\source\repos\Teste Pratico\Teste Pratico\Views\Categoria\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 66 "C:\Users\Cassio\source\repos\Teste Pratico\Teste Pratico\Views\Categoria\Details.cshtml"
                       Write(Html.DisplayFor(modelItem => item.getCategoria().nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 69 "C:\Users\Cassio\source\repos\Teste Pratico\Teste Pratico\Views\Categoria\Details.cshtml"
                       Write(Convert.ToDecimal(item.preco).ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 72 "C:\Users\Cassio\source\repos\Teste Pratico\Teste Pratico\Views\Categoria\Details.cshtml"
                       Write(item.ativo.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 75 "C:\Users\Cassio\source\repos\Teste Pratico\Teste Pratico\Views\Categoria\Details.cshtml"
                       Write(Html.ActionLink("Editar", "CreateOrUpdate", "Produto", new { id = item.id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            ");
#nullable restore
#line 76 "C:\Users\Cassio\source\repos\Teste Pratico\Teste Pratico\Views\Categoria\Details.cshtml"
                       Write(Html.ActionLink((item.ativo ? "Desativar" : "Ativar"), "Delete", "Produto", new { id = item.id }, new { @class = (item.ativo ? "btn btn-danger" : "btn btn-success") }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 79 "C:\Users\Cassio\source\repos\Teste Pratico\Teste Pratico\Views\Categoria\Details.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"mt-4\">\r\n    ");
#nullable restore
#line 86 "C:\Users\Cassio\source\repos\Teste Pratico\Teste Pratico\Views\Categoria\Details.cshtml"
Write(Html.ActionLink("Editar", "CreateOrUpdate", new { id = Model.id }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47a389a0c5c621e2b1bfbddccf7efa3d42d44fef10008", async() => {
                WriteLiteral("Voltar à listagem");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script src=""//cdn.datatables.net/1.10.21/js/jquery.dataTables.min.js""></script>
    <script src=""https://cdn.datatables.net/1.10.21/js/dataTables.bootstrap4.min.js""></script>
    <script src=""https://cdn.datatables.net/responsive/2.2.5/js/dataTables.responsive.min.js""></script>
    <script src=""https://cdn.datatables.net/responsive/2.2.5/js/responsive.bootstrap.min.js""></script>
    <script>
        $(document).ready(function () {
            $('#myTable').DataTable({
                ""language"": {
                    ""lengthMenu"": ""Exibe _MENU_ Registros por página"",
                    ""search"": ""Procurar"",
                    ""paginate"": { ""previous"": ""Retorna"", ""next"": ""Avança"" },
                    ""zeroRecords"": ""Nada foi encontrado"",
                    ""info"": ""Exibindo página _PAGE_ de _PAGES_"",
                    ""infoEmpty"": ""Sem registros"",
                    ""infoFiltered"": ""(filtrado de _MAX_ regitros totais)""
                },
                responsive: true,
       ");
                WriteLiteral("     });\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teste_Pratico.Models.Categoria> Html { get; private set; }
    }
}
#pragma warning restore 1591
