using OtoGaleri.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class User : Entity<Guid>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserType { get; set; }

        public Customer Customer { get; set; }
    }

    public enum UserType
    {
        Admin,
        Customer
    }
}
