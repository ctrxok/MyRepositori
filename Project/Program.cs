using System;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography;

namespace newApp
{
    public class List
    {
        private string[] array = new string[10];
        private int counter = 0;
        public int Size()
        {
          return array.Length;
        }
        public void Set(int index, string? value)
        {
            array[index] = value;
        }

        public string? Get(int index)
        {
            return array[index]; 
        }

        public void Add(string value)
        {

            if (array.Length < counter) 
            {

                string[] temp = new string[array.Length * 2];

                for (int i = 0; i < array.Length; i++)
                {
                    temp[i] = array[i];  
                }
                array = temp;
            }
                array[counter] = value;
            counter++;
        }

        public void Delete(int index)
        {
            for (int i = index; i < counter - 1; i++)
            {
                array[index] = array[index++];
            }

            array[counter-1] = null;        
        }

        
    }
    class Start_Point 
    {
        static void Main() 
        {
            List list = new List();

            bool repiter = true;

            int choser;

            while (repiter)
            {
                Console.Write("Whant repit?");
                if (Console.ReadLine() == "No" )
                {
                    repiter = false;
                }


                Console.WriteLine("enter number of method [1-5]: ");
                choser = Convert.ToInt32(Console.ReadLine());

                switch (choser)
                {
                    case 1:
                        Random random = new Random();   
                        for (int i = 0; i < 10; i++)
                        {
                            list.Add(Convert.ToString(random.Next(15)));
                        }
                        break;

                    case 2:
                        Console.WriteLine("Enter index: ");
                        int index = Convert.ToInt32(Console.ReadLine());    
                        Console.WriteLine("Enter value: ");
                        string? value = Console.ReadLine();

                        list.Set(index,value);
                        break;

                    case 3:
                        Console.WriteLine("enter index of element: ");
                        int index1 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(list.Get(index1));
                        break;

                    case 4:
                        Console.WriteLine("enter index of element: ");
                        int index2 = Convert.ToInt32(Console.ReadLine());
                        list.Delete(index2);
                        break; 
                    
                    case 5:
                        Console.WriteLine($"Size: {list.Size()}");
                        break;



                    default:
                        Console.WriteLine("Invalid method!");
                        break;
                }





            }
        }
    }


}