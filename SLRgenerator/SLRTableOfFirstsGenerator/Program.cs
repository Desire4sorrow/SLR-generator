using SLRgenerator.GeneratorMain;
using SLRgenerator.OtherViewUtils;
using System;
using System.IO;
using System.Text;

namespace SLRgenerator
{
	class Program
	{
		static void Main(string[] args)
		{
			using (StreamReader streamReader = new StreamReader(args[0], Encoding.Default))
			{
				var reader = new SentencesReader(streamReader);
				var creator = new FirstCreator(reader.Sentences);
				creator.WriteResult(Console.Out);
			}
		}
	}
}
