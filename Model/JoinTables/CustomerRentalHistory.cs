using OtoGaleri.Core.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.JoinTables
{
    public class CustomerRentalHistory : Entity<Guid>
    {
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }
        public Guid RentalHistoryId { get; set; }
        public RentalHistory RentalHistory { get; set; }
    }
}
