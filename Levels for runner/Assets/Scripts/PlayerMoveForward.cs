using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveForward : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    void Update()
    {
        transform.position += Vector3.forward * (speed * Time.deltaTime);
    }
}
