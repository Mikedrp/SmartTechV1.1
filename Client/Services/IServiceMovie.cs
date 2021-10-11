using PracticaSemanaIV.Shared.Entity;
using System.Collections.Generic;

namespace PracticaSemanaIV.Client.Services
{
    public interface IServiceMovie
    {
         List<Movie> GetMovies();

    }
}