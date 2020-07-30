using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SF_Client.DiscordRPC.APIDatas
{
    public class Main
    {
        public string id { get; set; }
        public int type { get; set; }
        public string name { get; set; }

    }

    public class Root
    {
        public List<Main> Main { get; set; }

    }
}
