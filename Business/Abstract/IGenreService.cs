using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IGenreService
    {
        IResult Add(Genre genre); //void birşy döndürmez

        IResult Update(Genre genre);

        IResult Delete(Genre genre);

        IDataResult<List<Genre>> GetAll();
    }
}
