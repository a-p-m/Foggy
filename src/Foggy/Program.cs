using System;
using System.Collections.Generic;
using System.Text;
using FoggyLib;

namespace Foggy
{
	class Program
	{
		static Options options = new Options();

		static void Main(string[] args)
		{
			FoggyLib.Report f = new Report();

			if (CommandLine.Parser.Default.ParseArguments(args, options))
			{
					Console.Write(f.MakeReport(options.Sentences, options.MinParaSentences, options.MaxParaSentences));
			}
			else
			{
				Console.Write(f.Usage());
			}


		
		}
	}
}
