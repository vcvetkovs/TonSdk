using System;
using System.Runtime.InteropServices;
using TonSdk.Interop.Enums;
using TonSdk.Interop.Models;

namespace TonSdk.Interop
{
    internal class TonAdapter
    {
        /// <summary>
        /// Create context using provided <c>config</c> with configuration json.
        /// Returned string is a JSON with the result or the error.
        /// <para></para>
        /// Result is returned in form of <c>{ "result": context }</c> where <c>context</c> is a number with context handle.
        /// Error is returned in form <c>{ "error": { error fields } }</c>.
        /// <para></para>
        /// Note: <c>tc_create_context</c> doesn't store pointer passed in config parameter.
        /// So it is safe to free this memory after the function returns.
        /// 
        /// </summary>
        [DllImport(Consts.LibPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tc_create_context(InteropString config);

        /// <summary>
        /// Closes and releases all resources that was allocated and opened by library during serving functions related to provided context.
        /// </summary>
        [DllImport(Consts.LibPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern int tc_destroy_context(uint context);

        /// <summary>
        /// Read string by pointer.
        /// Returned value is the internal string data.
        /// </summary>
        [DllImport(Consts.LibPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern InteropString tc_read_string(IntPtr stringPointer);

        /// <summary>
        /// Destroys rust string provided by <c>str</c> pointer.
        /// </summary>
        [DllImport(Consts.LibPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void tc_destroy_string(IntPtr stringPointer);

        [DllImport(Consts.LibPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tc_request_sync(
            uint context,
            InteropString methodName,
            InteropString paramsJson);

        /// <summary>
        /// Handles responses from the library.
        /// Note that an application can receive an unlimited count of responses related to single request.
        /// </summary>
        /// <param name="requestId">the request to which this response is addressed.</param>
        /// <param name="resultJsonData">response parameters encoded into JSON string.</param>
        /// <param name="status"> type of this response:
        /// <c>RESULT = 0</c>, function result.
        /// <c>ERROR = 1</c>, function execution error.
        /// <c>NOP = 2</c>, no operation. In combination with <c>finished = true</c> signals that the request handling was finished.
        /// <c>RESERVED = 3..99</c> – reserved for protocol internal purposes. Application(or binding) must ignore this response. Nevertheless the binding must check the finished flag to release data, associated with request.
        /// <c>STREAM = 100..</c> - additional function data related to request handling. Depends on the function.</param>
        /// <param name="isFinished">is a signal to release all additional data associated with the request. It is last response for specified request_id.</param>
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
        public delegate void ResponseHandler(
            uint requestId,
            InteropString resultJsonData,
            FunctionExecutionStatus status,
            bool isFinished);

        /// <summary>
        /// When application requires to invoke some ton client function it sends a function request to the library.
        /// </summary>
        /// <param name="context">Client internal context created in <see cref="tc_create_context"></see></param>
        /// <param name="functionName">function name requested.</param>
        /// <param name="paramsJson">function parameters encoded as a JSON string. If a function hasn't parameters then en empty string must be passed.</param>
        /// <param name="requestId">application (or binding) defined request identifier. Usually binding allocates and stores some additional data with every request. This data will help in the future to properly route responses to the application.</param>
        /// <param name="responseHandler">function that will receive responses related to this request.</param>
        [DllImport(Consts.LibPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr tc_request(
            uint context,
            InteropString functionName,
            InteropString paramsJson,
            uint requestId,
            [MarshalAs(UnmanagedType.FunctionPtr)] ResponseHandler responseHandler);

        [DllImport(Consts.LibPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern InteropJsonResponse tc_read_json_response(IntPtr response);

        [DllImport(Consts.LibPath, CallingConvention = CallingConvention.Cdecl)]
        public static extern void tc_destroy_json_response(IntPtr response);
    }
}
