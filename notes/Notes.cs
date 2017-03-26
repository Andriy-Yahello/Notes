using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    internal static class FindAndReplaceManager
    {
        public static void FindNext(string str)
        {
            Finder finder = new Finder();
            Console.WriteLine(finder.FindNext(str));
        }
    }

    internal class Finder
    {
        public class Notes
        {
            private string scratch = "";
            public string Scratch
            {
                get { return scratch; }
                set {
                    if (value != null)
                     scratch += value + "\n"; // \n new line
                }
                
            }
            
            
            public void Note(string str)
            {
                Console.WriteLine("A note '{0}' is saved.", str);
            }
        }
        
        public string FindNext(string strang)
        {
            return "Searching for: " + strang;

        }
    }
    
    

}
