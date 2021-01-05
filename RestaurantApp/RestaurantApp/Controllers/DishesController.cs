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
    public class DishesController : ControllerBase
    {
        private IMapper _mapper;

        private readonly IDishItemRepository _dishItemRepository;

        public DishesController(IMapper mapper, IDishItemRepository dishItemRepository)
        {
            _mapper = mapper;
            _dishItemRepository = dishItemRepository;
        }

        // GET: api/Dishes
        [HttpGet]
        public ActionResult<List<DishDTO>> GetDishes()
        {
            List<Dish> dishes = _dishItemRepository.GetDishes();
            return _mapper.Map<List<DishDTO>>(dishes);
        }

        // GET: api/Dishes/5
        [HttpGet("{id}")]
        public ActionResult<List<DishDTO>> GetDish(int id)
        {
            List<Dish> dishes = _dishItemRepository.GetById(id);
            if(dishes is null)
            {
                return NotFound();
            }
            return _mapper.Map<List<DishDTO>>(dishes);
        }

        // PUT: api/Dishes/5
        [HttpPut("{id}")]
        public IActionResult PutDish(int id, DishDTO dishDTO)
        {
            if (id != dishDTO.DishId)
            {
                return BadRequest();
            }

            Dish dish = _mapper.Map<Dish>(dishDTO);
            _dishItemRepository.Update(dish);

            try
            {
                _dishItemRepository.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DishExists(id))
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
        public ActionResult<DishDTO> PostDish(DishDTO dishDTO)
        {
            _dishItemRepository.Insert(_mapper.Map<Dish>(dishDTO));
            _dishItemRepository.Save(); 
            return CreatedAtAction("GetDish", new { id = dishDTO.DishId }, dishDTO);
        }

        // DELETE: api/Dishes/5
        [HttpDelete("{id}")]
        public IActionResult DeleteDish(int id)
        {
            if (!DishExists(id))
            {
                return NotFound();
            }
            _dishItemRepository.Delete(id);
            _dishItemRepository.Save();
            return NoContent();
        }

        private bool DishExists(int id)
        {
            return (_dishItemRepository.GetById(id) != null);
        }
    }
}