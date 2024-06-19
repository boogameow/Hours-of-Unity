using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControlScript : MonoBehaviour
{
    private float DeltaTime;
    private bool IsBig = false;

    public float CubeSpeed = 5;
    public float CubeSprintSpeed = 10;
    public float CubeRotSpeed = 3;

    public Camera MainCamera;

    // Every Frame

    void Update()
    {
        DeltaTime = Time.deltaTime;

        MoveCube();
        MouseRotate();

        ChangeCubeSize();
    }

    // Functions

    void MoveCube()
    {
        float Horizontal = Input.GetAxis("Horizontal") * DeltaTime; // -1 = Left, 0 = None, 1 = Right
        float Vertical = Input.GetAxis("Vertical") * DeltaTime; // -1 = Down, 0 = None, 1 = Up

        if (Horizontal != 0 || Vertical != 0)
        {
            float AppliedSpeed = CubeSpeed;

            if (Input.GetKey(KeyCode.LeftShift))
                AppliedSpeed = CubeSprintSpeed;

            transform.Translate(Horizontal * AppliedSpeed, 0f, Vertical * AppliedSpeed);
        }
    }

    void ChangeCubeSize()
    {
        bool IsButtonDown = Input.GetKeyDown(KeyCode.M); // Only is true once per press.

        if (IsButtonDown == true)
        {
            if (IsBig == false)
            {
                transform.localScale = new Vector3(2f, 2f, 2f);
                IsBig = true;
            } else {
                transform.localScale = new Vector3(1f, 1f, 1f);
                IsBig = false;
            }
        }
    }

    void MouseRotate()
    {
        float MouseX = Input.GetAxis("Mouse X"); // These are already measured per frame,
        float MouseY = Input.GetAxis("Mouse Y") * -1; // so deltaTime is not needed.

        if (MouseY != 0)
            MainCamera.transform.Rotate(MouseY, 0f, 0f);
        if (MouseX != 0)
            transform.Rotate(0f, MouseX * CubeRotSpeed, 0f);
    }
}
