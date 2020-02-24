using OtoGaleri.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.JoinTables
{
    public class CarRentalHistory : Entity<Guid>
    {
        public Guid CarId { get; set; }
        public Car Car { get; set; }
        public Guid RentalHistoryId { get; set; }
        public RentalHistory RentalHistory { get; set; }
    }
}
