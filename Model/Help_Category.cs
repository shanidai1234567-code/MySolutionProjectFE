﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Help_Category:BaseEntity
    {
        private string description;

        public string Description { get => description; set => description = value; }

        public override string ToString()
        {
            return $"Group Activity: {description}";
        }
    }
}
