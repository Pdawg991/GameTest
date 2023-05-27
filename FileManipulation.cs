using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InteractiveNovel
{
	public class FileManipulation
	{

		public void saveGame(ProgressTracker saveFile)
		{
			Serializer serializer = new Serializer();
			serializer.SaveViaDataContractSerialization(saveFile, "saveFile.xml");
		}
		public void loadGame(ref ProgressTracker saveFile)
		{
			
			Serializer serializer = new Serializer();
			saveFile = serializer.LoadViaDataContractSerialization("saveFile.xml");
			saveFile.classDump();
		}
		public void deleteGame()
		{
			Console.WriteLine("Delete Game");
		}
		public void exitGame()
		{
			System.Environment.Exit(1);
		}
	}
}
