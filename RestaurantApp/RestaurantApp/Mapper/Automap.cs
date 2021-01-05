using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using RestaurantApp.DTO;
using RestaurantApp.Model;

namespace RestaurantApp.Mapper
{
    public class Automap : Profile
    {
        public Automap()
        {
            CreateMap<Dish, DishDTO>()
                .ForMember(d => d.DishId, source => source.MapFrom(s => s.DishId))
                .ForMember(d => d.DishTypeId, source => source.MapFrom(s => s.TypeId))
                .ForMember(d => d.DishName, source => source.MapFrom(s => s.DishName))
                .ForMember(d => d.ImageUrl, source => source.MapFrom(s=> s.ImageUrl))
                .ForMember(d => d.Description, source => source.MapFrom(s => s.Description));
            CreateMap<Order, OrderDTO>();
            CreateMap<DishSize, PriceItemDTO>
        }
    }
}

/*  public string DishName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        */
