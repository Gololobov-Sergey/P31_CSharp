using System.Text;

namespace P31_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "P31 C#";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();


            // 22.09.2024
            //==============================================================================


            //int[] arr = { 2,4,56,7};
            //int[] arr1 = new int[10];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] *= 2;
            //    Console.WriteLine(arr[i]);
            //}
            //Console.WriteLine();

            //foreach (int i in arr)
            //{
            //    //i *= 2;  // error
            //    Console.Write(i + " ");
            //}

            Random rand = new Random();


            //int[] arr = new int[10];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = rand.Next(10, 16);
            //}
            //foreach (int item in arr)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //Створіть додаток, який відображає кількість парних,
            //непарних, унікальних елементів масиву.

            //int doubles = 0;
            //int notPaired = 0;
            //int unique = 0;
            //int counter;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    if (arr[i] % 2 == 0)
            //    {
            //        doubles++;
            //    }
            //    else
            //    {
            //        notPaired++;
            //    }

            //    counter = 0;

            //    for (int j = 0; j < arr.Length; j++)
            //    {
            //        if (arr[i] == arr[j])
            //        {
            //            counter++;
            //        }
            //    }

            //    if (counter == 1)
            //    {
            //        unique++;
            //    }
            //}

            //Console.WriteLine($"\nКількість парних: {doubles}");
            //Console.WriteLine($"Кількість не парних: {notPaired}");
            //Console.WriteLine($"Кількість унікальних: {unique}");

            //Console.WriteLine(arr.Distinct().Count());


            //int[,] arr2 = new int[3,4];
            //Console.WriteLine(arr2.Length);
            //Console.WriteLine(arr2.Rank);
            //Console.WriteLine(arr2.GetLength(0));
            //Console.WriteLine(arr2.GetLength(1));
            //for (int i = 0; i < arr2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr2.GetLength(1); j++)
            //    {
            //        arr2[i,j] = rand.Next(10);
            //        Console.Write(arr2[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //int[] arr = new int[10];


            // Дано 2 масиви розмірності M і N відповідно.
            // Необхідно переписати до третього масиву
            // загальні елементи перших двох масивів без повторень.

            //int m = Convert.ToInt32(Console.ReadLine());
            //int n = Convert.ToInt32(Console.ReadLine());
            //int[] arr1 = new int[n];
            //int[] arr2 = new int[m];
            //int minSize = m < n? m : n;
            //int[] arr3 = new int[minSize];

            //for (int i = 0; i < arr1.Length;i++)
            //{
            //    arr1[i] = rand.Next(10, 20);
            //}
            //for (int i = 0; i < arr2.Length; i++)
            //{
            //    arr2[i] = rand.Next(10, 20);
            //}

            //foreach (var item in arr1)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //foreach (var item in arr2)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();

            //int count = 0;
            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    if (arr2.Contains(arr1[i]) && !arr3.Contains(arr1[i]))
            //    {
            //        arr3[count++] = arr1[i];
            //    }
            //}

            //for (int i = 0; i < count; i++)
            //{
            //    Console.Write(arr3[i] + " ");
            //}
            //Console.WriteLine();



            string st = "Hello";
            Console.WriteLine($"{st.PadLeft(10, '.')}");
            Console.WriteLine($"{st.PadRight(10)}rtert");
            st += " C#";

            StringBuilder sb = new StringBuilder();
            sb.Append("mama");
            sb.AppendLine(st);
            sb.Append("45345");
            string st1 = sb.ToString();
            Console.WriteLine(st1);

            //Користувач вводить речення з    клавіатури.
            //Вам необхідно підрахувати кількість слів у ньому.

            string st3 = "Користувач     вводить      речення";
            Console.WriteLine(st3.Split(".,!? ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).Length);

            string st4 = "sun cat dogs cup tea";
            string[] st5 = st4.Split();
            for (int i = 0; i < st5.Length; i++)
            {
                st5[i].Reverse();
            }
            string st6 = String.Join(' ', st5);
            Console.WriteLine(st6);

            //================================================================================


            //Console.WriteLine("Мене звати Сергій");

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(a + b);

            //int c = Int32.Parse(Console.ReadLine());

            //int m = (int)5.3;

            //double d = 2;

            //DateTime date = DateTime.Now;
            //Console.WriteLine(date.ToLongDateString());
            //Console.WriteLine(date.ToShortDateString());
            //Console.WriteLine(date.ToLongTimeString());
            //Console.WriteLine(date.ToShortDateString());
            //Console.WriteLine(date.ToString());

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //if (!a)
            //{

            //}
            //else if (a)
            //{

            //}

            //int max = a > b ? a : b;

            //switch (a)
            //{
            //    case 3:
            //        Console.WriteLine("Hello");
            //        break;
            //    case 5:
            //    case 4:
            //    case 12:
            //        Console.WriteLine("jkhkj");
            //        break;
            //    default:
            //        break;
            //}

            //while (true)
            //{

            //}

            //do
            //{

            //} while (true);


            //for (int i = 0; i < a; i++)
            //{

            //}

            //foreach (var item in args)
            //{

            //}
            //int a = 9,b,c,d,e;
            //Console.WriteLine("Hello " + a);
            //Console.WriteLine($"Hello {a}");

            //int max = a;
            //if(b > max)
            //{
            //    max = b;
            //}
            //if(c > max)
            //{
            //    max = c;
            //}

            //DateTime d = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine(d);

            Console.ReadKey();
        }
    }
}
