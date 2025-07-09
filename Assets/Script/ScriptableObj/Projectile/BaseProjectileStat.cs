using UnityEngine;


[CreateAssetMenu(fileName = "BaseProjectileStat", menuName = "ScriptableObjects/BaseProjectileStat")]
public class BaseProjectileStat : ScriptableObject
{
    public float projectileSpeed;
    public int projectileDamage;
    public int projectileTeam;
    public float projectileLifeTime;

    public void ChangeSpeed(float speed)
    {
        projectileSpeed += speed;
    }

    public void ChangeDamage(int damage)
    {
        projectileDamage += damage;
    }
    
    public void ChangeProjectileTeam(int teamId)
    {
        projectileTeam = teamId;
    }
    
    public void ChangeLifeTime(float lifeTime)
    {
        projectileLifeTime += lifeTime;
    }
}
