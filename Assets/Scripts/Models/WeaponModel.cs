using UnityStandardAssets.Characters.FirstPerson;

namespace MoonShooter.Models
{
    public class WeaponModel
    {
        private RigidbodyFirstPersonController playerController;
        private WeaponModelData weaponModelData;
        private BulletModelData bulletModelData;
        private float cooldown;
        private int powerBonus;
        private float speed;
        private float damage;
    }
}