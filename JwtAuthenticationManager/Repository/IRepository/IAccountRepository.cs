﻿using JwtAuthenticationManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JwtAuthenticationManager.Repository.IRepository
{
    public interface IAccountRepository:IRepository<UserAccount>
    {
    }
}
