using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace basicDesignForm.Models
{
    public class ClsStudent
    {
        public int DocEntry { get; set; }
        public string IDCard { get; set; } 
        public  string Name { get; set; }
        public string Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }
        public List<Level> levels { get; set; }

    }
    public  class Level
    {
        public int DocEntry { get; set; }
        public string LevelName { get; set; }
        public double Price { get; set; }
        public string Time { get; set; }
    }
}
