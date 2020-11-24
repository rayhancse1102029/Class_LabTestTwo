using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LabTesttTwo.Models
{
    public class StudentRegistration
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { set; get; }

        public string name { set; get; }
        public string clsName { set; get; }
        public string dept { set; get; }
        public string roll { set; get; }
        public string father { set; get; }
        public string mother { set; get; } 
        public string mobileNum { set; get; }
        public string email { set; get; }
        public string present { set; get; }
        public string parmanent { set; get; }
    }
}
