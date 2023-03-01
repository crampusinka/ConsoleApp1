using System;

namespace Console1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleApp1.Array<int> array= new ConsoleApp1.Array<int>();
            Console.WriteLine("Введите кол-во элементов нового массива");
            var hui = array.CreateArray(int.Parse(Console.ReadLine() ?? "0"));
            array.OutputArray(hui);
            Console.WriteLine("Введите элемент для добавления в массив");
            var addItem = int.Parse(Console.ReadLine() ?? "0");
            array.AddArray(addItem);
            array.OutputArray(hui);
            Console.WriteLine("Введите индекс удаляемого элемента массива");
            var deleteItem = int.Parse(Console.ReadLine() ?? "0");
            array.DeleteArray(deleteItem);
            array.OutputArray(hui);
        }

       
    }
}