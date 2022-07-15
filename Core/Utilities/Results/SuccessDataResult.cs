using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {

        }
        public SuccessDataResult(T data) : base(data, true) //Mesaj olayına girme base deki al sana data işlem sonucu true
        {

        }
        public SuccessDataResult(string message) : base(default, true, message) //default haliyle datayı döndürebilir sadece mesaj geçip
        {

        }

        public SuccessDataResult() : base(default, true) //Hiçbirşey döndürmeden base datan defaultur işlem sonucun true'dur.
        {

        }
    }
}
