using System;
using System.Threading.Tasks;
using TonSdk.Modules.Debot.Models;

namespace TonSdk.Modules.Debot
{
	/// <summary>
	///     Module for working with debot.
	/// </summary>
	public interface IDebotModule
    {
        /// <summary>
        ///     Downloads debot smart contract (code and data) from blockchain and creates
        ///     an instance of Debot Engine for it.
        /// </summary>
        /// <remarks>
        ///     It does not switch debot to context 0. Browser Callbacks are not called.
        /// </remarks>
        Task<RegisteredDebot> Init(ParamsOfInit @params, Func<ParamsOfAppDebotBrowser, Task<ResultOfAppDebotBrowser>> callback);

        /// <summary>
        ///     Starts an instance of debot.
        /// </summary>
        /// <remarks>
        ///     Downloads debot smart contract from blockchain and switches it to
        ///     context zero.
        ///  <para/>
        ///     Returns a debot handle which can be used later in <see cref="Execute(ParamsOfExecute)"/> function.
        ///  <para/>
        ///     This function must be used by Debot Browser to start a dialog with debot.
        ///     While the function is executing, several Browser Callbacks can be called,
        ///     since the debot tries to display all actions from the context 0 to the user.
        ///  <para/>
        ///     When the debot starts SDK registers `BrowserCallbacks` AppObject.
        ///     Therefore when <see cref="Remove(RegisteredDebot)"/> is called the debot is being deleted and the callback is called
        ///     with `finish`=`true` which indicates that it will never be used again.
        ///  <para/>
        ///     <see cref="Start(ParamsOfStart)"/> is equivalent to
        ///     <see cref="Fetch(ParamsOfFetch)"/> + switch to context 0.
        ///  <para/>
        /// </remarks>
        Task Start(ParamsOfStart @params);

        /// <summary>
        ///     Fetches debot from blockchain.
        /// </summary>
        /// <remarks>
        ///     Downloads debot smart contract (code and data) from blockchain and creates 
        ///     an instance of Debot Engine for it.
        ///  <para/>
        ///     It does not switch debot to context 0. Browser Callbacks are not called.
        ///  <para/>
        /// </remarks>
        Task<ResultOfFetch> Fetch(ParamsOfFetch @params);

        /// <summary>
        ///     Executes debot action.
        /// </summary>
        /// <remarks>
        ///     Calls debot engine referenced by debot handle to execute input action.
        ///  <para/>
        ///     Calls Debot Browser Callbacks if needed.
        ///  <para/>
        ///     Chain of actions can be executed if input action generates a list of subactions.
        ///  <para/>
        /// </remarks>
        Task Execute(ParamsOfExecute @params);

        /// <summary>
        ///     Destroys debot handle.
        /// </summary>
        /// <remarks>
        ///     Removes handle from Client Context and drops debot engine referenced by that handle.
        /// </remarks>
        Task Remove(RegisteredDebot @params);

        /// <summary>
        ///     Used by Debot Browser to send response on Dinterface call or from other Debots.
        /// </summary>
        Task Send(ParamsOfSend @params);
    }
}
