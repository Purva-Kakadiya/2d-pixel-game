using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerMovement : MonoBehaviour {

    [SerializeField] GameInput gameInput;
    [SerializeField] float movementSpeed = 8f;

    //private float rotateSpeed = 2f;
    private Vector2 inputVector;

    private void Update() {
        inputVector = gameInput.GetMovement();
    }

    private void FixedUpdate() {
        Vector3 moveDir = new Vector3(inputVector.x, 0, 0);

        transform.position += moveDir * movementSpeed * Time.fixedDeltaTime;
        Debug.Log(transform.position);
    }

}
