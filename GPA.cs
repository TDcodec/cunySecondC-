//Class for GPA, has two data members and corresponding properties
using System;
namespace StudentGrade
{
	public class GPA
	{
		private float cumGPA;
		private float semesterGPA;

		//default constructor
		public GPA()
		{
		}

		//property of cumGPA
		public float Cumulative
		{
			set
			{
				cumGPA = value;
			}

			get 
			{
				return cumGPA;
			}
		}

		//property of semesterGPA
		public float SemesterGPA
		{
			set
			{
				semesterGPA = value;
			}

			get
			{
				return semesterGPA;
			}
		}
	}
}
