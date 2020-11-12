using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed = 10;

    private Rigidbody _myRigidBody;

    private void Awake()
    {
        _myRigidBody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        if (vertical != 0 || horizontal != 0)
        {
            _myRigidBody.AddForce(new Vector3(horizontal, 0, vertical) * _speed);
        }
    }


}
