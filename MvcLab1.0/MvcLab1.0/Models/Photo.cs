using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLab1._0.Models
{
    public class Photo
    {
        public Guid Id{ get; set; }
        public string Photoname { get; set; }
        public string Path { get; set; }
        public string AlternateText { get; set; }
    }
}