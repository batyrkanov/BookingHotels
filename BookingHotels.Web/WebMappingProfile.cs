﻿using AutoMapper;
using BookingHotels.BLL.DTO;
using BookingHotels.Domain.Entities;
using BookingHotels.Web.Models;

namespace BookingHotels.Web
{

    public class WebMappingProfile : Profile
    {
        public WebMappingProfile()
        {
            CreateMap<RoomDTO, RoomViewModel>(MemberList.None)
            .ForMember(o => o.RoomType, b => b.MapFrom(z => z.RoomType));
          

            CreateMap<RoomDTO, Room>(MemberList.None);
            CreateMap<RoomViewModel, RoomDTO>();

            CreateMap<HotelDTO, HotelViewModel>(MemberList.None);
            CreateMap<HotelViewModel, HotelDTO>();

            CreateMap<FeedbackDTO, FeedbackViewModel>(MemberList.None);
            CreateMap<FeedbackViewModel, FeedbackDTO>(MemberList.None);

            CreateMap<BookingDTO, BookingViewModel>(MemberList.None);
            CreateMap<BookingViewModel, BookingDTO>(MemberList.None);


        }
    }

}