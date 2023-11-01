using D_D_Class_Selector.Models;
using Microsoft.AspNetCore.Mvc;

namespace D_D_Class_Selector.Controllers
{
    public class QuestionController : Controller
    {
        private List<QuestionModel> GetQuestions()
        {
            var questions = new List<QuestionModel>
            {
                new QuestionModel
                { 
                    Text = "I want to use magic to solve all of my problems."
                
                },
                new QuestionModel
                {
                    Text = "I want to rely on my own cunning and prowess."
                
                },
                new QuestionModel
                {
                    Text = "I prefer to support my allies rather than rely on myself."
                
                },
                new QuestionModel
                {
                    Text = "I want to be in the thick of the fight."
                
                },
                new QuestionModel
                {
                    Text = "I want to focus on out of combat utility."
                
                },
                new QuestionModel
                {
                    Text = "I believe if you are strong enough, problems go away."
                
                },
                new QuestionModel
                {
                    Text = "My allies are precious; I will protect them."
                
                },
                new QuestionModel
                {
                    Text = "Mastering one's self is the key to mastering the world"
                
                },
                new QuestionModel
                {
                    Text = "A little luck is all I need."
                
                },
                new QuestionModel
                {
                    Text = "The world was meant to be explored"
                
                }
            };
            return questions;

        }
        public IActionResult Index()
        {
            var questions = GetQuestions();
            return View(questions);
        }
    }
}
