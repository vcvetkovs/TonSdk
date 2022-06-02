using System;
using System.Collections.Generic;
using System.Text;

namespace EverscaleSdk.Modules.Processing.Enums
{
    public enum ProcessingErrorCode
    {
        MessageAlreadyExpired = 501,
        MessageHasNotDestinationAddress = 502,
        CanNotBuildMessageCell = 503,
        FetchBlockFailed = 504,
        SendMessageFailed = 505,
        InvalidMessageBoc = 506,
        MessageExpired = 507,
        TransactionWaitTimeout = 508,
        InvalidBlockReceived = 509,
        CanNotCheckBlockShard = 510,
        BlockNotFound = 511,
        InvalidData = 512,
        ExternalSignerMustNotBeUsed = 513,
    }
}
