using System.Collections;
using System.Collections.Generic;

namespace MoonShooter.Models
{
    public class CrystalModel
    {
        private CrystalModelData crystalModelData;
        private int countShards;

        public CrystalModel(CrystalModelData crystalModelData)
        {
            this.crystalModelData = crystalModelData;
            countShards = crystalModelData.CountShard;
        }

        public int CountShards => countShards;
        public int MinCountDropShard => crystalModelData.MinCountDropShard;
        public int MaxCountDropShard => crystalModelData.MaxCountDropShard;

        public int SubstractShards(int value)
        {
            int ret = value > countShards ? countShards : value;
            countShards -= value;
            return ret;
        }
    }
}