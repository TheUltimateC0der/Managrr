using System;

namespace Managrr.Data.Models
{
    public class SonarrInstance
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Host { get; set; }

        public int Port { get; set; }

        public string ApiKey { get; set; }


        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }
    }
}
