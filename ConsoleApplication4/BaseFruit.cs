using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public abstract class BaseFruit : IFruit
    {
        private string _catname = string.Empty;
        public string Name { get; private set; }

        protected BaseFruit(string name)
        {
            Name = name;
        }

        public string Getcatogory()
        {
            return _catname;
        }

        public void Setcatogory(string catogory)
        {
            _catname = catogory;
        }

        public bool rotton { get; set; }

        public string Damagenote { get; protected set; }
        public virtual void Damaged(string note)
        {
            Damagenote = note;
        }
    }
}
