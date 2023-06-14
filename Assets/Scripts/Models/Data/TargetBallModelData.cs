using UnityEngine;

namespace MoonShooter.Models
{
    [CreateAssetMenu(fileName = "TargetBallModelData", menuName = "ScriptableObjects/Models/TargetBallModelData")]
    public class TargetBallModelData : ScriptableObject
    {
        [SerializeField] private int maxHitPoint;

        public int MaxHitPoint => maxHitPoint;
    }
}