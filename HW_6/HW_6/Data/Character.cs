﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HW_6.task1
{
    public class Character
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }
        public int StoryId { get; set; }
        public string StoryName { get; set; }

        public Character()
        {
        }

        public Character(string firstName, string lastName, bool gender, int age, int storyId, string storyName)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Age = age;
            StoryId = storyId;
            StoryName = storyName;
        }

        public override string ToString()
        {
            return $"FirstName: {FirstName}, \tLastName: {LastName},  \tGender: {Gender}," +
                   $" \tAge: {Age},  \tStoryId: {StoryId},  \tStoryName: {StoryName}";
        }
    }
}
