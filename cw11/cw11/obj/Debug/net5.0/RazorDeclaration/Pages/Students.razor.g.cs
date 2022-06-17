// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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