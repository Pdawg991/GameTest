using System.Text.RegularExpressions;


namespace InteractiveNovel
{
public class Interface
	{
	public int selectionSystem(string[] arr, ProgressTracker saveFile) {

		Console.WriteLine("****************************************************************************\n");

			int x = 0;

			foreach (string i in arr) {
				if (i == "")
				{
					continue;
				}
				else {
					Console.WriteLine(x + ": " + i);
				}
				x += 1;
			}	
			//randomNum = random.randint(1, x - 1)
		Console.WriteLine("****************************************************************************\n");
		int selection = validateInput(0, x - 1);

			/*if (selection == 0):
				print("You chose to be surprised, and you: " + arr[randomNum])

				selection == randomNum

			else:*/
			Console.WriteLine("You chose to: " + arr[selection]);
			saveFile.decisionsReference.Add(arr[selection]);
			//updateDecisions(decisionsMade, temporaryHold, selection, saveGame)
			return selection;
					}
	public string[] formatString(string chapter) 
		{
		string[] chOneLines = chapter.Split(Environment.NewLine, StringSplitOptions.RemoveEmptyEntries);
		return chOneLines;
		}

	public void advanceNextChapter(ProgressTracker saveFile, FileManipulation fileMan, Data data)
		{
			saveFile.liveCount = 0;
			saveFile.count = 0;
			Console.WriteLine(saveFile.currentChapter);
			string[] arr = formatString(data.allChapters[saveFile.currentChapter]);
			saveFile.count = arr.Length;
			saveFile.chapterArr = arr;
			while (saveFile.liveCount < saveFile.count)
			{
				inChapterMenu(saveFile, fileMan, data);
			}
			selectionSystem(data.allDecisions[saveFile.currentChapter], saveFile);
			saveFile.currentChapter += 1;
		}

	public void inChapterMenu(ProgressTracker saveFile, FileManipulation fileMan, Data data) {
			if (saveFile.liveCount != 0) {
				Console.WriteLine("*************************\n1: Advance\n2: Save game\n3: Exit Game\n*************************");
				int selection = validateInput(1, 3);
				if (selection == 1)
				{
					printNextSeven(saveFile, fileMan, data);
				}
				else if (selection == 2)
				{
					fileMan.saveGame(saveFile);
				}
				else if (selection == 3) {
					System.Environment.Exit(1);
				}
			}
			else 
			{
				printNextSeven(saveFile, fileMan, data);
			}
		}
		
	public void printNextSeven(ProgressTracker saveFile, FileManipulation fileMan, Data data)
		{
			if (saveFile.liveCount - saveFile.count == 0)
			{
				menu(ref saveFile, fileMan, data);
			}
			if (saveFile.count - saveFile.liveCount > 7)
			{
				for (int i = 0; i < 7; i++)
				{
					if (isFormatted(saveFile.chapterArr[i + saveFile.liveCount]))
					{
						storyReformat(saveFile, i);
					}
					else
					{
						Console.WriteLine(saveFile.chapterArr[i + saveFile.liveCount]);
					}			
				}
				saveFile.liveCount += 7;
			}
			else
			{
				for (int i = 0; i < saveFile.count % 7; i++)
				{
					if (isFormatted(saveFile.chapterArr[i + saveFile.liveCount]))
					{
						storyReformat(saveFile, i);
					}
					else
					{
						Console.WriteLine(saveFile.chapterArr[i + saveFile.liveCount]);
					}
				}
				saveFile.liveCount += saveFile.count % 7;
			}
		}
	
	public bool isFormatted(string checkString)
		{
			string formattedString = "(?:" + Regex.Escape("{0}") + ")";
			if (Regex.IsMatch(checkString, formattedString))
			{
				return true;
			}
			return false;
		}
	public void storyReformat(ProgressTracker saveFile, int line) {
			Console.WriteLine(saveFile.chapterArr[saveFile.liveCount + line], saveFile.decisionsReference[0]);
	}
		public int validateInput(int start, int end) {
			int intSelection;
			try
			{
				string selection = Console.ReadLine();
				intSelection = Convert.ToInt32(selection);
				while (intSelection < start || intSelection > end || selection == null)
				{
					Console.WriteLine("Use a valid input!");
					selection = Console.ReadLine();
					intSelection = Convert.ToInt32(selection);
				}
				return intSelection;
			}
			catch (Exception e) {
				Console.WriteLine("Please Use Valid Input");
				Console.WriteLine(e);
				return validateInput(start, end);
			}
		}
	public void menu(ref ProgressTracker saveFile, FileManipulation fileMan, Data data)
	{
		Console.WriteLine("**************************" +
			"\n1: Advance to next chapter\n2: Save game" +
			"\n3: Load Game\n4: Delete Game\n5: Exit Game\n"
			+ "**************************");
		int selection = validateInput(1,5);
			if (selection == 1)
				advanceNextChapter(saveFile, fileMan, data);
			else if (selection == 2)		
				fileMan.saveGame(saveFile);
			else if (selection == 3)
				fileMan.loadGame(ref saveFile);
			else if (selection == 4)
				fileMan.deleteGame();
			else if (selection == 5)
				fileMan.exitGame();
	}
}
}
