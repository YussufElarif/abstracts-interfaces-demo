using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public interface IFruit
    {
        string Name { get; }
        string Getcatogory();
        void Setcatogory(string catogory);
    }
}
