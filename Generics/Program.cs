using System.ComponentModel.DataAnnotations;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ARR<int> aRR = new ARR<int>();
            aRR.add(1);
            aRR.add(2);
            aRR.add(3);
            aRR.add(4);
            aRR.RemoveAt(0);
            aRR.Display();
            aRR.Reverse();
        }
    }

    class ARR<T>
    {
        public T[] itemes;
        public void add(T _item)
        {
            if( itemes is null)
            {
                itemes = new T[] { _item };
            }
            else 
            {
                int length = itemes.Length;
                T[] temp = new T[length + 1];
                for(int i = 0; i < itemes.Length; i++) 
                {
                    temp[i] = itemes[i];
                }
                temp[temp.Length - 1] = _item;
                itemes = temp;
                
            }
        }

        public void RemoveAt(int index) 
        {
            if (index < 0 || index >= itemes.Length - 1)
            {
                return;
            }
            T[] temp = new T[itemes.Length - 1];
            int pos = 0;
            for (int i = 0; i < itemes.Length; i++)
            {
                if (index == i)
                {
                    continue;
                }
                temp[pos++] = itemes[i];
            }
            itemes = temp;
        }

        public bool isEmpty => itemes.Length == 0;
        public bool count => itemes.Length > 0;
        public void Display()
        {
            Console.Write("[");
            for(int i = 0;i < itemes.Length;i++)
            {
                Console.Write($"{itemes[i]},");
            }
            Console.Write("]");
        }

        public void Reverse()
        {
            int [] itemes1 = new int[] {1,2,3,4};
            int length = itemes1.Length - 1;
            string rev = null;
            while (length >= 0)
            {
                rev = rev + itemes1[length];
                length --;
            }
            Console.WriteLine();
            Console.Write("[");
            Console.Write(rev);
            Console.Write("]");
        }
    }
}