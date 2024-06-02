using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public interface Ispecification<T>
    {
        // generic methods 
        // object is the thing more generic to use in c#
        // Expression<Func<T,bool>> Criteria 

        Expression<Func<T, bool>> Criteria { get; }

        List<Expression<Func<T, object>>> Includes { get; }
    }
}