using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MoonShooter.Models
{
    [CreateAssetMenu(fileName = "PlayerRBModelData", menuName = "ScriptableObjects/Models/PlayerRBModelData")]
    public class PlayerRBModelData : ScriptableObject
    {
        [SerializeField] private float powerLanding;

        public float PowerLanding => powerLanding;
    }
}