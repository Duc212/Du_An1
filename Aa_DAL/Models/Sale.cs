﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aa_DAL.Models
{
    public  class Sale
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; } 
        public double Percent {  get; set; }    
        public DateTime StartDate { get; set; } 
        public DateTime EndDate { get; set; }
        public int Status { get; set; } 
        public virtual List<SanPham> SanPhams { get; set; } 
    }
}
