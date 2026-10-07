using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyFirstApi.Data;
using MyFirstApi.Models;

namespace MyFirstApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GreetingsController : ControllerBase
{
    private readonly AppDbContext _db;

    public GreetingsController(AppDbContext db)
    {
        _db = db;
    }

    // =============================================
    // GET ALL — Optional Search by name
    // =============================================
    [HttpGet]
    public async Task<IActionResult> GetAll([FromQuery] string? search)
    {
        var items = _db.GreetingItems.AsQueryable();

        if (!string.IsNullOrWhiteSpace(search))
        {
            items = items.Where(x =>
                x.Name.Contains(search, StringComparison.OrdinalIgnoreCase) ||
                x.Message.Contains(search, StringComparison.OrdinalIgnoreCase));
        }

        var result = await items
            .OrderByDescending(x => x.CreatedAt)
            .ToListAsync();

        return Ok(result);
    }

    // =============================================
    // GET ONE — by ID
    // =============================================
    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var item = await _db.GreetingItems.FindAsync(id);
        if (item == null) return NotFound();
        return Ok(item);
    }

    // =============================================
    // POST — Add New
    // =============================================
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] GreetingItemDto request)
    {
        if (string.IsNullOrWhiteSpace(request.Name))
            return BadRequest(new { Error = "Name is required" });

        var newItem = new GreetingItem
        {
            Name = request.Name,
            Age = request.Age,              // ✅ Add
            Address = request.Address,      // ✅ Add
            Message = string.IsNullOrWhiteSpace(request.Message)
                ? $"Hello {request.Name}! Your data is saved in MySQL ✅"
                : request.Message,
            CreatedAt = DateTime.Now
        };

        _db.GreetingItems.Add(newItem);
        await _db.SaveChangesAsync();

        return CreatedAtAction(nameof(GetById), new { id = newItem.Id }, newItem);
    }

    // =============================================
    // PUT — Edit/Update
    // =============================================
    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, [FromBody] GreetingItemDto request)
    {
        var existing = await _db.GreetingItems.FindAsync(id);
        if (existing == null) return NotFound();

        if (string.IsNullOrWhiteSpace(request.Name))
            return BadRequest(new { Error = "Name is required" });

        existing.Name = request.Name;
        existing.Age = request.Age;          // ✅ Add
        existing.Address = request.Address;  // ✅ Add
        existing.Message = request.Message ?? existing.Message;

        await _db.SaveChangesAsync();
        return Ok(existing);
    }

    // =============================================
    // DELETE — Remove
    // =============================================
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var item = await _db.GreetingItems.FindAsync(id);
        if (item == null) return NotFound();

        _db.GreetingItems.Remove(item);
        await _db.SaveChangesAsync();
        return NoContent();
    }
}

// Data shape for Add/Edit
public class GreetingItemDto
{
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; } = 0;        // ✅ Match model
    public string Address { get; set; } = string.Empty; // ✅ Match model
    public string? Message { get; set; }
}