﻿namespace EverscaleSdk.Modules.Crypto.Models
{
    public struct ParamsOfScrypt
    {
        /// <summary>
        ///     The password bytes to be hashed.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>base64</c>.
        /// </remarks>
        public string Password { get; set; }

        /// <summary>
        ///     A salt bytes that modifies the hash to protect against Rainbow table attacks.
        /// </summary>
        /// <remarks>
        ///     Encoded with <c>base64</c>.
        /// </remarks>
        public string Salt { get; set; }

        /// <summary>
        ///     CPU/memory cost parameter.
        /// </summary>
        public byte LogN { get; set; }

        /// <summary>
        ///     The block size parameter, which fine-tunes sequential memory read size and performance.
        /// </summary>
        public uint R { get; set; }

        /// <summary>
        ///     Parallelization parameter.
        /// </summary>
        public uint P { get; set; }

        /// <summary>
        ///     Intended output length in octets of the derived key.
        /// </summary>
        public uint DkLen { get; set; }
    }
}
