﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6.task1
{
    public class Story
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }


        public Story(int storyId, string storyName, string description)
        {
            Id = storyId;
            Name = storyName;
            Description = description;
        }

        public override string ToString()
        {
            return $"StoryId: {Id}, \tStoryName: {Name},  \tDescription: {Description}";
        }
    }
}
