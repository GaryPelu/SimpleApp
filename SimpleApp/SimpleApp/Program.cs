using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleApp
{
    class Program
    {
        static int Main(string[] args)
        {
            App app = new App();

            return app.Run(args);
        }
    }

    public class App
    {
        public int Run(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                return 1;
            }

            string foo = Reverse(args[0]);
            Console.WriteLine(foo);
            return 0;
        }

        // yeah, I know there's a reverse method but for the sake of demonstrating Unit Testing...
        public string Reverse(string s)
        {
            char[] r = new char[s.Length];

            int j = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                r[j++] = s[i];
            }

            return new string(r);
        }
    }
}
