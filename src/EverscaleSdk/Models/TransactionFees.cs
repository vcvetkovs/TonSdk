namespace EverscaleSdk.Models
{
    public struct TransactionFees
    {
        /// <summary>
        ///     <c>Deprecated</c>. <para/>
        ///     
        ///     Left for backward compatibility.
        ///     Does not participate in account transaction fees calculation.
        /// </summary>
        public ulong InMsgFwdFee { get; set; }

        /// <summary>
        ///     Fee for account storage.
        /// </summary>
        public ulong StorageFee { get; set; }

        /// <summary>
        ///     Fee for processing.
        /// </summary>
        public ulong GasFee { get; set; }

        /// <summary>
        ///     <c>Deprecated.</c> <para/>
        ///     
        ///     Contains the same data as total_fwd_fees field.
        /// </summary>
        /// <remarks>
        ///     Deprecated because of its confusing name,
        ///     that is not the same with GraphQL API Transaction type's field.
        /// </remarks>
        public ulong OutMsgsFwdFee { get; set; }

        /// <summary>   
        ///     <c>Deprecated.</c> <para/>
        ///     
        ///     This is the field that is named as <c>total_fees</c> in
        ///     GraphQL API Transaction type.
        ///     <see cref="TotalAccountFees"/> name is misleading,
        ///     because it does not mean account fees, instead it means
        ///     validators total fees received for the transaction execution.
        ///     It does not include some forward fees that account actually pays
        ///     now, but validators will receive later during value delivery to
        ///     another account (not even in the receiving transaction). <para/>
        ///     
        ///     Because of all of this, this field is not interesting for those
        ///     who wants to understand the real account fees, this is why it is
        ///     deprecated and left for backward compatibility.
        /// </summary>
        public ulong TotalAccountFees { get; set; }

        /// <summary>
        ///     <c>Deprecated.</c>
        /// </summary>
        /// <remarks>
        ///     Deprecated because it means total value sent in the transaction,
        ///     which does not relate to any fees.
        /// </remarks>
        public ulong TotalOutput { get; set; }

        /// <summary>
        ///     Fee for inbound external message import.
        /// </summary>
        public ulong ExtInMsgFee { get; set; }

        /// <summary>
        ///     Total fees the account pays for message forwarding.
        /// </summary>
        public ulong TotalFwdFees { get; set; }

        /// <summary>
        ///     Total account fees for the transaction execution.
        ///     Compounds of storage_fee + gas_fee + ext_in_msg_fee + total_fwd_fees
        /// </summary>
        public ulong AccountFees { get; set; }
    }
}
