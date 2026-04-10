using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Blue
    {
        private string _input;
        public string Input => _input;

        protected Blue(string input) //по заданию защищенный конструктор
        {
            _input = input;
        }
        public abstract void Review();
        public virtual void ChangeText(string text)
        {
            _input = text;
            Review();
        }
    }
}
