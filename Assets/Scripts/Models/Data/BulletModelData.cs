using UnityEngine;

namespace MoonShooter.Models
{
    [CreateAssetMenu(fileName = "BulletModelData", menuName = "ScriptableObjects/Models/BulletModelData")]
    public class BulletModelData : ScriptableObject
    {
        [SerializeField] private float baseSpeed;
        [SerializeField] private float baseDamage;

        public float BaseSpeed => baseSpeed;
        public float BaseDamage => baseDamage;
    }
}