using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BlogAPIDemo.Domain.Dtos;
using BlogAPIDemo.Domain.Entities;
using BlogAPIDemo.Services.Interfaces;

namespace BlogAPIDemo.Services.Services
{
    public class PostService : IPostService
    {
        private readonly IRepository<Post> _postRepository;
        private IMapper _mapper;

        public PostService(IRepository<Post> postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        public bool Create(PostDto postDto)
        {
            var post = _mapper.Map<Post>(postDto);
            if (post != null)
            {
                _postRepository.Add(post);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                var entity = _postRepository.Find(s => s.Id == id);
                _postRepository.Delete(entity);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public PostDto FindById(int id)
        {
            var post = _postRepository.Find(s => s.Id == id);
            var postDto = _mapper.Map<PostDto>(post);
            return postDto;
        }

        public List<PostDto> GetList()
        {
            var postList = _postRepository.GetAll();
            var postDtos = _mapper.Map<List<PostDto>>(postList);
            return postDtos;
        }

        public bool Update(PostDto postDto)
        {
            try
            {
                var post = _mapper.Map<Post>(postDto);
                _postRepository.Update(post);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
