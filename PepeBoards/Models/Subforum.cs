using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PepeBoards.Models
{
    public class Subforum
    {
        public int ID { get; set; }
        public int ForumID { get; set; }
        public string Name { get; set; }    

        public Forum Forum { get; set; }
    }
}
