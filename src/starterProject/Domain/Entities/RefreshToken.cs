namespace Domain.Entities;

public class RefreshToken : Nova.Core.Security.Entities.RefreshToken<Guid, Guid>
{
    public virtual User User { get; set; } = default!;
}
