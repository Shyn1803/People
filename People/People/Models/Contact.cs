using System;
using System.Collections.Generic;
using System.Text;

namespace People.Models
{
    public class Contact
    {
        public String Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Company { get; set; }
        public String JobTitle { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public String City { get; set; }
        public String Street { get; set; }
        public String State { get; set; }
        public String PhotoUrl { get; set; }

        public String DisplayName => FirstName + " " + LastName;
    }
}
