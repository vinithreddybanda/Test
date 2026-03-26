class Program
{
    static void Main(string[] args)
    {
        int a =10;
        System.Console.WriteLine("\a"); // escape 
        System.Console.WriteLine(@"\a");
        System.Console.WriteLine($"{a}");
        System.Console.WriteLine(@"{a}"); //verbatim string literal
        System.Console.WriteLine("\u0041"); //unicode 
    }
}