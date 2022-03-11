using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateMechanism : MonoBehaviour
{
    private Rigidbody _rigidbody;
    private float rotateHolderWheel = 100f;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        PowerRotateLogic();
    }
    public void PowerRotateLogic()
    {
        _rigidbody.AddTorque(Vector3.right * rotateHolderWheel);
    }
}
