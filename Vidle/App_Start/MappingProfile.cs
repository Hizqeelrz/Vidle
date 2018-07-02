using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using Vidle.Dtos;
using Vidle.Models;

namespace Vidle.App_Start
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap Take 2 parameters <T.source, T.Destination/target>

            Mapper.CreateMap<Customer, CustomerDto>();
            Mapper.CreateMap<CustomerDto, Customer>();
        }

        // When we call this CreateMap method AutoMapper uses reflection to
        // scan these types it find its properties and maps them based on their name
        // thats why AutoMapper also Called Convention based mapping tool
        // because it use properties names as convention to map OBJECT
    }
}