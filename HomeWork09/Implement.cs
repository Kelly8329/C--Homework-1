using HomeWork04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork04
{
     public class Implement : IEqualityComparer<MyData>
    {
        public bool Equals(MyData x, MyData y)
        {
            return x.S_StarName == y.S_StarName;
        }

        public int GetHashCode(MyData obj)
        {
            return obj.S_StarName.GetHashCode();
        }
    }
}
