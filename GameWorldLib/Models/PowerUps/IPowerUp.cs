﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameWorldLib.Models.PowerUps
{
    public interface IPowerUp
    {
        string Name { get; set; }
        int Power { get; set; }
    }
}
