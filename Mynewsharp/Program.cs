﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp
{
    public class Program
    {
       public static void Main(string[] args)
        { 
       
            Console.ReadLine();
        }
    }
}
/*
 * 
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Lesson4
{
    public class Program
    {
        static void Main()
        {
            //Decision Making
            var var1 = Console.ReadLine();

            if (var1 == "5")
            {
                Console.WriteLine("Number is {0}", var1);
            }
            else if (var1 == "6")
            {
                Console.WriteLine("Number is {0}", var1);
            }
            else if (var1 == "7")
            {
                Console.WriteLine("Number is {0}", var1);
            }
            else if (var1 == "8")
            {
                Console.WriteLine("Number is {0}", var1);
            }
            else
            {
                Console.WriteLine("Other number");
            }

            //switch
            switch (var1)
            {
                case "5":
                case "6":
                case "7":
                case "8":
                    Console.WriteLine("Number is {0}", var1);
                    break;
                default:
                    Console.WriteLine("Other number");
                    break;
            }

            //short circuiting ?:

            var var2 = int.Parse(Console.ReadLine());

            string result;

            result = var2 >= 5 ? "true" : "false";

            if (var2 >=5)
            {
                result = "true";
            }
            else
            {
                result = "false";
            }

            Console.WriteLine(result);



            Console.WriteLine("Program ended");
            Console.ReadLine();
        }


        static void Main4()
        {
            //arrays [1,2,3,6,7,8,9]

            int[] array1 = new int[3];
            array1[0] = 5;
            array1[1] = 6;
            array1[2] = 19;

            int sum = array1[0] + array1[1] + array1[2];

            int sum1 = 0;

            for (int i = 0; i < array1.Length; i++)
            {
                sum1 += array1[i];
            }

            Console.WriteLine($"Sum is {sum}");
            Console.WriteLine($"Sum1 is {sum1}");

            int[] array2 = new int[50];
            var random = new Random();

            Console.WriteLine();
            Console.WriteLine("Array elements");
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = random.Next(0, 100);
                Console.WriteLine(array2[i]);

            }

            var result = array2.Max();
            Console.WriteLine(result);


            //2 dimensional arrays
            int[,] dim2Array1 = new int[2,3];
            dim2Array1[0, 0] = 5;
            dim2Array1[0, 1] = 6;
            dim2Array1[0, 2] = 7;
            dim2Array1[1, 0] = 8;
            dim2Array1[1, 1] = 9;
            dim2Array1[1, 2] = 10;

            Console.WriteLine("2dim Arrays");

            Console.WriteLine(dim2Array1.Length);
            Console.WriteLine(dim2Array1.Rank);
            Console.WriteLine(dim2Array1.GetLength(0));
            Console.WriteLine(dim2Array1.GetLength(1));

            var sum2DimArray = 0;

            for (int i = 0; i < dim2Array1.GetLength(0); i++)
            {
                for (int j = 0; j < dim2Array1.GetLength(1); j++)
                {
                    sum2DimArray += dim2Array1[i,j];
                }
            }

            Console.WriteLine(sum2DimArray);


            //3dim array
            int[,,] dim3Array1 = new int[2, 3, 4];

            Console.ReadLine();

        }



        static void Main3(string[] args)
        {
            const double pi = 3.14;

            DateTime date1 = DateTime.Now;

            var date2 = DateTime.Parse("08.14.2019 23:59:59");

            TimeSpan timeRange = date1 - date2;
            var stringResult = $"TimeRange is {timeRange}, year is {timeRange.Days/365}, days is {timeRange.Days}";
            var stringResult2 = string.Format("TimeRange is {0}, year is {1}, days is {2}", timeRange, timeRange.Days / 365, timeRange.Days);

            Console.WriteLine(stringResult);
            Console.WriteLine(stringResult2);
            Console.WriteLine("TimeRange is {0}, year is {1}, days is {2}", timeRange, timeRange.Days / 365, timeRange.Days);



            Console.WriteLine(date1.ToLongDateString());
            Console.WriteLine(TimeSpan.FromDays(2));
            Console.WriteLine(date1.Add(TimeSpan.Parse("5.23:25:56")));


            //date1.Kind.
            Console.WriteLine((int)date1.DayOfWeek);

            Console.WriteLine(date1.Date.ToString("dd.MM.yyyy HH:mm:ss.fff"));

            Console.ReadLine();
        }

        static void Main2(string[] args)
        {
            var studentType = (StudentType)int.Parse(Console.ReadLine());

            if (studentType == StudentType.GoodStudent)
            {
                //do something
            }
            else if(studentType == StudentType.ExcellentStudent)
            {
                // do some other stuff
            }

            Console.ReadLine();
        }
    }

    public enum StudentType : long
    { 
        BadStudent = 1,
        GoodStudent = 4,
        VeryGoodStudent = 9,
        ExcellentStudent = 15
    }

    public enum DayOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
    }
}
*/

