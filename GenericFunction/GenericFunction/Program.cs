using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class GenericFunc
{
    public static void Main()
    {
        // Instantiate delegate to reference UppercaseString method
        Func<string, int> convertMethod = UppercaseString;
        string name = "Dakota";
        // Use delegate instance to call UppercaseString method
        Console.WriteLine(convertMethod(name));
        Console.ReadKey();
    }

    private static int UppercaseString(string inputString)
    {
        return 3;
    }
}
