﻿namespace TonSdk.Models
{
    public class TransactionFees
    {
        public ulong InMsgFwdFee { get; set; }

        public ulong StorageFee { get; set; }

        public ulong GasFee { get; set; }

        public ulong OutMsgsFwdFee { get; set; }

        public ulong TotalAccountFees { get; set; }

        public ulong TotalOutput { get; set; }
    }
}
