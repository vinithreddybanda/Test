class Program
{
    static void Main(string[] args)
    {
        
        System.Console.WriteLine("Literals:  The fixed values - Not Changed ");
        System.Console.WriteLine();
        System.Console.WriteLine(" values of types int, uint, long, ulong, etc");
        System.Console.WriteLine();

        System.Console.WriteLine("C#, Octal Number Representation is not possible");

        System.Console.WriteLine();

        System.Console.WriteLine("");

        System.Console.WriteLine(" int x=101"); //no suffix-prefix
        int x1 =101; 
        

        System.Console.WriteLine("int x = 0X123F"); //0x prefix and f is suffix
        int x2 = 0X123F; //base-16

        System.Console.WriteLine("int x = 0b1111");//0b prefix
        int x3 = 0b1111;  // binary 1-0


        System.Console.WriteLine();
        System.Console.WriteLine();

        System.Console.WriteLine("base :"+ x1);
        System.Console.WriteLine("HEx :"+ x2);
        System.Console.WriteLine("Binary: "+ x3);


    }
}