using ModelReplacement;
using UnityEngine;

namespace realisticscavenger
{
    public class MRFIXEDSCAV : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        { 
            string model_name = "fixedscav";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }
}