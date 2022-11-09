using Microsoft.AspNetCore.Mvc;
using PairProgramming.Managers;

namespace PairProgramming.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MusicRecordsController: ControllerBase
    {
        private readonly MusicRecordsManager musicRecordsManager = new MusicRecordsManager();
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpGet]

        public ActionResult<MusicRecords> GetAll()
        {
            List<MusicRecords> musicRecords = musicRecordsManager.GetAll();

            if (musicRecords == null) return NotFound();

            else return Ok(musicRecords);
            
        }

        [HttpGet("id")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<MusicRecords> GetById(int id)
        {
            MusicRecords musicRecords = musicRecordsManager.GetById(id);

            if (id == null) return NotFound("" + id);

            return Ok(musicRecords);
        }
        [HttpGet("title")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<MusicRecords> GetTitle(string title)
        {
            MusicRecords musicRecords = musicRecordsManager.GetByTitle(title);
            if (musicRecords == null) return NotFound("" + title);
            return Ok(musicRecords);

        }
        [HttpGet("publicationYear")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<MusicRecords> GetPublicationYear(int publicationYear)
        {
            MusicRecords musicRecords = musicRecordsManager.GetByPublicationYear(publicationYear);
            if (musicRecords == null) return NotFound("" + publicationYear);

            return Ok(musicRecords);
        }
        [HttpGet("artist")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<MusicRecords> GetArtist(string artist)
        {
            MusicRecords musicRecords = musicRecordsManager.GetByArtist(artist);
            if (musicRecords == null) return NotFound("" + artist);

            return Ok(musicRecords);

        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public ActionResult<MusicRecords> Post([FromBody] MusicRecords musicRecords)
        {
            musicRecordsManager.Add(musicRecords);
            if (musicRecords == null) return NotFound("");
            return Ok(musicRecords);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public ActionResult<MusicRecords> Put(int id, [FromBody] MusicRecords value)
        {
            musicRecordsManager.Update(id, value);

            return Ok(id);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<MusicRecords> Delete(int id)
        {
            musicRecordsManager.Delete(id);
            if (id == null) return NotFound("you've deleted nothing");

            return Ok(id);
        }


    }

}