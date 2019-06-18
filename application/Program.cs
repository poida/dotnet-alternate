using System;
using thingy;

namespace application
{
    class Program
    {
        private IThingy _thingy;

        public Program(IThingy thingy)
        {
            _thingy = thingy;
        }

        public void DoSomethingUseful() {
            Console.WriteLine("Hello Thingy! Please get me some stuff.");
            var stuff = _thingy.GetStuff();
            Console.WriteLine($"Thingy got: {stuff}");
        }
        
        static void Main(string[] args)
        {
            var program = Program.Create();
            program.DoSomethingUseful();
        }

        private static Program Create() {
            IThingy thingy = null;

            #if USE_ALTERNATES
              thingy = new thingy.alternate.AlternateThingy();
            #else
              thingy = new thingy.http.HttpThingy();
            #endif

            return new Program(thingy);
        }
    }
}
