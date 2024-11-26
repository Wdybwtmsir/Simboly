using System;

class Program
{
    static void Main()
    {    
        char[] symbols = new char[11];

        Console.WriteLine("Введите 11 символов:");
        for (int i = 0; i < symbols.Length; i++)
        {
            symbols[i] = Console.ReadKey().KeyChar; 
            Console.Write(" "); 
        }
        for (int i = 0; i < symbols.Length; i++)
        {
            if (char.IsLower(symbols[i]))
            {
                symbols[i] = char.ToUpper(symbols[i]);
            }
        }
        Console.WriteLine("\nИзмененный массив символов:");
        foreach (char c in symbols)
        {
            Console.Write(c + " ");
        }
    }
}