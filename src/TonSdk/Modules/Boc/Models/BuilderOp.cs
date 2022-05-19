using System.Text.Json;

namespace TonSdk.Modules.Boc.Models
{
    /// <summary>
    ///     Cell builder operation.
    /// </summary>
    public abstract class BuilderOp
    {
        /// <summary>
        ///     Append integer to cell data.
        /// </summary>
        public class Integer : BuilderOp
        {
            /// <summary>
            ///     Bit size of the value.
            /// </summary>
            public uint Size { get; set; }

            /// <summary>
            ///     Value: - <c>Number</c> containing integer number.
            /// </summary>
            /// <remarks>
            ///     e.g. <c>123</c>, <c>-123</c>. - Decimal string. e.g. <c>"123"</c>, <c>"-123"</c>.
            ///     - <c>0x</c> prefixed hexadecimal string.
            ///       e.g <c>0x123</c>, <c>0X123</c>, <c>-0x123</c>.
            /// </remarks>
            public JsonElement Value { get; set; }
        }

        /// <summary>
        ///     Append bit string to cell data.
        /// </summary>
        public class BitString : BuilderOp
        {
            /// <summary>
            ///     Contains hexadecimal string representation:
            ///     <list type="bullet">
            ///      <item>
            ///       <description>
            ///         Can end with <c>_</c> tag.
            ///       </description>
            ///      </item>
            ///      <item>
            ///       <description>
            ///         Can be prefixed with <c>x</c> or <c>X</c>.
            ///       </description>
            ///      </item>
            ///      <item>
            ///       <description>
            ///         Can be prefixed with <c>x{</c> or <c>X{</c> and ended with <c>}</c>.
            ///       </description>
            ///      </item>
            ///     </list>
            ///     
            ///         Contains binary string represented as a sequence
            ///         of <c>0</c> and <c>1</c> prefixed with <c>n</c> or <c>N</c>. <para/>
            ///     
            ///         Examples:
            ///         <c>1AB</c>, <c>x1ab</c>, <c>X1AB</c>, <c>x{1abc}</c>, <c>X{1ABC}</c>
            ///         <c>2D9_</c>, <c>x2D9_</c>, <c>X2D9_</c>, <c>x{2D9_}</c>, <c>X{2D9_}</c>
            ///         <c>n00101101100</c>, <c>N00101101100</c>
            /// </summary>
            public string Value { get; set; }
        }

        /// <summary>
        ///     Append ref to nested cells.
        /// </summary>
        public class Cell : BuilderOp
        {
            /// <summary>
            ///     Nested cell builder.
            /// </summary>
            public BuilderOp[] Builder { get; set; }
        }

        /// <summary>
        ///     Append ref to nested cell.
        /// </summary>
        public class CellBoc : BuilderOp
        {
            /// <summary>
            ///     Nested cell BOC encoded with <c>base64</c> or BOC cache key.
            /// </summary>
            public string Boc { get; set; }
        }

        /// <summary>
        ///     Address.
        /// </summary>
        public class Address : BuilderOp
        {
            /// <summary>
            ///     Address.
            /// </summary>
            public string AddressAccessor { get; set; }
        }
    }
}
