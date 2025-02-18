﻿using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.FeatureCommands
{
    public class CreateFeatureCommand : IRequest
    {
        public string? Name { get; set; }
        public bool IsActive { get; set; } = true;
    }
}