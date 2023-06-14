namespace MoonShooter.Models
{
    public class TargetBallModel
    {
        private TargetBallModelData targetBallModelData;

        public float currentHitPoint;

        public int MaxHitPoint => targetBallModelData.MaxHitPoint;
        public bool IsDestroy => currentHitPoint <= 0;

        public TargetBallModel(TargetBallModelData targetBallModelData)
        {
            this.targetBallModelData = targetBallModelData;
            currentHitPoint = MaxHitPoint;
        }

        public void SubstractHitPoint(float value)
        {
            currentHitPoint -= value;
        }
    }
}