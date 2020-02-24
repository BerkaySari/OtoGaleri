using Model.JoinTables;
using OtoGaleri.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class Car : Entity<Guid>
    {
        public Car()
        {
            //this.RentalHistory = new HashSet<RentalHistory>();
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Color { get; set; }
        public byte[] Photo { get; set; }
        public DateTime? ArrivalDate { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual ICollection<CarRentalHistory> CarRentalHistory { get; set; }
    }
}
