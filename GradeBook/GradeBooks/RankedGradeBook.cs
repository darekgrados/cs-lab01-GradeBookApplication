using GradeBook.Enums;
using System;
using System.Linq;

namespace GradeBook.GradeBooks
{
	public class RankedGradeBook : BaseGradeBook
	{
		public RankedGradeBook(string name, bool isWeighted) : base(name, isWeighted)
		{
			Type = GradeBookType.Ranked;
		}

		public override char GetLetterGrade(double averageGrade)
		{
			var percentCheck = (int)Math.Ceiling(0.2 * Students.Count);
			var grades = Students.OrderByDescending(a => a.AverageGrade).Select(a => a.AverageGrade).ToList();

            if (averageGrade >= grades[percentCheck - 1])
                return 'A';
            if (averageGrade >= grades[(percentCheck * 2) - 1])
                return 'B';
            if (averageGrade >= grades[(percentCheck * 3) - 1])
                return 'C';
            if (averageGrade >= grades[(percentCheck * 4) - 1])
                return 'D';
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
