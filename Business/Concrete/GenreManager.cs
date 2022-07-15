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
    public class GenreManager : IGenreService
    {
        IGenreDal _genreDal;
        public GenreManager(IGenreDal genreDal)
        {
            _genreDal = genreDal;
        }
    
        public IResult Add(Genre genre)
        {
            if (genre.name.Length < 5)
            {
                //Magic Strings
                return new ErrorResult(Messages.GenreNameInvalid);
            }

            _genreDal.Add(genre);
            return new SuccessResult(Messages.GenreAdded);
        }

        public IResult Delete(Genre genre)
        {
            _genreDal.Delete(genre);
            return new SuccessResult(Messages.GenreDeleted);
        }

        public IDataResult<List<Genre>> GetAll()
        {
            if (DateTime.Now.Hour == 23)
            {
                return new ErrorDataResult<List<Genre>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Genre>>(_genreDal.GetAll(), Messages.GenresListed);
        }

        public IResult Update(Genre genre)
        {
            _genreDal.Update(genre);
            return new SuccessResult(Messages.GenreUpdated);
        }
    }

}
