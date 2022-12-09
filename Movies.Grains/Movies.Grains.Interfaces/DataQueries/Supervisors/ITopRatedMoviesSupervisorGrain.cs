﻿using Movies.Grains.Interfaces.DataQueries.FilteredMovies;

namespace Movies.Grains.Interfaces.DataQueries.Supervisors
{
	public interface ITopRatedMoviesSupervisorGrain : ISupervisorGrain<ITopRatedMoviesGrain>
	{
	}
}