using System;
using System.ComponentModel.Design;
using InteractiveNovel;

class Program
{
	public static void Main()
	{
		
		FileManipulation fileChange = new FileManipulation();
		ProgressTracker saveOne = new ProgressTracker();
		Interface front = new Interface();
		Data data = new Data();		


		while (true)
		{
		front.menu(ref saveOne, fileChange, data);
		}
	}
}
