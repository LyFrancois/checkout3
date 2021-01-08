using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Checkpoint_3.Models
{
    public class Edition
    {
        public int ID { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string autor { get; set; }
        public DateTime DateTime { get; set; }
    }
}
