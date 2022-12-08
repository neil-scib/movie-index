﻿using Movies.Contracts.Models;
using Orleans;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movies.Grains.Interfaces
{
	public interface IAllMoviesGrain : IGrainWithStringKey
	{
		Task<IEnumerable<Movie>> GetMoviesAsync();
		Task SetMovieListAsync(IEnumerable<Movie> movies);
	}
}
