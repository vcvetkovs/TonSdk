﻿using System.Text.Json;

namespace EverscaleSdk.Modules.Abi.Models
{
    public struct StateInitParams
    {
        public Abi Abi { get; set; }
        public JsonElement Value { get; set; }
    }
}
