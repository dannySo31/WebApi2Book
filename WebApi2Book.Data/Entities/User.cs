using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WebApi2Book.Data.Entities
{
    public class User:IVersionedEntity
    {
        public long UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public byte[] Version { get; set; }
    }
}
