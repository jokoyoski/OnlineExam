using System;

namespace OnlineExamApp.API.Dto
{
    public class UserForDetailedDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }
        public DateTime Created { get; set; }
        public string City { get; set; }
    }
}