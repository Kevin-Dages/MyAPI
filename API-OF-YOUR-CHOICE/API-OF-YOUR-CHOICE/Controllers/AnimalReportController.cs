using API_OF_YOUR_CHOICE.Models.Fall2022_Class_of_your_choice;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API_OF_YOUR_CHOICE.Controllers
{
    [Route("api/[controller]")] // These two are auto put into the the controller through VB
    [ApiController] // These two are auto put into the the controller through VB
    public class AnimalReportController : ControllerBase // this is also auto put inside
    {
        private AnimalReportContext _Context; // this is naming AnimalReportContext to _Context... Why am I renaming this??

        public AnimalReportController(AnimalReportContext context)   // again why am i renaming animalreportContext when its been named above?
        {
            _Context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<AnimalReport>>> GetAnimalReport() // what does task do,actionResult, IEnumerable
        {
            return await _Context.AnimalReports.ToListAsync(); //await????
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AnimalReport>> GetAnimalReports(int id)
        {
            if (_Context.AnimalReports == null)
            {
                return NotFound();
            }
            var videoGame = await _Context.AnimalReports.FindAsync(id);

            if (videoGame == null)
            {
                return NotFound();
            }

            return videoGame;
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> PutAnimalReport(int id, AnimalReport animalReport)
        {
            if (id != animalReport.Id)
            {
                return BadRequest();
            }

            _Context.Entry(animalReport).State = EntityState.Modified;

            try
            {
                await _Context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!animalReportExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<AnimalReport>> Post(AnimalReport animalReport)
        {
            if (_Context.AnimalReports == null)
            {
                return Problem("Entity set 'AnimalReportContext.animalReport'  is null.");
            }
            _Context.AnimalReports.Add(animalReport);
            await _Context.SaveChangesAsync();

            return CreatedAtAction("GetAnimalReport", new { id = animalReport.Id }, animalReport);
        }

        // DELETE: api/VideoGames/5 - "Delete" a record from the database
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVideoGame(int id)
        {
            if (_Context.AnimalReports == null)
            {
                return NotFound();
            }
            var animalReport = await _Context.AnimalReports.FindAsync(id);
            if (animalReport == null)
            {
                return NotFound();
            }

            _Context.AnimalReports.Remove(animalReport);
            await _Context.SaveChangesAsync();

            return NoContent();
        }

        private bool animalReportExists(int id)
        {
            return (_Context.AnimalReports?.Any(e => e.Id == id)).GetValueOrDefault();
        }

    }
}
