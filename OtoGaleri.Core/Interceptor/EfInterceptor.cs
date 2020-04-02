using System;
using Castle.DynamicProxy;
using Microsoft.EntityFrameworkCore;
using OtoGaleri.Core.UoW;

namespace OtoGaleri.Core.Interceptor
{
    public class EfInterceptor : IInterceptor
    {
        private readonly DbContext _dbContext;
        public EfInterceptor(DbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void Intercept(IInvocation invocation)
        {
            UnitOfWork.Current = new UnitOfWork(_dbContext);
            UnitOfWork.Current.BeginTransaction();

            try
            {
                invocation.Proceed();
                UnitOfWork.Current.Commit();
            }
            catch (Exception ex)
            {
                UnitOfWork.Current.Rollback();
            }
        }
    }
}
