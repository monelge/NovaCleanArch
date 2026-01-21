using Domain.Entities;
using Nova.Core.Persistence.Repositories;

namespace Application.Services.Repositories;

public interface IEmailAuthenticatorRepository
    : IAsyncRepository<EmailAuthenticator, Guid>,
        IRepository<EmailAuthenticator, Guid> { }
