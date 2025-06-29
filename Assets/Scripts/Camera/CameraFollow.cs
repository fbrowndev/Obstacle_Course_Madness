using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [Header("Player Info")]
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset = new Vector3(0f, 5f, -7f);
    [SerializeField] private float _smoothSpeed = 0.125f;


    void LateUpdate()
    {
        Vector3 desiredPosition = _target.position + _offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, _smoothSpeed);

        transform.position = smoothPosition;
        transform.LookAt(transform.position);
    }
}
