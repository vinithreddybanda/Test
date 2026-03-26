class Program
{
    static void Main(string[] args)
    {

        int x =10;
        Console.Title="hello";
        // Console.BackgroundColor;
        // Console.BufferHeight;
        // Console.ForegroundColor;
        // Console.CursorSize;
        
        Console.Clear();//clear cui
        Console.Beep(); // Beep Sound
        Console.ResetColor();// reset foreground and background color
        Console.Write("Write in Same Line");
        System.Console.WriteLine("Write and print next Line");
        System.Console.WriteLine("can pass var: "+ x);
        // Write  the specified string value to the standard output stream.

        
        System.Console.WriteLine("Read: ");
        var a= Console.Read();
        Console.ReadLine();//flush enter
         System.Console.WriteLine("Read - Single Character - return ascii value int: "+a);
        System.Console.WriteLine("ReadLine:");



        var b = Console.ReadLine();
        System.Console.WriteLine();//new line
        System.Console.WriteLine("Read - Line- return string: "+ b);

        System.Console.WriteLine("ReadKey:");
        var c = Console.ReadKey();
        System.Console.WriteLine();//print in new line
        System.Console.WriteLine("c.KeyChar: "+c.KeyChar +" key:"+c.Key);


System.Console.WriteLine("Convert.ToInt32- Enter a Number: ");
int num = Convert.ToInt32.Console.ReadLine();
System.Console.WriteLine("Number: "+ num);

        System.Console.WriteLine("Bye");


    }
}