using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ScoreYourPointApi.Domain
{
    public class User
    {
        public long Id { get; set; } // The user unique identifier

        public String Email { get; set; } // The user e-mail credential

        public String Password { get; set; } // The user password crendential

        public bool IsActive { get; set; } // Whether user is active or not in the system

    }
}
