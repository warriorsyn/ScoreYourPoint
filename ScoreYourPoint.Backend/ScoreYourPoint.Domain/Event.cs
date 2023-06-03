using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreYourPointApi.Domain
{
    public class Event
    {

        public long Id { get; set; }

        public long UserId { get; set; }

        public User User { get; set; }

        public string Name { get; set; }

        public string? Description { get; set; }

        public sbyte ParticipantsAmount { get; set; }

        public bool IsPublic { get; set; }

        public string? Photo { get; set; }

        public DateTime StartDateTime { get; set; }

        public DateTime EndDateTime { get; set; }

        public string Status { get; set; } 

        public sbyte Type { get; set; }

    }
}
