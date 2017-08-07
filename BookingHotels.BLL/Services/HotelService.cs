﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookingHotels.BLL.Interfaces;
using BookingHotels.BLL.DTO;
using BookingHotels.Domain.DALInterfaces;
using AutoMapper;
using BookingHotels.Domain.Entities;

namespace BookingHotels.BLL.Services
{
    public class HotelService : IHotelService
    {
        private IUnitOfWork _unitOfWork { get; set; }
        public HotelService(IUnitOfWork uow)
        {
            _unitOfWork = uow;
        }
        // Gets 1 hotel by it's ID and sends it to view
        public HotelDTO GetHotel(Guid? id)
        {
            Hotel hotel = _unitOfWork.Hotels.Get(id);
            return Mapper.Map<Hotel, HotelDTO>(hotel);
        }
        // Find hotel by room ID TODO
        public HotelDTO GetHotelByRoom(Guid id)
        {

            Hotel hotel = _unitOfWork.Hotels.Get(id);
            return Mapper.Map<Hotel, HotelDTO>(hotel);
        }
        // Get All Hotels
        public IEnumerable<HotelDTO> GetHotels()
        {
            var hotels = _unitOfWork.Hotels.GetAll().ToList();
            return Mapper.Map<List<Hotel>, List<HotelDTO>>(hotels);
        }

        public void Dispose()
        {
            _unitOfWork.Dispose();
        }

        public IEnumerable<HotelDTO> GetHotel()
        {
            throw new NotImplementedException();
        }
    }
}
