﻿using System.Collections.Generic;

namespace TabloidCLI.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // creating a list to contain new tags

        public List<Tag> Tags { get; set; } = new List<Tag>();

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}