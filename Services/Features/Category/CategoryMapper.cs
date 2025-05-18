public static class CategoryMapper
{
    public static List<CategoryView> MapToViewList(this IEnumerable<CategoryEntity> categories)
        => categories.Select(MapToView).ToList();

    public static CategoryView MapToView(this CategoryEntity categoryEntity)
        => (CategoryView)categoryEntity;
}