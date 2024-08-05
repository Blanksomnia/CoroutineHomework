using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField]
    private Vector3 rotation;

    [SerializeField, HideInInspector]
    private Rigidbody rig;
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Quaternion deltaRotation = Quaternion.Euler(rotation * Time.fixedDeltaTime);
        rig.MoveRotation(rig.rotation * deltaRotation);
    }
}
