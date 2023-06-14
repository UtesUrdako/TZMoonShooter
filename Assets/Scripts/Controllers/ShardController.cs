using InnerProtocol;
using PureAnimator;
using UnityEngine;

namespace MoonShooter.Controllers
{
    public class ShardController : MonoBehaviour
    {
        public AnimationCurve curve;
        private Collider collider;

        private void Awake()
        {
            collider = GetComponent<Collider>();
        }

        private void Start()
        {
            JumpAnimationData data = new JumpAnimationData();
            data.duration = 0.5f;
            Vector2 direction = Random.insideUnitCircle;
            float distance = direction.magnitude;
            data.curve = curve;
            data.heightJump = distance / 2f;
            data.endMove = transform.position + new Vector3(direction.x, 0, direction.y) * 2f;

            collider.enabled = false;
            PureAnimationAPI.PlayCurveJump(transform, data, () => { collider.enabled = true; });
        }

        public void DestroyShard()
        {
            Destroy(gameObject);
            Translator.Send(BaseProtocol.PowerUp);
        }
    }
}