using System;
using System.Collections.Generic;
using System.Text;
using BlogAPIDemo.Domain.Dtos;
using BlogAPIDemo.Domain.Entities;
using BlogAPIDemo.Services.Interfaces;
using AutoMapper;
namespace BlogAPIDemo.Services.Services
{
    public class CategoriService : ICategoriService
    {

        private readonly IRepository<Category> categoryRepository;
        private IMapper mapper;

        public CategoriService(IRepository<Category> categoryRepository, IMapper mapper)
        {
            this.categoryRepository = categoryRepository;
            this.mapper = mapper;
        }

        public bool Create(CategoryDto categoryDto)
        {
            var categori = mapper.Map<Category>(categoryDto);
            if (categori != null)
            {
                categoryRepository.Add(categori);
                return true;
            }
            else {
                return false;
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CategoryDto DindById(int id)
        {
            throw new NotImplementedException();
        }

        public List<CategoryDto> GetList()
        {
            var categorilist = categoryRepository.GetAll();
            var cateDtos = mapper.Map<List<CategoryDto>>(categorilist);
            return cateDtos;
        }

        public bool Update(CategoryDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
