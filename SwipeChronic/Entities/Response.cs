using System;
using SwipeChronic.Models.Constants;
namespace SwipeChronic.Models
{
    public class Response
    {

        public int Session;
        public Choice Choice { get; set; }

        //ForeignKey 
        public int QuestionId { get; set; }
        public Question Question { get; set; }

        //TODO [ForeignKey]
    }
}
