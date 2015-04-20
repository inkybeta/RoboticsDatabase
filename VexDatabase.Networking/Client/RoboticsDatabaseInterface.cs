using System;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboticsDatabase.Networking.Interfaces;
using RoboticsDatabase.Core.Models;
using Newtonsoft.Json;

namespace RoboticsDatabase.Networking.Client
{
	public class RoboticsDatabaseInterface : IRoboticsDatabaseInterface
	{
		private HttpClient client { get; set; }

		public int Size { get; private set; }

		public RoboticsConnectionSettings Settings { get; set; }

		public RoboticsDatabaseInterface()
		{
			client = new HttpClient();
			Size = JsonConvert.DeserializeObject<ResponseMessage>(client.GetStringAsync("http://api.vex.us.nallen.me/get_teams?nodata=true").Result).Size;
		}

		public async Task RefreshAsync()
		{
			string response = await client.GetStringAsync("http://api.vex.us.nallen.me/get_teams?nodata");
			Size = JsonConvert.DeserializeObject<ResponseMessage>(response).Size;
		}

		public async Task<Team[]> RefreshAllAsync()
		{
			var teams = new List<Team>();
			for (int i = 0; i < Size; i += 500)
			{
				string response = await client.GetStringAsync(String.Format("http://api.vex.us.nallen.me/get_teams?limit_start={0}&limit_number=100", i));
				var message = JsonConvert.DeserializeObject<ResponseMessage>(response);
				teams.AddRange(message.Teams);
			}
			return teams.ToArray();
		}

		public async Task<IEnumerable<Team>> ProgressiveRefreshAllAsync()
		{
			for (int i = 0; i < Size; i += 500)
			{
				string response = client.GetStringAsync(String.Format("http://api.vex.us.nallen.me/get_teams?limit_start={0}&limit_number=100", i)).Result;
				var message = JsonConvert.DeserializeObject<ResponseMessage>(response);
				foreach (Team team in message.Teams)
				{
					yield return team;
				}
			}
		}

		public Task<Team[]> GetTeamsAsync(int begin, int end)
		{
			throw new NotImplementedException();
		}

		public Task<Team> GetTeamAsync(string name)
		{
			throw new NotImplementedException();
		}

		public string URL { get; set; }

		public async Task<HttpResponseMessage> GetAsync(string getValues)
		{
			return await client.GetAsync(String.Format("http://api.vex.us.nallen.me/get_teams?{0}", getValues));
		}

		public async Task<HttpResponseMessage> GetAsync(Dictionary<string, string> getValues)
		{
			StringBuilder builder = new StringBuilder();
			foreach (KeyValuePair<string, string> pair in getValues)
			{
				builder.Append(pair.Key + "=" + Uri.EscapeDataString(pair.Value));
			}
			return await GetAsync(builder.ToString());
		}

		public Task<HttpResponseMessage> PostAsync(Dictionary<string, string> postValues)
		{
			throw new NotImplementedException();
		}

		public Task<HttpResponseMessage> PostAsync(string postValues)
		{
			throw new NotImplementedException();
		}
	}
}
