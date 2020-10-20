using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class HitCheck : MonoBehaviour
{
    [SerializeField] private Transform parent;
    


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            Lose();
        }
    }

    private void Lose()
    {
        Vector3 rotation = new Vector3(90f, 0f, 0f);
        parent.position = Vector3.zero;
        parent.rotation = Quaternion.Euler(rotation);
    }
}
