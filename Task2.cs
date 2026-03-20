using CW5.Variant00;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp5.Task2;

namespace ConsoleApp5
{
    public class Task2
    {
        public class Number : INumber
        {
            // поле
            private double _elem;

            // свойства
            public double Real
            {
                get
                {
                    return _elem;
                }

            }
            public virtual double Abs
            {
                get
                {
                    return Math.Abs(_elem);
                }
            }
            public int Sign
            {
                get
                {
                    return Math.Sign(_elem);
                }
            }
            //методы 
            virtual public void Sum(INumber other)
            {
                _elem += other.Real;
            }
            virtual public void Sub(INumber other)
            {
                _elem -= other.Real;
            }
            virtual public void Mul(INumber other)
            {
                _elem *= other.Real;
            }
            virtual public void Div(INumber other)
            {
                _elem /= other.Real;
            }
            virtual public void Neg()
            {
                _elem = -_elem;
            }
        }
        public class ComplexNumber : Number, IComplexNumber
        {
            double Imaginary
            {
                get
            }
        }
    }
}
