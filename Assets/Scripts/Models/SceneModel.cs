using UnityEngine;

namespace MoonShooter.Models
{
    public class SceneModel
    {
        private SceneModelData sceneModelData;

        public GameObject CrystalPrefab => sceneModelData.CrystalPrefab;
        public int MinCrystalsInScene => sceneModelData.MinCrystalsInScene;
        public int MaxCrystalsInScene => sceneModelData.MaxCrystalsInScene;
    }
}