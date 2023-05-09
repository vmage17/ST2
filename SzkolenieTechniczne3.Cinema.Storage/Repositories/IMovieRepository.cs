using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SzkolenieTechniczne3.Cinema.Storage.Entities;

namespace SzkolenieTechniczne3.Cinema.Storage.Repositories
{
    interface IMovieRepository
    {
        IEnumerable<Movie> GetAll();
        IMovieRepository GetById(Guid id);
        void Add(Movie movie);
        void Remove(Guid id);

        void Update(Guid id);

        bool IsMovieExist(string name, int year);
        bool IsSeanceExit(DateTime seanceDate);

        IMovieRepository GetSeanceDetails(Guid movieId);

        List<Seance> GetSeancesByMovieId(Guid movieId);
    }
}