using FoodDonationManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoodDonationManagementSystem.Repositry
{
   public  interface Imanagement
    {
        List<Management> Get();
        Management Post(Management management);
    }
}
