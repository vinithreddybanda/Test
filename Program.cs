class Program
{
    static void Main(string[] args)
    {

        System.Console.WriteLine();
        System.Console.WriteLine("Crazy we have pointer in c# IDK");
        System.Console.WriteLine("we use & and *");

        System.Console.WriteLine();
        System.Console.WriteLine();



        System.Console.WriteLine("int a = 10");

        System.Console.WriteLine();
        System.Console.WriteLine();

        System.Console.WriteLine("Use in unsafe blocks like :  unsafe{}\ncsproj <AllowUnsafeBlocks>true</AllowUnsafeBlocks>");
        System.Console.WriteLine();
        System.Console.WriteLine();

        
        unsafe 
        {
        int a = 10;
        int* ptr = &a;

        System.Console.WriteLine($"a: {a}\nAddress = {(IntPtr)ptr}\n*ptr={*ptr}");
        
        }
    }
}