﻿using System;
using SQLite;
namespace FeedbackApp
{
    public class Feedback
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
    }
}
