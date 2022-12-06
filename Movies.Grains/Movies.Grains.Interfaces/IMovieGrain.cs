﻿using Movies.Contracts.Models;
using Orleans;
using System.Threading.Tasks;

namespace Movies.Grains.Interfaces
{
	public interface IMovieGrain : IGrainWithIntegerKey
	{
		Task<Movie> GetAsync();
		Task SetAsync(Movie movie);
	}
}
