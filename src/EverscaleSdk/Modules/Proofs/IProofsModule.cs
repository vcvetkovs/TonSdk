﻿using System.Threading.Tasks;
using EverscaleSdk.Modules.Proofs.Models;

namespace EverscaleSdk.Modules.Proofs
{
	public interface IProofsModule
    {
        /// <summary>
        ///     Proves that a given block's data, which is queried from TONOS API, can be trusted.
        /// </summary>
        /// <remarks>
        ///     This function checks block proofs and compares given data with the proven.
        ///     If the given data differs from the proven, the exception will be thrown.
        ///     The input param is a single block's JSON object, which was queried from DApp server using
        ///     functions such as <see cref="Net.INetModule.Query(Net.Models.ParamsOfQuery)"/>,
        ///     <see cref="Net.INetModule.QueryCollection(Net.Models.ParamsOfQueryCollection)"/>
        ///     or
        ///     <see cref="Net.INetModule.WaitForCollection(Net.Models.ParamsOfWaitForCollection)"/>.
        ///     If block's BOC is not provided in the JSON, it will be queried from DApp server
        ///     (in this case it is required to provide at least <c>id</c> of block). <para/>
        ///     
        ///     Please note, that joins (like <c>signatures</c> in <c>Block</c>) are separated entities and not supported,
        ///     so function will throw an exception in a case if JSON being checked has such entities in it. <para/>
        ///     
        ///     If <c>cache_in_local_storage</c> in config is set to <see langword="true"/> (default), downloaded proofs and
        ///     master-chain BOCs are saved into the persistent local storage(e.g.file system for native
        ///     environments or browser's IndexedDB for the web); otherwise all the data is cached only in
        ///     memory in current client's context and will be lost after destruction of the client. <para/>
        ///
        ///
        ///     <c>Why Proofs are needed</c> <br/>
        ///     
        ///     Proofs are needed to ensure that the data downloaded from a DApp server is real blockchain
        ///     data. Checking proofs can protect from the malicious DApp server which can potentially provide
        ///     fake data, or also from "Man in the Middle" attacks class. <para/>
        ///     
        ///     <c>What Proofs are</c> <br/>
        ///     
        ///     Simply, proof is a list of signatures of validators', which have signed this particular master-
        ///     block. <para/>
        ///     
        ///     The very first validator set's public keys are included in the zero-state. Whe know a root hash
        ///     of the zero-state, because it is stored in the network configuration file, it is our authority
        ///     root.For proving zero-state it is enough to calculate and compare its root hash. <para/>
        ///     
        ///     In each new validator cycle the validator set is changed.The new one is stored in a key-block,
        ///     which is signed by the validator set, which we already trust, the next validator set will be
        ///     stored to the new key-block and signed by the current validator set, and so on. <para/>
        ///     
        ///     In order to prove any block in the master-chain we need to check, that it has been signed by
        ///     a trusted validator set. So we need to check all key-blocks' proofs, started from the zero-state
        ///     and until the block, which we want to prove.But it can take a lot of time and traffic to
        ///     download and prove all key-blocks on a client. For solving this, special trusted blocks are used
        ///     in Ever-SDK. <para/>
        ///     
        ///     The trusted block is the authority root, as well, as the zero-state.Each trusted block is the
        ///     <c>id</c> (e.g. <c>root_hash</c>) of the already proven key-block. There can be plenty of trusted
        ///     blocks, so there can be a lot of authority roots. The hashes of trusted blocks for MainNet
        ///     and DevNet are hardcoded in SDK in a separated binary file(trusted_key_blocks.bin) and is
        ///     being updated for each release by using <c>update_trusted_blocks</c> utility. <para/>
        ///     
        ///     See <see href="https://github.com/tonlabs/ever-sdk/blob/bfa5cb4d26f7451c58737f39fd3c29c35481a189/tools/update_trusted_blocks">
        ///     update_trusted_blocks</see> directory for more info. <para/>
        ///     
        ///     In future SDK releases, one will also be able to provide their hashes of trusted blocks for
        ///     other networks, besides for MainNet and DevNet.
        ///     By using trusted key-blocks, in order to prove any block, we can prove chain of key-blocks to
        ///     the closest previous trusted key-block, not only to the zero-state. <para/>
        ///     
        ///     But shard-blocks don't have proofs on DApp server. In this case, in order to prove any shard-
        ///     block data, we search for a corresponding master-block, which contains the root hash of this
        ///     shard-block, or some shard block which is linked to that block in shard-chain.After proving
        ///     this master-block, we traverse through each link and calculate and compare hashes with links,
        ///     one-by-one.After that we can ensure that this shard-block has also been proven.
        /// </remarks>
        public Task ProofBlockData(ParamsOfProofBlockData @params);

