﻿using Ex1.Data;
using Ex1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex1.Services
{
    public class SellerService
    {
        private readonly Ex1Context _context;

        public SellerService(Ex1Context context)
        {
            _context = context;
        }

        public List<Seller> FindAll()
        {
            return _context.Seller.ToList();
        }
    }
}
