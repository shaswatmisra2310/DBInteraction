﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace DBInteraction
{
    public class Device
    {
        [Key]
        public int DeviceNo { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        
        public string Description { get; set; }

    }
}
