using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

public class LambdaExpression
{
    public static void Main()
    {
        Func<string, string> convert = s => s.ToUpper();

        string name = "Dakota";
        Console.WriteLine(convert(name));
        Console.ReadKey();
    }
}
