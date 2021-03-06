﻿using System;
using SwipeChronic.Models;
using System.Threading.Tasks;
using System.Linq;
using SwipeChronic.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace SwipeChronic.Infrastructure
{
    public class QuestionRepository : IQuestionRepository
    {
        private RepositoryContext _context;
        private bool _disposed;


        public QuestionRepository(RepositoryContext context)
        {
            this._context = context;
        }

        public async Task<Question> GetQuestionbyIdAsync(int id)
        {
            return await _context.Questions.FindAsync(id);
        }

        public async Task CreateQuestionAsync(Question question)
        {
            await _context.Questions.AddAsync(question);
        }

        public async Task DeleteQuestionById(int id)
        {
            Question question = await _context.Questions.FindAsync(id);
            _context.Remove(question);
        }

        public async Task<int> GetQuestionsCount()
        {
            return await _context.Questions.CountAsync();
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }


        public void Dispose()
        {
            if (!_disposed)
            {
                _context.Dispose();
            }
            _disposed = true;
            GC.SuppressFinalize(this);
        }
    }
}
