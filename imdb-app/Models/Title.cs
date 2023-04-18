﻿using IMDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDB.Models
{
    public partial class Title
    {
        public string FormattedTime
        {
            get
            {
                return RuntimeMinutes.ToString() + " minutes";
            }
        }

        public string FormattedYear
        {
            get
            {
                return "Year: " + StartYear.ToString();
            }
        }

        public int FormattedGenre
        {
            get
            {
                var gen = 0;
                foreach (Genre genre in Genres)
                {
                    gen += 1;
                }
                return gen;
            }
        }

    }
}
