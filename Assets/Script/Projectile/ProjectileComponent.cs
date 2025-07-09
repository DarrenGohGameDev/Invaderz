using Unity.VisualScripting;
using UnityEngine;

public class ProjectileComponent : MonoBehaviour
{
    protected HealthComponent projectileHealthComponent;

    [SerializeField] protected BaseProjectileStat projectileStat;

    protected ProjectileMovementComponent projectileMovementComponent;

    private float projectileDuration;

    protected virtual void Awake()
    {
        projectileHealthComponent = this.GetComponent<HealthComponent>();
        projectileHealthComponent.onTakeDamage += OnProjectileDamaged;
        projectileHealthComponent.onDeath += OnProjectileDestroyed;
        projectileMovementComponent = this.GetComponent<ProjectileMovementComponent>();
    }

    protected virtual void FixedUpdate()
    {
        projectileMovementComponent.MoveProjectile(projectileStat.projectileSpeed);

        ProjectileLifeTimer();
    }

    public virtual void Init(Vector2 direction)
    {
        projectileMovementComponent.SetProjectileDirection(direction);
        projectileDuration = projectileStat.projectileLifeTime;
    }

    public BaseProjectileStat GetProjectileStat()
    {
        return projectileStat;
    }

    protected virtual void ProjectileLifeTimer()
    {
        projectileDuration -= Time.deltaTime;

        if (projectileDuration <= 0f)
        {
            projectileHealthComponent.Die();
        }
    }

    protected virtual void OnProjectileDamaged(float amount)
    {
        // projectile take damage animation playing or stuff to trigger here
    }

    protected virtual void OnProjectileDestroyed()
    {
        // destroy the projectile or something
        Destroy(this.gameObject);
    }
}
