using System;
using System.Collections.Generic;
using ReCapProject.Core.Entities.Concrete;

namespace ReCapProject.Core.Utilities.Security.JWT
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
