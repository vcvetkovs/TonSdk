namespace EverscaleSdk.Interop.Models
{
    public struct ResultOfFunctionCall<T>
    {
        public T Result { get; set; }
        public ClientError? Error { get; set; }
    }
}
