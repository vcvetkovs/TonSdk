using System.Runtime.InteropServices;

namespace TonSdk.Interop.Models
{
    [StructLayout(LayoutKind.Sequential)]
    internal struct InteropJsonResponse
    {
        public InteropString ResultJson { get; set; }
        public InteropString ErrorJson { get; set; }
    }
}
