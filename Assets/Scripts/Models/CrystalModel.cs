using System.Collections;
using System.Collections.Generic;

namespace MoonShooter.Models
{
    public class CrystalModel
    {
        private CrystalModelData crystalModelData;
        private int countShards;

        public int CountShards => countShards;
        public int MinCountDropShard => crystalModelData.MinCountDropShard;
        public int MaxCountDropShard => crystalModelData.MaxCountDropShard;
    }
}