using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_converter
{
    class Program
    {
        static void Main(string[] args)
        {
            HTML html = new HTML();

            html.getGreeting();
            html.getInput();
            html.getOutput();
            Console.ReadLine();

        }
    }
}
