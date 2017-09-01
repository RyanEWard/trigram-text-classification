﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TextClassification.Models
{
    public class Document
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }
        public string Content { get; set; }

        public virtual Class Class { get; set; }
    }
}