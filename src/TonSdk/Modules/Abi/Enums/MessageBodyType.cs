namespace TonSdk.Modules.Abi.Enums
{
    public enum MessageBodyType
    {
        /// <summary>
        /// Message contains the input of the ABI function.
        /// </summary>
        Input,

        /// <summary>
        /// Message contains the output of the ABI function.
        /// </summary>
        Output,

        /// <summary>
        /// Message contains the input of the imported ABI function.
        /// Occurs when contract sends an internal message to other
        /// contract.
        /// </summary>
        InternalOutput,

        /// <summary>
        /// Message contains the input of the ABI event.
        /// </summary>
        Event
    }
}
