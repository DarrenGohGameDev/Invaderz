using UnityEngine;


[CreateAssetMenu(fileName = "BaseProjectileStat", menuName = "ScriptableObjects/BaseProjectileStat")]
public class BaseProjectileStat : ScriptableObject
{
    public int totalProjectile;
    public float projectileSpeed;
    public int projectileDamage;
    public int projectileTeam;
}
