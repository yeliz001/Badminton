using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Vector3 difference;
    [SerializeField] private Transform target;

    private void LateUpdate()
    {
        transform.position = target.position + difference;
    }
}
