﻿namespace EverscaleSdk.Modules.Tvm.Enums
{
    public enum TvmErrorCode
    {
        CanNotReadTransaction = 401,
        CanNotReadBlockchainConfig = 402,
        TransactionAborted = 403,
        InternalError = 404,
        ActionPhaseFailed = 405,
        AccountCodeMissing = 406,
        LowBalance = 407,
        AccountFrozenOrDeleted = 408,
        AccountMissing = 409,
        UnknownExecutionError = 410,
        InvalidInputStack = 411,
        InvalidAccountBoc = 412,
        InvalidMessageType = 413,
        ContractExecutionError = 414,
    }
}
