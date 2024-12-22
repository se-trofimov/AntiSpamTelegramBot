﻿global using Microsoft.Azure.Functions.Worker;
global using Microsoft.Extensions.Logging;
global using System.Text.Json;
global using Telegram.Bot;
global using Telegram.Bot.Types;
global using Telegram.Bot.Types.Enums;
global using TelegramAntiSpamBot.OpenAI;
global using TelegramAntiSpamBot.Persistence;
global using TelegramAntiSpamBot.Persistence.Entities;
global using Microsoft.Extensions.Hosting;
global using Microsoft.Extensions.DependencyInjection;
global using System.ComponentModel.DataAnnotations;
global using Microsoft.Extensions.Options;
global using Microsoft.Extensions.Configuration;
global using TelegramAntiSpamBot.Functions;
global using System.Net;
global using Microsoft.Azure.Functions.Worker.Middleware;