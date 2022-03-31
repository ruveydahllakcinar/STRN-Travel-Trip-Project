﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace STRN_Travel_Trip_Project.Models.Siniflar
{
    public class Comments
    {
        [Key]
        public int Id { get; set; }
        public string KullaniciAdi { get; set; }
        public string Mail { get; set; }
        public string Yorum { get; set; }
        public int BlogId { get; set; }
        public virtual Blog Blog { get; set; }
    }
}