        /// <summary>
        ///     Proves that a given transaction's data, which is queried from TONOS API, can be trusted.
        /// </summary>
        /// <remarks>
        ///     This function requests the corresponding block, checks block proofs, ensures that given
        ///     transaction exists in the proven block and compares given data with the proven.
        ///     If the given data differs from the proven, the exception will be thrown.
        ///     The input parameter is a single transaction's JSON object (see params description),
        ///     which was queried from TONOS API using functions such as 
        ///     <see cref="Net.INetModule.Query(Net.Models.ParamsOfQuery)"/>,
        ///     <see cref="Net.INetModule.QueryCollection(Net.Models.ParamsOfQueryCollection)"/>
        ///     or
        ///     <see cref="Net.INetModule.WaitForCollection(Net.Models.ParamsOfWaitForCollection)"/>.
        ///     
        ///     If transaction's BOC and/or <c>block_id</c> are not provided in the JSON, they will be queried from
        ///     TONOS API.
        ///     
        ///     Please note, that joins (like <c>account</c>, <c>in_message</c>, <c>out_messages</c>, etc. in <c>Transaction</c>
        ///     entity) are separated entities and not supported, so function will throw an exception in a case
        ///     if JSON being checked has such entities in it.
        ///     
        ///     For more information about proofs checking, see description of <see cref="ProofBlockData(ParamsOfProofBlockData)"/> function.
        /// </remarks>
        public Task ProofTransactionData(ParamsOfProofTransactionData @params);

        /// <summary>
        ///     Proves that a given message's data, which is queried from TONOS API, can be trusted.
        /// </summary>
        /// <remarks>
        ///     This function first proves the corresponding transaction, ensures that the proven transaction
        ///     refers to the given message and compares given data with the proven.
        ///     If the given data differs from the proven, the exception will be thrown.
        ///     The input parameter is a single message's JSON object (see params description),
        ///     which was queried from TONOS API using functions such as 
        ///     <see cref="Net.INetModule.Query(Net.Models.ParamsOfQuery)"/>,
        ///     <see cref="Net.INetModule.QueryCollection(Net.Models.ParamsOfQueryCollection)"/>
        ///     or
        ///     <see cref="Net.INetModule.WaitForCollection(Net.Models.ParamsOfWaitForCollection)"/>. <para/>
        ///     
        ///     If message's BOC and/or non-null <c>src_transaction.id</c> or <c>dst_transaction.id</c>
        ///     are not provided in the JSON, they will be queried from TONOS API. <para/>
        ///     
        ///     Please note, that joins (like <c>block</c>, <c>dst_account</c>, <c>dst_transaction</c>, <c>src_account</c>,
        ///     <c>src_transaction</c>, etc. in <c>Message</c> entity) are separated entities and not supported,
        ///     so function will throw an exception in a case if JSON being checked has such entities in it.
        ///     
        ///     For more information about proofs checking, see description of <see cref="ProofBlockData(ParamsOfProofBlockData)"/> function.
        /// </remarks>
        public Task ProofMessageData(ParamsOfProofMessageData @params);
    }
}

