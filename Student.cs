using System;
namespace BTVN
{
	public class Student
	{
		private string name;
		private int grade;
		public Student()
		{
		}
		public Student(string name,int grade)
		{
			this.name = name;
			this.grade = grade;
		}
		public void setName(string name)
		{
			this.name = name;
		}
		public string getName()
		{
			return this.name;
		}
		public void setGrade(int grade)
		{
			this.grade = grade;
		}
		public int getGrade()
		{
			return this.grade;
		}
		public Student studentMaxGrade(List<Student> students)
		{
			Student student = students[0];
			
			for(int i = 1; i < students.Count; i++)
			{
				if (student.grade < students[i].grade)
				{
					student = students[i];
				}
			}
			return student;
		}
		public string toString()
		{
			return string.Format("Name: {0} - Grade: {1}", this.name,this.grade);
		}
	}
}

