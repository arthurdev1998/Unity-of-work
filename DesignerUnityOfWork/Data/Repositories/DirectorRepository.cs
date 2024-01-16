using DesignerUnityOfWork.Interfaces;
using DesignerUnityOfWork.Models;
using Microsoft.EntityFrameworkCore;

namespace DesignerUnityOfWork.Data.Repositories;

public class DirectorRepository : IDirectorRepository
{
    private readonly AppDbContext _context;

    public DirectorRepository(AppDbContext context)
    {
        _context = context;
    }

    public async Task<Director?> Create(Director entity)
    {
        await _context.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public void Delete(Director entity)
    {
        var director = GetById(entity.Id);
        if (director.Result != default)
        {
            _context.Directors.Remove(director.Result);
        }

        _context.SaveChangesAsync();

    }

    public async Task<IEnumerable<Director>> GetAll()
    {
        return await _context.Directors.ToListAsync();
    }

    public async Task<Director?> GetById(int id)
    {
        return await _context.Directors.SingleOrDefaultAsync(x => x.Id == id);
    }

    public void Update(Director entity)
    {
        _context.Directors.Attach(entity);
        _context.Directors.Entry(entity).State = EntityState.Modified;
    }
}