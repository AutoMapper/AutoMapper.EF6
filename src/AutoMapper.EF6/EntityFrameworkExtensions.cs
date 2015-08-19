namespace AutoMapper
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Threading.Tasks;
    using QueryableExtensions;
    using DelegateDecompiler;
    using DelegateDecompiler.EntityFramework;

    public static class EntityFrameworkExtensions
    {
        public static Task<List<TDestination>> ProjectToListAsync<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().DecompileAsync().ToListAsync();
        }

        public static Task<TDestination[]> ProjectToArrayAsync<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().DecompileAsync().ToArrayAsync();
        }

        public static Task<TDestination> ProjectToSingleOrDefaultAsync<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().DecompileAsync().SingleOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToSingleAsync<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().DecompileAsync().SingleAsync();
        }

        public static Task<TDestination> ProjectToFirstOrDefaultAsync<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().DecompileAsync().FirstOrDefaultAsync();
        }

        public static Task<TDestination> ProjectToFirstAsync<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().DecompileAsync().FirstAsync();
        }

        public static List<TDestination> ProjectToList<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().Decompile().ToList();
        }

        public static TDestination[] ProjectToArray<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().Decompile().ToArray();
        }

        public static TDestination ProjectToSingleOrDefault<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().Decompile().SingleOrDefault();
        }

        public static TDestination ProjectToSingle<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().Decompile().Single();
        }

        public static TDestination ProjectToFirstOrDefault<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().Decompile().FirstOrDefault();
        }

        public static TDestination ProjectToFirst<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().Decompile().First();
        }

        public static IQueryable<TDestination> ProjectToQueryable<TDestination>(this IQueryable queryable)
        {
            return queryable.ProjectTo<TDestination>().Decompile();
        }
    }
}