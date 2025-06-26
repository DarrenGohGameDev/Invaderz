using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D playerRb;

    public Vector2 moveInput;

    public float moveSpeed = 1f;

    void Start()
    {
        playerRb = this.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (moveInput != Vector2.zero)
        {
            playerRb.MovePosition(playerRb.position + (moveInput * GameManager.instance.currentGameSpeed));
        }
    }

    public void Move(Vector2 direction)
    {
        moveInput.x = direction.x * moveSpeed;
    }
}
