using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_04_QLPT.Model
{
    internal class PhieuThu
    {
        [Key]
        public int PhieuthuID { get; set; }
        public DateTime Ngaylap { get; set; }
        public string Nhanvienlap { get; set; }
        public string Ghichu { get; set; }
        public double Thanhtien { get; set; }
        public  List<ChiTietPhieuThu> ChiTietPhieuThus { get; set; }
        public void Nhap()
        {
            Console.WriteLine("Nhap ngay lap:");
            Ngaylap = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhan vien lap:");
            Nhanvienlap = Console.ReadLine();
            Console.WriteLine("Ghi chu");
            Ghichu = Console.ReadLine();
            //Console.WriteLine("Thanh tien");
            //Thanhtien=Double.Parse(Console.ReadLine());
        }
        public void In()
        {
            Console.WriteLine($"Phieu thu {PhieuthuID}\n" +
                              $"Do nhan vien {Nhanvienlap}\n" +
                              $"Ngay {Ngaylap.ToShortDateString()}\n" +
                              $" {Ghichu}\n" +
                              $"Gia {Thanhtien}");
        }
    }
}
