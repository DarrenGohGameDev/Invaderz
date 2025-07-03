using Unity.VisualScripting;
using UnityEngine;

public class ProjectileComponent : MonoBehaviour
{
    private HealthComponent projectileHealthComponent;

    [SerializeField] protected BaseProjectileStat projectileStat;

    protected ProjectileMovemntComponent projectileMovementComponent;

    public ProjectileComponent(Vector2 projectileMovingDirection)
    {
        projectileMovementComponent.movingDirection = projectileMovingDirection;
    }

    protected virtual void Start()
    {
        projectileHealthComponent = this.GetComponent<HealthComponent>();
        projectileHealthComponent.onTakeDamage += OnProjectileDamaged;
        projectileHealthComponent.onDeath += OnProjectileDestroyed;
    }

    protected virtual void Update()
    {
        projectileMovementComponent.MoveProjectile();
    }

    public BaseProjectileStat GetProjectileStat()
    {
        return projectileStat;
    }

    protected virtual void OnProjectileDamaged(float amount)
    {
        // projectile take damage animation playing or stuff to trigger here
    }

    protected virtual void OnProjectileDestroyed()
    {
        // destroy the projectile or something
    }
}
