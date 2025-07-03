using UnityEngine;

public class ShootingComponent : MonoBehaviour
{
    [SerializeField] private float fireRate = 1f;

    [SerializeField] private ProjectileComponent projectile;

    public bool autoShoot = false;

    private void Update()
    {
        if(autoShoot)
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        
    }
}
