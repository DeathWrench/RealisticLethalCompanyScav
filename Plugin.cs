using BepInEx;
using HarmonyLib;
using UnityEngine;
using System.Reflection;
using ModelReplacement;
using System;
using System.Xml.Linq;
using DunGen;

namespace realisticscavenger
{
    [BepInPlugin("DeathWrench.RealisticScavengers", "Realistic Scavengers", "0.1.2")]
    [BepInDependency("meow.ModelReplacementAPI", BepInDependency.DependencyFlags.HardDependency)]

    public class Plugin : BaseUnityPlugin
    {
        private void Awake()
        { 
            Assets.PopulateAssets();

            // Plugin startup logic
            ModelReplacementAPI.RegisterSuitModelReplacement("Default", typeof(OranScav));
            ModelReplacementAPI.RegisterSuitModelReplacement("Orange suit", typeof(OranScav));
            ModelReplacementAPI.RegisterSuitModelReplacement("Green suit", typeof(GreeScav));
            ModelReplacementAPI.RegisterSuitModelReplacement("Pajama suit", typeof(PajaScav));
            ModelReplacementAPI.RegisterSuitModelReplacement("Hazard suit", typeof(HazaScav));
            ModelReplacementAPI.RegisterSuitModelReplacement("Purple suit", typeof(PurpScav));

            Harmony harmony = new Harmony("com.realisticscav.battle");
            harmony.PatchAll();
            Logger.LogInfo($"Plugin {"com.realisticscav.battle"} is loaded!");
        }
    }
    public static class Assets
    {
        // Replace mbundle with the Asset Bundle Name from your unity project 
        public static string mainAssetBundleName = "RealsticScavenger";
        public static AssetBundle MainAssetBundle = null;

        private static string GetAssemblyName() => Assembly.GetExecutingAssembly().GetName().Name.Replace(" ","_");
        public static void PopulateAssets()
        {
            if (MainAssetBundle == null)
            {
                Console.WriteLine(GetAssemblyName() + "." + mainAssetBundleName);
                using (var assetStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(GetAssemblyName() + "." + mainAssetBundleName))
                {
                    MainAssetBundle = AssetBundle.LoadFromStream(assetStream);
                }

            }
        }
    }

}