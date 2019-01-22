using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerimeterAndArea
{
    class Program
    {
        static void Main(string[] args)
        {
            String lengthMessage = "What's your field's length ?";
            Console.WriteLine(lengthMessage);
            int length = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Your length = " + length);
            Console.WriteLine();
            String widthMessage = "What's your field's width ?";
            Console.WriteLine(widthMessage);
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Your width = " + width);
            Console.WriteLine();
            String endMessage = "We assume your field has four sides so :\n" +
                "Your field's area is: " + Convert.ToString(width * length) + "\n" +
                "Your field's perimeter is: " + Convert.ToString(2 * (width + length));
            Console.WriteLine(endMessage);
            Console.ReadKey();
        }
    }
}
