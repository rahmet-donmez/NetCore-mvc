﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Offer
    {
        [Key]
        public int OfferId { get; set; }
        public int OfferPrice { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

       // [ForeignKey("User")]
        //public int UserId { get; set; }

        public User User { get; set; }

    }
}
