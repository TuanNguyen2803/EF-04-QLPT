using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_04_QLPT.Model
{
    internal class NguyenLieu
    {
        [Key]
        public int NguyenlieuID { get; set; }
        public int LoainguyenlieuID { get; set; }
        public string Tennguyenlieu { get; set; }
        public double Giaban { get; set; }
        public string Donvitinh { get; set; }
        public int Soluongkho { get; set; }
        public virtual LoaiNguyenLieu LoaiNguyenLieus { get; set; }
        public virtual IEnumerable<ChiTietPhieuThu> ChiTietPhieuThus { get; set; }
        public void Nhap()
        {
            Console.WriteLine("Nhap ten nguyen lieu");
            Tennguyenlieu = Console.ReadLine();
            Console.WriteLine("Nhap gia ban");
            Giaban = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap don vi tinh");
            Donvitinh = Console.ReadLine();
            Console.WriteLine("Nhap so luong kho");
            Soluongkho = int.Parse(Console.ReadLine());
        }
        public void In()
        {
            Console.WriteLine($"Nguyen lieu {NguyenlieuID}\n" +
                $"thuoc loai nguyen lieu {LoainguyenlieuID}\n" +
                $"Co ten {Tennguyenlieu}\n" +
                $"Gia {Giaban}\n"+
                $"Don vi tinh{Donvitinh}\n"+
                $"So luong kho {Soluongkho}" );
        }

    }
}
