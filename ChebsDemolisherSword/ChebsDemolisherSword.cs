using System;
using System.IO;
using BepInEx;
using Jotunn;
using Jotunn.Managers;
using Jotunn.Utils;
using UnityEngine;

namespace ChebsDemolisherSword
{
    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    [BepInDependency(Main.ModGuid)]
    [NetworkCompatibility(CompatibilityLevel.NotEnforced, VersionStrictness.None)]
    internal class ChebsDemolisherSword : BaseUnityPlugin
    {
        public const string PluginGuid = "com.chebgonaz.chebsdemolishersword";
        public const string PluginName = "ChebsDemolisherSword";
        public const string PluginVersion = "1.2.1";

        private Mesh _demolisherSwordMesh;
        private Material _demolisherSwordMaterial;

        private void Awake()
        {
            LoadAssetBundle();

            PrefabManager.OnVanillaPrefabsAvailable += DoOnVanillaPrefabsAvailable;
        }

        private void DoOnVanillaPrefabsAvailable()
        {
            PrefabManager.OnVanillaPrefabsAvailable -= DoOnVanillaPrefabsAvailable;

            var demolisherHammerPrefab = PrefabManager.Instance.GetPrefab("SledgeDemolisher");
            if (demolisherHammerPrefab == null)
            {
                Logger.LogError("Failed to get demolisher hammer prefab");
                return;
            }

            var meshFilter = demolisherHammerPrefab.GetComponentInChildren<MeshFilter>(true);
            if (meshFilter == null)
            {
                Logger.LogError("Failed to get demolisher hammer prefab's mesh filter");
                return;
            }
            
            meshFilter.mesh = _demolisherSwordMesh;

            var meshRenderer = demolisherHammerPrefab.GetComponentInChildren<MeshRenderer>(true);
            if (meshRenderer == null)
            {
                Logger.LogError("Failed to get demolisher hammer prefab's mesh renderer");
                return;
            }
            
            meshRenderer.sharedMaterial = _demolisherSwordMaterial;
        }

        private void LoadAssetBundle()
        {
            var assetBundlePath = Path.Combine(Path.GetDirectoryName(Info.Location), "enclavesix");
            var chebgonazAssetBundle = AssetUtils.LoadAssetBundle(assetBundlePath);
            try
            {
                _demolisherSwordMesh = chebgonazAssetBundle.LoadAsset<Mesh>("EnclaveSix_DemolisherSwordMesh");
                _demolisherSwordMaterial = chebgonazAssetBundle.LoadAsset<Material>("EnclaveSix_DemolisherSwordMaterial");
            }
            catch (Exception ex)
            {
                Logger.LogWarning($"Exception caught while loading assets: {ex}");
            }
            finally
            {
                chebgonazAssetBundle.Unload(false);
            }
        }
    }
}