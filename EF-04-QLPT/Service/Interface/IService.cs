using EF_04_QLPT.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_04_QLPT.Service.Interface
{
    internal interface IService
    {
        //Phieu thu
        void Themphieuthu();
        void Xoaphieuthu();
         void  Layphieuthutheothoigian();

        //Nguyen lieu
        void Themnguyenlieu();
        // Chi tiet
        void Themchitietphieuthu(int phieuthuID);
    }
}
