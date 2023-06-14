using MoonShooter.Models;
using UnityEngine;

namespace MoonShooter.Controllers
{
    public class CrystallController : MonoBehaviour, IDamageable
    {
        [SerializeField] private CrystalModelData data;
        private CrystalModel model;

        private void Awake()
        {
            model = new CrystalModel(data);
        }

        public void Damage(float value)
        {
            int count = (int)(data.MaxCountDropShard * value);
            count = model.SubstractShards(count);
            for (int i = 0; i < count; i++)
                Instantiate(data.ShardPrefab, transform.position, Quaternion.AngleAxis(Random.Range(0, 360), Vector3.up));

            if (model.CountShards <= 0)
                Destroy(gameObject);
        }
    }
}