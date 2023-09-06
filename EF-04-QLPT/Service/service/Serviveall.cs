using EF_04_QLPT.Model;
using EF_04_QLPT.Service.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_04_QLPT.Service.service
{
    internal class Serviveall : IService
    {
        private readonly AppDbContext dbContext;
        public Serviveall()
        {
            dbContext = new AppDbContext();
        }

        public void Themlistctpt()
        {
            Console.WriteLine("Nhap phieu thu id");
            int phieuthuid=int.Parse(Console.ReadLine());
            var checkpt = dbContext.PhieuThus.FirstOrDefault(x => x.PhieuthuID == phieuthuid);
            if (checkpt == null)
            {
                Console.WriteLine("Phieu thu chua ton tai");
                return;
            }
            else
            {
             
                for (int i = 0;; i++)
                {
                    Themchitietphieuthu(phieuthuid);
                    Console.WriteLine("Ban co muyon");
                    char c=char.Parse(Console.ReadLine());
                    if(c=='y'|| c=='Y')
                    {
                        continue;
                    }
                    else
                    {
                        
                        return;
                    }
                }
                
            }
        }
        public void Themchitietphieuthu(int phieuthuID)
        {
            var checkpt = dbContext.PhieuThus.FirstOrDefault(x => x.PhieuthuID == phieuthuID);
            if (checkpt == null)
            {
                Console.WriteLine("Phieu thu chua ton tai");
                return;
            }
            else
            {
                ChiTietPhieuThu ctpt = new ChiTietPhieuThu();
                ctpt.PhieuthuID = phieuthuID;
                ctpt.Nhap();
                var checknl = dbContext.NguyenLieus.FirstOrDefault(x => x.NguyenlieuID == ctpt.NguyenlieuID);

                if (checknl == null)
                {
                    Console.WriteLine("Nguyen lieu chua ton tai");
                }
                else
                {
                    if (checknl.Soluongkho > ctpt.Soluongban)
                    {
                        checknl.Soluongkho -= ctpt.Soluongban;
                        checkpt.Thanhtien += checknl.Giaban * ctpt.Soluongban;
                        dbContext.NguyenLieus.Update(checknl);
                        dbContext.SaveChanges();

                        dbContext.PhieuThus.Update(checkpt);
                        dbContext.SaveChanges();

                        dbContext.ChiTietPhieuThus.Add(ctpt);
                        dbContext.SaveChanges();
                        Console.WriteLine("Them chi tiet phieu thu thanh cong");
                    }
                    else
                    {
                        Console.WriteLine("So luong kho khong du de ban");
                    }
                }
            }
        }

        public void Themnguyenlieu()
        {
            Console.WriteLine("Nhap id loai nguyen lieu cho nguyen lieu ");
            int loainguyenlieuID=int.Parse(Console.ReadLine());
            var checklnl = dbContext.LoaiNguyenLieus.FirstOrDefault(x => x.LoainguyenlieuID == loainguyenlieuID);
            if (checklnl != null)
            {

                NguyenLieu nguyenlieu = new NguyenLieu();
                nguyenlieu.LoainguyenlieuID = loainguyenlieuID;
                nguyenlieu.Nhap();
                dbContext.Add(nguyenlieu);
                dbContext.SaveChanges();
                Console.WriteLine("Them thanh cong");
            }
            else
            {
                Console.WriteLine("That bai");
            }
        }

        public void Themphieuthu()
        {
            PhieuThu phieuThu = new PhieuThu();
            phieuThu.Nhap();
            dbContext.PhieuThus.Add(phieuThu); 
            dbContext.SaveChanges();
            Themchitietphieuthu(phieuThu.PhieuthuID);
            Console.WriteLine("Them phieu thu thanh cong");
        }

        public void Xoaphieuthu()
        {
            Console.WriteLine("Nhap id phieu thu can xoa");
            int phieuthuID=int.Parse(Console.ReadLine());
            var checkpt = dbContext.PhieuThus.FirstOrDefault(x => x.PhieuthuID == phieuthuID);
            if (checkpt == null)
            {
                Console.WriteLine("Phieu thu chua ton tai");
            }
            else
            {
                dbContext.PhieuThus.Remove(checkpt);
                dbContext.SaveChanges();
                Console.WriteLine("Xoa thanh cong");

            }
        }

        public void  Layphieuthutheothoigian()
        {
            Console.WriteLine("Nhap thoi gian");
            DateTime thoigian = DateTime.Parse(Console.ReadLine());
            var check = dbContext.PhieuThus.Include(x => x.ChiTietPhieuThus).ThenInclude(x => x.NguyenLieus).Where(x => x.Ngaylap == thoigian).ToList();
            if (check.Count == 0)
            {
                Console.WriteLine("Danh sach trong");
            }
            else
            {
                foreach (var phieuThu in check)
                {
                    phieuThu.In();
                    if (phieuThu.ChiTietPhieuThus.Count == 0)
                    {
                        Console.WriteLine("Khong co chi tiet phieu thu nao");
                    }
                    else
                    {
                        foreach (var chiTietPhieuThu in phieuThu.ChiTietPhieuThus)
                        {
                            var checknl=dbContext.NguyenLieus.Where(x => x.NguyenlieuID==chiTietPhieuThu.NguyenlieuID).ToList();
                            if(checknl.Count == 0)
                            {
                                Console.WriteLine("Khong co nguyen lieu");
                            }
                            else
                            {
                                foreach (var nguyenLieu in checknl)
                                {
                                    nguyenLieu.In();
                                }
                            }
                        }
                    }
                }
            }
           
            Console.WriteLine();
        }
    }
}
