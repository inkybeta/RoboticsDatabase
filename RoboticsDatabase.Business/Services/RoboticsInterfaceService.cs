using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RoboticsDatabase.Business.Interfaces;
using System.Threading.Tasks;
using RoboticsDatabase.Core.Models;
using RoboticsDatabase.Networking.Client;
using RoboticsDatabase.Networking.Interfaces;

namespace RoboticsDatabase.Business.Services
{
	public class RoboticsInterfaceService : IRoboticsInterfaceService
	{
		private IRoboticsDatabaseInterface dataInterface { get; set; }

		public RoboticsInterfaceService(IRoboticsDatabaseInterface inter)
		{
			dataInterface = inter;
		}

		public Task<Team[]> GetTeams()
		{
			return Task.WhenAll(() =>{
				foreach();
		}

		public Task<Team[]> LoadTeams()
		{
			throw new NotImplementedException();
		}

		public Task<Team[]> LoadData()
		{
			throw new NotImplementedException();
		}

		public Task<int> CalculateThreat(Team team)
		{
			throw new NotImplementedException();
		}

		public Task<Team> GetTeam(string number)
		{
			throw new NotImplementedException();
		}

		public Task<Team> LoadTeamAsync(Team team)
		{
			throw new NotImplementedException();
		}

		public Task<Team> LoadData(Team number)
		{
			throw new NotImplementedException();
		}
	}
}
