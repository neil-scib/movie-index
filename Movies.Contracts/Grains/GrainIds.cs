﻿namespace Movies.Contracts.Grains
{
	public static class GrainIds
	{
		public const string AllMoviesGrainId = nameof(AllMoviesGrainId);
		public const string TopRatedMoviesSupervisorGrainId = nameof(TopRatedMoviesSupervisorGrainId);
		public const string GenreFilterSupervisorGrainId = nameof(GenreFilterSupervisorGrainId);
		public const string AddMovieGrainId = nameof(AddMovieGrainId);
	}
}
