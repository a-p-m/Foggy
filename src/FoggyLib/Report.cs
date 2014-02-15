using System;
using System.Collections.Generic;
using System.Text;

namespace FoggyLib
{
	public class Report
	{
		Random rnd = new Random();

		/* List of LEADINS, all of which mean nothing but buy time */ 
		string[] Leadin = {
									"In particular,",
									"On the other hand,",
									"However,",
									"Similarly,",
									"As a resultant implication,",
									"In this regard,",
									"Based on integral subsystem considerations,",
									"For example,",
									"Thus,",
									"In respect to specific goals,",
									"Interestingly enough,",
									"Without going into the technical details,",
									"Of course,",
									"To approach true user-friendliness,",
									"In theory,",
									"It is assumed that",
									"Conversely,",
									"We can see, in retrospect,",
									"It is further assumed that",
									"Further,",
									"In summary,",
									"It should be noted that",
									"To further describe and annotate,",
									"Specifically,"
								};

		/* List of SUBJECT clauses chosen for no redeeming value whatsoever */
		string[] Subject = {
									"a large portion of interface coordination communication",
									"a constant flow of effective communication",
									"the characterization of specific criteria",
									"initiation of critical subsystem development",
									"the fully integrated test program",
									"the product configuration baseline",
									"any associated supporting element",
									"the incorporation of additional mission constraints",
									"the independent functional principle",
									"the interrelation of system and/or subsystem technologies",
									"the product assurance architecture"
								};

		/* List of VERB clauses chosen for auto-recursive obfuscation */ 
		string[] Verb = {
									"must utilize and be functionally interwoven with",
									"maximizes the probability of project success, yet minimizes cost and time required for",
									"adds explicit performance limits to",
									"necessitates that urgent consideration be applied to",
									"requires considerable systems analysis and trade-off studies to arrive at",
									"is further compounded when taking into account",
									"presents extremely interesting challenges to",
									"recognizes other systems' importance and the necessity for",
									"affects a significant implementation of",
									"adds overriding performance constraints to",
									"mandates staff-meeting-level attention to",
									"is functionally equivalent and parallel to"
								};

		/* List of OBJECT clauses selected for profound meaninglessness */ 
		string[] Object = {
									"the most recent level of hardware.  ",
									"the anticipated fourth-generation equipment.  ",
									"the subsystem compatibility testing.  ",
									"the structural design, based on system engineering concepts.  ",
									"the preliminary qualification limit.  ",
									"the evolution of specifications over a given time period.  ",
									"the philosophy of commonality and standardization.  ",
									"the greater fight-worthiness concept.  ",
									"any discrete configuration mode.  ",
									"the management-by-contention principle.  ",
									"the total system rationale.  ",
									"possible bidirectional logical relationship approaches.  ",
									"the postulated use of dialog management technology.  ",
									"the overall negative profitability.  "
								};

		public string Usage()
		{
			System.Text.StringBuilder sb = new StringBuilder();
			sb.AppendLine("foggy.rex");
			sb.AppendLine(" FOGGY is an interactive productivity tool designed to assist");
			sb.AppendLine(" in the composition of monthly reports, project plans, memos to");
			sb.AppendLine(" management and so forth.  If entered without parameters,");
			sb.AppendLine(" FOGGY generates as output a high-fog-index sentence suitable for");
			sb.AppendLine(" befuddling even the most determined seeker-after-content.  If you");
			sb.AppendLine(" need vast amounts of FOGGY for really serious tush-covering, enter");
			sb.AppendLine(" the number of sentences needed as a parameter.  For example,");
			sb.AppendLine(" entering 'FOGGY -s5' outputs half a screen of heat-treated, battle-");
			sb.AppendLine(" hard, industrial-strength slop, well suited to choking hogs and");
			sb.AppendLine(" assurance planners. ");
			sb.AppendLine("");
			sb.AppendLine(" REMEMBER:");
			sb.AppendLine(" FOGGY can be a terrible weapon -- never abuse it.");

			return sb.ToString();
		}

		private string MakeSentence()
		{
			string result = "";

			result += Leadin[rnd.Next(0, Leadin.Length)];
			result += " " + Subject[rnd.Next(0, Subject.Length)];
			result += " " + Verb[rnd.Next(0, Verb.Length)];
			result += " " + Object[rnd.Next(0, Object.Length)];

			return result;
		}


		public string MakeReport(int numberOfSentences, int minPara, int maxPara)
		{
			int p = rnd.Next(minPara, maxPara);
			int c = 1;
			System.Text.StringBuilder sb = new StringBuilder();
			for (int i = 0; i < numberOfSentences; i++)
			{
				sb.Append(MakeSentence());
				if (c++ >= p)
				{
					p = rnd.Next(minPara, maxPara);
					c = 1;
					sb.AppendLine("");
					sb.AppendLine("");
				}
			}
			return sb.ToString();
		}

		public int GetRandom(int minimum, int maximum)
		{
			return rnd.Next(minimum, maximum);
		}
	}
}
