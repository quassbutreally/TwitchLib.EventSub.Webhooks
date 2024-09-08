﻿using TwitchLib.EventSub.Webhooks.Core.Models;
using TwitchLib.EventSub.Core.SubscriptionTypes.User;

namespace TwitchLib.EventSub.Webhooks.Core.EventArgs.User
{
    public class UserWhisperMessageArgs : TwitchLibEventSubEventArgs<EventSubNotificationPayload<UserWhisperMessage>>
    { }
}