using GradeBook.Enums;
using System;

namespace GradeBook.GradeBooks
{
	public class RankedGradeBook : BaseGradeBook
	{
		public RankedGradeBook(string name) : base(name)
		{
			Type = GradeBookType.Ranked;
		}

		public override char GetLetterGrade(double averageGrade)
		{
			if (averageGrade >= 80)
				return 'A';
			else if (averageGrade >= 60)
				return 'B';
			else if (averageGrade >= 40)
				return 'C';
			else if (averageGrade >= 20)
				return 'D';
			else
				return 'F';
		}

		public override void CalculateStatistics()
		{
			if (Students.Count < 5)
			{
				Console.WriteLine("Ranked grading requires at least 5 students.");
			}
			else
			{
				base.CalculateStatistics();
			}
		}

		public override void CalculateStudentStatistics(string name)
		{
			if (Students.Count < 5)
			{
				Console.WriteLine("Ranked grading requires at least 5 students.");
			}
			else
			{
				base.CalculateStudentStatistics(name);
			}
		}
	}
}
