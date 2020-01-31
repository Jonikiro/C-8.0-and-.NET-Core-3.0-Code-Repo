using System;

namespace Final
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new String('-', 84));
            Console.WriteLine(String.Format("{0,-8}{1,-3}{2,18}{3,32}",
                "Type", "Byte(s) of Memory", "Min", "Max"));
            Console.WriteLine(new String('-', 84));
            
            Console.WriteLine(String.Format("{0,-8}{1,-3}{2,32}{3,32}",
                "sbyte",sizeof(sbyte),sbyte.MinValue,sbyte.MaxValue));
            Console.WriteLine(String.Format("{0,-8}{1,-3}{2,32}{3,32}",
                "byte",sizeof(byte),byte.MinValue,byte.MaxValue));
            Console.WriteLine(String.Format("{0,-8}{1,-3}{2,32}{3,32}",
                "short",sizeof(short),short.MinValue,short.MaxValue));
            Console.WriteLine(String.Format("{0,-8}{1,-3}{2,32}{3,32}",
                "ushort",sizeof(ushort),ushort.MinValue,ushort.MaxValue));
            Console.WriteLine(String.Format("{0,-8}{1,-3}{2,32}{3,32}",
                "int",sizeof(int),int.MinValue,int.MaxValue));
            Console.WriteLine(String.Format("{0,-8}{1,-3}{2,32}{3,32}",
                "uint",sizeof(uint),uint.MinValue,uint.MaxValue));
            Console.WriteLine(String.Format("{0,-8}{1,-3}{2,32}{3,32}",
                "long",sizeof(long),long.MinValue,long.MaxValue));
            Console.WriteLine(String.Format("{0,-8}{1,-3}{2,32}{3,32}",
                "ulong",sizeof(ulong),ulong.MinValue,ulong.MaxValue));
            Console.WriteLine(String.Format("{0,-8}{1,-3}{2,32}{3,32}",
                "float",sizeof(float),float.MinValue,float.MaxValue));
            Console.WriteLine(String.Format("{0,-8}{1,-3}{2,32}{3,32}",
                "double",sizeof(double),double.MinValue,double.MaxValue));
            Console.WriteLine(String.Format("{0,-8}{1,-3}{2,32}{3,32}",
                "decimal",sizeof(decimal),decimal.MinValue,decimal.MaxValue));
        }
    }
}
