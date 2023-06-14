using UnityEngine;

namespace MoonShooter.Models
{
    [CreateAssetMenu(fileName = "WeaponModelData", menuName = "ScriptableObjects/Models/WeaponModelData")]
    public class WeaponModelData : ScriptableObject
    {
        [SerializeField] private GameObject bulletPrefab;
        [SerializeField] private float cooldownShoot;
        [SerializeField] private float powerRecoil;
    }
}