using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OnlineExamApp.API.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineExamApp.API.Repository
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly DataContext _dbContext;
        public QuestionRepository(DataContext dbContext)
        {
            this._dbContext = dbContext;
        }
        public async Task<IEnumerable<IQuestion>> GetQuestionsByCaregoryId(int categoryId)
        {
            try{
                var result = await (from d in _dbContext.Questions 
                            where d.CategoryId.Equals(categoryId)
                          select new  Model.Question{
                              QuestionId = d.QuestionId,
                              Questions = d.Questions,
                              DateCreated = d.DateCreated,
                              CategoryId = d.CategoryId,
                              //DateModified = d.DateModified
                          }).OrderByDescending(p=>p.QuestionId).ToListAsync();

                return result;
            }catch(Exception e){
                throw new ApplicationException("QuestionRepository from GetQuestionsByCaregoryId", e);
            }
        }
        public async Task<string> SaveQuestion(IFormFile formFile)
        {
            /* try
            {
                //using (var stream = new MemoryStream())
                //{
                //    await formFile.CopyToAsync(stream);

                //    using (var package = new ExcelPackage(stream))
                //    {
                //        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                //        var rowCount = worksheet.Dimension.Rows;

                //        for (int row = 2; row <= rowCount; row++)
                //        {
                //            Question questions = new Question();
                //            questions.Questions = worksheet.Cells[row, 1].Value.ToString().Trim();
                //          questions.CategoryId = 5;
                //            questions.OptionA = worksheet.Cells[row, 3].Value.ToString().Trim();
                //            questions.OptionB = worksheet.Cells[row, 4].Value.ToString().Trim();
                //            if (worksheet.Cells[row, 5].Value.ToString().Trim() == null)
                //            {
                //                questions.OptionC = "0";
                //            }
                //            else
                //            {
                //                questions.OptionC = worksheet.Cells[row, 5].Value.ToString().Trim();

                //            }

                //            if (worksheet.Cells[row, 6].Value.ToString().Trim() == null)
                //            {
                //                questions.OptionD = "0";
                //            }
                //            else
                //            {
                //                questions.OptionD = worksheet.Cells[row, 6].Value.ToString().Trim();

                //            }

                //            if (worksheet.Cells[row, 7].Value.ToString().Trim() == null)
                //            {
                //                questions.OptionE = "0";
                //            }
                //            else
                //            {
                //                questions.OptionE = worksheet.Cells[row, 7].Value.ToString().Trim();

                //            }
                //            questions.DateCreated = DateTime.Now;
                //            questions.DateModified = DateTime.Now;
                //            questions.SelectedAnswer = worksheet.Cells[row, 8].Value.ToString().Trim();

                //            var getQuestions = await this.dbContext.Questions.FirstOrDefaultAsync(x => x.Questions == questions.Questions);

                //            if(getQuestions==null)
                //            {
                //               this.dbContext.Add(questions);
                //               this.dbContext.SaveChanges();
                //            }

                //        }




                //    }


                //}
                this.dbContext.Database.OpenConnection();
                var value = new Question()
                {
                    CategoryId = 6,
                    DateCreated = DateTime.Now,
                    DateModified=DateTime.Now,
                    OptionA="lagos",
                    OptionB="fjfjfjfjf",
                    OptionC="dfhfhfhfhj",
                    OptionD="fffjfjfj",
                    OptionE="gjgjgjgj",
                    SelectedAnswer="B"
                };
                this.dbContext.Add(value);
                this.dbContext.SaveChanges();
                this.dbContext.Database.CloseConnection();
            }
            catch (DbEntityValidationException e)
            {
                List<String> lstErrors = new List<string>();
                foreach (var eve in e.EntityValidationErrors)
                {
                    string msg = string.Format(
                        "Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name,
                        eve.Entry.State);

                    lstErrors.Add(msg);

                    foreach (var ve in eve.ValidationErrors)
                    {
                        msg = string.Format("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                        lstErrors.Add(msg);
                    }
                }

                if (lstErrors != null && lstErrors.Count() > 0)
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var item in lstErrors)
                    {
                        sb.Append(item + "; ");
                    }

                    throw new Exception("Repository.Save. Db Entity Validation Exception. Data not saved. Error: " +
                                        sb.ToString());
                }
            }

            catch (NotSupportedException e)
            {
            }
           // return result;

         */
            return "File Saved Successfully";
        }
    }
}
