using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Book.Models
{
    public class BookStore
    {
        [Key]
        public int Bid {  get; set; }

        public string Btitle { get; set; }

        public string Bauthor { get; set; }

        public string Bprice { get; set; }

    }
}