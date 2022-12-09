﻿using Orleans;
using System.Threading.Tasks;

namespace Movies.Grains.Interfaces.DataQueries.Supervisors
{
	public interface ISupervisorGrain<TSupervisedGrainInterface> : IGrainWithStringKey
		where TSupervisedGrainInterface : IResettableGrain
	{
		Task ResetAllAsync();
		Task<TSupervisedGrainInterface> GetSupervisedGrainAsync(int primaryKey);
	}
}
