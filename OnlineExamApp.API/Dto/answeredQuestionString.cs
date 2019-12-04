using System.IO;

namespace OnlineExamApp.API.Dto
{
    public static class answeredQuestionString
    {
        public static string anweredQuestion = File.ReadAllText("Dto/answeredQuestion.json");

    }
}