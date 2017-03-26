using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            FindAndReplaceManager.FindNext("Superman");
            string a = Console.ReadLine();

            Finder.Notes note = new Finder.Notes();
            note.Note(a);//method

            note.Scratch = "Nice feature";//Property
            note.Scratch = "";//Property + ""
            note.Scratch = "it works";//Property + "it works"
            Console.WriteLine(note.Scratch);

            Console.ReadKey();
        }
    }
}
