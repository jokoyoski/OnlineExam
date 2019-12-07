using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using OnlineExamApp.API.Interfaces;
using OnlineExamApp.API.Model;
using OnlineExamApp.API.Repository;

namespace OnlineExamApp.API.Dto
{
    public class Seed
    {
        private readonly DataContext dataContext;

        public Seed(IQuestionRepository questionRepository, DataContext dataContext)
        {
            this.dataContext = dataContext;

        }

     /* */   public void SeedQuestions()
        {

            if (dataContext.Questions.Find(1) == null)
            {
                var questionJSONs = System.IO.File.ReadAllText("Dto/QuestionsJSON.json");

                var questionJSONCollection = JsonConvert.DeserializeObject<List<Question>>(questionJSONs);

                foreach (var question in questionJSONCollection)
                {
                    question.DateCreated = DateTime.UtcNow;
                    dataContext.Questions.Add(question);
                    dataContext.SaveChanges();

                        var optionsJSONs = System.IO.File.ReadAllText("Dto/OptionsJSON.json");

                        var optionsJSONCollection = JsonConvert.DeserializeObject<List<Option>>(questionJSONs);

                        foreach (var option in optionsJSONCollection)
                        {
                            option.DateCreated = DateTime.UtcNow;
                            option.QuestionId = question.QuestionId;

                            dataContext.Options.Add(option);
                            dataContext.SaveChanges();
                        }
                    
                }
            }
        }
    }
}