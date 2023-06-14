using UnityEngine;

namespace MoonShooter.Models
{
    [CreateAssetMenu(fileName = "SceneModelData", menuName = "ScriptableObjects/Models/SceneModelData")]
    public class SceneModelData : ScriptableObject
    {
        [SerializeField] private GameObject crystalPrefab;
        [SerializeField] private float sizeSpawnZone;
        [SerializeField] private int minCrystalsInScene;
        [SerializeField] private int maxCrystalsInScene;

        public GameObject CrystalPrefab => crystalPrefab;
        public float SizeSpawnZone => sizeSpawnZone;
        public int MinCrystalsInScene => minCrystalsInScene;
        public int MaxCrystalsInScene => maxCrystalsInScene;
    }
}