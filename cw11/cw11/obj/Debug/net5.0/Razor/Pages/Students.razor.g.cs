#pragma checksum "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "31f6fa08c2c0985482093a5ec755f771985d293d"
// <auto-generated/>
#pragma warning disable 1591
namespace cw11.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Peter\Downloads\cw11\cw11\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Peter\Downloads\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Peter\Downloads\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Peter\Downloads\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Peter\Downloads\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Peter\Downloads\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Peter\Downloads\cw11\cw11\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Peter\Downloads\cw11\cw11\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Peter\Downloads\cw11\cw11\_Imports.razor"
using cw11;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Peter\Downloads\cw11\cw11\_Imports.razor"
using cw11.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Peter\Downloads\cw11\cw11\_Imports.razor"
using cw11.Data.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Peter\Downloads\cw11\cw11\_Imports.razor"
using cw11.Data.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/students")]
    public partial class Students : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 b-hn8lsfub33>Students</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "id", "students");
            __builder.AddAttribute(3, "b-hn8lsfub33");
            __builder.OpenElement(4, "thead");
            __builder.AddAttribute(5, "b-hn8lsfub33");
            __builder.OpenElement(6, "tr");
            __builder.AddAttribute(7, "b-hn8lsfub33");
            __builder.AddMarkupContent(8, "<th b-hn8lsfub33>Avatar</th>\r\n            ");
            __builder.OpenElement(9, "th");
            __builder.AddAttribute(10, "b-hn8lsfub33");
            __builder.OpenElement(11, "button");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor"
                                    () => orderBy("fname")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "b-hn8lsfub33");
            __builder.AddContent(14, "First name");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n            \r\n            ");
            __builder.OpenElement(16, "th");
            __builder.AddAttribute(17, "b-hn8lsfub33");
            __builder.OpenElement(18, "button");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor"
                                    () => orderBy("lname")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "b-hn8lsfub33");
            __builder.AddContent(21, "Last name");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            \r\n            ");
            __builder.OpenElement(23, "th");
            __builder.AddAttribute(24, "b-hn8lsfub33");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 21 "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor"
                                    () => orderBy("birthdate")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(27, "b-hn8lsfub33");
            __builder.AddContent(28, "Birthdate");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            \r\n            ");
            __builder.OpenElement(30, "th");
            __builder.AddAttribute(31, "b-hn8lsfub33");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor"
                                    () => orderBy("studies")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(34, "b-hn8lsfub33");
            __builder.AddContent(35, "Studies");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n            ");
            __builder.AddMarkupContent(37, "<th b-hn8lsfub33>Actions</th>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.OpenElement(39, "tbody");
            __builder.AddAttribute(40, "b-hn8lsfub33");
#nullable restore
#line 32 "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor"
         foreach (var stud in StudentsList)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(41, "tr");
            __builder.AddAttribute(42, "b-hn8lsfub33");
            __builder.OpenElement(43, "td");
            __builder.AddAttribute(44, "b-hn8lsfub33");
            __builder.OpenElement(45, "img");
            __builder.AddAttribute(46, "src", 
#nullable restore
#line 35 "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor"
                           stud.Avatar

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(47, "alt", (
#nullable restore
#line 35 "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor"
                                              stud.FirstName

#line default
#line hidden
#nullable disable
            ) + " " + (
#nullable restore
#line 35 "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor"
                                                              stud.LastName

#line default
#line hidden
#nullable disable
            ) + " Avatar");
            __builder.AddAttribute(48, "b-hn8lsfub33");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.OpenElement(50, "td");
            __builder.AddAttribute(51, "b-hn8lsfub33");
#nullable restore
#line 36 "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor"
__builder.AddContent(52, stud.FirstName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.OpenElement(54, "td");
            __builder.AddAttribute(55, "b-hn8lsfub33");
#nullable restore
#line 37 "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor"
__builder.AddContent(56, stud.LastName);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.OpenElement(58, "td");
            __builder.AddAttribute(59, "b-hn8lsfub33");
#nullable restore
#line 38 "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor"
__builder.AddContent(60, stud.BirthDate);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.OpenElement(62, "td");
            __builder.AddAttribute(63, "b-hn8lsfub33");
#nullable restore
#line 39 "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor"
__builder.AddContent(64, stud.Studies);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.OpenElement(66, "td");
            __builder.AddAttribute(67, "b-hn8lsfub33");
            __builder.OpenElement(68, "button");
            __builder.AddAttribute(69, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor"
                                    () => OpenDetails(stud.IdStudent)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(70, "b-hn8lsfub33");
            __builder.AddContent(71, "Open details");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                ");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor"
                                    () => Delete(stud.IdStudent)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(75, "b-hn8lsfub33");
            __builder.AddContent(76, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 45 "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor"
             if (10 - StudentsList.ToArray().Length > 0)
            {
               

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor"
                for(int i=0;i<10 - StudentsList.ToArray().Length;i++){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(77, @"<tr b-hn8lsfub33><td b-hn8lsfub33></td>
                       <td b-hn8lsfub33></td>
                       <td b-hn8lsfub33></td>
                       <td b-hn8lsfub33></td>
                       <td b-hn8lsfub33></td>
                       <td b-hn8lsfub33></td></tr>");
#nullable restore
#line 57 "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor"
               }

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor"
                 
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "C:\Users\Peter\Downloads\cw11\cw11\Pages\Students.razor"
       
    public IEnumerable<Student> StudentsList { get; set; }
    public string Lastorder = "";
    protected override void OnInitialized()
    {
        StudentsList = StudentService.GetStudents();
    }

    private void OpenDetails(int id)
    {
        NavigationManager.NavigateTo($"/students/{id}");
    }

    private async Task Delete(int id)
    {
        if(await js.InvokeAsync<bool>("confirm", "Are you sure?"))
        {
            StudentService.DeleteStudent(id);
        }
    }
    
    private void orderBy(string parametr)
    {
        IEnumerable<Student> LastStudentsList = StudentsList;
        switch (parametr)
        {
            case "fname":
                StudentsList = StudentsList.OrderBy(a => a.FirstName);
                break;
            case "lname":
                StudentsList = StudentsList.OrderBy(a => a.LastName);
                break;
            case "birthdate":
                StudentsList = StudentsList.OrderBy(a => a.BirthDate);
                break;
            case "studies":
                StudentsList = StudentsList.OrderBy(a => a.Studies);
                break;
        }
        
        if (checkIfTheSame(LastStudentsList,StudentsList) && Lastorder==parametr)
        {
            StudentsList = StudentsList.Reverse();
        }
        Lastorder = parametr;
    }

    private bool checkIfTheSame(IEnumerable<Student> lastStudentsList, IEnumerable<Student> studentsList)
    {
        List<Student> l1 = lastStudentsList.ToList();
        List<Student> l2 = studentsList.ToList();
        
        for (int i = 0; i < l1.Count; i++)
        {
            if (!l1[i].get().Equals(l2[i].get()))
            {
                return false;
            }
        }
        return true;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IStudentService StudentService { get; set; }
    }
}
#pragma warning restore 1591
