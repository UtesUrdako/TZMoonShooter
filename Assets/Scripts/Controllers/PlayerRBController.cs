using MoonShooter.Models;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

namespace MoonShooter.Controllers
{
    public class PlayerRBController : MonoBehaviour
    {
        [SerializeField] private PlayerRBModelData playerRBModelData;

        private RigidbodyFirstPersonController firstPersonController;
        private PlayerRBModel playerRBModel;

        private void Awake()
        {
            firstPersonController = GetComponent<RigidbodyFirstPersonController>();
            playerRBModel = new PlayerRBModel(GetComponent<Rigidbody>(), GetComponentInChildren<WeaponController>());
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.Space))
                ForseLanding();

            if (Input.GetMouseButton(0))
                Shoot();
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider.CompareTag("Crystal"))
            {
                //var power = collision.contacts[0].point.magnitude;
                //Debug.Log($"Power landing {power}");
            }
        }

        private void Shoot()
        {
            playerRBModel.WeaponController.Shoot();
        }

        private void ForseLanding()
        {
            playerRBModel.PlayerRigidbody.velocity = playerRBModelData.PowerLanding * Vector3.down;
        }

        public void Recoil(Vector3 direction)
        {
            firstPersonController.Jump(direction);
            return;

            //var position = transform.position;
            //position.y += 0.4f;
            //transform.position = position;

            var velocity = playerRBModel.PlayerRigidbody.velocity;
            velocity.x += direction.x / 6f;
            velocity.y = direction.y;
            velocity.z += direction.z / 6f;
            playerRBModel.PlayerRigidbody.velocity = velocity;
        }
    }
}