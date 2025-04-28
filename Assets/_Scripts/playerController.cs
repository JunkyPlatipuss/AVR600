using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(CharacterController))]

public class PlayerController : MonoBehaviour

{
    public Camera playerCamera;
    public float runSpeed = 12f;
    // public float jumpPower = 7f;
    public float gravity = 10f;
    public float lookSpeed = 2f;
    public float lookXLimit = 45f;
    public float defaultHeight = 0.08f;
    private Vector3 moveDirection = Vector3.zero;
    private float rotationX = 0;
    private CharacterController characterController;
    private bool canMove = true;
    public bool hasMoved = false;

    // public void stopMovement(){
    //     canMove = false;
    // }

    void Start()

    {
        characterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false; 
    }

    


    void FixedUpdate()

    {
        // while(!hasMoved){
        //     if(Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d")){
        //         Vector3 climboutHeight = new Vector3(0f, 0.972f, 0f);
        //         characterController.Move (climboutHeight);
        //         hasMoved = true;
        //     }
        // }

        if(!hasMoved){
            if(Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("s") || Input.GetKey("d")){
                Vector3 climboutHeight = new Vector3(0f, 2.072f, 0f);
                characterController.Move (climboutHeight);
                hasMoved = true;
            }
        }

        Vector3 forward = transform.TransformDirection(Vector3.forward);
        Vector3 right = transform.TransformDirection(Vector3.right);


        float curSpeedX = canMove ? runSpeed * Input.GetAxis("Vertical") : 0;

        float curSpeedY = canMove ? runSpeed * Input.GetAxis("Horizontal") : 0;

        float movementDirectionY = moveDirection.y;

        moveDirection = (forward * curSpeedX) + (right * curSpeedY);




        characterController.Move(moveDirection * Time.deltaTime);



        if (canMove)

        {

            rotationX += -Input.GetAxis("Mouse Y") * lookSpeed;

            rotationX = Mathf.Clamp(rotationX, -lookXLimit, lookXLimit);

            playerCamera.transform.localRotation = Quaternion.Euler(rotationX, 0, 0);

            transform.rotation *= Quaternion.Euler(0, Input.GetAxis("Mouse X") * lookSpeed, 0);

        }
    
        
        if(Input.GetKey("r")){
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        

    }

}
