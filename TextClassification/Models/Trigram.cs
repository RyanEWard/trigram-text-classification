﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TextClassification.Models
{
    public class Trigram
    {
        [Key]
        public int Id { get; set; }

        [StringLength(3)]
        public string Sequence { get; set; }
    }
}