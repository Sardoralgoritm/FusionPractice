[DataContract, MemoryPackable]
[ParameterComparer(typeof(ByValueParameterComparer))]
public partial class CategoryView
{
    [property: DataMember] public long Id { get; set; }
    [property: DataMember] public string Name { get; set; } = string.Empty;
}
