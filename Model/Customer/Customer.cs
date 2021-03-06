﻿using Model.JoinTables;
using OtoGaleri.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Customer : Entity<Guid>
    {
        //public Customer()
        //{
        //    this.RentalHistory = new HashSet<RentalHistory>();
        //}

        public string Name { get; set; }
        public string LastName { get; set; }
        public long IdentityNumber { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public byte[] Photo { get; set; }

        public Guid? UserId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<CustomerRentalHistory> CustomerRentalHistory { get; set; }
        public virtual ICollection<Car> Car { get; set; }
    }
}
