using OtoGaleri.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.JoinTables
{
    public class CarRentalHistory : Entity<Guid>
    {
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int RentalHistoryId { get; set; }
        public RentalHistory RentalHistory { get; set; }
    }
}
