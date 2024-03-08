using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel
{
    internal class Resenva
    {
        public string Name { get; private set; } 
        public string Email { get; private set; }
        public int Room { get; private set; }

        public Resenva(string name, string email, int room)
        {
            Name = name;
            Email = email;
            Room = room;
        }
    }
}
