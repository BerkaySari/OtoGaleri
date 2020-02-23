using System;
using System.Collections.Generic;
using System.Text;

namespace OtoGaleri.Core.Entity
{
    public class Entity<TPrimaryKey> : IEntity<TPrimaryKey>
    {
        public TPrimaryKey Id { get; set; }
        //public virtual DateTime CreatedDate { get; set; }
        //public virtual DateTime? ModifiedDate { get; set; }
    }
}
