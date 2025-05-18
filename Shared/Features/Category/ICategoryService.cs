public interface ICategoryService : IComputeService
{
    [ComputeMethod]
    Task<List<CategoryView>> GetAll(CancellationToken cancellationToken = default);

    [ComputeMethod]
    Task<CategoryView> Get(long Id, CancellationToken cancellationToken = default);

    [CommandHandler]
    Task Create(CreateCategoryCommand command, CancellationToken cancellationToken = default);

    [CommandHandler]
    Task Update(UpdateCategoryCommand command, CancellationToken cancellationToken = default);

    [CommandHandler]
    Task Delete(DeleteCategoryCommand command, CancellationToken cancellationToken = default);

    Task<Unit> Invalidate() { return TaskExt.UnitTask; }
}
