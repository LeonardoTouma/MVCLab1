using System;
using System.Collections.Generic;
using System.Web;

namespace MvcLab1._1.Models
{
    public class Photo
    {
        public Guid Id { get; set; }
        public string Photoname { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public DateTime DatePosted { get; set; }

        public IEnumerable<HttpPostedFileBase> Files { get; set; }
        public IEnumerable<Photo> photos { get; set; }
    }
}