using System;

namespace SofiaUniversity.Data
{
    public class Professor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Faculty Faculty { get; set; }
        public string Subject { get; set; }
    }
}
