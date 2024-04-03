using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjects.Week14
{
    internal class MobilePhone : Asset
    {
        public MobilePhone(string modelName, DateTime purchaseDate, double price)
            : base(modelName, purchaseDate, price)
        {
        }
    }
}
