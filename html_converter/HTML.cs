using System;
using System.Text.RegularExpressions;

namespace html_converter
{
    internal class HTML
    {
        string greeting;
        string html;

        public HTML()
        {
            greeting = "HTML Converter";
            html = "<h1>Grocery List</h1>\n" +
                "<ul>\n" +
                "<li>Eggs</li>\n" +
                "<li>Milk</li>\n" +
                "<li>Butter</li>\n" +
                "</ul>";
        }



        public string getGreeting()
        {
            Console.WriteLine("HTML Converter:\n");
            return greeting;
        }

        public string getInput()
        {
            Console.WriteLine("INPUT:\n" + html);
            return html;
        }

        public string getOutput()
        {

            Regex pattern = new Regex("[<>/hliu1]");
            pattern.Replace(html, " ");

            Console.WriteLine("OUTPUT:\n" + html);
            return html;
        }
    }
}