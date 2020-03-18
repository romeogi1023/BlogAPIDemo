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

        private readonly IRepository<Category> _categoryRepository;
        private IMapper _mapper;

        public CategoriService(IRepository<Category> categoryRepository, IMapper mapper)
        {
            this._categoryRepository = categoryRepository;
            this._mapper = mapper;
        }

        public bool Create(CategoryDto categoryDto)
        {
            var categori = _mapper.Map<Category>(categoryDto);
            if (categori != null)
            {
                _categoryRepository.Add(categori);
                return true;
            }
            else {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var entity = _categoryRepository.Find(s => s.Id == id);
                _categoryRepository.Delete(entity);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public CategoryDto FindById(int id)
        {
            var categori = _categoryRepository.Find(s => s.Id == id);
            var cateDto = _mapper.Map<CategoryDto>(categori);
            return cateDto;
        }

        public List<CategoryDto> GetList()
        {
            var categorilist = _categoryRepository.GetAll();
            var cateDtos = _mapper.Map<List<CategoryDto>>(categorilist);
            return cateDtos;
        }

        public bool Update(CategoryDto categoryDto)
        {
            try
            {
                var categori = _mapper.Map<Category>(categoryDto);
                _categoryRepository.Update(categori);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
