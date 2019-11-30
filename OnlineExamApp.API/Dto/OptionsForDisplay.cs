using OnlineExamApp.API.Interfaces;

namespace OnlineExamApp.API.Dto
{
    public class OptionsForDisplay : IOptionsForDisplay
    {
        public int OptionId { get; set; }
        public string OptionName { get; set; }
        public string OptionLabel { get; set; }
        public bool IsAvailable { get; set; }
        public bool Checked { get; set; }
    }
}