using UnityEngine;

public class GameInput : MonoBehaviour {

    private InputSystem_Actions playerInputAction;

    private void Awake() {
        playerInputAction = new InputSystem_Actions();
        playerInputAction.Player.Enable();
    }
    public Vector2 GetMovement() {
        var inputVector = playerInputAction.Player.Move.ReadValue<Vector2>();

        return inputVector;
    }

}
