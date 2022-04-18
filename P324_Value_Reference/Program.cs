using System;
using System.Text;
//using System.Text;

namespace P324_Value_Reference
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework
            //Console.WriteLine("bir eded daxil edin)");
            //int num = Convert.ToInt32(Console.ReadLine());
            //int copy = num;
            //int prefix = 3;
            //while (copy!=0)
            //{
            //    copy /= 10;

            //    prefix *= 10;

            //}
            //Console.WriteLine(num + prefix);



            //int num = Convert.ToInt32(Console.ReadLine());

            //if(num % 7  == 0)
            //{
            //    Console.WriteLine(num + " 7-ye bolunur");
            //}
            //else
            //{
            //    int remainder = num % 7;
            //    if(remainder >= 4)
            //    {
            //        while (num % 7  != 0)
            //        {
            //            num++;
            //        }
            //    }
            //    else
            //    {
            //        while (num % 7 != 0)
            //        {
            //            num--;
            //        }
            //    }
            //    Console.WriteLine(num);
            //}




            //Console.WriteLine("Zehmet olmasa bir eded daxil edin");
            //int num = Convert.ToInt32(Console.ReadLine());

            //int[] arr;
            //if(num <= 50)
            //{
            //    int count = num / 3 + 1;
            //    arr = new int[count];
            //    int index = 0;
            //    for (int i = 0; i <= num; i++)
            //    {
            //        if(i % 3 == 0)
            //        {
            //            arr[index] = i;
            //            index++;
            //        }
            //    }   
            //}
            //else if (num <= 100)
            //{
            //    int count = num / 5 + 1;
            //    arr = new int[count];
            //    int index = 0;
            //    for (int i = 0; i <= num; i++)
            //    {
            //        if (i % 5 == 0)
            //        {
            //            arr[index] = i;
            //            index++;
            //        }
            //    }
            //}
            //else
            //{
            //    int count = num / 8 + 1;
            //    arr = new int[count];
            //    int index = 0;
            //    for (int i = 0; i <= num; i++)
            //    {
            //        if (i % 8 == 0)
            //        {
            //            arr[index] = i;
            //            index++;
            //        }
            //    }
            //}


            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            //int number = 30;
            //Change(number);
            //Console.WriteLine(number);

            //int number1 = number;
            //number = 20;
            //Console.WriteLine(number);
            //Console.WriteLine(number1);
            //int[] arr = { 1, 2, 3, 4, 5 };

            //int[] arr1 = arr;//{1,2,3,4,5}

            //Console.WriteLine(arr[0]);
            ////int num = arr[0];
            //arr[0] = 212;

            //Console.WriteLine(arr1[0]);

            //int number;
            ////0x60000
            ////Change(ref number);
            ////Console.WriteLine(number);
            //ChangeWithOut(out number);
            //Console.WriteLine(number);


            //int num = Convert.ToInt32(Console.ReadLine());
            //int number;
            //string str = Console.ReadLine();
            //int num = int.Parse(str);
            //bool result = int.TryParse(str, out number);

            //Console.WriteLine(num);

            //if (result)
            //{
            //    Console.WriteLine(number);
            //}
            //else
            //{
            //    Console.WriteLine("Zehmet olmasa duzgun eded daxil edin");
            //}

            //Normal();
            //Console.WriteLine(num);

            //int[] arr = { 1, 2, 3, 4, 5 };
            //ChangeArr(ref arr);
            //Console.WriteLine(arr[0]);


            string str = "P";
            str += "324";
            //str += " Programming";
            string empty = "";

            int[] arr = { 1, 2, 3 };


            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.Append("P");
            stringBuilder.Append("324");
            stringBuilder.Append(" Programming");

            Console.WriteLine(stringBuilder);

            //for (int i = 0; i < 5; i++)
            //{
            //    str += i;
            //    Console.WriteLine(str);
            //}

            //P
            //P324
            //P324 Programming

            //Console.WriteLine(str);

        }


        public static void Normal(int number = 20)
        {

            Console.WriteLine(number);
        }
        public static void Change(ref int num)
        {
            num += 5;
            Console.WriteLine(num);
        }


        public static void ChangeWithOut(out int num)
        {
            num = 255;
            Console.WriteLine(num);
        }

        public static void ChangeArr(ref int[] arr)
        {
            //arr[0] = 20;

            arr = new int[]{ 5,6,7,8,9};
        }
    }
}
