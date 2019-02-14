using System;
using System.ComponentModel.DataAnnotations.Schema;
using SwipeChronic.Models.Constants;
namespace SwipeChronic.Models
{
    public class Response
    {

        public int Id { get; set; }
        public int Session { get; set; }
        public Choice Choice { get; set; }
        public int QuestionId { get; set; }

        [ForeignKey("QuestionId")]
        public Question Question { get; set; }
    }
}
