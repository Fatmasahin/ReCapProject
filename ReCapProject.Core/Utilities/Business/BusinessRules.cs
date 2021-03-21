using System;
using ReCapProject.Core.Utilities.Results;

namespace ReCapProject.Core.Utilities.Business
{
    public class BusinessRules
    {
        public BusinessRules()
        {
        }
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (!logic.Success)
                {
                    return logic;
                }
            }
            return null;
        }
    }
}
