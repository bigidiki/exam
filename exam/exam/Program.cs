using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5] ;
            Console.WriteLine(" Введите 10 цифр ");

            char[] ch = new char[] { ' ', ';', ',' };
            string result = Console.ReadLine();
            string[] str = result.Split(ch);
            for (int i = 0; i < str.Length; i++)
            {
                array[i] = Convert.ToInt32(str[i]);
                Console.Write(" {0} ",array[i]);
            }
            Console.Write(" - Array 10 elements ");
            Console.WriteLine(" ");
            even_odd(array);
            Console.ReadKey();                
                
        }

        #region evenandodd
        public static void even_odd(int[] array)
        {
            
            int acum = 0;
            int acum2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array.Length == 0)
                {
                    break;
                }
                if (array[i] % 2 == 0)
                {
                    acum2++;
                }
                else
                {
                    acum++;
                }
            }
            int[] a1 = new int[acum];
            int[] a2 = new int[acum2];

            acum = 0;
            acum2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    a2[acum2] = array[i];
                    acum2++;
                }
                if (array[i] % 2 != 0)
                {
                    a1[acum] = array[i];
                    acum++;
                }
            }

            bubbleSort(a2);
            bubbleSort(a1);

            Console.WriteLine(" Введите значение ");
            string result = Console.ReadLine();
            Search(a2, a1, int.Parse(result));
            Console.WriteLine(" ");
            while (true)
            {
                Console.WriteLine(" Выберите массив even или выберите odd  ");
                result = Console.ReadLine();
                if (result == "q") { break; }
                switch (result)
                {
                    case "even":
                        Console.WriteLine("Вы выбрали массив even");
                        foreach(int i in a2)
                        {
                            Console.Write(" {0}",i);
                        }
                        break;
                    case "odd":
                        Console.WriteLine("Вы выбрали массив odd");
                        foreach (int i in a1)
                        {
                            Console.Write(" {0}", i);
                        }
                        break;
                    default:
                        Console.WriteLine("Невозможно выполнить операцию");
                        break;
                }
            }
        }
        #endregion

        #region Search
        public static void Search(int[] a2,int[]a1, int a)
        {
            bool b = false;
            if (a % 2 == 0)
            {
                for(int i = 0; i < a2.Length; i++)
                {
                    if (a2[i] == a)
                    {
                        b = true;
                        Console.WriteLine(" {0} - находится в четных числах",a);
                    }
                }
                if (b == true)
                {
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine(" числа нет ");
                }
                
            }
            else if (a % 2 != 0)
            {
                for(int i = 0; i < a1.Length; i++)
                {
                    if (a1[i] == a)
                    {
                        b = true;
                        Console.WriteLine(" {0} - находится в нечетных числах", a);
                    }
                }
                if (b == true)
                {
                    Console.WriteLine(" ");
                }
                else
                {

                    Console.WriteLine(" числа нет ");
                }
            }
          
        }
        #endregion

        #region bublesort
        public static void bubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        swap(array[i], array[j]);
                    }
                }
            }
        }
        #endregion

        #region swap
        public static void swap(int one, int two)
        {
            int temp = one;
            one = two;
            two = temp;
        }
        #endregion

        #region selectsort
        public static void selectSort(int[] array)
        {
            int outarr;
            int inarr;
            int min;

            for (outarr = 0; outarr < array.Length - 1; outarr++)
            {
                min = outarr;
                for (inarr = outarr + 1; inarr < array.Length; inarr++)
                {
                    if (array[inarr] < array[min])
                        min = inarr;
                    swap(outarr, min);
                }
            }
        }
        #endregion

        #region insertSort
        public static void insertSort(int[] arr)
        {
            int inarr;
            int outarr;
            int nElems = arr.Length;

            for (outarr = 1; outarr < nElems; outarr++)
            {
                int temp = arr[outarr];
                inarr = outarr;
                while (inarr > 0 && arr[inarr - 1] >= temp)
                {
                    arr[inarr] = arr[inarr - 1];
                    --inarr;
                }
                arr[inarr] = temp;

            }
        }
        #endregion
    }
}
