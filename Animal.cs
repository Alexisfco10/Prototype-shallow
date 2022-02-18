using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype_shallow
{
    public class Animal : ICloneable
    {
        public int Patas { get; set; }
        public String Nombre { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
