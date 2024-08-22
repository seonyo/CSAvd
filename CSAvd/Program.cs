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

        struct Point
        {
            public int x;
            public int y;
            public string testA;
            public string testB;

            // 구조체 -> 기본생성자 사용X
            // 구조체 생성자 -> 변수가 모두 초기화 되어야 함!

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
                testA = null;
                testB = "init";
            }
            public Point(int x, int y, string test)
            {
                this.x = x;
                this.y = y;
                testA = null;
                testB = test;
            }
        }
        class PointClass
        {
            public int x;
            public int y;
            public PointClass(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }
        struct PointStruct
        {
            public int x;
            public int y;
            public PointStruct(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
        }

        static void NextPosition(int x, int y, int vx, int vy,
            out int rx, out int ry)
        {
            rx = x + vx;
            ry = y + vy;
        }

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

            int x = 0;
            int y = 0;
            int vx = 0;
            int vy = 0;
            Console.WriteLine("현재 좌표 : (" + x + ". " + y + ")");

            NextPosition(x, y, vx, vy, out x, out y);
            Console.WriteLine("현재 좌표 : (" + x + ". " + y + ")");
            PointClass pCA = new PointClass(10, 20);
            PointClass pCB = pCA;  // 참조 복사. pCA와 pCB는 동일 객체를 바라본다.
            pCB.x = 100;
            pCB.y = 100;
            Console.WriteLine("pCA: {0}, {1}", pCA.x, pCA.y); // pCA: 100, 100
            Console.WriteLine("pCB: {0}, {1}", pCB.x, pCB.y); // pCB: 100, 100
            Console.WriteLine();

            PointStruct pSA = new PointStruct(10, 20);
            PointStruct pSB = pSA;  // 값 복사. pSA와 pSB는 별개의 변수.
            pSB.x = 100;
            pSB.y = 100;
            Console.WriteLine("pSA: {0}, {1}", pSA.x, pSA.y); // pSA: 10, 20
            Console.WriteLine("pSB: {0}, {1}", pSB.x, pSB.y); // pSB: 100, 100
            Console.WriteLine();
        }
    }
}
