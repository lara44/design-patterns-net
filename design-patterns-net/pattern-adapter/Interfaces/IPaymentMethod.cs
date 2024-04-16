using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_adapter.Interfaces
{
    public interface IPaymentMethod
    {
        void Pay(decimal value);
    }
}
