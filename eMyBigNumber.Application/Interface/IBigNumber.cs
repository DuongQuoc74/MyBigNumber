using eMyBigNumber.Application.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eMyBigNumber.Application.Interface
{
    public interface IBigNumber
    {
        void Sum(MyBigNumber request);
    }
}
