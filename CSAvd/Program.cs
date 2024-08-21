using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSAvd
{
    class Wanted<T>
    {
        public T Value;
        public Wanted(T value) {
            this.Value = value; 
        }
    }

    class WantedTest<T, U>
        where T : IComparable
        where U : IComparable, IDisposable
    {

    }

    class SquateCalculator
    {
        public int this[int i]
        {
            get { return i * i; }
            set { Console.WriteLine("{i}번째 상품 설정", i); }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Wanted<string> wantedString = new Wanted<string>("string");
            Wanted<int> wantedInt = new Wanted<int>(52273);
            Wanted<double> wantedDouble = new Wanted<double>(52.273);

            Console.WriteLine(wantedString.Value);
            Console.WriteLine(wantedInt.Value);
            Console.WriteLine(wantedDouble.Value);


            SquateCalculator sc = new SquateCalculator();
            Console.WriteLine(sc[10]);
            Console.WriteLine(sc[11]);
            Console.WriteLine(sc[40]);
            sc[3] = 4;

            //out 키워드
            Console.WriteLine("숫자 입력:");
            int output;
            bool result = int.TryParse(Console.ReadLine(), out output);
            if (result)
            {
                Console.WriteLine("입력한 숫자:" + output);
            }
            else
            {
                Console.WriteLine("숫자를 입력하세요");
            }
        }
    }
}
