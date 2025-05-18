[DataContract, MemoryPackable]
public partial record CreateCategoryCommand([property: DataMember] Session Session, [property: DataMember] CategoryView Entity) : ISessionCommand<CategoryView>;

[DataContract, MemoryPackable]
public partial record UpdateCategoryCommand([property: DataMember] Session Session, [property: DataMember] CategoryView Entity) : ISessionCommand<CategoryView>;

[DataContract, MemoryPackable]
public partial record DeleteCategoryCommand([property: DataMember] Session Session, [property: DataMember] long Id) : ISessionCommand<CategoryView>;
