using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Array<T>
    {
        private T[] array;

        public Array(int elementCount) 
        {
            array = new T[elementCount];
        }

        public void FillArray(params T[] elements)
        {
            array = elements;
        }

        public T[] GetArray()
        {
            return array;
        }
        public void OutputArray()
        {

        }

        public void AddArray(T obj)
        {

        }

        public void DeleteArray(T obj)
        {

        }
    }
}
