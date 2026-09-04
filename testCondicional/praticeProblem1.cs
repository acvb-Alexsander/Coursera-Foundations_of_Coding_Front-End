using System;

public class ProblemOne
{
	public ProblemOne()
	{
	}

	public void praticeProblem(int grade)
	{
       

        Console.WriteLine("Enter the student's grade: ");
        grade = int.Parse(Console.ReadLine());
		if (grade >= 50)
		{
			Console.WriteLine("Passed");
		}else
		{
			Console.WriteLine("Failed");
		}
	}
	
}
