using UnityEngine;

public class ProjectileMovementComponent : MonoBehaviour
{
    private Rigidbody2D projectileRb;

    private Vector2 movingDirection;

    private void Awake()
    {
        projectileRb = this.GetComponent<Rigidbody2D>();
    }

    public void MoveProjectile(float projectileSpeed)
    {
        projectileRb.MovePosition(projectileRb.position + (movingDirection * projectileSpeed * GameManager.instance.currentGameSpeed));
    }

    public void SetProjectileDirection(Vector2 direction)
    {
        movingDirection = direction;
    }
}
