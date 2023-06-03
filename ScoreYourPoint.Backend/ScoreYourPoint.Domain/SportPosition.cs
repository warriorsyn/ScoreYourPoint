namespace ScoreYourPointAPI.Domain
{
    public class SportPosition
    {

        public long Id { get; set; } // The sport positions unique identifier

        public long SportId { get; set; } // The sport identifier

        public Sport Sport { get; set; } // The sport object for referency

        public long PositionId { get; set; } // The position identifier

        public Position Position { get; set; } // The position object for referency

    }
}
