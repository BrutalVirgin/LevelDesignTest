using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float rotateSpeed = 3f;
    private readonly float screenWidthSide = Screen.width / 2;
    void Update()
    {
        var mousePos = Input.mousePosition.x;
        transform.position += Vector3.forward * (speed * Time.deltaTime);

        if (Input.GetMouseButton(0) && mousePos < screenWidthSide)
        {
            transform.Rotate(Vector3.forward * rotateSpeed);
        }
        else if(Input.GetMouseButton(0) && mousePos > screenWidthSide)
        {
            transform.Rotate(Vector3.forward * -rotateSpeed);
        }
    }
}
