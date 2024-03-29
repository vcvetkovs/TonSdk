﻿using EverscaleSdk.Modules.Net.Enums;

namespace EverscaleSdk.Modules.Net.Models
{
    public struct FieldAggregation
    {
        /// <summary>
        ///     Dot separated path to the field.
        /// </summary>
        public string Field { get; set; }

        /// <summary>
        ///     Aggregation function that must be applied to field values.
        /// </summary>
        public AggregationFn Fn { get; set; }
    }
}
