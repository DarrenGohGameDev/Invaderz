using UnityEngine;

public class DamagingProjectileComponent : ProjectileComponent
{
    public DamagingProjectileComponent(Vector2 projectileMovingDirection) : base(projectileMovingDirection)
    {
        
    }

    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
    }

    private void OnTriggerEnter(Collider other)
    {
        HealthComponent collidedHealthComponent;

        if (!other.TryGetComponent<HealthComponent>(out collidedHealthComponent)) return;

        ProjectileComponent collidedProjectile;

        if (other.TryGetComponent<ProjectileComponent>(out collidedProjectile) && collidedProjectile.projectileStat.projectileTeam == projectileStat.projectileTeam) return;

        collidedHealthComponent.TakeDamage(projectileStat.projectileDamage);
    }
}
