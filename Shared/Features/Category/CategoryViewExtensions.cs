public partial class CategoryView
{
    public static explicit operator CategoryView(CategoryEntity entity)
        => new()
        {
            Id = entity.Id,
            Name = entity.Name
        };


    public static implicit operator CategoryEntity(CategoryView view)
        => new()
        {
            Id = view.Id,
            Name = view.Name
        };


    public override bool Equals(object? o)
    {
        var other = o as CategoryView;
        return other?.Id == Id;
    }

    public override int GetHashCode() => Id.GetHashCode();
}