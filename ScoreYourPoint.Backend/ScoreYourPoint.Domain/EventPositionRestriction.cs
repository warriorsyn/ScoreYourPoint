using ScoreYourPointApi.Domain;

namespace ScoreYourPointAPI.Domain
{
    public class EventPositionRestriction
    {

        public long Id { get; set; } // The event position restriction unique identifier

        public sbyte PositionLimitAmount { get; set; } // The position amount limit

        public char Team { get; set; } // The event participation character

        public long SportPositionId { get; set; } // The sport position identifier

        public SportPosition SportPosition { get; set; } // The sport position object for referency

        public long EventId { get; set; } // The event identifier

        public Event Event { get; set; } // The event object for referency

    }
}
