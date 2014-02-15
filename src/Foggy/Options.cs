using System;
using System.Collections.Generic;
using System.Text;
using CommandLine;
using CommandLine.Text;
using System.Reflection;


namespace Foggy
{
	public class Options
	{
		[Option('s', "number-of-sentences", DefaultValue = 10, HelpText = "Specify the number of sentences to return")]
		public int Sentences { get; set; }

		[Option('m', "minimum-paragraph-sentences", DefaultValue = 2, HelpText = "Specify the minimum number of sentences a paragraph should have")]
		public int MinParaSentences { get; set; }

		[Option('n', "max-para-sentences", DefaultValue = 7, HelpText = "Specify the maximum number of sentences a paragraph should have")]
		public int MaxParaSentences { get; set; }

		[HelpOption]
		public string GetUsage()
		{
			// this without using CommandLine.Text
			//  or using HelpText.AutoBuild
			//var usage = new StringBuilder();
			//usage.AppendLine("Quickstart Application 1.0");
			//usage.AppendLine("Read user manual for usage instructions...");
			//return usage.ToString();

			string copyrightMessage = ((AssemblyCopyrightAttribute)Attribute.GetCustomAttribute(
				Assembly.GetExecutingAssembly(),
				typeof(AssemblyCopyrightAttribute), false)).Copyright;

			var help = new HelpText
			{
				Heading = new HeadingInfo("FOGGY", Assembly.GetEntryAssembly().GetName().Version.ToString()),
				Copyright = copyrightMessage,
				AdditionalNewLineAfterOption = true,
				AddDashesToOption = true
			};
			help.AddPreOptionsLine("For External Use Only [Discontinue if a rash develops]");
			help.AddOptions(this);
			return help;

		}

	}
}
