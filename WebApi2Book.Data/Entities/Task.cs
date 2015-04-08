﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi2Book.Data.Entities
{
    public class Task
    {

        public long TaskId { get; set; }
        public string Subject { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? CompletedDate { get; set; }
        public virtual Status Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public virtual User CreatedBy { get; set; }
        public virtual IList<User> Users
        {
            get { return _users; }
        }

        public byte[] Version { get; set; }
        private readonly IList<User> _users = new List<User>();
    }
}
