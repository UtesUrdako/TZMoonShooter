using MoonShooter.Controllers;
using UnityEngine;

namespace MoonShooter.Models
{
    [CreateAssetMenu(fileName = "WeaponModelData", menuName = "ScriptableObjects/Models/WeaponModelData")]
    public class WeaponModelData : ScriptableObject
    {
        [SerializeField] private BulletController bulletPrefab;
        [SerializeField] private float cooldownShoot;
        [SerializeField] private float powerRecoil;

        public BulletController BulletPrefab => bulletPrefab;
        public float CooldownShoot => cooldownShoot;
        public float PowerRecoil => powerRecoil;
    }
}