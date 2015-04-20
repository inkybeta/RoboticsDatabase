using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RoboticsDatabase.Core.Models
{
    public class Team
    {
		[Key]
		[JsonProperty("team_name")]
		public string Name { get; set; }

		[Required]
		[JsonProperty("number")]
		public string Number { get; set; }

		[Required]
		[JsonProperty("program")]
		public string Program { get; set; }

		[Required]
		[JsonProperty("grade")]
		public string Grade { get; set; }

		[Required]
		[JsonProperty("country")]
		public string Region { get; set; }

		[Required]
		[JsonProperty("opr")]
		public int Offensive { get; set; }

		[Required]
		[JsonProperty("rank")]
		public int Rank { get; set; }

		[Required]
		[JsonProperty("max_score")]
		public int Maximum { get; set; }
    }
}
