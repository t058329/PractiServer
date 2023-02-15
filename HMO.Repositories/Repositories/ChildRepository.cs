using HMO.Repositories.Entities;
using HMO.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMO.Repositories.Repositories
{
    internal class ChildRepository : IDataRepository<Child>
    {
        private readonly IContext _context;
        public ChildRepository(IContext context)
        {
            _context = context;
        }
        public async Task<Child> AddAsync(Child entity)
        {
            EntityEntry<Child> newOne=_context.Children.Add(entity);
            await _context.SaveChangesAsync();
            return newOne.Entity;
        }

        public Task DeleteAsync(string id)
        {
            _context.Children.Remove(_context.Children.FirstOrDefault(c => c.ChildId == id));
            return _context.SaveChangesAsync();
        }

        public async Task<List<Child>> GetAllAsync()
        {
            return await _context.Children.ToListAsync();
        }

        public async Task<Child> GetByIdAsync(string id)
        {
            return await _context.Children.FindAsync(id);
        }

        public async Task<Child> UpdateAsync(Child entity)
        {
            var upd = await GetByIdAsync(entity.ChildId);
            upd.ParentId = entity.ParentId;
            upd.FirstName = entity.FirstName;
            upd.DateOfBirth = entity.DateOfBirth;
            var newEntity = _context.Children.Update(upd);
            return newEntity.Entity;
        }
    }
}
