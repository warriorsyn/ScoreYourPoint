using ScoreYourPointApi.Domain;

namespace ScoreYourPointAPI.Domain
{
    public class UserEventParticipation
    {

        public long Id { get; set; } // The user event participation unique identifier

        public char Team { get; set; } // The event participation character

        public long UserId { get; set; } // The user identifier

        public User User { get; set; } // The user object for referency

        public long EventId { get; set; } // The event identifier

        public Event Event { get; set; } // The event object for referency

    }
}
