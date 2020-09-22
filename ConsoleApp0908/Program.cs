using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp0908
{
    class Program
    {
        static void Main(string[] args)
        {
            //byte,short,int,long

            short n1 = 2;
            n1 += 10;
            Console.WriteLine(n1); //12

            byte b1 = 125;
            Console.WriteLine(b1);//125

            n1 = b1;//byte를 int한테(자동변환,암시적형변환)작은것에서 큰것
            b1 = (byte)n1;//int를 byte한테(명시적형변환)큰것에서 작은것
            //값의 범위가 넘치더라도 명시적형변환을 하면,컴파일러 오류는 발생하지 않지만 이상한 값을 갖는다.
            n1 = 300;

            //////////////////////////////////////////////
            //float,double,decimal
            float f1 = (float)2.35; //초기값을 준 모든 실수는 기본 double 형 인식,자동 형변환 실패
            Console.WriteLine(f1);

            float f2 = 2.35f;//대문자 F도 가능
            Console.WriteLine(f2);

            decimal d1 = (decimal)2.35;
            d1 = 2.54m;
            Console.WriteLine(d1); //2.54

            float f9 = 3.14658783443258748421234851f;//6자리
            double d9 = 3.1459514563154842123454;//14자리
            decimal m9 = 3.145687545212487445484521m;

            Console.WriteLine(f9);
            Console.WriteLine(d9);
            Console.WriteLine(m9);
            //===============================================

            int d = 10;
            float cf = d;
            Console.WriteLine(cf);//10
            cf = 2.5f;
            d = (int)cf;//명시적형변환 실수=>정수 명시적형변환을 하는 경우 ,소수점은 버려진다.
            Console.WriteLine(d);//2

            int kor = 95;
            int math = 78;
            int eng = 99;
            int sum = kor + math + eng;
            double avr = (double)sum / 3.0;

            //평균(int)=총점(int)/과목수(int)
            //총점도 int과 과목수도 int여서 평균도 int로 나온다
            //double/int=>int를 double로 자동형변횐이 일어난다
            Console.WriteLine(avr);

            //형변환의 경우
            //값=>값:int->byte, byte->int, int->double(형변환타입)
            //참조=>참조 : string->object, object->string(형변환타입)

            //값=>참조 : int->string, double->string(특별한 방법이용)
            //참조=>값: string->int, string->double(특별한 방법이용)

            int k = (int)double.Parse("10");
            string msg = "총점" + sum.ToString();

            Console.WriteLine(msg);

        }
    }
}