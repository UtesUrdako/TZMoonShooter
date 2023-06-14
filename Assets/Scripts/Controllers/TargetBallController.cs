using MoonShooter.Models;
using UnityEngine;

namespace MoonShooter.Controllers
{
    public class TargetBallController : MonoBehaviour, IDamageable
    {
        [SerializeField] private TargetBallModelData targetBallModel;
        private TargetBallModel model;

        private void Awake()
        {
            model = new TargetBallModel(targetBallModel);
        }

        public void Damage(float value)
        {
            model.SubstractHitPoint(value);
            if (model.IsDestroy)
                Destroy(gameObject);
        }
    }
}