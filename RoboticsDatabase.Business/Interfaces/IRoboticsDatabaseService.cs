using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboticsDatabase.Core.Models;
using RoboticsDatabase.Networking.Client;

namespace RoboticsDatabase.Business.Interfaces
{
	public interface IRoboticsDatabaseService
	{
		IRoboticsInterfaceService service { set; }
		Task AddAsync(Team team);
		Task ReloadTeamAsync(string number);
		Task ReloadTeamScoreAsync(string number);
		Task DeleteAsync(string number);
		Task<Team> GetTeam(string number);
		Task<Team[]> GetTeams();
		Task<Team[]> GetTeams(int beginning, int end);
		Task<Team[]> SearchTeamsByNameAsync(string name);
		/// <summary>
		/// For partially filled numbers (ex 57--- )
		/// </summary>
		/// <param name="number">The partial number you wish to search</param>
		/// <returns>An array of teams that fit the known number.</returns>
		Task<Team[]> SearchTeamsByNumberAsync(string number);
		Task<Team[]> SearchTeamsAsync(string fieldName, object value);
	}
}
