using DSTEd.Publisher.Actions;
using System;

namespace DSTEd.Publisher {
    public static class Program {
        public static int Main(string[] args) {
            try {
                var parser      = new ArgumentParser();
               
                parser.AddHandler(new Update());
                parser.AddHandler(new Upload());
                parser.AddHandler(new Download());
                parser.AddHandler(new Status());
                parser.AddHandler(new List());
                parser.AddHandler(new Software());

                return parser.Parse(args);
            } catch(Exception e) {
                System.Diagnostics.Debug.WriteLine(e.ToString());
                System.Diagnostics.Debugger.Break();
            }

            return 0;
        }
    }
}
