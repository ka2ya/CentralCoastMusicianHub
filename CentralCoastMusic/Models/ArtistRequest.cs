﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CentralCoastMusic.Models
{
    public class ArtistRequest
    {
        public Dictionary<string,string> Auth { get; set; }
        public Artist Artist { get; set; }
    }
}
