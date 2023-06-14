using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private Transform shootPoint;

    public Transform ShootPoint => shootPoint;
}
