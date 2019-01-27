﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDApplication
{
    class cd
    {
        private string artist, title, genre;
        private int releaseDate;

        //constructors - make sure you make these public!
        //default
        public cd()
        {
            artist = genre = title = "";
            releaseDate = 2018;
        }

        //parameter constructor
        public cd(string t, string a, string g, int d)
        {
            title = t;
            artist = a;
            genre = g;
            releaseDate = d;
        }

        //setter and getter properties
        public string Artist
        {
            get
            {
                return artist;
            }
            set
            {
                artist = value;
            }
        }

        public int ReleaseDate
        {
            get
            {
                return releaseDate;
            }

            set
            {
                releaseDate = value;
            }
        }

        public string Genre
        {
            get
            {
                return genre;
            }
            set
            {
                genre = value;
            }
        }
        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        //additional method
        public void resetCD()
        {
            artist = genre = title = "";
            releaseDate = 2018;
        }
    }
}
