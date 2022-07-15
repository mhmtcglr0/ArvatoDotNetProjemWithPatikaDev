using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        //Access token oluşturacak yapının kendisi aynı zamanda ilgili kullanıcı için calaimlerini içerin JWT üret demek
        AccessToken CreateToken(User user, List<OperationClaim> operatingClaims);
    }
}
