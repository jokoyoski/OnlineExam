using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Model
{
    public class Setting : ISetting
    {
        public int Id { get; set; }
        public string Key { get; set; }
        public string Value { get; set;}
    }
}