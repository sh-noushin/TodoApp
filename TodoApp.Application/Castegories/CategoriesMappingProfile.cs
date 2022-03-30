using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoApp.Application.Contract.Categories.Dtos.Responses;
using TodoApp.Domain.Categories;

namespace TodoApp.Application.Castegories
{
    public class CategoriesMappingProfile: Profile
    {
        public CategoriesMappingProfile()
        {
            CreateMap<Category, CategoryResponse>();
        }
    }
}

