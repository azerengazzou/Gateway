using JwtAuthenticationManager.Data;
using JwtAuthenticationManager.Models;
using JwtAuthenticationManager.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthenticationManager.Repository
{
    public class AccountRepository : Repository<UserAccount>, IAccountRepository
    {
        private readonly ApplicationDbContext _db;

        public AccountRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
    }
}