using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestaurantApp.Database;
using RestaurantApp.DTO;
using RestaurantApp.Model;
using RestaurantApp.Repository;

namespace RestaurantApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PriceItemController : ControllerBase
    {
        private IMapper _mapper;

        private readonly IPriceItemRepository _priceItemRepository;

        public PriceItemController(IMapper mapper, IPriceItemRepository priceItemRepository)
        {
            _mapper = mapper;
            _priceItemRepository = priceItemRepository;
        }

        [HttpGet]
        public ActionResult<List<PriceItemDTO>> GetPriceItems()
        {
            List<DishSize> priceItems = _priceItemRepository.GetPriceItems();
            return _mapper.Map<List<PriceItemDTO>>(priceItems);
        }

        [HttpGet("{id}")]
        public ActionResult<List<DishDTO>> GetDish(int id)
        {
            List<DishSize> priceItems = _priceItemRepository.GetById(id);
            if (priceItems is null)
            {
                return NotFound();
            }
            return _mapper.Map<List<DishDTO>>(priceItems).Select(e => new DishDTO
            {
                DishId = e.DishId,
                DishTypeId = e.DishTypeId,
                DishName = e.DishName,
                ImageUrl = e.ImageUrl,
                Description = e.Description,
                DishSizes = e.DishSizes.Select(d => new DishSize
                {
                    DishId = d.DishId,
                    Price = d.Price,
                    DateFrom = d.DateFrom,
                    DateTo = d.DateTo,
                    ProductId = d.ProductId,
                    SizeId = d.SizeId
                }).ToList()
            }).ToList();
        }

        // PUT: api/Dishes/5
        [HttpPut("{id}")]
        public IActionResult PutPriceItem(int id, PriceItemDTO priceItemDTO)
        {
            if (id != priceItemDTO.ProductId)
            {
                return BadRequest();
            }

            DishSize priceItem = _mapper.Map<DishSize>(priceItemDTO);
            _priceItemRepository.Update(priceItem);


            try
            {
                _priceItemRepository.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PriceItemExists(id))
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

        // POST: api/Dishes
        [HttpPost]
        public ActionResult<DishDTO> PostDish(PriceItemDTO priceItemDTO)
        {
            _priceItemRepository.Insert(_mapper.Map<DishSize>(priceItemDTO));
            _priceItemRepository.Save();
            return CreatedAtAction("GetDish", new { id = priceItemDTO.ProductId }, priceItemDTO);
        }

        // DELETE: api/Dishes/5
        [HttpDelete("{id}")]
        public IActionResult DeletePriceItem(int id)
        {
            if (!PriceItemExists(id))
            {
                return NotFound();
            }
            _priceItemRepository.Delete(id);
            _priceItemRepository.Save();
            return NoContent();
        }

        private bool PriceItemExists(int id)
        {
            return (_priceItemRepository.GetById(id) != null);
        }
    }

}
