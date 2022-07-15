using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IMovieService
    {
     

        IResult Add(Movie movie); //void birşy döndürmez

        IResult Update(Movie movie);

        IResult Delete(Movie movie);

      
    }
}
