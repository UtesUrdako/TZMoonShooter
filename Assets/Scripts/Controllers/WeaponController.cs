using InnerProtocol;
using MoonShooter.Models;
using UnityEngine;

namespace MoonShooter.Controllers
{
    public class WeaponController : MonoBehaviour
    {
        [SerializeField] private Weapon weapon;
        [SerializeField] private PlayerRBController playerController;
        [SerializeField] private WeaponModelData weaponModelData;
        [SerializeField] private BulletModelData bulletModelData;

        private CustomSignal onPowerUp;

        private WeaponModel model;

        private void Awake()
        {
            model = new WeaponModel(playerController, weaponModelData, bulletModelData);
            onPowerUp = PowerUp;
            Translator.Add<BaseProtocol>(onPowerUp);
        }

        public void Shoot()
        {
            if (model.Cooldown) return;
            model.Cooldown = true;

            CreateBullet();

            model.PlayerController.Recoil(-transform.forward);

            Invoke(nameof(Cooldown), model.CooldownTime);
        }

        private void Cooldown()
        {
            model.Cooldown = false;
        }

        private void CreateBullet()
        {
            var bullet = Instantiate(weaponModelData.BulletPrefab, weapon.ShootPoint.position, weapon.ShootPoint.rotation);
            bullet.Initialize(model.Speed, model.Damage);
            Translator.Send(BaseProtocol.Shoot);
        }

        public void PowerUp(System.Enum code)
        {
            switch (code)
            {
                case BaseProtocol.PowerUp:
                    {
                        model.PowerBonus += 1;
                        model.Speed += bulletModelData.BaseSpeed * 0.1f;
                        model.Damage += model.Damage * 0.2f;

                        Translator.Send(BaseProtocol.PowerUpMessage, new StringArray { value = new string[2] { model.Speed.ToString(), model.Damage.ToString() } });
                    }
                    break;
            }
        }
    }
}