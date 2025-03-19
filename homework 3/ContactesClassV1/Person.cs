using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactesClassV1
{
    public class Person
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string LastName { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public int Age { get; set; }


        public bool isBestFriend { get; set; }

        public string IsBestFriendStr => isBestFriend ? "No" : "Yes";




    }
}
