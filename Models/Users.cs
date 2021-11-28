using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todo_s03.Models
{
    class Users
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string UserPicture { get; set; }
        public string ToDo { get; set; }
        public string CompleteToDo { get; set; }
    }
}
