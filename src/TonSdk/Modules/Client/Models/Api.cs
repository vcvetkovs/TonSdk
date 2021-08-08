namespace TonSdk.Modules.Client.Models
{
    public class Api : IApi
    {
        public string Version { get; set; }
        public ApiModuleDefinition[] Modules { get; set; }
    }
    public interface IApi
    {
        string Version { get; set; }
        ApiModuleDefinition[] Modules { get; set; }
    }

    public class ApiModuleDefinition : ApiItemDescription, IApiModuleDefinition
    {
        public ApiField[] Types { get; set; }
        public ApiFunction[] Functions { get; set; }
    }
    public interface IApiModuleDefinition : IApiItemDescription
    {
        ApiField[] Types { get; set; }
        ApiFunction[] Functions { get; set; }
    }

    public class ApiFunction : ApiItemDescription, IApiFunction
    {
        public ApiField[] Params { get; set; }
        public ApiType Result { get; set; }
        public ApiError[] Errors { get; set; }
    }
    public interface IApiFunction
    {
        ApiField[] Params { get; set; }
        ApiType Result { get; set; }
        ApiError[] Errors { get; set; }
    }

    public class ApiField : ApiType, IApiField
    {
        public string Name { get; set; }
        public string? Summary { get; set; }
        public string? Description { get; set; }
    }
    public interface IApiField : IApiType, IApiItemDescription
    {

    }

    public enum ApiConstValueIs
    {
        Unknown,
        None,
        Bool,
        String,
        Number
    }

    public class ApiConst : ApiItemDescription, IApiConst
    {
        public ApiConstValueIs Type { get; set; }
        public string? Value { get; set; }
    }
    public interface IApiConst : IApiItemDescription
    {
        ApiConstValueIs Type { get; set; }
        string? Value { get; set; }
    }

    public enum ApiTypeIs
    {
        Unknown,
        Ref,
        None,
        Any,
        Boolean,
        String,
        Number,
        BigInt,
        Optional,
        Array,
        Struct,
        EnumOfConsts,
        EnumOfTypes,
        Generic,
    }

    public class ApiRef : IApiRef
    {
        public ApiTypeIs Type { get; set; }
        public string RefName { get; set; }
    }
    public interface IApiRef
    {
        ApiTypeIs Type { get; set; }
        string RefName { get; set; }
    }

    public class ApiOptional : IApiOptional
    {
        public ApiTypeIs Type => ApiTypeIs.Optional;
        public ApiType OptionalInner { get; set; }
    }
    public interface IApiOptional
    {
        ApiTypeIs Type { get; }
        ApiType OptionalInner { get; set; }
    }

    public class ApiArray : IApiArray
    {
        public ApiTypeIs Type => ApiTypeIs.Array;
        public ApiType ArrayItem { get; set; }
    }
    public interface IApiArray
    {
        ApiTypeIs Type { get; }
        ApiType ArrayItem { get; set; }
    }

    public class ApiStruct : IApiStruct
    {
        public ApiTypeIs Type => ApiTypeIs.Struct;
        public ApiField[] StructFields { get; set; }
    }
    public interface IApiStruct
    {
        ApiTypeIs Type { get; }
        ApiField[] StructFields { get; set; }
    }

    public class ApiEnumOfConsts : IApiEnumOfConsts
    {
        public ApiTypeIs Type => ApiTypeIs.EnumOfConsts;
        public ApiConst[] EnumConsts { get; set; }
    }
    public interface IApiEnumOfConsts
    {
        ApiTypeIs Type { get; }
        ApiConst[] EnumConsts { get; set; }
    }

    public class ApiEnumOfTypes : IApiEnumOfTypes
    {
        public ApiTypeIs Type => ApiTypeIs.EnumOfTypes;
        public ApiField[] EnumTypes { get; set; }
    }
    public interface IApiEnumOfTypes
    {
        ApiTypeIs Type { get; }
        ApiField[] EnumTypes { get; set; }
    }

    public class ApiGeneric : IApiGeneric
    {
        public ApiTypeIs Type => ApiTypeIs.Generic;
        public string GenericName { get; set; }
        public ApiType[] GenericArgs { get; set; }
    }
    public interface IApiGeneric
    {
        ApiTypeIs Type { get; }
        string GenericName { get; set; }
        ApiType[] GenericArgs { get; set; }
    }

    public enum ApiNumberType
    {
        UInt,
        Int,
        Float,
    }

    public class ApiNumber : IApiNumber
    {
        public ApiTypeIs Type => ApiTypeIs.Number;
        public ApiNumberType NumberType { get; set; }
        public int NumberSize { get; set; }
    }
    public interface IApiNumber
    {
        ApiTypeIs Type { get; }
        ApiNumberType NumberType { get; set; }
        int NumberSize { get; set; }
    }

    public class ApiBigInt : IApiBigInt
    {
        public ApiTypeIs Type => ApiTypeIs.BigInt;
        public ApiNumberType NumberType { get; set; }
        public int NumberSize { get; set; }
    }
    public interface IApiBigInt
    {
        ApiTypeIs Type { get; }
        ApiNumberType NumberType { get; set; }
        int NumberSize { get; set; }
    }

    public class ApiType : IApiType
    {
        public ApiTypeIs Type { get; set; }
    }
    public interface IApiType
    {
        ApiTypeIs Type { get; set; }
    }

    // TODO: Finish
    //public class ApiType 
    //export type ApiType = {
    //    module: ApiModuleDefinition,
    //} & (
    //    { type: ApiTypeIs.None } |
    //    { type: ApiTypeIs.Any } |
    //    { type: ApiTypeIs.Boolean } |
    //    { type: ApiTypeIs.String } |
    //    ApiNumber |
    //    ApiBigInt |
    //    ApiRef |
    //    ApiOptional |
    //    ApiArray |
    //    ApiStruct |
    //    ApiEnumOfConsts |
    //    ApiEnumOfTypes |
    //    ApiGeneric);

    public class ApiError : IApiError
    {
        public int Number { get; set; }
        public string Message { get; set; }
        public object? Data { get; set; }
    }
    public interface IApiError
    {
        int Number { get; set; }
        string Message { get; set; }
        object? Data { get; set; }
    }

    public struct ApiFunctionInfo
    {
        public ApiField[]? Params { get; set; }
        private bool HasResponseHandler { get; set; }
    }

    public class ApiItemDescription : IApiItemDescription
    {
        public string Name { get; set; }
        public string? Summary { get; set; }
        public string? Description { get; set; }
    }
    public interface IApiItemDescription
    {
        public string Name { get; set; }
        public string? Summary { get; set; }
        public string? Description { get; set; }
    }
}
