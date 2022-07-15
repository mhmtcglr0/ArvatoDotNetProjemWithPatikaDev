using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorDataResult<T> : DataResult<T>
    {
        public ErrorDataResult(T data, string message) : base(data, false, message)
        {

        }
        public ErrorDataResult(T data) : base(data, false) //Mesaj olayına girme base deki al sana data işlem sonucu false
        {

        }
        public ErrorDataResult(string message) : base(default, false, message) //default haliyle datayı döndürebilir sadece mesaj geçip
        {

        }

        public ErrorDataResult() : base(default, false) //Hiçbirşey döndürmeden base datan defaultur işlem sonucun false'dur.
        {

        }
    }
}