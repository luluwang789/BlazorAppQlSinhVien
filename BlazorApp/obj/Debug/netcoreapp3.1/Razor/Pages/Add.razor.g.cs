#pragma checksum "E:\blazor\BlazorApp\BlazorApp\Pages\Add.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24baa6a991fd8da7ea6c4beb22326008e821b374"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\blazor\BlazorApp\BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\blazor\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\blazor\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\blazor\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\blazor\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\blazor\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\blazor\BlazorApp\BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\blazor\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\blazor\BlazorApp\BlazorApp\_Imports.razor"
using BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\blazor\BlazorApp\BlazorApp\Pages\Add.razor"
using BlazorApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\blazor\BlazorApp\BlazorApp\Pages\Add.razor"
using System.Text;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add")]
    public partial class Add : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Thêm sinh viên</h1>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-md-6");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "form-group");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "hidden");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.AddAttribute(13, "placeholder", "id sinh vien");
            __builder.AddAttribute(14, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "E:\blazor\BlazorApp\BlazorApp\Pages\Add.razor"
                                        Id

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Id = __value, Id));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.AddMarkupContent(17, "<label>Họ tên</label>\r\n            ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "text");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "placeholder", "Nguyễn Văn A");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 13 "E:\blazor\BlazorApp\BlazorApp\Pages\Add.razor"
                                      Name

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Name = __value, Name));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.AddMarkupContent(25, "<label>Giới tính</label>\r\n            ");
            __builder.OpenElement(26, "select");
            __builder.AddAttribute(27, "class", "form-control");
            __builder.AddAttribute(28, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "E:\blazor\BlazorApp\BlazorApp\Pages\Add.razor"
                           Gender

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(29, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Gender = __value, Gender));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "option");
            __builder.AddAttribute(32, "value", true);
            __builder.AddContent(33, "----------");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "option");
            __builder.AddAttribute(36, "value", "Nam");
            __builder.AddContent(37, "Nam");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.OpenElement(39, "option");
            __builder.AddAttribute(40, "value", "Nữ");
            __builder.AddMarkupContent(41, "Nữ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.AddMarkupContent(44, "<label>Ngày sinh</label>\r\n            ");
            __builder.OpenElement(45, "input");
            __builder.AddAttribute(46, "type", "datetime-local");
            __builder.AddAttribute(47, "class", "form-control");
            __builder.AddAttribute(48, "placeholder", "");
            __builder.AddAttribute(49, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 21 "E:\blazor\BlazorApp\BlazorApp\Pages\Add.razor"
                                                DateOfBirth

#line default
#line hidden
#nullable disable
            , format: "yyyy-MM-ddTHH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(50, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => DateOfBirth = __value, DateOfBirth, format: "yyyy-MM-ddTHH:mm:ss", culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            ");
            __builder.AddMarkupContent(52, "<label>Mã số sinh viên</label>\r\n            ");
            __builder.OpenElement(53, "input");
            __builder.AddAttribute(54, "type", "text");
            __builder.AddAttribute(55, "class", "form-control");
            __builder.AddAttribute(56, "placeholder", "4401104076");
            __builder.AddAttribute(57, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 23 "E:\blazor\BlazorApp\BlazorApp\Pages\Add.razor"
                                      StuCode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => StuCode = __value, StuCode));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.AddMarkupContent(60, "<label>Lớp</label>\r\n            ");
            __builder.OpenElement(61, "input");
            __builder.AddAttribute(62, "type", "text");
            __builder.AddAttribute(63, "class", "form-control");
            __builder.AddAttribute(64, "placeholder", "K44CNTTA");
            __builder.AddAttribute(65, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 25 "E:\blazor\BlazorApp\BlazorApp\Pages\Add.razor"
                                      Class

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(66, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Class = __value, Class));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n            ");
            __builder.AddMarkupContent(68, "<label>Số điện thoại</label>\r\n            ");
            __builder.OpenElement(69, "input");
            __builder.AddAttribute(70, "type", "text");
            __builder.AddAttribute(71, "class", "form-control");
            __builder.AddAttribute(72, "placeholder", "0981512780");
            __builder.AddAttribute(73, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 27 "E:\blazor\BlazorApp\BlazorApp\Pages\Add.razor"
                                      Phone

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(74, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Phone = __value, Phone));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n            ");
            __builder.AddMarkupContent(76, "<label>Email</label>\r\n            ");
            __builder.OpenElement(77, "input");
            __builder.AddAttribute(78, "type", "text");
            __builder.AddAttribute(79, "class", "form-control");
            __builder.AddAttribute(80, "placeholder", "duchoaikevin279@gmail.com");
            __builder.AddAttribute(81, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 29 "E:\blazor\BlazorApp\BlazorApp\Pages\Add.razor"
                                      Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(82, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Email = __value, Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.AddMarkupContent(84, "<label>Quê quán</label>\r\n            ");
            __builder.OpenElement(85, "input");
            __builder.AddAttribute(86, "type", "text");
            __builder.AddAttribute(87, "class", "form-control");
            __builder.AddAttribute(88, "placeholder", "Ninh Thuận");
            __builder.AddAttribute(89, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 31 "E:\blazor\BlazorApp\BlazorApp\Pages\Add.razor"
                                      Country

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Country = __value, Country));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(91, "\r\n            <br>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(92);
            __builder.AddAttribute(93, "href", "");
            __builder.AddAttribute(94, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(95, "\r\n                ");
                __builder2.OpenElement(96, "input");
                __builder2.AddAttribute(97, "type", "submit");
                __builder2.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "E:\blazor\BlazorApp\BlazorApp\Pages\Add.razor"
                                               DoAdd

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(99, "class", "btn btn-outline-primary");
                __builder2.AddAttribute(100, "value", "Thêm");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(102, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n    ");
            __builder.AddMarkupContent(105, "<div class=\"col-md-6\">\r\n\r\n    </div>\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "E:\blazor\BlazorApp\BlazorApp\Pages\Add.razor"
       
    private List<Student> students;
    private string Id;
    private string Name;
    private string Gender;
    private string StuCode;
    private DateTime DateOfBirth = new DateTime();
    private string Class;
    private string Phone;
    private string Email;
    private string Country;
    private Student _item;

    protected override void OnInitialized()
    {
        students = Service.GetData();
        _item = students != null && students.Count > 0 ? students[0] : null;
    }

    public class RandomGenerator
    {
        // Instantiate random number generator.
        // It is better to keep a single Random instance
        // and keep using Next on the same instance.
        private readonly Random _random = new Random();

        // Generates a random number within a range.
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }

        // Generates a random string with a given size.
        public string RandomString(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);

            // Unicode/ASCII Letters are divided into two blocks
            // (Letters 65–90 / 97–122):
            // The first group containing the uppercase letters and
            // the second group containing the lowercase.

            // char is a single Unicode character
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length = 26

            for (var i = 0; i < size; i++)
            {
                var @char = (char)_random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }

        // Generates a random password.
        // 4-LowerCase + 4-Digits + 2-UpperCase
        public string RandomPassword()
        {
            var passwordBuilder = new StringBuilder();

            // 4-Letters lower case
            passwordBuilder.Append(RandomString(4, true));

            // 4-Digits between 1000 and 9999
            passwordBuilder.Append(RandomNumber(1000, 9999));

            // 2-Letters upper case
            passwordBuilder.Append(RandomString(2));
            return passwordBuilder.ToString();
        }
    }

    private void DoAdd()
    {
        var generator = new RandomGenerator();
        if (!string.IsNullOrWhiteSpace(Name))
        {
            students.Add(new Student() {
                Id = generator.RandomPassword(),
                Hoten = Name,
                Gioitinh = Gender,
                Mssv = StuCode,
                NgaySinh = DateOfBirth,
                Lop = Class,
                SoDienThoai = Phone,
                Email = Email,
                QueQuan = Country
            });
        }
        Service.SaveChanges();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private StudentServices Service { get; set; }
    }
}
#pragma warning restore 1591
