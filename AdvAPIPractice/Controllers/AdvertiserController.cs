using AdvAPIPractice.Data;
using AdvAPIPractice.DTOs;
using AdvAPIPractice.Models;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AdvAPIPractice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertiserController : ControllerBase
    {
        private readonly IAdvertiserRepo _advertiserRepo;
        private readonly IAdvertisementRepo _advertisementRepo;
        private readonly IMapper _mapper;

        public AdvertiserController(IAdvertiserRepo advertiserRepo, IAdvertisementRepo advertisementRepo, IMapper mapper)
        {
            _advertiserRepo = advertiserRepo;
            _advertisementRepo = advertisementRepo;
            _mapper = mapper;
        }

        [HttpGet("{id}", Name = "GetAdvertiserById")]
        public ActionResult<AdvertiserReadDTO> GetAdvertiserById(int id)
        {

            var commandItem = _advertiserRepo.GetAdvertiserById(id);

            if (commandItem == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<AdvertiserReadDTO>(commandItem));
        }

        [HttpGet("GetAdvertisementByKeyWords")]
        public ActionResult<AdvertisementReadDTO> GetAdvertisementByKeyWords(int id, string size, [FromQuery] string[] keywords)
        {
            var items = _advertisementRepo.GetAdvertisementByKeyWords(id, size, keywords);

            if (items == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<AdvertisementReadDTO>(items));
        }

        [HttpGet]
        public ActionResult<AdvertiserReadDTO> GetAllAdvertiser()
        {
            var commandItem = _advertiserRepo.GetAllAdvertiser();

            if (commandItem == null)
            {
                return NotFound();
            }

            return Ok(_mapper.Map<IEnumerable<AdvertiserReadDTO>>(commandItem));
        }
    }
}
