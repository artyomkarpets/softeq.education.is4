﻿using MediatR;
using TrialsSystem.UsersService.Infrastructure.Models.UserDTOs;

namespace TrialsSystem.UsersService.Api.Application.Commands.DeviceCommands
{
    public class CreateDeviceCommand : IRequest<CreateUserRequest>
    {
        public CreateDeviceCommand(string serialNumber,
            string model,
            string userId)
        {
            SerialNumber = serialNumber;
            Model = model;
            UserId = userId;
        }

        public string SerialNumber { get; }

        public string Model { get; }

        public string UserId { get; }

    }
}
