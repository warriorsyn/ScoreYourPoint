using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreYourPointApi.Domain
{
    public class ProfileRating
    {

        public long Id { get; set; } // The profile rating unique identifier

        public long UserId { get; set; } // The user identifier

        public User User { get; set; } // The user object for referency

        public long ProfileId { get; set; } // The profile identifier

        public Profile Profile { get; set; } // The profile object for referency

        public float Rate { get; set; } // The profile rating float number (between 0.0 and 5.0)

        public String Description { get; set; } // The profile rating description

    }
}
