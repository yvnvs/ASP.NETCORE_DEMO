namespace Shared.DataTransferObjects;

//[Serializable]
public record ProjectDto
{
    public Guid Id { get; init; }
    public string Name { get; init; }
    public string Description { get; init; }
    public string Field { get; init; }
}