﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _5StarsSchoolForum.Models
{
    public class Reply
    {

        public int Id { get; set; }
        public int MessageId { get; set; }
        [Required]
        public string ReplyMessage { get; set; }
        public String ReplyFrom { get; set; }
        [DisplayName("RepliedDateTime")]
        public DateTime PostingTime { get; set; }

        public string UserId { get; set; }
      


        public virtual ApplicationUser User { get; set; }
public virtual Message Message { get; set; }
    }
}