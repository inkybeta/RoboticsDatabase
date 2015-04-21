using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.Common;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using RoboticsDatabase.Core.Models;

namespace RoboticsDatabase.Database.Contexts
{
	public class RoboticsDatabaseContext : DbContext
	{
		public DbSet<Team> Teams { get; set; }

		private RoboticsDatabaseContext()
			: base("RoboticsServer")
		{
			
		}

		public RoboticsDatabaseContext(string url)
			: base(url)
		{
			
		}

		public static RoboticsDatabaseContext CreateContext() {
			try
			{
				var mysql = new RoboticsDatabaseContext();
				if (mysql.Database.Exists())
					return mysql;
				return new RoboticsDatabaseContext("RoboticsCache");
			}
			catch (SqlException)
			{
				return new RoboticsDatabaseContext("RoboticsCache");
			}
		}
	}
}
