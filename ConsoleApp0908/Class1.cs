using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0908
{
    class Class1
    {
        static void Main()
        {
            char a = '안';//''문자->한글자(영어도 한글자, 한글도 한글자)
            char b = '녕'; 
            Console.Write(a);
            Console.WriteLine(b);


            char ch1 = '\t';//tab키
            char ch2 = 'T';
            char ch3 = '\n';
            char ch4 = 'o';

            Console.WriteLine(ch1);
            Console.WriteLine(ch2);
            Console.WriteLine(ch3);
            Console.WriteLine(ch4);

            string str = "Hello";
            String sss = "World";
            int d = 5;
            Console.WriteLine(str+" "+sss);

            Console.WriteLine("당신의 이름은 {0}이고, 나이는 {2}세 {1}입니다.",str,sss,d);

            string fileName = @"C:\Users\82108\source\repos\ConsoleApp0908\ConsoleApp0908\Class1.cs";
        }
    }
}
