namespace EverscaleSdk.Modules.Boc.Models
{
    public abstract class BocCacheType
    {
        /// <summary>
        ///     Such BOC will not be removed from cache until it is unpinned.
        /// </summary>
        public class Pinned : BocCacheType
        {
            public string Pin { get; set; }
        }

        public class Unpinned : BocCacheType
        {
        }
    }
}
