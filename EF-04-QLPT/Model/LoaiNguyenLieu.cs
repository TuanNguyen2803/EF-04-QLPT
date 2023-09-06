using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_04_QLPT.Model
{
    internal class LoaiNguyenLieu
    {
        [Key]
        public int LoainguyenlieuID { get; set; }
        public string Tenloai { get; set; }
        public string Mota { get; set; }
        public virtual IEnumerable<NguyenLieu> NguyenLieus { get; set; }
    }
}
