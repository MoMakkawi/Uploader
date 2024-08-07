﻿using Application.Models.Attachments;

namespace Application.Models.Identities;

public class RegisterCommand
{
    public required string UserName { get; set; }
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string Email { get; set; }
    public required string Password { get; set; }

    public List<SaveAttachmentCommand>? Attachments { get; set; }
}
