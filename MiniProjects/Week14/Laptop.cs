using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProjects.Week14
{
    internal class Laptop : Asset
    {
        public Laptop(string modelName, DateTime purchaseDate, double price)
            : base(modelName, purchaseDate, price)
        {
        }
  
    }
}
