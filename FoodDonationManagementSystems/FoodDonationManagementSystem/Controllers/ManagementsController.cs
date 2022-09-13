using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FoodDonationManagementSystem.Data;
using FoodDonationManagementSystem.Models;
using FoodDonationManagementSystem.Repositry;

namespace FoodDonationManagementSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagementsController : ControllerBase
    {
        private readonly ManagementDbContext _managementRepo;

        public ManagementsController(ManagementDbContext imanagement)
        {
            _managementRepo = imanagement;
        }


        [HttpGet("Get")]
        public IActionResult Get()
        {
            try
            {
                var result = _managementRepo.GetType();
                return StatusCode(200, result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost("Post")]
        public IActionResult Post([FromBody] Management management)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var result = _managementRepo.Post(management);
                    return StatusCode(200, result);
                }
                else
                {
                    return BadRequest();
                }
            }
            catch (Exception)
            {
                return BadRequest();
            }
        }

    }
}
