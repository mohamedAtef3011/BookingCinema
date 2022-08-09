﻿using BookingCinema.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BookingCinema.Controllers
{
    public class MoviesController : Controller
    {

        private readonly AppDbContext _context;

        public MoviesController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var movies = await _context.Movies.Include(m=>m.Cinema).ToListAsync();

            return View(movies);
        }
    }
}
