using System;

namespace TestGenerics
{
    public class MyGenericArray<T>
    {
       private T[] array;

       public MyGenericArray(int size)
       {
           array = new T[size + 1];
       }

        public T GetItems(int index)
        {
            return array[index];
        }

        public void SetItems(int index, T value)
        {
            array[index] = value;
        }

    
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyGenericArray<int>intArray = new MyGenericArray<int>(5);

            // setting values
            for (int i = 0; i < 5; i++)
            {
                intArray.SetItems(i, i*3);
            }

            // retriving the items
            for (int i = 0; i < 5; i++)
            {
                Console.Write(intArray.GetItems(i) + " ");
            }

            Console.WriteLine();

            MyGenericArray<char>chaArray = new MyGenericArray<char>(4);

            // setting values
            for (int c = 0; c < 5; c++)
            {
                chaArray.SetItems(c, (char)(c+97));
            }

            for (int c = 0; c < 5; c++)
            {
                Console.WriteLine(chaArray.GetItems(c) + " ");
            }

            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
