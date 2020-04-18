﻿using System.Collections.Generic;

namespace TurnipTrackerApi.Database.Entities
{
    public class BoardUser
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public long BoardId { get; set; }

        public Board Board { get; set; }

        public long RegisteredUserId { get; set; }

        public RegisteredUser RegisteredUser { get; set; }

        public ICollection<Week> Weeks { get; set; }

        public bool Deleted { get; set; }
    }
}