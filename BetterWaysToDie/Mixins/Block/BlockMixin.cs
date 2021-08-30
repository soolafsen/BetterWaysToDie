using System;
using SharpILMixins.Annotations;
using SharpILMixins.Annotations.Inject;
using UnityEngine;

namespace BetterWaysToDie.Mixins.Block
{
    /// <summary>
    /// Allows us to hook in and create/modify blocks without using any XML
    /// </summary>
    [Mixin(typeof(global::Block))]
    public class BlockMixin
    {
        [Inject(BlockTargets.Methods.AssignIds, AtLocation.Head)]
        [Unique]
        private static void PostXmlCreateBlocks()
        {
            try
            {
                // var registry = new DictionaryRegistry<global::Block>();
                // Registry<global::Block>.Invoke(registry);
            }
            catch (Exception e)
            {
                Debug.LogError("Failed to call post xml hook");
                Debug.LogError(e.ToString());
            }
        }
    }
}
