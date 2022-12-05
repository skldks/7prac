using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace _5prac
{
    public class Rational : Pair
    {

        private int _first;
        private int _second;
        public int First
        {
            get { return _first; }
            set { _first = value; }
        }

        public int Second
        {
            get { return _second; }
            set { _second = value; }
        }
        public Rational(int first, int second) : base(first, second)
        {
            First = first;
            Second = second;
        }
        public Pair Nnew(Rational first, Rational second,Pair pair)
        {
            return new Pair(First + pair.Second, Second + pair.First);
        }
        public Pair Nnew(Rational first, Rational second, Pair pair, Pair pair1)
        {
            return new Pair(First - pair.Second, Second - pair.First);
        }
        public Pair Division(Rational first, Rational second, Pair pair)
        {
            return new Pair(First / pair.Second, Second / pair.First);
        } 
    }
}
