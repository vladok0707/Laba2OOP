using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static Tuple<int, int, int , char> lok(int[] qq, string s)
        {
            int min = qq[0];
            int max =qq[0];
            foreach (int x in qq)
            {
                if (x < min) min = x;
                if (x > max) max = x;
            }
            int sum = min + max;
            char fi = (char)(s[0]);
            return Tuple.Create<int, int, int, char>(min, max, sum, fi);
        }

        static Tuple<int, string, char> CreateCortage(string name)
        {
            int len = name.Length;
            string s = "My first name is " + name;
            char ch = (char)(name[0]);
            return Tuple.Create<int, string, char>(len, s, ch);
        }
        static void Main(string[] args)
        {
            Int32 a = 1;
            long b = 2;
            float c = 1.344F;
            sbyte q = 3;
            short w = 4;


            Int64 e = a;
            long r = a;
            Int32 t = (int)c;
            short y = (short)q;


            int val = 5;
            object obj = val;     // присваивание сопровождается упаковкой
            int valUnboxed = (int)obj; // приведение вызовет распаковку

            var i = 5;
            var s = "Hello";
            var u = new[] { 0, 1, 2 };


            int? x1 = null;
            int? x2 = null;
            System.Console.WriteLine(x1 == x2); //True
            int? x3 = null; if (x1.HasValue)
            {
                int x4 = (int)x3;//явное 
                int? x5 = x3; //неявное
                long? x6 = x4; //неявное расширяющее
            }


            string str1 = "qqq";
            string str2 = "qqw";
            if (str1 == str2) { Console.WriteLine("stroki ravni"); } else Console.WriteLine("stroki ne ravni");


            string test1 = "test1";
            string test2 = "test2";
            string test3 = "test3";
            string con = String.Concat(test1, test2, test3);
            Console.WriteLine(con);
            string kop = String.Copy(test1);
            Console.WriteLine(kop);
            string sub = test1.Substring(3);
            Console.WriteLine(sub);

            string text = "This is a text. New string";
            char[] delims = ".,;:!?\n\xD\xA\" ".ToCharArray();
            string[] words = text.Split(delims, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words) Console.WriteLine(word);

            string ins = test1.Insert(3, test3);
            Console.WriteLine(ins);
            string rem = test1.Remove(3);
            Console.WriteLine(rem);



            /*    string str5 = "";
                str5.ToUpper();
                string str6 = null;
                str6.ToUpper(); */




            StringBuilder sb = new StringBuilder("ABC", 50);
            sb.Remove(2, 1);
            sb.Append(new char[] { 'D' });
            sb.Insert(0, "KYKY");

            Console.WriteLine(sb);

            int[,] myArr = new int[4, 5];
            Random ran = new Random();
            // Инициализируем данный массив
            for (int ii = 0; ii < 4; ii++)
            {
                for (int j = 0; j < 5; j++)
                {
                    myArr[ii, j] = ran.Next(1, 15);
                    Console.Write("{0}\t", myArr[ii, j]);
                }
                Console.WriteLine();
            }


            int[] cc = { 61, 2, 5, 7, 83, 45 };
            foreach (int x in cc) Console.Write(x + ",");
            Console.WriteLine();
            Console.WriteLine(cc.GetLength(0));
            int ww = int.Parse(Console.ReadLine());
            int ee = int.Parse(Console.ReadLine());
            cc[ww] = ee;
            foreach (int x in cc) Console.Write(x + ",");
            Console.WriteLine();

            int[][] aa = new int[3][];
            aa[0] = new int[2];
            aa[1] = new int[3];
            aa[2] = new int[4];


            foreach (int[] x in aa)
            {
                foreach (int bb in x) { int we = int.Parse(Console.ReadLine());
                    Console.Write("\t" + we); }
                Console.WriteLine();
            }

            var array = new object[0];
            var str = "";



            var someTuple = CreateCortage("Annaaaa"); Console.WriteLine(someTuple.Item1.ToString());
            Console.WriteLine(someTuple.Item2);
            Console.WriteLine(someTuple.Item3);
            var someTuple2 = Tuple.Create<decimal, Tuple<int, string, char>>(12, someTuple);
            

            var t1 = Tuple.Create(123, "Hello");
            var t2 = Tuple.Create(123, "Hello");
            Console.WriteLine(t1 == t2); // False
            Console.WriteLine(t1.Equals(t2)); // True




           var t12 = new Tuple<int, string>(123, "Hello"); // Конструктор
            Tuple<int, string> t22 = Tuple.Create(123, "Hello"); // Статический метод
            var t23 = Tuple.Create(123, "Hello"); // Упрощенная версия



            var someTuple3 = lok(cc, "Vlad");
            Console.WriteLine(someTuple3.Item1);
            Console.WriteLine(someTuple3.Item2);
            Console.WriteLine(someTuple3.Item3);
            Console.WriteLine(someTuple3.Item4);
        }

      

    }
    

}

