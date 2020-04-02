using System;
using System.Collections.Generic;
using System.Text;

namespace OtoGaleri.Core.UoW
{
    public interface IUnitOfWork
    {
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
