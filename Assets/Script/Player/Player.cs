using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour 
{
    private PlayerMovement playerMovement;

    private InputManager playerInputManager;

    private HealthComponent playerHealthComponent;

    private ShootingComponent playerShootingCompoent;

    void Start()
    {
        playerMovement = this.GetComponent<PlayerMovement>();
        playerInputManager = this.GetComponent<InputManager>();
        playerHealthComponent = this.GetComponent<HealthComponent>();
        playerShootingCompoent = this.GetComponent<ShootingComponent>();
        playerInputManager.inputActions.Player.Move.performed += ctx => playerMovement.Move(ctx.ReadValue<Vector2>());
        playerInputManager.inputActions.Player.Move.canceled += ctx => playerMovement.moveInput = Vector2.zero;
        playerInputManager.inputActions.Player.Attack.performed += ctx => playerShootingCompoent.Shoot();
    }


    void Update()
    {
        
    }
}
