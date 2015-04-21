using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoboticsDatabase.Core.Models;
using RoboticsDatabase.Networking;

namespace RoboticsDatabase.Business.Interfaces
{
	public interface IRoboticsInterfaceService
	{
		Task<Team[]> GetTeams();
		Task<Team[]> LoadTeams();
		Task<Team[]> LoadData();

		Task<int> CalculateThreat(Team team);

		Task<Team> GetTeam(string number);
		Task<Team> LoadTeamAsync(Team team);
		Task<Team> LoadData(Team number);
	}
}
