﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _5StarsSchoolForum.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Checked { get; set; }


        public virtual ICollection<ApplicationUser> AttendingMembers { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        //public virtual ICollection<Reply> Replies { get; set; }
    }


}