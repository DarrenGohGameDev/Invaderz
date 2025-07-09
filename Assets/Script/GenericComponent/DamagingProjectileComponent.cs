using UnityEngine;

public class DamagingProjectileComponent : ProjectileComponent
{
    protected override void Awake()
    {
        base.Awake();
    }

    protected override void FixedUpdate()
    {
        base.FixedUpdate();
    }

    public override void Init(Vector2 direction)
    {
        base.Init(direction);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log($"{other.gameObject.name}");
        HealthComponent collidedHealthComponent;

        if (!other.TryGetComponent<HealthComponent>(out collidedHealthComponent)) return;

        ProjectileComponent collidedProjectile;

        if (other.TryGetComponent<ProjectileComponent>(out collidedProjectile) && collidedProjectile.GetProjectileStat().projectileTeam == projectileStat.projectileTeam) return;

        projectileHealthComponent.Die();
        collidedHealthComponent.TakeDamage(projectileStat.projectileDamage);
    }
}
