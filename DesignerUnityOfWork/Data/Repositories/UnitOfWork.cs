using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesignerUnityOfWork.Interfaces.Repositories;

namespace DesignerUnityOfWork.Data.Repositories;

public class UnitOfWork : IUnityOfWork
{
    private readonly AppDbContext _context;
    public MovieRepository MovieRepository { get; private set; }
    public UnitOfWork(AppDbContext context)
    {
        _context = context;
        this.MovieRepository = new MovieRepository(_context);
    }



    public async Task Commit()
    {
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}