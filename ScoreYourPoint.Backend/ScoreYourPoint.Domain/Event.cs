using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreYourPointApi.Domain
{
    public class Event
    {

        public long Id { get; set; } // The event unique identifier

        public long UserId { get; set; } // The user identifier

        public User User { get; set; } // The user object for referency

        public String Name { get; set; } // Event name

        public String? Description { get; set; } // Event description

        public sbyte ParticipantsAmount { get; set; } // Amount of players participating in the event

        public bool IsPublic { get; set; } // If public, all user profiles can see the displayed event in the application
                                           // Else, only participating users can view

        public String? Photo { get; set; } // The event photo image

        public DateTime StartDateTime { get; set; } // The starting date of the event

        public DateTime EndDateTime { get; set; } // The end date of the event

        // TODO: Check this field later

        public String Status { get; set; } // Event status

        public sbyte Type { get; set; } // Event type

    }
}
