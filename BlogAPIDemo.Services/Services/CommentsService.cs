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
            var comment = _mapper.Map<Comments>(commentDto);
            if (comment != null)
            {
                _commentsRepository.Add(comment);
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
            var comments = _commentsRepository.Find(s => s.Id == id);
            var commentsDto= _mapper.Map<CommentsDto>(comments);
            return commentsDto;
        }

        public List<CommentsDto> GetList()
        {
            var commentList = _commentsRepository.GetAll();
            var commentDtos = _mapper.Map<List<CommentsDto>>(commentList);
            return commentDtos;
        }

        public bool Update(CommentsDto commentDto)
        {
            try
            {
                var comment = _mapper.Map<Comments>(commentDto);
                _commentsRepository.Update(comment);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
          
           
        }
    }
}
