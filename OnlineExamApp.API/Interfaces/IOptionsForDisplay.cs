namespace OnlineExamApp.API.Interfaces
{
    public interface IOptionsForDisplay
    {
        int OptionId { get; set; }
        string OptionName { get; set; }
        string OptionLabel { get; set; }
        bool IsAvailable { get; set; }
        bool Checked { get; set; }
    }
}