using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Bookly.Dtos;
using Bookly.Models;

namespace Bookly.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // DOMAIN TO DTO
            Mapper.CreateMap<Customer, CustomerDto>();
            // Mapper.CreateMap<CustomerDto, Customer>();

            Mapper.CreateMap<Book, BookDto>();
            Mapper.CreateMap<MembershipType, MembershipTypeDto>();
            Mapper.CreateMap<Genre, GenreDto>();

            // DTO TO DOMAIN
            Mapper.CreateMap<CustomerDto, Customer>()
                .ForMember(c => c.Id, opt => opt.Ignore());

            Mapper.CreateMap<BookDto, Book>()
                .ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}