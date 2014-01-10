using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HartleyMarksAssignment.Models
{
    public class Item
    {
        private string imagePath = "default.png";
        public int Id { get; set; }
        public string Title { get; set; }
        public string Publisher { get; set; }
        public string Description { get; set; }
        public string Image
        {
            get
            {
                return imagePath;
            }
            set
            {
                imagePath = value;
            }
        }
        public string Genre { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}