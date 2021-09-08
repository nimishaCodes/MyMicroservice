﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MyMicroservice.Models
{
    public class TodoItem
    {
        public long Id { get; set; }
        [Required]
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
