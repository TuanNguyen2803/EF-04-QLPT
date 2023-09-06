using EF_04_QLPT.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_04_QLPT
{
    internal class AppDbContext:DbContext
    {
        public DbSet<LoaiNguyenLieu> LoaiNguyenLieus { get; set; }
        public DbSet<NguyenLieu> NguyenLieus { get; set; }
        public DbSet<PhieuThu> PhieuThus { get; set; }
        public DbSet<ChiTietPhieuThu> ChiTietPhieuThus { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=TUANNM\\TUANNM; database = QLPhieuThu; integrated security = sspi; encrypt = true; trustservercertificate = true;");
        }
    }
}
