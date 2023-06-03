using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreYourPointApi.Domain
{
    public class Profile
    {

        public long Id { get; set; }

        public long UserId { get; set; }

        public User User { get; set; }

        public string Name { get; set; }

        public char Gender { get; set; }

        public sbyte Age { get; set; }

        public char LeftOrRight { get; set; }

        public float Height { get; set; }

        public float Weight { get; set; }

    }
}
