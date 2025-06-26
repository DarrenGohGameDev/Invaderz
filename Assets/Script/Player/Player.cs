using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour 
{
    private PlayerMovement playerMovement;

    private InputManager playerInputManager;

    private HealthComponent playerHealthComponent;

    void Start()
    {
        playerMovement = this.GetComponent<PlayerMovement>();
        playerInputManager = this.GetComponent<InputManager>();
        playerHealthComponent = this.GetComponent<HealthComponent>();
        playerInputManager.inputActions.Player.Move.performed += ctx => playerMovement.Move(ctx.ReadValue<Vector2>());
        playerInputManager.inputActions.Player.Move.canceled += ctx => playerMovement.moveInput = Vector2.zero;
    }


    void Update()
    {
        
    }
}
