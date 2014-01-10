using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HartleyMarksAssignment.Models
{
    public class Category
    {
        public List<Item> Items { get; set; }
        public string Title { get; set; }
    }
}