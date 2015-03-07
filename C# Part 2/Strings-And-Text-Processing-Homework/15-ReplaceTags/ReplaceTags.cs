﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_ReplaceTags
{
    class ReplaceTags
    {
        /*Write a program that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].
Example:

         input	
         <p>Please visit <a href="http://academy.telerik. com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>
          
          output:
          <p>Please visit [URL=http://academy.telerik. com]our site[/URL] to choose a training course. Also visit [URL=www.devbg.org]our forum[/URL] to discuss the courses.</p>
        */
        static void Main(string[] args)
        {
            string html = @"<p>Please visit <a href=""http://academy.telerik. com"">our site</a> to choose a training course. Also visit <a href=""www.devbg.org"">our forum</a> to discuss the courses.</p>";

           string replaced = html.Replace("<a href=\"", "[URL=")
               .Replace("</a>", "[/URL]")
               .Replace("\">", "]");
      
            Console.WriteLine(replaced);

        }
    }
}
