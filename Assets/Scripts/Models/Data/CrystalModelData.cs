using MoonShooter.Controllers;
using UnityEngine;

namespace MoonShooter.Models
{
    [CreateAssetMenu(fileName = "CrystalModelData", menuName = "ScriptableObjects/Models/CrystalModelData")]
    public class CrystalModelData : ScriptableObject
    {
        [SerializeField] private ShardController shardPrefab;
        [SerializeField] private int countShard;
        [SerializeField] private int minCountDropShard;
        [SerializeField] private int maxCountDropShard;

        public ShardController ShardPrefab => shardPrefab;
        public int CountShard => countShard;
        public int MinCountDropShard => minCountDropShard;
        public int MaxCountDropShard => maxCountDropShard;
    }
}