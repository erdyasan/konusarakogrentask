﻿using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Specifications;
public class BaseSpecification<T> : ISpecification<T>
    where T : BaseEntity
{
    public Expression<Func<T, bool>> Criteria { get; set; }
    public List<Expression<Func<T, object>>> Includes { get; } = new();
    public List<string> IncludeStrings { get; } = new();

    public Expression<Func<T, bool>> And(Expression<Func<T, bool>> query)
    {
        return Criteria = Criteria == null ? query : Criteria.And(query);
    }

    public Expression<Func<T, bool>> Or(Expression<Func<T, bool>> query)
    {
        return Criteria = Criteria == null ? query : Criteria.Or(query);
    }

    protected virtual void AddInclude(Expression<Func<T, object>> includeExpression)
    {
        Includes.Add(includeExpression);
    }

    protected virtual void AddInclude(string includeString)
    {
        IncludeStrings.Add(includeString);
    }
}

