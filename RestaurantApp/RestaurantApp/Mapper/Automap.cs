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
                .ForMember(d => d.ImageUrl, source => source.MapFrom(s => s.ImageUrl))
                .ForMember(d => d.Description, source => source.MapFrom(s => s.Description))
                .ForMember(d => d.DishSizes, source => source.MapFrom(s => s.DishSizes));

            CreateMap<Order, OrderDTO>()
                .ForMember(d => d.OrderId, source => source.MapFrom(s => s.OrderId))
                .ForMember(d => d.CustomerId, source => source.MapFrom(s => s.CustomerId))
                .ForMember(d => d.StatusId, source => source.MapFrom(s => s.StatusId))
                .ForMember(d => d.Notes, source => source.MapFrom(s => s.Notes));

            CreateMap<DishSize, PriceItemDTO>()
                .ForMember(d => d.DishId, source => source.MapFrom(s => s.DishId))
                .ForMember(d => d.ProductId, source => source.MapFrom(s => s.ProductId))
                .ForMember(d => d.SizeId, source => source.MapFrom(s => s.SizeId))
                .ForMember(d => d.Price, source => source.MapFrom(s => s.Price))
                .ForMember(d => d.DateFrom, source => source.MapFrom(s => s.DateFrom))
                .ForMember(d => d.DateTo, source => source.MapFrom(s => s.DateTo));
        }
    }
}

/*  public string DishName { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        */
