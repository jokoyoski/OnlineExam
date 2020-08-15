namespace OnlineExamApp.API.Interfaces
{
    public interface ISetting
    {
        int Id { get; set; }
        string Key { get; set; }
        string Value { get; set;}
    }
}