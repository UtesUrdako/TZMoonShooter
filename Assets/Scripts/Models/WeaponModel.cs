using MoonShooter.Controllers;

namespace MoonShooter.Models
{
    public class WeaponModel
    {
        private PlayerRBController playerController;
        private WeaponModelData weaponModelData;
        private BulletModelData bulletModelData;
        private bool cooldown;
        private int powerBonus;
        private float speed;
        private float damage;

        public PlayerRBController PlayerController => playerController;
        public float PowerPecoil => weaponModelData.PowerRecoil;
        public bool Cooldown { get => cooldown; set => cooldown = value; }
        public float CooldownTime => weaponModelData.CooldownShoot;
        public int PowerBonus { get => powerBonus; set => powerBonus = value; }
        public float Speed { get => speed; set => speed = value; }
        public float Damage { get => damage; set => damage = value; }

        public WeaponModel(PlayerRBController playerController, WeaponModelData weaponModelData, BulletModelData bulletModelData)
        {
            this.playerController = playerController;
            this.weaponModelData = weaponModelData;
            this.bulletModelData = bulletModelData;
            this.cooldown = false;
            this.powerBonus = 0;
            this.speed = bulletModelData.BaseSpeed;
            this.damage = bulletModelData.BaseDamage;
        }
    }
}