﻿namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct ParamsOfMnemonicVerify
    {
        /// <summary>
        ///     Phrase.
        /// </summary>
        public string Phrase { get; set; }

        /// <summary>
        ///     Dictionary identifier.
        /// </summary>
        public byte? Dictionary { get; set; }

        /// <summary>
        ///     Mnemonic word count.
        /// </summary>
        public byte? WordCount { get; set; }
    }
}
