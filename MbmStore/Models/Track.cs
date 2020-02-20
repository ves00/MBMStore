﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Track
    {
        //auto-implemnted properties
        public string Title { get; set; }   
        public string Composer { get; set; }
        public TimeSpan Length { get; set; }


        // constructors
        public Track()
        {

        }

        public Track(string title, string composer, TimeSpan length) 
        {
            this.Title = title;
            this.Composer = composer;
            this.Length = length;
        }
    }
}
