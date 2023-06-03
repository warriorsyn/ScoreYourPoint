using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreYourPointApi.Domain
{
    public class Profile
    {

        public long Id { get; set; } // The profile unique identifier

        public long UserId { get; set; } // The user identifier

        public User User { get; set; } // The user object for referency

        public String Name { get; set; } // The profile name

        public char Gender { get; set; } //  The user profile gender

        public sbyte Age { get; set; } // The user profile age

        public char LeftOrRight { get; set; } // Whether the player uses left or right side to play in the event

        public float Height { get; set; } // The user profile height (cm)

        public float Weight { get; set; } // The user profile weight (kg)

    }
}
