namespace MoonShooter.Models
{
    public class TargetBallModel
    {
        private TargetBallModelData targetBallModelData;

        public int currentHitPoint;

        public int MaxHitPoint => targetBallModelData.MaxHitPoint;
    }
}