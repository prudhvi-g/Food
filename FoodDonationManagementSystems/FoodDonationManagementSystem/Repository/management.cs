using FoodDonationManagementSystem.Data;
using FoodDonationManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonationManagementSystem.Repositry
{
    public class management:Imanagement

    {
          private readonly ManagementDbContext _context;
            public management(ManagementDbContext context)
            {
                _context = context;
            }
            public List<Management> Get()
            {
                var list = _context.management.ToList();
                return list;
            }

            public Management Post(Management model)
            {
                _context.management.AddAsync(model);
                _context.SaveChangesAsync();
                return model;
            }

        

        }
}
