﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace TurnipTrackerApi.Database.Entities
{
    public class RegisteredUser
    {
        public long Id { get; set; }

        public string Email { get; set; }

        [JsonIgnore]
        public byte[] PasswordHash { get; set; }

        [JsonIgnore]
        public byte[] PasswordSalt { get; set; }

        public ICollection<BoardUser> BoardUsers { get; set; }

        public ICollection<Board> OwnedBoards { get; set; }
    }
}