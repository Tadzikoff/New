using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectMain.Models
{
    public class Account
    {
        public int Id { get; set; }

        public User User { get; set; }
    }
}
