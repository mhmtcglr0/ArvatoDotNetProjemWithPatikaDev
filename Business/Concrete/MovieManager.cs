using Business.Abstract;
using Business.Constans;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class MovieManager : IMovieService
    {
        IMovieDal _movieDal; //Dependency Injection
       
        

        public MovieManager(IMovieDal movieDal)
        {
            _movieDal = movieDal;   
        }

        public IResult Add(Movie movie)
        {
            if (movie.title.Length < 2)
            {
                //Magic Strings
                return new ErrorResult(Messages.MovieNameInvalid);
            }

            _movieDal.Add(movie);
            return new SuccessResult(Messages.MovieAdded); //Bu yapabilmenin yöntemi constructır eklemektir.
        }

        public IResult Delete(Movie movie)
        {
            _movieDal.Delete(movie);
            return new SuccessResult(Messages.MovieDeleted);
        }

        public IResult Update(Movie movie)
        {
            var result = _movieDal.GetAll(m => m.id == movie.id).Count;
            if (result >= 11000)
            {
                return new ErrorResult(Messages.MovieCountOfError);
            }
            _movieDal.Add(movie);
            return new SuccessResult(Messages.MovieUpdated);
        }
    }

       
    }

