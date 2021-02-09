using System;
using static cs_interop.Native;

namespace cs_interop
{
    class Program
    {
        static void Main(string[] args)
        {
            printc("Hello world from c#");
            var Function = takeFunctionPointerAndCallIt(() => {
                System.Console.WriteLine("Hello wolrd C# function Pointer Speaking");
            });

            Function();
        }
    }
}
