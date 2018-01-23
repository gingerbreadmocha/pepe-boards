using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeBoards.Models
{
    public class Forum
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Subforum> Subforums { get; set; }
    }
}
