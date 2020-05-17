namespace AutoMapper
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Threading.Tasks;
    using QueryableExtensions;
    using DelegateDecompiler;
    using DelegateDecompiler.EntityFramework;

    public static class EntityFrameworkExtensions
    {
        public static Task<List<TDestination>> ProjectToListAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).DecompileAsync().ToListAsync();
        }

        public static Task<List<TDestination>> ProjectToListAsync<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().DecompileAsync().ToListAsync();
        }

        public static Task<List<TDestination>> ProjectToListAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config, object parameters)
        {
            return queryable.ProjectTo<TDestination>(config, parameters).DecompileAsync().ToListAsync();
        }

        public static Task<List<TDestination>> ProjectToListAsync<TDestination>(this IQueryable queryable, object parameters)
        {
            return queryable.ProjectTo<TDestination>(parameters).DecompileAsync().ToListAsync();
        }

        public static Task<TDestination[]> ProjectToArrayAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).DecompileAsync().ToArrayAsync();
        }

        public static Task<TDestination[]> ProjectToArrayAsync<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().DecompileAsync().ToArrayAsync();
        }

        public static Task<TDestination[]> ProjectToArrayAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config, object parameters)
        {
            return queryable.ProjectTo<TDestination>(config, parameters).DecompileAsync().ToArrayAsync();
        }

        public static Task<TDestination[]> ProjectToArrayAsync<TDestination>(this IQueryable queryable, object parameters)
        {
            return queryable.ProjectTo<TDestination>(parameters).DecompileAsync().ToArrayAsync();
        }

        public static Task<TDestination> ProjectToSingleOrDefaultAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).DecompileAsync().SingleOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToSingleOrDefaultAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config).DecompileAsync().SingleOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToSingleOrDefaultAsync<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().DecompileAsync().SingleOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToSingleOrDefaultAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>().DecompileAsync().SingleOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToSingleOrDefaultAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config, object parameters)
        {
            return queryable.ProjectTo<TDestination>(config, parameters).DecompileAsync().SingleOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToSingleOrDefaultAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config, object parameters)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config, parameters).DecompileAsync().SingleOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToSingleOrDefaultAsync<TDestination>(this IQueryable queryable, object parameters)
        {
            return queryable.ProjectTo<TDestination>(parameters).DecompileAsync().SingleOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToSingleOrDefaultAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, object parameters)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(parameters).DecompileAsync().SingleOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToSingleAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).DecompileAsync().SingleAsync();
        }

        public static Task<TDestination> ProjectToSingleAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config).DecompileAsync().SingleAsync();
        }

        public static Task<TDestination> ProjectToSingleAsync<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().DecompileAsync().SingleAsync();
        }

        public static Task<TDestination> ProjectToSingleAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>().DecompileAsync().SingleAsync();
        }

        public static Task<TDestination> ProjectToSingleAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config, object parameters)
        {
            return queryable.ProjectTo<TDestination>(config, parameters).DecompileAsync().SingleAsync();
        }

        public static Task<TDestination> ProjectToSingleAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config, object parameters)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config, parameters).DecompileAsync().SingleAsync();
        }

        public static Task<TDestination> ProjectToSingleAsync<TDestination>(this IQueryable queryable, object parameters)
        {
            return queryable.ProjectTo<TDestination>(parameters).DecompileAsync().SingleAsync();
        }

        public static Task<TDestination> ProjectToSingleAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, object parameters)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(parameters).DecompileAsync().SingleAsync();
        }

        public static Task<TDestination> ProjectToFirstOrDefaultAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).DecompileAsync().FirstOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToFirstOrDefaultAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config).DecompileAsync().FirstOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToFirstOrDefaultAsync<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().DecompileAsync().FirstOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToFirstOrDefaultAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>().DecompileAsync().FirstOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToFirstOrDefaultAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config, object parameters)
        {
            return queryable.ProjectTo<TDestination>(config, parameters).DecompileAsync().FirstOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToFirstOrDefaultAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config, object parameters)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config, parameters).DecompileAsync().FirstOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToFirstOrDefaultAsync<TDestination>(this IQueryable queryable, object parameters)
        {
            return queryable.ProjectTo<TDestination>(parameters).DecompileAsync().FirstOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToFirstOrDefaultAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, object parameters)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(parameters).DecompileAsync().FirstOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToFirstAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).DecompileAsync().FirstAsync();
        }

        public static Task<TDestination> ProjectToFirstAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config).DecompileAsync().FirstAsync();
        }

        public static Task<TDestination> ProjectToFirstAsync<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().DecompileAsync().FirstAsync();
        }

        public static Task<TDestination> ProjectToFirstAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>().DecompileAsync().FirstAsync();
        }

        public static Task<TDestination> ProjectToFirstAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config, object parameters)
        {
            return queryable.ProjectTo<TDestination>(config, parameters).DecompileAsync().FirstAsync();
        }

        public static Task<TDestination> ProjectToFirstAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config, object parameters)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config, parameters).DecompileAsync().FirstAsync();
        }

        public static Task<TDestination> ProjectToFirstAsync<TDestination>(this IQueryable queryable, object parameters)
        {
            return queryable.ProjectTo<TDestination>(parameters).DecompileAsync().FirstAsync();
        }

        public static Task<TDestination> ProjectToFirstAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, object parameters)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(parameters).DecompileAsync().FirstAsync();
        }

        public static List<TDestination> ProjectToList<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).DecompileAsync().ToList();
        }

        public static List<TDestination> ProjectToList<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().DecompileAsync().ToList();
        }

        public static List<TDestination> ProjectToList<TDestination>(this IQueryable queryable, IConfigurationProvider config, object parameters)
        {
            return queryable.ProjectTo<TDestination>(config, parameters).DecompileAsync().ToList();
        }

        public static List<TDestination> ProjectToList<TDestination>(this IQueryable queryable, object parameters)
        {
            return queryable.ProjectTo<TDestination>(parameters).DecompileAsync().ToList();
        }

        public static TDestination[] ProjectToArray<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).DecompileAsync().ToArray();
        }

        public static TDestination[] ProjectToArray<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().DecompileAsync().ToArray();
        }

        public static TDestination[] ProjectToArray<TDestination>(this IQueryable queryable, IConfigurationProvider config, object parameters)
        {
            return queryable.ProjectTo<TDestination>(config, parameters).DecompileAsync().ToArray();
        }

        public static TDestination[] ProjectToArray<TDestination>(this IQueryable queryable, object parameters)
        {
            return queryable.ProjectTo<TDestination>(parameters).DecompileAsync().ToArray();
        }

        public static TDestination ProjectToSingleOrDefault<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).DecompileAsync().SingleOrDefault();
        }

        public static TDestination ProjectToSingleOrDefault<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config).DecompileAsync().SingleOrDefault();
        }

        public static TDestination ProjectToSingleOrDefault<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().DecompileAsync().SingleOrDefault();
        }

        public static TDestination ProjectToSingleOrDefault<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>().DecompileAsync().SingleOrDefault();
        }

        public static TDestination ProjectToSingleOrDefault<TDestination>(this IQueryable queryable, IConfigurationProvider config, object parameters)
        {
            return queryable.ProjectTo<TDestination>(config, parameters).DecompileAsync().SingleOrDefault();
        }

        public static TDestination ProjectToSingleOrDefault<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config, object parameters)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config, parameters).DecompileAsync().SingleOrDefault();
        }

        public static TDestination ProjectToSingleOrDefault<TDestination>(this IQueryable queryable, object parameters)
        {
            return queryable.ProjectTo<TDestination>(parameters).DecompileAsync().SingleOrDefault();
        }

        public static TDestination ProjectToSingleOrDefault<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, object parameters)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(parameters).DecompileAsync().SingleOrDefault();
        }

        public static TDestination ProjectToSingle<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).DecompileAsync().Single();
        }

        public static TDestination ProjectToSingle<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config).DecompileAsync().Single();
        }

        public static TDestination ProjectToSingle<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().DecompileAsync().Single();
        }

        public static TDestination ProjectToSingle<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>().DecompileAsync().Single();
        }

        public static TDestination ProjectToSingle<TDestination>(this IQueryable queryable, IConfigurationProvider config, object parameters)
        {
            return queryable.ProjectTo<TDestination>(config, parameters).DecompileAsync().Single();
        }

        public static TDestination ProjectToSingle<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config, object parameters)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config, parameters).DecompileAsync().Single();
        }

        public static TDestination ProjectToSingle<TDestination>(this IQueryable queryable, object parameters)
        {
            return queryable.ProjectTo<TDestination>(parameters).DecompileAsync().Single();
        }

        public static TDestination ProjectToSingle<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, object parameters)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(parameters).DecompileAsync().Single();
        }

        public static TDestination ProjectToFirstOrDefault<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).DecompileAsync().FirstOrDefault();
        }

        public static TDestination ProjectToFirstOrDefault<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config).DecompileAsync().FirstOrDefault();
        }

        public static TDestination ProjectToFirstOrDefault<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().DecompileAsync().FirstOrDefault();
        }

        public static TDestination ProjectToFirstOrDefault<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>().DecompileAsync().FirstOrDefault();
        }

        public static TDestination ProjectToFirstOrDefault<TDestination>(this IQueryable queryable, IConfigurationProvider config, object parameters)
        {
            return queryable.ProjectTo<TDestination>(config, parameters).DecompileAsync().FirstOrDefault();
        }

        public static TDestination ProjectToFirstOrDefault<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config, object parameters)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config, parameters).DecompileAsync().FirstOrDefault();
        }

        public static TDestination ProjectToFirstOrDefault<TDestination>(this IQueryable queryable, object parameters)
        {
            return queryable.ProjectTo<TDestination>(parameters).DecompileAsync().FirstOrDefault();
        }

        public static TDestination ProjectToFirstOrDefault<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, object parameters)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(parameters).DecompileAsync().FirstOrDefault();
        }

        public static TDestination ProjectToFirst<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).DecompileAsync().First();
        }

        public static TDestination ProjectToFirst<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config).DecompileAsync().First();
        }

        public static TDestination ProjectToFirst<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().DecompileAsync().First();
        }

        public static TDestination ProjectToFirst<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>().DecompileAsync().First();
        }

        public static TDestination ProjectToFirst<TDestination>(this IQueryable queryable, IConfigurationProvider config, object parameters)
        {
            return queryable.ProjectTo<TDestination>(config, parameters).DecompileAsync().First();
        }

        public static TDestination ProjectToFirst<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config, object parameters)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config, parameters).DecompileAsync().First();
        }

        public static TDestination ProjectToFirst<TDestination>(this IQueryable queryable, object parameters)
        {
            return queryable.ProjectTo<TDestination>(parameters).DecompileAsync().First();
        }

        public static TDestination ProjectToFirst<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, object parameters)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(parameters).DecompileAsync().First();
        }

        public static IQueryable<TDestination> ProjectToQueryable<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).DecompileAsync();
        }

        public static IQueryable<TDestination> ProjectToQueryable<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().DecompileAsync();
        }

        public static IQueryable<TDestination> ProjectToQueryable<TDestination>(this IQueryable queryable, IConfigurationProvider config, object parameters)
        {
            return queryable.ProjectTo<TDestination>(config, parameters).DecompileAsync();
        }

        public static IQueryable<TDestination> ProjectToQueryable<TDestination>(this IQueryable queryable, object parameters)
        {
            return queryable.ProjectTo<TDestination>(parameters).DecompileAsync();
        }
    }
}