using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Help_Class_Sample.Models
{
    public class StudentRecord
    {
        public List<Student> lstStudentData = new List<Student>();

        public void AddUser(Student user)
        {
            lstStudentData.Add(user);
        }

        public void EditUser(Student user)
        {
            for (int i = 0; i < lstStudentData.Count; i++)
            {
                if(lstStudentData[i].UserName == user.UserName)
                {
                    lstStudentData[i].Mobile = user.Mobile;
                    lstStudentData[i].Email = user.Email; 
                }
                
            }
        }

        public Student GetUser(string user)
        {
            for (int i = 0; i < lstStudentData.Count; i++)
            {
                if (lstStudentData[i].UserName == user)
                {
                    return lstStudentData[i];
                }               
            }
            return null;
        }
    }
}