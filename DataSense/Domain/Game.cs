using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataSense.Domain
{
    internal class Game: Entity<int>
    {
        public int IdG { get; set; }
        public string Name { get; set; }
    
        public int Rating { get; set; }

        public string Status { get; set; }

        public Game(int IdG, string Name, string Status, int Rating)
        {
            this.IdG = IdG;
            this.Name = Name;
            this.Status = Status;
            this.Rating = Rating;
        }
    }
}
