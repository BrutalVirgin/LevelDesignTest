using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerFollow : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Vector3 offset;

    void Update()
    {
        if(player != null)
        {
            transform.position = player.position + offset;
        }
    }
}
