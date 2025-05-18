public class CategoryService(IServiceProvider services) : DbServiceBase<AppDbContext>(services), ICategoryService
{
    #region Query

    public virtual async Task<List<CategoryView>> GetAll(CancellationToken cancellationToken = default)
    {
        await Invalidate();
        await using var dbContext = await DbHub.CreateDbContext(cancellationToken);
        //var categories = from s in dbContext.Categories select s;
        //var items = await categories.AsNoTracking().ToListAsync(cancellationToken: cancellationToken);
        return new();
    }

    public virtual async Task<CategoryView> Get(long Id, CancellationToken cancellationToken = default)
    {
        await Invalidate();
        await using var dbContext = await DbHub.CreateDbContext(cancellationToken);
        //var organization = await dbContext.Categories.AsNoTracking().FirstOrDefaultAsync(x => x.Id == Id, cancellationToken);
        //if (organization is null)
        //{
        //    throw new NotFoundException("Category not found!");
        //}

        return new();
    }

    #endregion

    #region Mutation

    public virtual async Task Create(CreateCategoryCommand command, CancellationToken cancellationToken = default)
    {
        if (Invalidation.IsActive)
        {
            _ = await Invalidate();
            return;
        }
        await using var dbContext = await DbHub.CreateOperationDbContext(cancellationToken);
        CategoryEntity organization = (CategoryEntity)command.Entity;
        //dbContext.Categories.Add(organization);
        await dbContext.SaveChangesAsync(cancellationToken);
    }

    public virtual async Task Update(UpdateCategoryCommand command, CancellationToken cancellationToken = default)
    {
        if (Invalidation.IsActive)
        {
            _ = await Invalidate();
            return;
        }
        await using var dbContext = await DbHub.CreateOperationDbContext(cancellationToken);
        //var organization = await dbContext.Categories.FirstOrDefaultAsync(x => x.Id == command.Entity.Id, cancellationToken);
        //if (organization is null)
        //{
        //    throw new NotFoundException("Category not found!");
        //}

        //organization = (CategoryEntity)command.Entity;
        //dbContext.Categories.Update(organization);
        await dbContext.SaveChangesAsync(cancellationToken);
    }

    public virtual async Task Delete(DeleteCategoryCommand command, CancellationToken cancellationToken = default)
    {
        if (Invalidation.IsActive)
        {
            _ = await Invalidate();
            return;
        }
        await using var dbContext = await DbHub.CreateOperationDbContext(cancellationToken);
        //var organization = await dbContext.Categories.FirstOrDefaultAsync(x => x.Id == command.Id, cancellationToken);
        //if (organization is null)
        //{
        //    throw new NotFoundException("Category not found!");
        //}
        //dbContext.Categories.Remove(organization);
        await dbContext.SaveChangesAsync(cancellationToken);
    }

    #endregion

    #region Helpers

    [ComputeMethod]
    public virtual Task<Unit> Invalidate() => TaskExt.UnitTask;

    #endregion
}