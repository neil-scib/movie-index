﻿using Movies.Contracts.Models;
using Movies.Grains.Clients.Interfaces;
using Movies.Grains.Interfaces.FilteredMovies;
using Orleans;
using System.Linq;
using System.Threading.Tasks;

namespace Movies.Grains.Clients
{
	public class MovieSearchGrainClient : IMovieSearchGrainClient
	{
		private readonly IGrainFactory _grainFactory;

		public MovieSearchGrainClient(IGrainFactory grainFactory)
		{
			_grainFactory = grainFactory;
		}

		public async Task<Movie> GetMovie(int id)
		{
			var movieSearchGrain = _grainFactory.GetGrain<IMovieSearchGrain>(id);
			return (await movieSearchGrain.GetMoviesAsync()).SingleOrDefault();
		}
	}
}