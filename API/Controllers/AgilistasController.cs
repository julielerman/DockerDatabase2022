using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AgilistaTracker;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Agilistas.Controllers {
  [Route ("api/[controller]")]
  [ApiController]
  public class AgilistasController : ControllerBase {
    private readonly AgilistaContext _context;

    public AgilistasController (AgilistaContext context) {
      _context = context;

    }

    // GET: api/Agilistas
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Agilista>>> GetAgilista () {
      //excess is in here for those using the demo because db is so easy to get wrong!
      try
      {
       return await _context.Agilistas.Include (a => a.PrimaryFocus).Include (a => a.SecondaryFocus).ToListAsync ();
      //  return await _context.Agilistas.ToListAsync ();
      }
       catch (Exception ex)
      {
        var conn = _context.Database.GetDbConnection ().ConnectionString;
        throw new Exception (ex + Environment.NewLine + "the failed db connstring is: " + conn);
      }
  
    }

    // GET: api/Agilistas/5
    [HttpGet ("{id}")]
    public async Task<ActionResult<Agilista>> GetAgilista (Guid id) {
      var Agilista = await _context.Agilistas.Include (a => a.PrimaryFocus).Include (a => a.SecondaryFocus).FirstOrDefaultAsync (a => a.Id == id);

      if (Agilista == null) {
        return NotFound ();
      }

      return Agilista;
    }

    // PUT: api/Agilistas/5
    [HttpPut ("{id}")]
    public async Task<IActionResult> PutAgilista (Guid id, Agilista Agilista) {
      if (id != Agilista.Id) {
        return BadRequest ();
      }

      _context.Entry (Agilista).State = EntityState.Modified;

      try {
        await _context.SaveChangesAsync ();
      } catch (DbUpdateConcurrencyException) {
        if (!AgilistaExists (id)) {
          return NotFound ();
        } else {
          throw;
        }
      }

      return NoContent ();
    }

    // POST: api/Agilistas
    [HttpPost]
    public async Task<ActionResult<Agilista>> PostAgilista (Agilista Agilista) {
      _context.Agilistas.Add (Agilista);
      await _context.SaveChangesAsync ();

      return CreatedAtAction ("GetAgilista", new { id = Agilista.Id }, Agilista);
    }

    // DELETE: api/Agilistas/5
    [HttpDelete ("{id}")]
    public async Task<ActionResult<Agilista>> DeleteAgilista (int id) {
      var Agilista = await _context.Agilistas.FindAsync (id);
      if (Agilista == null) {
        return NotFound ();
      }

      _context.Agilistas.Remove (Agilista);
      await _context.SaveChangesAsync ();

      return Agilista;
    }

    private bool AgilistaExists (Guid id) {
      return _context.Agilistas.Any (e => e.Id == id);
    }
  }
}