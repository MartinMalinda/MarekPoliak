using System;
using System.Collections.Generic;
using System.Text;

namespace ICloneable
{
    class Cohort
    {
        private List<Student> students;
        private List<Mentor> mentors;
        private string name;

        public Cohort(string name)
        {
            this.name = name;
            students = new List<Student>();
            mentors = new List<Mentor>();
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public void AddMentor(Mentor mentor)
        {
            mentors.Add(mentor);
        }

        public void Info()
        {
            Console.WriteLine("info about cohort........:/");
        }
    }
}
