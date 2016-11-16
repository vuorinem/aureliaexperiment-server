using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using noteapi.Models;

namespace noteapi.Controllers {
    [Route("api/[controller]")]
    public class NotesController : Controller {
        [HttpGet]
        public IEnumerable<NoteDto> Get() {
            return new NoteDto[] {
                new NoteDto { Content = "This is the first note" },
                new NoteDto { Content = "And this is the second note" },
            };
        }

        [HttpGet("{id}")]
        public NoteDto Get(int id) {
            return new NoteDto { Content = "This is a single note" };
        }

        [HttpPost]
        public void Post([FromBody]NoteDto dto) {
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]NoteDto dto) {
        }

        [HttpDelete("{id}")]
        public void Delete(int id) {
        }
    }
}
