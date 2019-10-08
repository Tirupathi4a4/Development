using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace Help_Class_Sample.Models
{
    public class Student
    {
        [DisplayName("User Name")]
        public string UserName { set; get; }
        public string Mobile { set; get; }
        public string Email { set; get; }
    }
}