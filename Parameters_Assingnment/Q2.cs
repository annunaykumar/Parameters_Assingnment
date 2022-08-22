using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Parameters_Assingnment
{
    internal class Q2
    {

        public static void Main()
        {
            string sentence = "DotNet is technology and DotNet is interoperable and DotNet is simple";
            string[] words = sentence.Split(new char[] { ' ', ',', '.', '!', ':', '?', ';' }, StringSplitOptions.RemoveEmptyEntries); // this splits the string into the words
            var groups = words.GroupBy(x => x); // this groups the words
            foreach (var group in groups)
            {
                Console.WriteLine("{0} - {1}", group.Key, group.Count());
                Console.ReadKey();
            }
        }
    }
}