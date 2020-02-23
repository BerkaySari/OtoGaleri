using OtoGaleri.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class RentalHistory : Entity<Guid>
    {
        public RentalHistory()
        {
            this.Car = new HashSet<Car>();
            this.Customer = new HashSet<Customer>();
        }

        public DateTime? RentalDate { get; set; }
        public virtual ICollection<Car> Car { get; set; }
        public virtual ICollection<Customer> Customer { get; set; }
    }
}
