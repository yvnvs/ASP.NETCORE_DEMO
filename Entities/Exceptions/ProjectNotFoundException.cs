namespace Entities.Exceptions;

public sealed class ProjectNotFoundException : NotFoundException
{
    public ProjectNotFoundException(Guid projecId) 
        : base($"The project with {projecId} does not exists.")
    {

    }
}