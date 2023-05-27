using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml;

namespace InteractiveNovel
{
	//Make properties private
	[DataContract]
	public class ProgressTracker
	{
		[DataMember]
		public int currentChapter { get; set; }
		[DataMember]
		public int decisionNumber { get; set; }
		[DataMember]
		public int affectedDecisions { get; set; }
		[DataMember]
		public List<string> decisionsReference { get; set; }
		[DataMember]
		public int count { get; set; }
		[DataMember]
		public int liveCount { get; set; }
		[DataMember]
		public string saveGameName { get; set; }
		[DataMember]
		public string[] chapterArr { get; set; }

		public ProgressTracker()
		{
			currentChapter = 0;
			decisionNumber = 0;
			decisionsReference = new List<string>();
			affectedDecisions = 0;
			count = 0;
			liveCount = 0;
			saveGameName = "";
		}
		public void classDump()
		{
			Console.WriteLine($"CurrentChapter: {currentChapter}");
			Console.WriteLine($"DecisionNumber: {decisionNumber}");
			Console.WriteLine($"AffectedDecisions: {affectedDecisions}");
			Console.WriteLine($"DecisionsReference: {decisionsReference}");
			Console.WriteLine($"Count: {count}");
			Console.WriteLine($"LiveCount: {liveCount}");
			Console.WriteLine($"SaveGameName: {saveGameName}");
		}
	}
	class Serializer
	{
		public void SaveViaDataContractSerialization(ProgressTracker serializableObject, string filepath)
		{
			var serializer = new DataContractSerializer(typeof(ProgressTracker));
			var settings = new XmlWriterSettings()
			{
				Indent = true,
				IndentChars = "\t",
			};
			var writer = XmlWriter.Create(filepath, settings);
			serializer.WriteObject(writer, serializableObject);
			writer.Close();
		}


		public ProgressTracker LoadViaDataContractSerialization(string filepath)
		{
			var fileStream = new FileStream(filepath, FileMode.Open);
			var reader = XmlDictionaryReader.CreateTextReader(fileStream, new XmlDictionaryReaderQuotas());
			var serializer = new DataContractSerializer(typeof(ProgressTracker));
			ProgressTracker serializableObject = (ProgressTracker)serializer.ReadObject(reader, true);
			reader.Close();
			fileStream.Close();
			return serializableObject;
		}
	}
}
