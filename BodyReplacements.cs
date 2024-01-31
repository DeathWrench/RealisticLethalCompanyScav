using ModelReplacement;
using UnityEngine;

namespace realisticscavenger
{
    public class PurpScav : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            string model_name = "purplescav";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }
    public class OranScav : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            string model_name = "fixedscav";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }
    public class PajaScav : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            string model_name = "pajamascav";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }
    public class GreeScav : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            string model_name = "greenscav";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }
    public class HazaScav : BodyReplacementBase
    {
        protected override GameObject LoadAssetsAndReturnModel()
        {
            string model_name = "hazardscav";
            return Assets.MainAssetBundle.LoadAsset<GameObject>(model_name);
        }
    }
}
