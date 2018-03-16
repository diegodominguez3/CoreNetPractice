using System;
using System.Text.RegularExpressions;
using System.Text; 


namespace Unit_Testing
{
    public class Program
    {

        public Int64 Hash_function(string s)
        {
            Int64 h;
            string letters;
            int i;
            int index;
            long inc;

            h = 7;
            letters = "acdegilmnoprstuw";

                for (i = 0; i < s.Length; i++)
                {
                    inc = h * 37;
                    index = letters.IndexOf(s[i]);
                    h = inc + index;
                }
          

            return h; 
        }

        public string slugify(string s)
        {
            s = s.ToLowerInvariant();
            s = Regex.Replace(s, @"\s", "-", RegexOptions.Compiled);
            s = Regex.Replace(s, @"[^a-z0-9\s-_]", "", RegexOptions.Compiled);
            s= s.Trim('-', '_');
            s = Regex.Replace(s, @"([-_]){2,}", "$1", RegexOptions.Compiled);

            return s; 
        }
           







        static void Main(string[] args)
        {
            Program p = new Program(); 
            Console.WriteLine(p.slugify("Hola como estas amigo jajajaja"));
            Console.ReadLine(); 
        }
    }
}
