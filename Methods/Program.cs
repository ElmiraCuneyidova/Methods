using System;
using System.Net.Mail;
using System.Reflection.Metadata;
using System.Threading.Channels;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Sum(5,7);


            //int[] arr = { 5, 7, 9, 2, 1, 0 };
            //Console.WriteLine(Average(arr));


            //Console.WriteLine("Enter your number: ");
            //float f = float.Parse(Console.ReadLine());
            //Console.WriteLine(Round(f));


            //Console.WriteLine("Enter your number: ");
            //int num = int.Parse(Console.ReadLine());
            //Task4(num);


            //bool female = true;
            //Console.WriteLine(Task5(female));


            //string firstName = "Elmira";
            //string lastNmae = "juneyidova";
            //string fullname = Task6(firstName,lastNmae);
            //Console.WriteLine(fullname);



            //Console.WriteLine("Enter your number: ");
            //decimal num = decimal.Parse(Console.ReadLine());
            //Console.WriteLine(Task7(num));

            //Console.WriteLine("Enter your number");
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(Task8(num));

            Console.WriteLine("Enter your number");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your power");
            int pow = int.Parse(Console.ReadLine());
            Console.WriteLine(Task9(num, pow));

        }

        #region task1

        //1.Parametr kimi iki tam ədəd götürən və onların cəmini qaytaran metod
        //yaradın.

        static void Sum(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine("Sum is " + sum);
        }

        #endregion


        #region task2

        //2. Tam ədədlər arrayini parametr kimi götürən və arraydəki bütün ədədlərin
        //ədəfi ortasını qaytaran metod yazın.


        static double Average(int[] arr)
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            double result  = sum / arr.Length;  
           return result;

        }
        #endregion


        #region Task3

        //3. Parametr kimi float qəbul edən və onu ən yaxın tam ədədə
        //yuvarlaqlaşdıran metod yazın.

        static float  Round(float f)
        {
            float result = (float)Math.Round(f);
           return result;
        }
        

        #endregion


        #region Task4

        //4. Tam ədədi parametr kimi qəbul edən və ədədin cüt və ya tək olduğunu
        //göstərən və geriyə boolean qaytaran metod yazın.

        static int Task4(int num)
        {

            if (num%2== 0)
            {
                Console.WriteLine($"Number {num} is even.");
            }
            else
            {
                Console.WriteLine($"Number {num} is odd.");
            }
            return num;
        }

        #endregion


        #region Task5 

        //5. Parametr kimi boolean götürən və string qaytaran metod yaradın.
        //Boolean doğrudursa, metod "Bəli", yanlışdırsa, "Xeyr" qaytarmalıdır.

     static string Task5(bool b)
        {
           

            if (b==true)
            {
                return "Yes";
            }
            else
            {
                return "No";
            }


        }


        #endregion


        #region Task6

        //6. İki string parametr kimi götürən və onları birləşdirən metod yazın.Bir
        //oyunçunun ad və soyadlarından tam adını yaratmaq üçün bu metoddan
        //istifadə edin.

        static string  Task6 (string name, string surname)
        {


            return name + " " + surname;
        }


        #endregion


        #region Task7

        //7. Parametr kimi decimal qəbul edən və ədədin kvadratını qaytaran metod
        //yaradın.


        static decimal Task7(decimal d)
        {
            return d*d;
        }

        #endregion


        #region Task8

        //8. Parametr kimi int qəbul edən və Sade olub olmadıgına görə bool deyeri
        //qaytarır.Main methodda bool true qaytararsa Console - Edet Sadedir
        //yazısı cıxsın.


        static bool Task8 (int a)
        {
            if (a % 2 == 0 || a % 3 == 0 || a % 5 == 0 || a % 7 == 0)
            {

                Console.WriteLine("Eded sade deyil");
                return false;
            }
            else
            {

                Console.WriteLine("Eded sadedir");
                return true;
            }
        }



        #endregion


        #region Task9 

        //9. Parametr olaraq 2 dənə int qəbul edən method yaradın(int number, int
        //power). Bu method number ededinin power quvettine qaldirib,
        //qaytarmalıdır.

        static double  Task9 (int number,int power )
        {
           double result = Math.Pow(number, power);
            return result;
        }



        #endregion
    }
}
