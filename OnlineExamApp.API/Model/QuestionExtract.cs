using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineExamApp.API.Model
{

    #region 
    public class QuestionObject
    {
        public string Question { get; set; }
        public int No { get; set; }
        public List<OptionObject> Options { get; set; }
        public Guid PictureId { get; set; }
        public bool isQuestionValid 
        { 
            get 
            {

                if(!string.IsNullOrEmpty(Question) && Options != null && Options.Any() && Options.Count() == 4)
                {
                    return true;
                }
                return false;
            }
        }
    }
    public class OptionObject
    {
        public char Num { get; set; }
        public string Option { get; set; }
        public bool isCorrect { get; set; }
    }
    #endregion
}