using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DailyBlogger2.Models
{
    public class BlogPost
    {
        [Key]
        public int id { get; set; }
        public string blogTitle { get; set; }
        public string content { get; set; }
        public DateTime blogDate { get; set; }
    }
}
