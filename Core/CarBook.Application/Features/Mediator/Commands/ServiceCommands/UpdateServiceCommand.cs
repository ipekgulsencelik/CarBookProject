﻿using MediatR;

namespace CarBook.Application.Features.Mediator.Commands.ServiceCommands
{
    public class UpdateServiceCommand : IRequest
    {
        public int ServiceID { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public string? Icon { get; set; }
        public bool IsActive { get; set; }
        public bool IsShown { get; set; }
    }
}