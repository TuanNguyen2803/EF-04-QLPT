using EF_04_QLPT.Service.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_04_QLPT.View
{
    internal class PhieuthuVIew
    {
        Serviveall sva=new Serviveall();
        public void Menu()
        {
            Console.Clear();
            Console.WriteLine("--------------Chuong trinh quan ly phieu thu-------------");
            Console.WriteLine("1. Them nguyen lieu vao loai nglieu");
            Console.WriteLine("2. Them danh sach chi tiet 1 phieu thu ");
            Console.WriteLine("3. Them 1 phieu thu ");
            Console.WriteLine("4. Xoa phieu thu");
            Console.WriteLine("5. Lay thong tin theo thoi gian");
            Console.WriteLine("6.Thoat");
            Console.WriteLine();
            Console.Write("Chon: ");
            int luaChon = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Action(luaChon);
        }
        private void Action(int luaChon)
        {
            switch (luaChon)
            {
                case 1:                                  
                    sva.Themnguyenlieu();
                    break;
                case 2:                
                    sva.Themlistctpt();
                    break;
                case 3:
                    sva.Themphieuthu();
                    break;
                case 4:                
                    sva.Xoaphieuthu();
                    break;
                case 5:
                    sva.Layphieuthutheothoigian();
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
            }
            Console.ReadKey();
            Menu();
        }
    }
}
