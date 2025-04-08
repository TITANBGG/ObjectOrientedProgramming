using System;

class Program
{
    static void Main(string[] args)
    {
        MyArrayList list = new MyArrayList();

        list.Add("Ali");
        list.Add("Enver");
        list.Add(42);
        list.Insert(1, "Fırat");

        Console.WriteLine("Liste: " + list.ToString()); // Ali, Fırat, Enver, 42

        list.RemoveAt(2);
        Console.WriteLine("Yeni Liste: " + list.ToString()); // Ali, Fırat, 42

        Console.WriteLine("İndeks 1: " + list.Get(1)); // Fırat
        Console.WriteLine("Toplam Eleman: " + list.Count); // 3

        Console.ReadLine(); // Konsol açık kalsın
    }
}
