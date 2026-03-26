class Program
{
    static void Main(string[] args)
    {

        // 8 bits - range 2^8
        //1byte - 8 butts :)
        System.Console.WriteLine("byte is 0 to 255 - usigned - positive");
        byte a= 100;
        System.Console.WriteLine("byte a: "+ a);
        System.Console.WriteLine("byte min value: "+ byte.MinValue);
        System.Console.WriteLine("byte max value "+ byte.MaxValue );
        System.Console.WriteLine("byte size  "+ sizeof(byte));


        System.Console.WriteLine();
        System.Console.WriteLine();

        System.Console.WriteLine("sbyte is -128 to 127 - signed");   
        sbyte b = -127;
        System.Console.WriteLine("sbyte b: "+ b);
        System.Console.WriteLine("sbyte min value: "+ sbyte.MinValue);
        System.Console.WriteLine("sbyte min value: "+ sbyte.MaxValue);
        System.Console.WriteLine("sbyte size: "+ sizeof(sbyte));


        System.Console.WriteLine();
        System.Console.WriteLine();

        System.Console.WriteLine("char Type");   
        char c = 'b';
        System.Console.WriteLine("char c: "+c);
        System.Console.WriteLine("c min value: "+ char.MinValue);
        System.Console.WriteLine("c min value: "+ char.MaxValue);
        System.Console.WriteLine("c size: "+ sizeof(char));


        System.Console.WriteLine();
        System.Console.WriteLine();

        System.Console.WriteLine("String Type : reference type - immutuable - new object(memory) -- class type");   
        string str = "babby";
        System.Console.WriteLine("string str: "+str);
        System.Console.WriteLine("str length: "+ str.Length);
        
        System.Console.WriteLine("string size: // cannot  sizeof(string)" );
        System.Console.WriteLine("Use str.Length*size(char): "+ str.Length*sizeof(char));


        System.Console.WriteLine();
        System.Console.WriteLine();

        System.Console.WriteLine("Int - int32- 4 bytes or int16- 2 bytes or int64 - 8 ");   
        int num= 10;
        System.Console.WriteLine("int num: "+ num);
        System.Console.WriteLine("int min value: "+ int.MinValue);
        System.Console.WriteLine("int min value: "+ int.MaxValue);
        System.Console.WriteLine("int size: "+ sizeof(int));

        System.Console.WriteLine();
        System.Console.WriteLine();

        System.Console.WriteLine("short- int16 \nint - int32\n long -int64");
        System.Console.WriteLine("ushort- uint16 \nuint - uint32\n ulong -uint64");



        System.Console.WriteLine();
        System.Console.WriteLine();

        System.Console.WriteLine("Precison based - float(Single) f , double , decimal m");
        float xa = 1.78986380830029492956829698978655434342477f; //7 digits Maximum
        double xb = 1.78986380830029492956829698978655434342477; //15 digits Maximum
        decimal xc = 1.78986380830029492956829698978655434342477m; //29 digits 

        Console.WriteLine("7 digits max float: "+xa);
        Console.WriteLine("15 digits max double: "+ xb);
        Console.WriteLine("29 digits max decimal: "+xc);

        System.Console.WriteLine();
        System.Console.WriteLine();

        System.Console.WriteLine("short took 30 MS compared with 73 MS with decimal--speed matters");

        System.Console.WriteLine();
        System.Console.WriteLine();
        System.Console.WriteLine("reference type will be in another branch");


        System.Console.WriteLine();
        System.Console.WriteLine();

        System.Console.WriteLine("BOOL LITERALS");
        bool ba = true; // no 1
        bool bb = false; //no 0

        System.Console.WriteLine(ba);
        System.Console.WriteLine(bb);

        System.Console.WriteLine();

        






        



        System.Console.WriteLine();

    }
}