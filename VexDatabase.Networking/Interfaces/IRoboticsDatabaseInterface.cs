using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboticsDatabase.Core.Models;

namespace RoboticsDatabase.Networking.Interfaces
{
	public interface IRoboticsDatabaseInterface : IWorldWideWebInterface
	{
		int Size { get; }
		RoboticsConnectionSettings Settings { get; }
		
		Task RefreshAsync();
		Task<Team[]> RefreshAllAsync();
		IEnumerable<Task<Team>> ProgressiveRefreshAllAsync();
		Task<Team[]> GetTeamsAsync(int begin, int end);
		Task<Team> GetTeamAsync(string number);

	}
}
