#pragma checksum "D:\大实训2  仓库管理系统\WMS_MVC\WMS_MVC\WMS_MVC\Views\Stockindetails\Show.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdf729281dcbd2490905c102268bb614f79eb2eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Stockindetails_Show), @"mvc.1.0.view", @"/Views/Stockindetails/Show.cshtml")]
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
#line 1 "D:\大实训2  仓库管理系统\WMS_MVC\WMS_MVC\WMS_MVC\Views\_ViewImports.cshtml"
using WMS_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\大实训2  仓库管理系统\WMS_MVC\WMS_MVC\WMS_MVC\Views\_ViewImports.cshtml"
using WMS_MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdf729281dcbd2490905c102268bb614f79eb2eb", @"/Views/Stockindetails/Show.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d2675e3018d93bc97dc009e4184a70cdd1dc5a7", @"/Views/_ViewImports.cshtml")]
    public class Views_Stockindetails_Show : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\大实训2  仓库管理系统\WMS_MVC\WMS_MVC\WMS_MVC\Views\Stockindetails\Show.cshtml"
  
    ViewData["Title"] = "Show";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Show</h2>

<table class=""table table-hover"">
    <thead>
        <tr>
            <td>操作</td>
            <td>明细ID</td>
            <td>入库单号</td>
            <td>状态</td>
            <td>计划数量</td>
            <td>实际数量</td>
            <td>货架编号</td>
            <td>货架名称</td>
            <td>审核人</td>
            <td>审核时间</td>
            <td>备注</td>
            <td>创建人</td>
            <td>创建时间</td>
            <td>修改人</td>
            <td>修改时间</td>
        </tr>
    </thead>
    <tbody id=""tb""></tbody>
</table>

");
            DefineSection("scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdf729281dcbd2490905c102268bb614f79eb2eb5045", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fdf729281dcbd2490905c102268bb614f79eb2eb6144", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
    <script>
        $(function () {
            Show(1);
        })
        //显示
        function Show() {
            $.ajax({
                url: ""http://localhost:63209/api/Stockindetails/Gets?StockInIds="" + 5,
                type: ""Get"",
                //data: {  },
                contentType: ""application/json"",
                success: function (d) {
                    $(""#tb"").empty();
                    //循环遍历
                    $(d).each(function () {
                        //拼接tr一行
                        var line = '<tr>'
                            + '<td>' + '<a href=javascript:; onclick=""Getid(' + this.stockInDetailId + ')"">修改</a>' + '    ' + '<a href=javascript:; onclick=""Del(' + this.stockInDetailId + ')"">删除</a>' + '</td>'
                            + '<td>' + this.stockInDetailId + '</td>'
                            + '<td>' + this.stockInId + '</td>'
                            + '<td>' + this.status + '</td>'
                            + '<td>' + this.plan");
                WriteLiteral(@"InQty + '</td>'
                            + '<td>' + this.actInQty + '</td>'
                            + '<td>' + this.storagerackId + '</td>'
                            + '<td>' + this.storagerackname + '</td>'
                            + '<td>' + this.auditinId + '</td>'
                            + '<td>' + this.auditinTime + '</td>'
                            + '<td>' + this.remark + '</td>'
                            + '<td>' + this.createBy + '</td>'
                            + '<td>' + this.createDate + '</td>'
                            + '<td>' + this.modifiedBy + '</td>'
                            + '<td>' + this.modifiedDate + '</td>'
                            + '</tr>'
                        //将数据放入表格
                        $(""#tb"").append(line);
                    });
                }
            });
        }
        function Getid(id) {
            location.href = '/Stockindetails/Upt?id=' + id;
        }
        //删除
        function Del(id) {
       ");
                WriteLiteral(@"     $.ajax({
                url: 'http://localhost:63209/api/Stockindetails/Delete/' + id,
                type: 'Delete',
                contentType: ""application/json"",
                dataType: 'json',
                success: function (d) {
                    if (d > 0) {
                        alert('删除成功');
                        location.href = '/Stockindetails/Show';
                    }
                }
            })
        }
    </script>
");
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
