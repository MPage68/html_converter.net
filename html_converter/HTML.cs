using System;

namespace html_converter
{
    internal class HTML
    {     
       string greeting = "HTML Converter";
       string html = "<h1>Grocery List</h1>\n" +
                     "<ul>\n" +
                     "<li>Eggs</li>\n" +
                     "<li>Milk</li>\n" +
                     "<li>Butter</li>\n" +
                     "</ul>\n";

        public HTML()
        {
        }

        public string getGreeting()
        {
            Console.WriteLine("HTML Converter:\n");            
            return greeting;
        }

        public string getInput()
        {
            Console.WriteLine("Original INPUT:\n" + html);          
            return html;
        }

        public String getOutput()
        {
            html = html.Replace("<li>", " * ")
                       .Replace("</li>", "")
                       .Replace("<h1>", " ")
                       .Replace("</h1>", "")
                       .Replace("<ul>", "")
                       .Replace("</ul>", "")
                       .Replace("    ", "");
           
            Console.WriteLine("Parsed OUTPUT:\n" + html);         
            return html;
        }
    }
}