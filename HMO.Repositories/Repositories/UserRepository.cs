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
    public class UserRepository : IDataRepository<User>
    {
        private readonly IContext _context;
        public UserRepository(IContext context)
        {
            _context = context;
        }
        public async Task<User> AddAsync(User entity)
        {
            EntityEntry<User> newOne=_context.Users.Add(entity);
            await _context.SaveChangesAsync();
            return newOne.Entity;
        }

        public async Task DeleteAsync(string id)
        {
           _context.Users.Remove(_context.Users.First(u=>u.UserId== id));
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllAsync()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetByIdAsync(string id)
        {
            return await _context.Users.FindAsync(id);
        }

        public async Task<User> UpdateAsync(User entity)
        {
            var upd=await GetByIdAsync(entity.UserId);
            upd.Firstname = entity.Firstname;
            upd.LastName= entity.LastName;
            upd.DateOfBirth= entity.DateOfBirth;
            upd.Hmo=entity.Hmo;
            upd.Kind=entity.Kind;
            var newEntity=_context.Users.Update(upd);
            await _context.SaveChangesAsync();
            return newEntity.Entity;
        }
    }
}
