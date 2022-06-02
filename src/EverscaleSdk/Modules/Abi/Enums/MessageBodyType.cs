namespace EverscaleSdk.Modules.Abi.Enums
{
    public enum MessageBodyType : byte
    {
        /// <summary>
        ///     Message contains the input of the ABI function.
        /// </summary>
        Input,

        /// <summary>
        ///     Message contains the output of the ABI function.
        /// </summary>
        Output,

        /// <summary>
        ///     Occurs when contract sends an internal message to other
        ///     contract.
        /// </summary>
        InternalOutput,

        /// <summary>
        ///     Message contains the input of the ABI event.
        /// </summary>
        Event,
    }
}
