using MoonShooter.Models;
using UnityEngine;

namespace MoonShooter.Controllers
{
    public class BulletController : MonoBehaviour
    {
        private BulletModel bulletModel;

        public void Initialize(float speed, float damage)
        {
            bulletModel = new BulletModel();
            bulletModel.speed = speed;
            bulletModel.damage = damage;
        }

        private void Update()
        {
            transform.position += transform.forward * bulletModel.speed * Time.deltaTime;
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("TargetBall"))
            {
                var target = other.GetComponent<IDamageable>();
                target.Damage(bulletModel.damage);
                Destroy(gameObject);
            }
        }
    }
}