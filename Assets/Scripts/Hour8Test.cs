using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hour8Test : MonoBehaviour
{
    //public Light LightComponent;
    private GameObject target;
    
    void Start()
    {
        //LightComponent = GetComponent<Light>();
        //LightComponent.type = LightType.Directional;

        target = GameObject.Find("EmptyFind"); // Very slow.
        // FindWithTag also exists.
    }

    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal"); // -1 = Left, 0 = None, 1 = Right
        float Vertical = Input.GetAxis("Vertical"); // -1 = Down, 0 = None, 1 = Up

        if (Input.GetKey(KeyCode.M))
            print("M is held down");
        if (Input.GetKeyDown(KeyCode.O))
            print("O was pressed this frame, will only print once");

        float MouseX = Input.GetAxis("Mouse X"); // Amount the mouse has moved horizontally in the past frame. Resets every frame.
        float MouseY = Input.GetAxis("Mouse Y"); // Amount the mouse has moved vertically in the past frame. Resets every frame.

        bool IsMouse1Down = Input.GetMouseButtonDown(0); // LMB
        bool IsMouse2Down = Input.GetMouseButtonDown(1); // RMB
        bool IsMouse3Down = Input.GetMouseButtonDown(2); // MMB (middle mouse)

    }

    void TransformTest() // These are all local to the object
    {
        transform.Translate(0.05f, 0f, 0f); // Move by 0.05 units on X
        transform.Rotate(0f, 0f, 1f); // Rotate by 1 degree (radian?) on Z
        transform.localScale = new Vector3(2f, 2f, 2f); // CHANGES size to 2. Is NOT local.
    }
}
