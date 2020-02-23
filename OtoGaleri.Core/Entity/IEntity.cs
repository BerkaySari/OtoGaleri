using System;
using System.Collections.Generic;
using System.Text;

namespace OtoGaleri.Core.Entity
{
    public interface IEntity<TPrimaryKey>
    {
        TPrimaryKey Id { get; set; }
    }
}
