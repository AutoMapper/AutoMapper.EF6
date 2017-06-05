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
        public static async Task<List<TDestination>> ProjectToListAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return await queryable.ProjectTo<TDestination>(config).DecompileAsync().ToListAsync();
        }

        public static async Task<List<TDestination>> ProjectToListAsync<TDestination>(this IQueryable queryable)
        {
            return await queryable.ProjectTo<TDestination>().DecompileAsync().ToListAsync();
        }

        public static async Task<TDestination[]> ProjectToArrayAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return await queryable.ProjectTo<TDestination>(config).DecompileAsync().ToArrayAsync();
        }

        public static async Task<TDestination[]> ProjectToArrayAsync<TDestination>(this IQueryable queryable)
        {
            return await queryable.ProjectTo<TDestination>().DecompileAsync().ToArrayAsync();
        }

        public static async Task<TDestination> ProjectToSingleOrDefaultAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return await queryable.ProjectTo<TDestination>(config).DecompileAsync().SingleOrDefaultAsync();
        }

        public static async Task<TDestination> ProjectToSingleOrDefaultAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return await queryable.Where(predicate).ProjectTo<TDestination>(config).DecompileAsync().SingleOrDefaultAsync();
        }

        public static async Task<TDestination> ProjectToSingleOrDefaultAsync<TDestination>(this IQueryable queryable)
        {
            return await queryable.ProjectTo<TDestination>().DecompileAsync().SingleOrDefaultAsync();
        }

        public static async Task<TDestination> ProjectToSingleOrDefaultAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return await queryable.Where(predicate).ProjectTo<TDestination>().DecompileAsync().SingleOrDefaultAsync();
        }

        public static async Task<TDestination> ProjectToSingleAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return await queryable.ProjectTo<TDestination>(config).DecompileAsync().SingleAsync();
        }

        public static async Task<TDestination> ProjectToSingleAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return await queryable.Where(predicate).ProjectTo<TDestination>(config).DecompileAsync().SingleAsync();
        }

        public static async Task<TDestination> ProjectToSingleAsync<TDestination>(this IQueryable queryable)
        {
            return await queryable.ProjectTo<TDestination>().DecompileAsync().SingleAsync();
        }

        public static async Task<TDestination> ProjectToSingleAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return await queryable.Where(predicate).ProjectTo<TDestination>().DecompileAsync().SingleAsync();
        }

        public static async Task<TDestination> ProjectToFirstOrDefaultAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return await queryable.ProjectTo<TDestination>(config).DecompileAsync().FirstOrDefaultAsync();
        }

        public static async Task<TDestination> ProjectToFirstOrDefaultAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return await queryable.Where(predicate).ProjectTo<TDestination>(config).DecompileAsync().FirstOrDefaultAsync();
        }

        public static async Task<TDestination> ProjectToFirstOrDefaultAsync<TDestination>(this IQueryable queryable)
        {
            return await queryable.ProjectTo<TDestination>().DecompileAsync().FirstOrDefaultAsync();
        }

        public static async Task<TDestination> ProjectToFirstOrDefaultAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return await queryable.Where(predicate).ProjectTo<TDestination>().DecompileAsync().FirstOrDefaultAsync();
        }

        public static async Task<TDestination> ProjectToFirstAsync<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return await queryable.ProjectTo<TDestination>(config).DecompileAsync().FirstAsync();
        }

        public static async Task<TDestination> ProjectToFirstAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return await queryable.Where(predicate).ProjectTo<TDestination>(config).DecompileAsync().FirstAsync();
        }

        public static async Task<TDestination> ProjectToFirstAsync<TDestination>(this IQueryable queryable)
        {
            return await queryable.ProjectTo<TDestination>().DecompileAsync().FirstAsync();
        }

        public static async Task<TDestination> ProjectToFirstAsync<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return await queryable.Where(predicate).ProjectTo<TDestination>().DecompileAsync().FirstAsync();
        }

        public static List<TDestination> ProjectToList<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).Decompile().ToList();
        }

        public static List<TDestination> ProjectToList<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().Decompile().ToList();
        }

        public static TDestination[] ProjectToArray<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).Decompile().ToArray();
        }

        public static TDestination[] ProjectToArray<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().Decompile().ToArray();
        }

        public static TDestination ProjectToSingleOrDefault<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).Decompile().SingleOrDefault();
        }

        public static TDestination ProjectToSingleOrDefault<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config).Decompile().SingleOrDefault();
        }

        public static TDestination ProjectToSingleOrDefault<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().Decompile().SingleOrDefault();
        }

        public static TDestination ProjectToSingleOrDefault<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>().Decompile().SingleOrDefault();
        }

        public static TDestination ProjectToSingle<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).Decompile().Single();
        }

        public static TDestination ProjectToSingle<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config).Decompile().Single();
        }

        public static TDestination ProjectToSingle<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().Decompile().Single();
        }

        public static TDestination ProjectToSingle<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>().Decompile().Single();
        }

        public static TDestination ProjectToFirstOrDefault<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).Decompile().FirstOrDefault();
        }

        public static TDestination ProjectToFirstOrDefault<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config).Decompile().FirstOrDefault();
        }

        public static TDestination ProjectToFirstOrDefault<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().Decompile().FirstOrDefault();
        }

        public static TDestination ProjectToFirstOrDefault<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>().Decompile().FirstOrDefault();
        }

        public static TDestination ProjectToFirst<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).Decompile().First();
        }

        public static TDestination ProjectToFirst<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate, IConfigurationProvider config)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>(config).Decompile().First();
        }

        public static TDestination ProjectToFirst<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().Decompile().First();
        }

        public static TDestination ProjectToFirst<TSource, TDestination>(this IQueryable<TSource> queryable, Expression<Func<TSource, bool>> predicate)
        {
            return queryable.Where(predicate).ProjectTo<TDestination>().Decompile().First();
        }

        public static IQueryable<TDestination> ProjectToQueryable<TDestination>(this IQueryable queryable, IConfigurationProvider config)
        {
            return queryable.ProjectTo<TDestination>(config).Decompile();
        }

        public static IQueryable<TDestination> ProjectToQueryable<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().Decompile();
        }
    }
}
