using UnityEngine;

public class ProjectileMovemntComponent : MonoBehaviour
{
    private Rigidbody2D projectileRb;

    public Vector2 movingDirection;

    private void Start()
    {
        projectileRb = this.GetComponent<Rigidbody2D>();
    }

    public void MoveProjectile()
    {
        projectileRb.MovePosition(projectileRb.position + (movingDirection * GameManager.instance.currentGameSpeed));
    }
}
