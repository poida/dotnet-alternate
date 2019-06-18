using System;

namespace thingy.http
{
    public class HttpThingy : IThingy
    {
        public String GetStuff() {
            return "http stuff";
        }
    }
}
