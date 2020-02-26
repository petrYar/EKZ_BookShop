using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EKZ_BoolShop.Entity
{
    public class EFContext : DbContext
    {
        public EFContext() : base("EKZ_BookShop")
        {

        }
    }
}
