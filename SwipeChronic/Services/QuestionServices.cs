using System;
using System.Threading.Tasks;
using SwipeChronic.Infrastructure.Interfaces;
using SwipeChronic.Models;
using SwipeChronic.Services.Interfaces;

namespace SwipeChronic.Services
{
    public class QuestionServices : IQuestionServices
    {
        private readonly IQuestionRepository _questionRepository;

        public QuestionServices(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public async Task Register(Question question)
        {
            await _questionRepository.InsertQuestion(question);
            await _questionRepository.Save();
        }

        //Dame 10 preguntas
    }
}
