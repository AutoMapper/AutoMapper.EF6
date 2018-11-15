using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace AutoMapper.EF6.OData
{
    /// <summary>
    /// In OData, requesting the $inlinecount leads to a call to "Queryable.LongCount" on the EntityFramework QueryProvider.
    /// As it does not support "LongCount", the Expression needs to be rewritten to call "Queryable.Count" instead
    /// 
    /// <example>
    /// // use it when exposing an IQueryable with the "UseAsDataSource()" extension method like so:
    /// [EnableQuery]
    /// public IQueryable<OrderDto> Get()
    /// {
    ///     return context.OrderSet.UseAsDataSource(Mapper.Engine)
    ///         // add an additional visitor to convert "Queryable.LongCount" calls to "Queryable.Count" calls
    ///         // as EntityFramework does not support this method
    ///         .BeforeProjection(new EntityFrameworkCompatibilityVisitor())
    ///         .For<OrderDto>()
    /// }
    /// </example>
    /// </summary>
    public class EntityFrameworkCompatibilityVisitor : ExpressionVisitor
    {
        protected override Expression VisitMethodCall(MethodCallExpression node)
        {
            // replace call to "LongCount" with "Count"            
            if (node.Method.IsGenericMethod && node.Method.DeclaringType == typeof(Queryable) && node.Method.Name == "LongCount")
            {
                var method = node.Method.DeclaringType.GetMethods(BindingFlags.Public | BindingFlags.Static).First(m => m.Name == "Count");
                method = method.MakeGenericMethod(node.Method.GetGenericArguments());
                return Expression.Call(method, node.Arguments);
            }

            return base.VisitMethodCall(node);
        }
    }
}
