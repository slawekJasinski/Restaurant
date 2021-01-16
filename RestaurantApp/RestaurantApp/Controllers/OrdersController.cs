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
    public class OrderController : ControllerBase
    {
        private IMapper _mapper;

        private readonly IOrderRepository _orderRepository;

        public OrderController(IMapper mapper, IOrderRepository orderRepository)
        {
            _mapper = mapper;
            _orderRepository = orderRepository;
        }

        // GET: api/Dishes
        [HttpGet]
        public ActionResult<List<OrderDTO>> GetOrders()
        {
            List<Order> orders = _orderRepository.GetOrders();
            return _mapper.Map<List<OrderDTO>>(orders);
        }

        // GET: api/Dishes/5
        [HttpGet("{id}")]
        public ActionResult<OrderDTO> GetOrder(int id)
        {
            Order order = _orderRepository.GetById(id);
            if (order is null)
            {
                return NotFound();
            }
            return _mapper.Map<OrderDTO>(order);
        }

        // PUT: api/Dishes/5
        [HttpPut("{id}")]
        public IActionResult PutDish(int id, OrderDTO orderDTO)
        {
            if (id != orderDTO.OrderId)
            {
                return BadRequest();
            }

            Order order = _mapper.Map<Order>(orderDTO);
            _orderRepository.Update(order);

            try
            {
                _orderRepository.Save();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
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
        public ActionResult<DishDTO> PostDish(OrderDTO orderDTO)
        {
            _orderRepository.Insert(_mapper.Map<Order>(orderDTO));
            _orderRepository.Save();
            return CreatedAtAction("GetDish", new { id = orderDTO.OrderId }, orderDTO);
        }

        // DELETE: api/Dishes/5
        [HttpDelete("{id}")]
        public IActionResult DeleteDish(int id)
        {
            if (!OrderExists(id))
            {
                return NotFound();
            }
            _orderRepository.Delete(id);
            _orderRepository.Save();
            return NoContent();
        }

        private bool OrderExists(int id)
        {
            return (_orderRepository.GetById(id) != null);
        }
    }
}
