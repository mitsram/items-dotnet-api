using Items.Domain.Entities;

namespace Items.Application.Services.Authentication;

public record AuthenticationResult(
    User User,
    string Token
);