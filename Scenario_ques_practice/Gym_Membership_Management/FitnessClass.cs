using System;
using System.Collections.Generic;

namespace Gym_Management
{
    public class FitnessClass
    {
        public string ClassName { get; set; }
        public string Instructor { get; set; }
        public DateTime Schedule { get; set; }
        public int MaxParticipants { get; set; }
        public List<int> RegisteredMembers { get; set; } = new List<int>();
    }
}
