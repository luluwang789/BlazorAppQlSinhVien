using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BlazorApp.Data
{
    public class StudentServices
    {
        private static List<Student> _stu = new List<Student>()
        {
            new Student {
                Id = "1",
                Hoten = "Trần Hoài Đức",
                Mssv = "4401104076",
                Gioitinh = "Nam",
                NgaySinh = new DateTime(1999,10,19),
                Lop = "K44CNTTA",
                Email = "duchoaikevin279@gmail.com",
                SoDienThoai = "0981512780",
                QueQuan = "Ninh Thuận"
            },
            new Student {
                Id = "2",
                Hoten = "Nguyễn Quốc Cường",
                Mssv = "4401104061",
                Gioitinh = "Nam",
                NgaySinh = new DateTime(2000,07,23),
                Lop = "K44CNTTA",
                Email = "nqcuong20@gmail.com",
                SoDienThoai = "0981512780",
                QueQuan = "Dak Lak"
            },
            new Student {
                Id = "3",
                Hoten = "Dương Thái Nhật",
                Mssv = "4401104161",
                Gioitinh = "Nam",
                NgaySinh = new DateTime(2000,01,18),
                Lop = "K44CNTTC",
                Email = "duongthainhat@gmail.com",
                SoDienThoai = "0981512780",
                QueQuan = "Bình Định"
            },
            new Student {
                Id = "4",
                Hoten = "Nguyễn Thị Kim Anh",
                Mssv = "4401104051",
                Gioitinh = "Nữ",
                NgaySinh = new DateTime(2000,03,23),
                Lop = "K44CNTTA",
                Email = "nguyenthikimanhcntt@gmail.com",
                SoDienThoai = "0981512780",
                QueQuan = "Lâm Đồng"
            },
            new Student {
                Id = "5",
                Hoten = "Dương Tấn Thiên",
                Mssv = "4401104123",
                Gioitinh = "Nam",
                NgaySinh = new DateTime(2000,07,23),
                Lop = "K44CNTTD",
                Email = "duongtanthien@gmail.com",
                SoDienThoai = "0981512780",
                QueQuan = "Tây Ninh"
            }
        };

        private readonly string _file = "Data\\sinhvien.json";

        public List<Student> GetData()
        {
            if (File.Exists(_file))
            {
                using var file = File.OpenText(_file);
                var serializer = new JsonSerializer();
                _stu = serializer.Deserialize(file, typeof(List<Student>)) as List<Student>;
            }
            return _stu;
        }

        public void SaveChanges()
        {
            using var file = File.CreateText(_file);
            var serializer = new JsonSerializer();
            serializer.Serialize(file, _stu);
        }
    }
}
