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
	}
}
