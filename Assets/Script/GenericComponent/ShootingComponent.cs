using UnityEngine;

public class ShootingComponent : MonoBehaviour
{
    [SerializeField] private float fireRate = 1f;

    [SerializeField] private ProjectileComponent projectile;

    public bool autoShoot;

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
