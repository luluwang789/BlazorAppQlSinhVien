using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp.Data
{
    public class Student
    {
        public string Id { get; set; }
        public string Hoten { get; set; }
        public string Mssv { get; set; }
        public string Gioitinh { get; set; }
        public DateTime NgaySinh { get; set; }
        public string Lop { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string QueQuan { get; set; }
    }
}
