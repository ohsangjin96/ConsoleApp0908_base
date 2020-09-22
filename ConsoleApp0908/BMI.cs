using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0908
{
    class Bmi
    {
        static void Main(string[] args)
        {
            double weight;
            double height;
            double tall;
            double bmi;
            for (int a = 0; a < 5; a++)
            {
                Console.Write("키를 입력해주세요:");
                height = Convert.ToSingle(Console.ReadLine());
                tall = height / 100;


                Console.Write("몸무게를 입력해주세요 : ");
                weight = Convert.ToSingle(Console.ReadLine());
                bmi = weight / (tall * tall);
               

                if (bmi >= 30)
                {
                    Console.WriteLine("당신의 BMI는 " + bmi + " 입니다.");
                    Console.WriteLine("당신의 비만도는 고도비만입니다.");
                }
                else if (bmi >= 25)
                {
                    Console.WriteLine("당신의 BMI는 " + bmi + " 입니다.");
                    Console.WriteLine("당신의 비만도는 비만입니다.");
                }
                else if (bmi >= 23)
                {
                    Console.WriteLine("당신의 BMI는 " + bmi + " 입니다.");
                    Console.WriteLine("당신의 비만도는 과체중입니다.");
                }
                else if (bmi >= 18.5)
                {
                    Console.WriteLine("당신의 BMI는 " + bmi + " 입니다.");
                    Console.WriteLine("당신의 비만도는 정상입니다.");
                }
                else
                {
                    Console.WriteLine("당신의 BMI는 " + bmi + " 입니다.");
                    Console.WriteLine("당신의 비만도는 저체중입니다.");
                }
               
            }
        }
    }
}
