using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Task1 : Blue
    {
        private int _output;
        public int Output => _output;

        public Task1(string input) : base(input)
        {
            _output = 0; //дефолтное значение
        }
        public override void Review()
        {
            //исходный текст лежит в Input
            //найти ответ на задание для текста
            //ответ записать в Output
            _output = 44;
        }
        public override string ToString()
        {
            return $"{Input}{Environment.NewLine}{Output}";
        }
    }
}
