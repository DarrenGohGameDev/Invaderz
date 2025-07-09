using UnityEngine;

public class ShootingComponent : MonoBehaviour
{
    [SerializeField] private float fireRate = 1f;

    [SerializeField] private ProjectileComponent projectile;

    public int totalShootingProjectile = 1;

    public void Shoot()
    {
        SpawnProjectile(totalShootingProjectile);
    }

    private void SpawnProjectile(int total)
    {
        for (int i = 0; i < total; i++)
        {
            ProjectileComponent newProjectile = Instantiate(projectile, this.gameObject.transform.localPosition, Quaternion.identity);
            newProjectile.Init(this.gameObject.transform.up);
        }
    }

    public void ChangeProjectileType(ProjectileComponent newProjectile)
    {
        projectile = newProjectile;
    }
}
