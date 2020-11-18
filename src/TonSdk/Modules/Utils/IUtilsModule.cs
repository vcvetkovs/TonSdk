using System.Threading.Tasks;

namespace TonSdk.Modules.Utils
{
    /// <summary>
    /// Misc utility Functions.
    /// </summary>
    public interface IUtilsModule
    {
        /// Converts address from any TON format to 'AccountId' TON format.
        /// 
        /// <para>
        /// Examples:
        /// </para>
        /// <para>
        ///   fcb91a3a3816d0f7b8c2c76108b8a9bc5a6b7a55bd79f8ab101c52db29232260 -> fcb91a3a3816d0f7b8c2c76108b8a9bc5a6b7a55bd79f8ab101c52db29232260
        /// </para>
        /// <para>  
        ///  Uf/8uRo6OBbQ97jCx2EIuKm8Wmt6Vb15+KsQHFLbKSMiYG+ -> fcb91a3a3816d0f7b8c2c76108b8a9bc5a6b7a55bd79f8ab101c52db29232260
        /// </para>
        /// </summary>
        Task<string> ConvertAddressToAccountId(string address);

        /// <summary>
        /// Converts address from any TON format to 'AccountId' TON format.
        /// 
        /// <para>
        /// Examples:
        /// </para>
        /// <para>
        ///   0:fcb91a3a3816d0f7b8c2c76108b8a9bc5a6b7a55bd79f8ab101c52db29232260 -> 0:fcb91a3a3816d0f7b8c2c76108b8a9bc5a6b7a55bd79f8ab101c52db29232260
        /// </para>
        /// <para>  
        ///  Uf/8uRo6OBbQ97jCx2EIuKm8Wmt6Vb15+KsQHFLbKSMiYG+ -> 0:fcb91a3a3816d0f7b8c2c76108b8a9bc5a6b7a55bd79f8ab101c52db29232260
        /// </para>
        /// </summary>
        Task<string> ConvertAddressToHex(string address);

        /// <summary>
        /// Converts address from any TON format to 'AccountId' TON format.
        /// 
        /// <para>
        /// Examples:
        /// </para>
        /// <para>
        ///  Uf/8uRo6OBbQ97jCx2EIuKm8Wmt6Vb15+KsQHFLbKSMiYG+9 -> Uf/8uRo6OBbQ97jCx2EIuKm8Wmt6Vb15+KsQHFLbKSMiYG+9
        /// </para>
        /// <para>  
        ///  fcb91a3a3816d0f7b8c2c76108b8a9bc5a6b7a55bd79f8ab101c52db29232260 -> Uf/8uRo6OBbQ97jCx2EIuKm8Wmt6Vb15+KsQHFLbKSMiYG+9
        /// </para>
        /// </summary>
        Task<string> ConvertAddressToBase64(string address, bool url = false, bool test = false, bool bounce = false);
    }
}
