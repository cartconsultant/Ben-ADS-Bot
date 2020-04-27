﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using ADS.Bot.V1.Models;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.AI.Luis;
using Microsoft.Bot.Builder.AI.QnA;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Schema;
using Microsoft.Extensions.Configuration;
using System.Threading;
using System.Threading.Tasks;

namespace ADS.Bot1
{
    public interface IBotServices
    {
        IStatePropertyAccessor<UserProfile> UserProfileAccessor { get; }
        IStatePropertyAccessor<DialogState> DialogStateAccessor { get; }

        IConfiguration Configuration { get; }

        QnAMaker LeadQualQnA { get; }

        Task<UserProfile> GetUserProfileAsync(ITurnContext turnContext, CancellationToken cancellationToken);
        Task SetUserProfileAsync(UserProfile profile, ITurnContext turnContext, CancellationToken cancellationToken);
    }
}
