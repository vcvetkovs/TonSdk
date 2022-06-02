namespace EverscaleSdk.Modules.Debot.Models
{
	public struct DebotAction
    {
        /// <summary>
        ///     A short action description.
        ///     Should be used by Debot Browser as name of menu item.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     Depends on action type.
        ///     Can be a debot function name or a print string (for Print Action).
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Action type.
        /// </summary>
        public byte ActionType { get; set; }

        /// <summary>
        ///     ID of debot context to switch after action execution. 
        /// </summary>
        public byte To { get; set; }

        /// <summary>
        ///     Action attributes. In the form of "param=value,flag".
        ///     attribute example: instant, args, fargs, sign.
        /// </summary>
        public string Attributes { get; set; }

        /// <summary>
        ///     Some internal action data. Used by debot only.
        /// </summary>
        public string Misc { get; set; }
    }
}
