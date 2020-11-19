using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectMain.Models
{
    public class User
    {
        public int id { get; set; }
        public User AccountHolder { get; set; }
    }
}
