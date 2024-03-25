//using AutoMapper;
//using BasketApp.Domain.Entities;
//using BasketApp.Domain.Interfaces;
//using BasketApp.Application.DTOs;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BasketApp.Application.Services
//{
//    public class CommentService : ICommentService
//    {
//        private readonly ICommentRepository _commentRepository;
//        private readonly IMapper _mapper;

//        public CommentService(ICommentRepository commentRepository, IMapper mapper)
//        {
//            _commentRepository = commentRepository;
//            _mapper = mapper;
//        }

//        public async Task AddCommentAsync(CommentDto commentDto)
//        {

//            var comment = _mapper.Map<Comment>(commentDto);
//            await _commentRepository.AddCommentAsync(comment);
//        }

//        public async Task<IEnumerable<Comment>> GetCommentsByGameIdAsync(int gameId)
//        {
//            return await _commentRepository.GetCommentsByGameIdAsync(gameId);
//        }
//    }
//}
