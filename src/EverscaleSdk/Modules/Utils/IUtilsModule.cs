using System.Threading.Tasks;
using EverscaleSdk.Modules.Utils.Models;

namespace EverscaleSdk.Modules.Utils
{
    /// <summary>
    ///     Misc utility Functions.
    /// </summary>
    public interface IUtilsModule
    {
        /// <summary>
        ///     Converts address from any TON format to any TON format.
        /// </summary>
        Task<string> ConvertAddress(ParamsOfConvertAddress @params);

        /// <summary>
        ///     Converts address from any TON format to 'AccountId' TON format.
        /// 
        ///     Examples: <para/>
        ///     
        ///     fcb91a3a3816d0f7b8c2c76108b8a9bc5a6b7a55bd79f8ab101c52db29232260 -> fcb91a3a3816d0f7b8c2c76108b8a9bc5a6b7a55bd79f8ab101c52db29232260 <para/>
        ///     
        ///     Uf/8uRo6OBbQ97jCx2EIuKm8Wmt6Vb15+KsQHFLbKSMiYG+ -> fcb91a3a3816d0f7b8c2c76108b8a9bc5a6b7a55bd79f8ab101c52db29232260
        /// </summary>
        Task<string> ConvertAddressToAccountId(string address);

        /// <summary>
        ///     Converts address from any TON format to 'AccountId' TON format.
        /// 
        ///     Examples: <para/>
        ///     
        ///     0:fcb91a3a3816d0f7b8c2c76108b8a9bc5a6b7a55bd79f8ab101c52db29232260 -> 0:fcb91a3a3816d0f7b8c2c76108b8a9bc5a6b7a55bd79f8ab101c52db29232260 <para/>
        ///     
        ///     Uf/8uRo6OBbQ97jCx2EIuKm8Wmt6Vb15+KsQHFLbKSMiYG+ -> 0:fcb91a3a3816d0f7b8c2c76108b8a9bc5a6b7a55bd79f8ab101c52db29232260
        /// </summary>
        Task<string> ConvertAddressToHex(string address);

        /// <summary>
        ///     Converts address from any TON format to 'AccountId' TON format.
        /// 
        ///     Examples: <para/>
        ///     
        ///     Uf/8uRo6OBbQ97jCx2EIuKm8Wmt6Vb15+KsQHFLbKSMiYG+9 -> Uf/8uRo6OBbQ97jCx2EIuKm8Wmt6Vb15+KsQHFLbKSMiYG+9 <para/>
        ///     
        ///     fcb91a3a3816d0f7b8c2c76108b8a9bc5a6b7a55bd79f8ab101c52db29232260 -> Uf/8uRo6OBbQ97jCx2EIuKm8Wmt6Vb15+KsQHFLbKSMiYG+9
        /// </summary>
        Task<string> ConvertAddressToBase64(string address, bool url = false, bool test = false, bool bounce = false);

        /// <summary>
        ///     Address types are the following:
        ///     
        ///     <list type="bullet">
        ///      <item>
        ///       <term>
        ///         0:919db8e740d50bf349df2eea03fa30c385d846b991ff5542e67098ee833fc7f7
        ///       </term>
        ///       <description>
        ///         standard TON address most commonly used in all cases. Also called as hex address
        ///       </description>
        ///      </item>
        ///      <item>
        ///       <term>
        ///         919db8e740d50bf349df2eea03fa30c385d846b991ff5542e67098ee833fc7f7
        ///       </term>
        ///       <description>
        ///         account ID. A part of full address. Identifies account inside particular workchain
        ///       </description>
        ///      </item>
        ///      <item>
        ///       <term>
        ///         EQCRnbjnQNUL80nfLuoD+jDDhdhGuZH/VULmcJjugz/H9wam
        ///       </term>
        ///       <description>
        ///         base64 address. Also called "user-friendly".
        ///         Was used at the beginning of TON. Now it is supported for compatibility
        ///       </description>
        ///      </item>
        ///     </list>
        /// </summary>
        Task<ResultOfGetAddressType> GetAddressType(ParamsOfGetAddressType @params);

        /// <summary>
        ///     Calculates storage fee for an account over a specified time period.
        /// </summary>
        Task<ResultOfCalcStorageFee> CalcStorageFee(ParamsOfCalcStorageFee @params);

        /// <summary>
        ///     Compresses data using Zstandard algorithm.
        /// </summary>
        Task<ResultOfCompressZstd> CompressZstd(ParamsOfCompressZstd @params);

        /// <summary>
        ///     Decompresses data using Zstandard algorithm.
        /// </summary>
        Task<ResultOfDecompressZstd> DecompressZstd(ParamsOfDecompressZstd @params);
    }
}
