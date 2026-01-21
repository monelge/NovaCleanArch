using Domain.Entities;
using Nova.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IOtpAuthenticatorRepository : IAsyncRepository<OtpAuthenticator, Guid>, IRepository<OtpAuthenticator, Guid> { }
