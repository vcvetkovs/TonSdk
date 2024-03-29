﻿namespace EverscaleSdk.Modules.Net.Enums
{
	public enum NetErrorCode
    {
        QueryFailed = 601,
        SubscribeFailed = 602,
        WaitForFailed = 603,
        GetSubscriptionResultFailed = 604,
        InvalidServerResponse = 605,
        ClockOutOfSync = 606,
        WaitForTimeout = 607,
        GraphqlError = 608,
        NetworkModuleSuspended = 609,
        WebsocketDisconnected = 610,
        NotSupported = 611,
        NoEndpointsProvided = 612,
        GraphqlWebsocketInitError = 613,
        NetworkModuleResumed = 614,
    }
}
