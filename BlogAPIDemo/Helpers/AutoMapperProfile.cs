using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using AutoMapper;
using BlogAPIDemo.Domain.Dtos;
using BlogAPIDemo.Domain.Entities;


namespace BlogAPIDemo.Helpers
{
    public class AutoMapperProfile:Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Post, PostDto>()
                .ForMember(d => d.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
                .ForMember(d => d.Category, opt => opt.MapFrom(src => src.Category))
                .ForMember(d => d.Tag, opt => opt.MapFrom(src => src.Tag))
                .ForMember(d => d.CommentsList, opt => opt.MapFrom(src => src.Comments));

            CreateMap<PostDto, Post>()
                .ForMember(d => d.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(d => d.Title, opt => opt.MapFrom(src => src.Title))
                .ForMember(d => d.Content, opt => opt.MapFrom(src => src.Content))
                .ForMember(d => d.CreateDate, opt => opt.MapFrom(src => src.CreateDate))
                .ForMember(d => d.CategoryId, opt => opt.MapFrom(src => src.CategoryId))
                .ForMember(d => d.Category, opt => opt.MapFrom(src => src.Category))
                .ForMember(d => d.PostGuid, opt => opt.MapFrom(src => src.postguid));

            CreateMap<Comments, CommentsDto>()
                .ForMember(d => d.Id, opt => opt.MapFrom(src => src.Id))
                .ForMember(d => d.CreateDate, opt => opt.MapFrom(src => src.CreateDate))
                .ForMember(d => d.CommentContent, opt => opt.MapFrom(src => src.CommentContent));

            CreateMap<PostTag, PostTagDto>()
                .ForMember(d => d.Name, opt => opt.MapFrom(src => src.Name));

            CreateMap<Category, CategoryDto>()
                .ForMember(d => d.Name, opt => opt.MapFrom(src => src.CategoryName));

            CreateMap<CategoryDto, Category>()
                .ForMember(d => d.CategoryName, opt => opt.MapFrom(src => src.Name));


        }
    }
}
