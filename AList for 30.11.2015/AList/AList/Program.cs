using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AList
{
    class Program
    {
        static IAList list;

        static void Main(string[] args)
        {
            var a = new LList2();
            int[] mas = new int[] { 1, 2 };
            a.Init(mas);
            int res = a.DelStart();
            mas = new int[] { 2 };
            Console.WriteLine();
            Console.ReadLine();

            //string operation = "";
            //Console.WriteLine("Choose the class you want to test:");
            //Console.WriteLine("1. AList0");
            //Console.WriteLine("2. AList1");
            //Console.WriteLine("3. AList2");
            //int classToUse = Convert.ToInt16(Console.ReadLine());

            //while (!ChooseClass(classToUse)) { }

            //while (operation != "e")
            //{
            //    Console.WriteLine("Choose Method to test");
            //    Console.WriteLine("1. Size");
            //    Console.WriteLine("2. Clear");
            //    Console.WriteLine("3. Init");
            //    Console.WriteLine("4. ToArray");
            //    Console.WriteLine("5. AddStart");
            //    Console.WriteLine("6. AddEnd");
            //    Console.WriteLine("7. AddPos");
            //    Console.WriteLine("8. DelStart");
            //    Console.WriteLine("9. DelEnd");
            //    Console.WriteLine("10. DelPos");
            //    Console.WriteLine("11. Min");
            //    Console.WriteLine("12. Max");
            //    Console.WriteLine("13. MinI");
            //    Console.WriteLine("14. MaxI");
            //    Console.WriteLine("15. Reverse");
            //    Console.WriteLine("16. HalfReverse");
            //    Console.WriteLine("17. Get");
            //    Console.WriteLine("18. Set");
            //    Console.WriteLine("19. Sort");

            //    Console.WriteLine("Press 'e' to exit.");
            //    operation = Console.ReadLine();
            //    ChooseOperation(operation);
            //}
        }

        private static void ChooseOperation(string operation)
        {
            int[] mas;
            int num = 0;
            switch (operation)
            {
                case "1":
                    Console.WriteLine(list.Size());
                    break;
                case "2":
                    list.Clear();
                    break;
                case "3":
                    Console.WriteLine("Input array length:");
                    int n = Convert.ToInt16(Console.ReadLine());
                    mas = new int[n];
                    for (int i = 0; i < n; i++)
                    {
                        try
                        {
                            mas[i] = Convert.ToInt16(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("It is not an integer number");
                            i--;
                        }
                    }
                    list.Init(mas);
                    Console.WriteLine(list.Size());
                    break;
                case "4":
                    mas = list.ToArray();
                    foreach (int a in mas)
                    {
                        Console.WriteLine(a.ToString());
                    }
                    break;
                case "5":
                    for (int i = 0; i < 1; i++)
                    {
                        try
                        {
                            num = Convert.ToInt16(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("It is not an integer number");
                            i--;
                        }
                    }
                    list.AddStart(num);
                    break;
                case "6":
                    Console.WriteLine("Input number to add:");
                    for (int i = 0; i < 1; i++)
                    {
                        try
                        {
                            num = Convert.ToInt16(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("It is not an integer number");
                            i--;
                        }
                    }
                    list.AddEnd(num);
                    break;
                case "7":
                    Console.WriteLine("Input number to add and the place it will be added to:");
                    mas = new int[2];
                    for (int i = 0; i < 2; i++)
                    {
                        try
                        {
                            mas[i] = Convert.ToInt16(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("It is not an integer number");
                            i--;
                        }
                    }
                    list.AddPos(mas[1], mas[0]);
                    break;
                case "8":
                    list.DelStart();
                    break;
                case "9":
                    list.DelEnd();
                    break;
                case "10":
                    Console.WriteLine("Input the index of the number to delete:");
                    for (int i = 0; i < 1; i++)
                    {
                        try
                        {
                            num = Convert.ToInt16(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("It is not an integer number");
                            i--;
                        }
                    }
                    list.DelPos(num);
                    break;
                case "11":
                    Console.WriteLine(list.Min().ToString());
                    break;
                case "12":
                    Console.WriteLine(list.Max().ToString());
                    break;
                case "13":
                    Console.WriteLine(list.MinI().ToString());
                    break;
                case "14":
                    Console.WriteLine(list.MaxI().ToString());
                    break;
                case "15":
                    list.Reverse();
                    break;
                case "16":
                    list.HalfReverse();
                    break;
                case "17":
                    Console.WriteLine("Input the index of the number to get:");
                    for (int i = 0; i < 1; i++)
                    {
                        try
                        {
                            num = Convert.ToInt16(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("It is not an integer number");
                            i--;
                        }
                    }
                    Console.WriteLine(list.Get(num).ToString());
                    break;
                case "18":
                    Console.WriteLine("Input the index of the number to set and the value:");
                    mas = new int[2];
                    for (int i = 0; i < 2; i++)
                    {
                        try
                        {
                            mas[i] = Convert.ToInt16(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("It is not an integer number");
                            i--;
                        }
                    }
                    list.Set(mas[0], mas[1]);
                    break;
                case "19":
                    list.Sort();
                    break;
            }
        }

        private static bool ChooseClass(int classToUse)
        {
            bool res = false;
            switch (classToUse)
            {
                case 1:
                    list = new AList0();
                    res = true;
                    break;
                case 2:
                    list = new AList1();
                    res = true;
                    break;
                case 3:
                    list = new AList2();
                    res = true;
                    break;
                default:
                    Console.WriteLine("There is no such class!");
                    break;
            }
            return res;
        }
    }
}
