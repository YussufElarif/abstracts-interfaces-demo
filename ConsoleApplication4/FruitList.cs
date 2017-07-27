using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class FruitList: List<BaseFruit>
    {
        public int Getcountall()
        {
            return this.Count;
        }

        public int CountOfFruit<T>()
        {
            var C = 0;

            foreach (var f in this)
            {
                if(f.GetType() == typeof(T))
                {
                    C++;
                }
            }
            return C;
        }
    }
}
