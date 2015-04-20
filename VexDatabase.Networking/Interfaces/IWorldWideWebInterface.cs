using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;

namespace RoboticsDatabase.Networking.Interfaces
{
	public interface IWorldWideWebInterface
	{
		string URL { get; set; }
		Task<HttpResponseMessage> GetAsync(string getValues);
		Task<HttpResponseMessage> GetAsync(Dictionary<string, string> getValues);
		Task<HttpResponseMessage> PostAsync(Dictionary<string, string> postValues);
		Task<HttpResponseMessage> PostAsync(string postValues);
	}
}
