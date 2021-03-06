﻿using System;
using System.ComponentModel.DataAnnotations;

namespace BeerCellier.Models
{
    public class CreateBeerViewModel
    {
        [Required()]
        [MaxLength(80)]
        public string Name { get; set; }

        [Required()]
        [Range(0, Int32.MaxValue)]
        public int Quantity { get; set; }
    }
}