﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGear.Database.Entities
{
    public class ProductReview:BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }


        public int UserId { get; set; }
        public User User { get; set; }


        [Range(1, 5)]
        public int Rating { get; set; }

        [MaxLength(1000)]
        public string? ReviewText { get; set; }

    }
}
