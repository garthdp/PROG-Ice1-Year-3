using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Ice1
{
    public class Student
    {
        private string studentNumber, name, surname, year, dob, course, phoneNumber, email;

        public Student(string studentNumber, string name, string surname, string year, string dob, string course, string phoneNumber, string email)
        {
            this.studentNumber = studentNumber;
            this.name = name;
            this.surname = surname;
            this.year = year;
            this.dob = dob;
            this.course = course;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public object this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0:return studentNumber;
                    case 1: return name;
                    case 2: return surname;
                    case 3: return year;
                    case 4: return dob;
                    case 5: return course;
                    case 6: return phoneNumber;
                    case 7: return email;
                }
                return null;
            }
            set
            {
                if (index == 0)
                    this.studentNumber = (string)value;
                else if (index == 1)
                    this.name = (string)value;
                else if (index == 2)
                    this.surname = (string)value;
                else if (index == 3)
                    this.year = (string)value;
                else if (index == 4)
                    this.dob = (string)value;
                else if (index == 5)
                    this.course = (string)value;
                else if (index == 5)
                    this.phoneNumber = (string)value;
                else if (index == 5)
                    this.email = (string)value;
            }
        }
        public object this[string attrName]
        {
            get
            {
                switch (attrName.ToLower())
                {
                    case "studentnumber": return this.studentNumber;
                    case "name": return this.name;
                    case "surname": return this.surname;
                    case "year": return this.year;
                    case "dob": return this.dob;
                    case "course": return this.course;
                    case "phonenumebr": return this.phoneNumber;
                    case "email": return this.email;
                }
                return null;
            }
            set
            {
                if (attrName.ToLower().Equals("studentnumber"))
                    this.studentNumber = (string)value;
                else if (attrName.ToLower().Equals("name"))
                    this.name = (string)value;
                else if (attrName.ToLower().Equals("surname"))
                    this.surname = (string)value;
                else if (attrName.ToLower().Equals("year"))
                    this.year = (string)value;
                else if (attrName.ToLower().Equals("dob"))
                    this.dob = (string)value;
                else if (attrName.ToLower().Equals("course"))
                    this.course = (string)value;
                else if (attrName.ToLower().Equals("phonenumber"))
                    this.phoneNumber = (string)value;
                else if (attrName.ToLower().Equals("email"))
                    this.email = (string)value;
            }
        }
    }
}
