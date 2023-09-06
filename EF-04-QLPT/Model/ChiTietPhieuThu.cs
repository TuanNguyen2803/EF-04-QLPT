using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_04_QLPT.Model
{
    internal class ChiTietPhieuThu
    {
        [Key]
        public int ChitietphieuthuID { get; set; }
        public int NguyenlieuID { get; set; } 
        public int PhieuthuID { get; set; }
        public int Soluongban { get; set; }
        public virtual NguyenLieu NguyenLieus { get; set; }
        public virtual PhieuThu PhieuThus { get; set; }
        public void Nhap()
        {
            Console.WriteLine("Nhap nguyenlieuid");
            NguyenlieuID=int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so luong ban");
            Soluongban = int.Parse(Console.ReadLine());
        }
    }
}
