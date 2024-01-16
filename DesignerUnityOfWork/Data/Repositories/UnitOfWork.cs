using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignerUnityOfWork.Interfaces.Repositories;

namespace DesignerUnityOfWork.Data.Repositories;

public class UnitOfWork : IUnityOfWork
{
    private readonly AppDbContext _context;
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public Task Commit()
    {
        throw new NotImplementedException();
    }

    public void Dispose()
    {
        throw new NotImplementedException();
    }
}