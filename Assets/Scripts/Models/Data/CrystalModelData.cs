using UnityEngine;

namespace MoonShooter.Models
{
    [CreateAssetMenu(fileName = "CrystalModelData", menuName = "ScriptableObjects/Models/CrystalModelData")]
    public class CrystalModelData : ScriptableObject
    {
        [SerializeField] private int minCountDropShard;
        [SerializeField] private int maxCountDropShard;

        public int MinCountDropShard => minCountDropShard;
        public int MaxCountDropShard => maxCountDropShard;
    }
}