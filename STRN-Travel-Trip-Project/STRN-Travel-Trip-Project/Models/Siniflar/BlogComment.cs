using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace STRN_Travel_Trip_Project.Models.Siniflar
{
    public class BlogComment
    {
        public IEnumerable<Blog> Deger1 { get; set; }  //IEnumerable sayesinde bir wievde bir sürü değer çekebilirim
        public IEnumerable<Blog> Deger3 { get; set; }
        public IEnumerable<Comments> Deger2 { get; set; }
    }
}