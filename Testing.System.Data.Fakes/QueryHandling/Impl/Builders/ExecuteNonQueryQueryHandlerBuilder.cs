using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace System.Data.Fakes.QueryHandling.Impl
{
    sealed class ExecuteNonQueryQueryHandlerBuilder : AbstractQueryHandlerBuilder<IExecuteNonQueryQueryHandlerBuilderArgChecker, int>,
        IExecuteNonQueryQueryHandlerBuilder, IExecuteNonQueryQueryHandlerBuilderArgChecker
    {
        protected override IQueryHandler CreateHandler<TArgs>(List<Regex> queryRegex, Dictionary<string, Func<object, bool>> argCheckers, Func<TArgs, int> getResult)
        {
            return new ExecuteNonQueryQueryHandler<TArgs>(queryRegex, argCheckers, getResult);
        }
    }
}
