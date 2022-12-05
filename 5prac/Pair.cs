using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5prac
{

    public class Pair
    {

        private int _first;
        private int _second;

        public Pair(int first, int second)
        {
            First = first;
            Second = second;
        }


        public  int First
        {
            get { return _first; }
            set { _first = value; }
        }

        public int Second
        {
            get { return _second; }
            set { _second = value; }
        }

        public static Pair operator -(Pair pair, Pair pair1)
        {
            return new Pair(pair.First - pair1.Second, pair.Second - pair1.First);
        }
        public Pair Substraction(Pair pair, Pair pair1)
        {
            return new Pair(First - pair.First - pair1.First, Second - pair.Second - pair1.Second);
        }

       
        //class Rational : Pair
        //{
        //    public int Paair { get; set; }
        //    public Employee(int first, int second, int paair) : base (first, second)
        //    {
        //        Paair = paair;
        //    }
        //}
        //public Pair Substraction(Pair paair)
        //{
        //    return new Pair(First - pair.Second, Second - pair.First)
        //}
    }
}
