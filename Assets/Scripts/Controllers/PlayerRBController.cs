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
        private float startHeight;
        private float maxHeight = 1.7f;
        private float forceHeight;

        private void Awake()
        {
            firstPersonController = GetComponent<RigidbodyFirstPersonController>();
            playerRBModel = new PlayerRBModel(GetComponent<Rigidbody>(), GetComponentInChildren<WeaponController>());
        }

        private void Start()
        {
            startHeight = transform.position.y;
        }

        private void Update()
        {
            if (Input.GetKey(KeyCode.Space))
                ForseLanding();

            if (Input.GetKeyDown(KeyCode.Space))
                forceHeight = transform.position.y;

            if (Input.GetMouseButton(0))
                Shoot();

            if (transform.position.y > maxHeight)
                maxHeight = transform.position.y;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Crystal") && Input.GetKey(KeyCode.Space))
            {
                var target = other.GetComponent<IDamageable>();
                float delta = forceHeight - startHeight;
                float maxDelta = maxHeight = startHeight;
                target.Damage(delta / maxDelta);
            }
            else if (other.CompareTag("Shard"))
            {
                other.GetComponent<ShardController>().DestroyShard();
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
        }
    }
}