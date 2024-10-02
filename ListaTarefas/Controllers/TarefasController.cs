using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ListaTarefas.Data;
using ListaTarefas.Models;

namespace ListaTarefas.Controllers;

[Route("api/tarefas")]
[ApiController]
public class TarefasController : ControllerBase
{
    private readonly AppDbContext _context;

    public TarefasController(AppDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Tarefas>>> GetTarefas()
    {
        return await _context.Tarefas.ToListAsync();
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<Tarefas>> GetTarefas(int id)
    {
        var tarefas = await _context.Tarefas.FindAsync(id);

        if (tarefas == null)
        {
            return NotFound();
        }

        return tarefas;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutTarefas(int id, Tarefas tarefas)
    {
        if (id != tarefas.Id)
        {
            return BadRequest();
        }

        _context.Entry(tarefas).State = EntityState.Modified;

        try
        {
            await _context.SaveChangesAsync();
        }
        catch (DbUpdateConcurrencyException)
        {
            if (!TarefasExists(id))
            {
                return NotFound();
            }
            else
            {
                throw;
            }
        }

        return Ok(tarefas);
    }

    [HttpPost]
    public async Task<ActionResult<Tarefas>> PostTarefas(Tarefas tarefas)
    {
        _context.Tarefas.Add(tarefas);
        await _context.SaveChangesAsync();

        return CreatedAtAction("GetTarefas", new { id = tarefas.Id }, tarefas);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteTarefas(int id)
    {
        var tarefas = await _context.Tarefas.FindAsync(id);
        if (tarefas == null)
        {
            return NotFound();
        }

        _context.Tarefas.Remove(tarefas);
        await _context.SaveChangesAsync();

        return Ok(tarefas);
    }

    private bool TarefasExists(int id)
    {
        return _context.Tarefas.Any(e => e.Id == id);
    }
}
