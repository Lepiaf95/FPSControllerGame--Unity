using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private CharacterController cc;
    public Transform ccCamera;

    public float speed = 7f;
    private float yJump = 0;
    private float gravity = -5f;
    private float currentY = 0;
    private float minY = 0;
    private float maxY = 10f;


    // Start is called before the first frame update
    void Start()
    {
        cc = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked; // The cursor is placed in the center of the view and cannot be moved.
    }

    // Update is called once per frame
    void Update()
    {
        float xInput = Input.GetAxis("Horizontal") * speed; // The movement right and left
        float zInput = Input.GetAxis("Vertical") * speed; // The movement forward and back

        float xMouse = Input.GetAxis("Mouse X") * speed; // The rotation right and left
        float yMouse = Input.GetAxis("Mouse Y") * speed; // The rotation up and down

        if (cc.isGrounded)
        {
            if (Input.GetButton("Jump")) // The jump
                yJump = 5f;
            else
                yJump = gravity * Time.deltaTime;
        }
        else
        {
            yJump += gravity * Time.deltaTime;
        }

       
        // Apply the movement for all directions of the camera thanks to "transform.TransformDirection"
        cc.Move(transform.TransformDirection(new Vector3(xInput, yJump, zInput) * Time.deltaTime));

        // Player and Camera rotate left and right together
        cc.transform.Rotate(Vector3.up * xMouse);

        // Only camera rotates vertically
        currentY = Mathf.Clamp(currentY + yMouse, minY, maxY);
        ccCamera.transform.localEulerAngles = Vector3.right * currentY;

    }
}