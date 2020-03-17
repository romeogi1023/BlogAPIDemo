using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using BlogAPIDemo.Domain.Dtos;
using BlogAPIDemo.Domain.Entities;
using BlogAPIDemo.Services.Interfaces;

namespace BlogAPIDemo.Services.Services
{
    public class CommentsService : ICommentService
    {
        private readonly IRepository<Comments> _commentsRepository;
        private IMapper _mapper;

        public CommentsService(IRepository<Comments> commentsRepository, IMapper mapper)
        {
            _commentsRepository = commentsRepository;
            _mapper = mapper;
        }
 
        public bool Create(CommentsDto commentDto)
        {
            var post = _mapper.Map<Comments>(commentDto);
            if (post != null)
            {
                _commentsRepository.Add(post);
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
                var entity = _commentsRepository.Find(s => s.Id == id);
                _commentsRepository.Delete(entity);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public CommentsDto FindById(int id)
        {
            var post = _commentsRepository.Find(s => s.Id == id);
            var postDto = _mapper.Map<CommentsDto>(post);
            return postDto;
        }

        public List<CommentsDto> GetList()
        {
            throw new NotImplementedException();
        }

        public bool Update(CommentsDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
