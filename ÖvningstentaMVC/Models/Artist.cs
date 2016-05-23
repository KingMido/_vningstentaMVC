using ÖvningstentaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningstentaMVC.Models
{
   public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Band { get; set; }
        public List<Song> Songs { get; set; }

    }
}
