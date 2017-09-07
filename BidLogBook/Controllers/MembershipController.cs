using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using BidLogBook.Models;
using BidLogBook.Repositories;
using AutoMapper;



namespace BidLogBook.Controllers
{
    public class MembershipController : Controller
    {
        public string _userId;
        public string _userName;
        private readonly IMapper _mapper;

        public MembershipController(IHttpContextAccessor httpContextAccessor,
            UserManager<ApplicationUser> userManager, IMapper _mapper, IReadRepository db)
        {
            var user = httpContextAccessor.HttpContext.User;
            _userId = userManager.GetUserId(user);
            _userName = userManager.GetUserName(user);
            _db = db;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ListView()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ItemView(int id)
        {
            return View();
        }

    }
}