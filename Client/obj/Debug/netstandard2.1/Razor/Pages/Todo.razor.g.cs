#pragma checksum "C:\Users\Rebeca Muniz\OneDrive - Florida Gulf Coast University\Visual Studios Projects\BlazerTutorial\BlazerTutorial\Client\Pages\Todo.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14ea4c9c6f064164e30e8833dd71082dc68aae5c"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazerTutorial.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Rebeca Muniz\OneDrive - Florida Gulf Coast University\Visual Studios Projects\BlazerTutorial\BlazerTutorial\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Rebeca Muniz\OneDrive - Florida Gulf Coast University\Visual Studios Projects\BlazerTutorial\BlazerTutorial\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Rebeca Muniz\OneDrive - Florida Gulf Coast University\Visual Studios Projects\BlazerTutorial\BlazerTutorial\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Rebeca Muniz\OneDrive - Florida Gulf Coast University\Visual Studios Projects\BlazerTutorial\BlazerTutorial\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Rebeca Muniz\OneDrive - Florida Gulf Coast University\Visual Studios Projects\BlazerTutorial\BlazerTutorial\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Rebeca Muniz\OneDrive - Florida Gulf Coast University\Visual Studios Projects\BlazerTutorial\BlazerTutorial\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Rebeca Muniz\OneDrive - Florida Gulf Coast University\Visual Studios Projects\BlazerTutorial\BlazerTutorial\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Rebeca Muniz\OneDrive - Florida Gulf Coast University\Visual Studios Projects\BlazerTutorial\BlazerTutorial\Client\_Imports.razor"
using BlazerTutorial.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Rebeca Muniz\OneDrive - Florida Gulf Coast University\Visual Studios Projects\BlazerTutorial\BlazerTutorial\Client\_Imports.razor"
using BlazerTutorial.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/todo")]
    public partial class Todo : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "h1");
            __builder.AddContent(1, "Todo (");
            __builder.AddContent(2, 
#nullable restore
#line 3 "C:\Users\Rebeca Muniz\OneDrive - Florida Gulf Coast University\Visual Studios Projects\BlazerTutorial\BlazerTutorial\Client\Pages\Todo.razor"
           todos.Count(todo => !todo.IsDone)

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(3, ")");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "ul");
            __builder.AddMarkupContent(6, "\r\n");
#nullable restore
#line 5 "C:\Users\Rebeca Muniz\OneDrive - Florida Gulf Coast University\Visual Studios Projects\BlazerTutorial\BlazerTutorial\Client\Pages\Todo.razor"
     foreach (var todo in todos)
    {

#line default
#line hidden
#nullable disable
            __builder.AddContent(7, "        ");
            __builder.OpenElement(8, "li");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "checkbox");
            __builder.AddAttribute(12, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 8 "C:\Users\Rebeca Muniz\OneDrive - Florida Gulf Coast University\Visual Studios Projects\BlazerTutorial\BlazerTutorial\Client\Pages\Todo.razor"
                                          todo.IsDone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.IsDone = __value, todo.IsDone));
            __builder.SetUpdatesAttributeName("checked");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n            ");
            __builder.OpenElement(15, "input");
            __builder.AddAttribute(16, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\Rebeca Muniz\OneDrive - Florida Gulf Coast University\Visual Studios Projects\BlazerTutorial\BlazerTutorial\Client\Pages\Todo.razor"
                          todo.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(17, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => todo.Title = __value, todo.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 11 "C:\Users\Rebeca Muniz\OneDrive - Florida Gulf Coast University\Visual Studios Projects\BlazerTutorial\BlazerTutorial\Client\Pages\Todo.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "placeholder", "Something todo");
            __builder.AddAttribute(23, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "C:\Users\Rebeca Muniz\OneDrive - Florida Gulf Coast University\Visual Studios Projects\BlazerTutorial\BlazerTutorial\Client\Pages\Todo.razor"
                                           newTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => newTodo = __value, newTodo));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n");
            __builder.OpenElement(26, "button");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\Rebeca Muniz\OneDrive - Florida Gulf Coast University\Visual Studios Projects\BlazerTutorial\BlazerTutorial\Client\Pages\Todo.razor"
                  AddTodo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Add todo");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 16 "C:\Users\Rebeca Muniz\OneDrive - Florida Gulf Coast University\Visual Studios Projects\BlazerTutorial\BlazerTutorial\Client\Pages\Todo.razor"
       
    private List<TodoItem> todos = new List<TodoItem>();
    private string newTodo;

    private void AddTodo()
    {
        if (!string.IsNullOrWhiteSpace(newTodo))
        {
            todos.Add(new TodoItem { Title = newTodo });
            newTodo = string.Empty;
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
