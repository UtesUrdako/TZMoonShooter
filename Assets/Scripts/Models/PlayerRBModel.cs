using MoonShooter.Controllers;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

namespace MoonShooter.Models
{
    public class PlayerRBModel
    {
        private Rigidbody playerRigidbody;
        private WeaponController weaponController;

        public Rigidbody PlayerRigidbody => playerRigidbody;
        public WeaponController WeaponController => weaponController;

        public PlayerRBModel(Rigidbody playerController, WeaponController weaponController)
        {
            this.playerRigidbody = playerController;
            this.weaponController = weaponController;
        }
    }
}