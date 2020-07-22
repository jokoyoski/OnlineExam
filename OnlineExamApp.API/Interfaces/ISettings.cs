namespace OnlineExamApp.API.Interfaces
{
    public interface ISettings
    {
        int Id { get; set; }
        string Key { get; set; }
        string Value { get; set;}
    }
}