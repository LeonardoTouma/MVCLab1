using System;
using System.Collections.Generic;
using System.Web;

namespace MvcLab1._1.Models
{
    public class Photo
    {
        public Guid Id { get; set; }
        public string Photoname { get; set; }

        public IEnumerable<HttpPostedFileBase> Files { get; set; }
    }
}