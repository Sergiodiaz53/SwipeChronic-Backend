using System;
using SwipeChronic.Models;
using System.Threading.Tasks;
using System.Linq;

namespace SwipeChronic.Infrastructure
{
    public class QuestionRepository
    {
        private RepositoryContext context;

        public QuestionRepository(RepositoryContext context)
        {
            this.context = context;
        }

        public async Task<Question> GetQuestionbyIdAsync(int id)
        {
            return await context.Questions.FindAsync(id);
        }

        public async Task CreateQuestionAsync(Question question)
        {
            await context.Questions.AddAsync(question);
        }

        public async Task DeleteQuestionById(int id)
        {
            Question question = await context.Questions.FindAsync(id);
            context.Remove(question);
        }

        public async Task<Question> GetRandomQuestion()
        {
            Random rand = new Random();
            int id = rand.Next(0, context.Questions.Count());
            return await context.Questions.FindAsync(id);
        }
    }
}