// DateTime dateTime = DateTime.UtcNow;
//Console.WriteLine((int)dateTime.DayOfYear);
// Console.WriteLine(dateTime.AddYears(222));\
// Console.WriteLine(dateTime.Add(TimeSpan.Parse)("30.25.10"));

//int a = 5;
//int b = 5;
// int sum = a + b;
//char a = 'a';
//char b = 'b';
//var var1 = char.IsNumber(a);
// var var2 = char.IsLetter(b);
//string a = "asdsdswd";
//string b = a.ToUpper();
//double a = Math.PI;
//int a = 5;
//string b = a.ToString();
//int a = 6;
// int b = 7;
// Console.WriteLine(a+b);
//  Console.WriteLine(++a);
//expicit inversion
//b = (short)c;
// Console.WriteLine(a);
//int a = 7;
/*  int a = 5;
  int b = 7;
  if (a %2 ==0 && b%2==0 )
  {
      Console.WriteLine("cut");
  }
  else
  {
      Console.WriteLine("tek");
  }
*/

//string a = "Azerbaycan";
// string b = "can";
// Console.WriteLine(a.Contains(b));
/*
 DateTime dateTime = DateTime.Now;

 Console.WriteLine(dateTime.DayOfWeek);

 Console.ReadLine();
}
*/

/*

var student = (MyEnum)int.Parse(Console.ReadLine());

if (student==MyEnum.BadStudent)
{
    Console.WriteLine("bad");
}
else if (student == MyEnum.GoodStudent)
{
    Console.WriteLine("good");
}
else if (student==MyEnum.ExcellentStudent)
{
    Console.WriteLine("excellent");
}


Console.ReadLine();
}

public enum MyEnum
{
BadStudent=5,
GoodStudent=7,
ExcellentStudent=9,
*/

/*
 * using System;
using System.Collections;
using System.IO;

namespace Lesson5
{
    class Program1
    {
        static void Main5()
        {
            Program2.DoSomething();

            int[] myArray = {1,5,7,9,10};

            ArrayList list = Program1.CreateAndInitializeArrayList(30, "Bu gun", DateTime.Now);

            PrintArrayList(list);

            int sumWithFor = 0;
            for (int i = 0; i < myArray.Length; i++)
            {
                sumWithFor += myArray[i];
            }

            Console.WriteLine($"Sum with for operator is {sumWithFor}");

            int sumWithForeach = 0;
            foreach (var item in myArray)
            {
                sumWithForeach += item;
            }

            Console.WriteLine($"Sum with foreach operator is {sumWithForeach}");
        }

        static void Main4()
        {
            bool isContinue = false;
            do
            {
                Console.WriteLine("Do you want to continue ? Yes/No");
                string userAnswer = Console.ReadLine();
                isContinue = userAnswer.ToLower() == "yes";

                Console.WriteLine(isContinue ? "you want to continue" : "you choose to exit");
            } 
            while (isContinue);
        }

        static void Main3()
        {
            Console.WriteLine("Do you want to continue ? Yes/No");

            while (true)
            {
                string userAnswer = Console.ReadLine();
                bool isContinue = userAnswer.ToLower() == "yes";

                if (isContinue)
                {
                    Console.WriteLine("you want to continue");
                    continue;
                }

                Console.WriteLine("you choose to exit");
                break;
            }


            int i = 0;
            while (i < 100)
            {
                Console.WriteLine(i);
                i++;
            }

            Console.ReadLine();
        }

        static void Main2(string[] args)
        {
            //loops
            for (int i = 1; i <= 100; i+=2)
            {
                if (i > 70)
                {
                    break;
                }

                if (i / 10 >= 1 && i % 10 == 0)
                {
                    continue;
                }

                Console.WriteLine(i);
            }

            Console.WriteLine("First loop part seperator");

            for (int i = 100; i>0; i--)
            {
                Console.WriteLine(i);
            }
        }

        static ArrayList CreateAndInitializeArrayList(int itemCount, string text, DateTime date)
        {
            ArrayList list = new ArrayList();

            for (int i = 0; i < itemCount; i++)
            {
                list.Add(i);
            }

            int var1 = Convert.ToInt32(list[1]);

            list.Add(1);
            list.Add(text);
            list.Add(date);

            return list;
        }

        static void PrintArrayList(ArrayList list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            return;

            int a = 5;
        }
    }
}
*/
/*
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class Program2
    {
        static void Main()
        {
            var random = new Random();
            var magicNumber = random.Next(1, 101);

            var input = 0;

            Console.WriteLine("Enter value to find magic number: ");

            while (input != magicNumber)
            { 
                input = int.Parse(Console.ReadLine());

                if (input > magicNumber)
                {
                    Console.WriteLine("Enter small number");
                }
                else
                {
                    Console.WriteLine("Enter big number");
                }
            }

            Console.WriteLine($"Your magic number is {input}");
        }

        public static void DoSomething()
        {
            Console.WriteLine("Doing something");
        }
    }
}
*/
