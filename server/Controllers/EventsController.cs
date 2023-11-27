<<<<<<< HEAD
﻿using AutoMapper;
using Microsoft.AspNetCore.Authorization;
=======
﻿using System.Security.Claims;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
>>>>>>> 95e8f6d94275e0d193004a8a0340148a48ca3370
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Configuration;
using server.Data;
using server.DTOs;
using server.Entities;

namespace server.Controllers;

[ApiController]
[Route("server/[controller]")]
public class EventsController : BaseApiController
{
    private readonly StoreContext _context;
    private readonly IMapper _mapper;
<<<<<<< HEAD

    public EventsController(StoreContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
=======
    private readonly UserManager<User> _userManager;

    public EventsController(StoreContext context, IMapper mapper, UserManager<User> userManager)
    {
        _context = context;
        _mapper = mapper;
        _userManager = userManager;
>>>>>>> 95e8f6d94275e0d193004a8a0340148a48ca3370
    }

    [HttpGet]
    public async Task<ActionResult<List<Event>>> GetEvents()
    {
        return await _context.Events.ToListAsync();
    }

    [HttpGet("{id}", Name = "GetEvent")]
    public async Task<ActionResult<Event>> GetEvent(int id)
    {
        return await _context.Events.FindAsync(id);
    }


    [Authorize]
    [HttpPost]
    public async Task<ActionResult<Event>> CreateEvent(CreateEventDto eventDto)
    {
<<<<<<< HEAD
        var e = _mapper.Map <Event>(eventDto);
=======
        var userId = await _userManager.FindByNameAsync(User.Identity.Name);
        var e = _mapper.Map <Event>(eventDto);
        e.UserId = userId.Id;
>>>>>>> 95e8f6d94275e0d193004a8a0340148a48ca3370
        _context.Events.Add(e);

        var result = await _context.SaveChangesAsync() > 0;

        if (result) return CreatedAtRoute("GetEvent", new { Id = e.Id }, e);

        return BadRequest(new ProblemDetails { Title = "Problem creating new event" });
    }
}