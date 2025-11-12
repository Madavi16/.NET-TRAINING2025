using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerOverloadingDemo
{
    internal class OperatorOverloading
    {
        static void Main(string[] args)
        {
            Complex c1 = new Complex(8, 35);
            Complex c2 = new Complex(8, 30);
            Complex sum = c1 + c2;
            Complex Diff = c1 - c2;
            Complex Pdt = c1 * c2;
            Complex Div = c1 / c2;
            Console.WriteLine("Sum: "+sum);
            Console.WriteLine("Diff: "+Diff);
            Console.WriteLine("Mult: "+Pdt);
            Console.WriteLine("Div: "+Div);
          
            Console.WriteLine($"c1==c2 : {c1==c2}");
            Console.WriteLine($"c1!=c2 : {c1 != c2}");
            Console.WriteLine($"Equals Method: {c1.Equals(c2)}");
            Console.ReadLine();
        }
    }
    public class Complex
    {
        public int Real { get; set; }
        public int Imaginary { get; set; }

        private string lastOperator = "";
        public Complex(int real, int imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        public static Complex operator+(Complex lhs, Complex rhs)
        {
            Complex result= new Complex(lhs.Real + rhs.Real, lhs.Imaginary + rhs.Imaginary);
            result.lastOperator = "+ (Addition)";
            return result;
        }
        public static Complex operator -(Complex lhs, Complex rhs)
        {
            Complex result= new Complex(lhs.Real - rhs.Real, lhs.Imaginary - rhs.Imaginary);
            result.lastOperator = "- (Difference)";
            return result;
        }
        public static Complex operator *(Complex lhs, Complex rhs)
        {
            Complex result= new Complex(lhs.Real * rhs.Real, lhs.Imaginary * rhs.Imaginary);
            result.lastOperator = "* (Multiplication)";
            return result;
        }
        public static Complex operator/(Complex lhs, Complex rhs)
        {
            Complex result= new Complex(lhs.Real/rhs.Real, lhs.Imaginary/rhs.Imaginary);
            result.lastOperator = "/ (Division)";
            return result;
        }
        public static bool operator ==(Complex lhs, Complex rhs)
        {
            return (lhs.Real==rhs.Real && lhs.Imaginary==rhs.Imaginary);

        }
        public static bool operator !=(Complex lhs, Complex rhs)
        {
            return !(lhs == rhs);
        }
        public override bool Equals(object obj)
        {
            if(obj is Complex c)
            {
                return this.Real ==c.Real || this.Imaginary==c.Imaginary;
            }
            return false;
        }
        public override int GetHashCode() // if we want to override a built-in function like .Equals() we should override its hash code also to overcome warnings.
        {
            return Real.GetHashCode() ^Imaginary.GetHashCode();
        }
        public override string ToString()
        {
            return $"Operation: {lastOperator} => Result={Real}r + {Imaginary} i";
        }
    }
}
