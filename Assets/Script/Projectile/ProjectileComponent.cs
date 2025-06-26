using Unity.VisualScripting;
using UnityEngine;

public class ProjectileComponent : MonoBehaviour
{
    private HealthComponent projectileHealthComponent;

    public BaseProjectileStat projectileStat;

    protected ProjectileMovemntComponent projectileMovementComponent;

    public ProjectileComponent(Vector2 projectileMovingDirection)
    {
        projectileMovementComponent.movingDirection = projectileMovingDirection;
    }

    protected virtual void Start()
    {
        projectileHealthComponent = this.GetComponent<HealthComponent>();
    }

    protected virtual void Update()
    {
        projectileMovementComponent.MoveProjectile();
    }
}
