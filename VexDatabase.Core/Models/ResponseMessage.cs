using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RoboticsDatabase.Core.Models
{
	public class ResponseMessage
	{
		[JsonProperty("status")]
		public int Status { get; set; }

		[JsonProperty("size")]
		public int Size { get; set; }

		public Team[] Teams { get; set; }
	}
}
