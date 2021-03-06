using GraphProcessor;
using Object = UnityEngine.Object;

namespace mitaywalle.AssetProcessGraph.Nodes
{
    //[Serializable, NodeMenuItem("Process/Node Name", typeof(AssetProcessGraph))]
    public abstract class ProcessAssetNode : AssetProcessGraphNode
    {
        [Input("Assets")] protected Object[] assets;
        [Output("Assets")] protected Object[] outputAssets;

        public override string ToString()
        {
            return $"assets {assets?.Length} | outputAssets {outputAssets?.Length}";
        }
        protected override void Process()
        {
            foreach (Object asset in assets)
            {
                ProcessAsset(asset);
            }

            outputAssets = assets;
        }

        protected abstract void ProcessAsset(Object asset);
    }
}