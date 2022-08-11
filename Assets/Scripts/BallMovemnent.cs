using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovemnent : MonoBehaviour
{
    private Rigidbody2D _rigidBody;
    private Vector2 _velocity;
    private Vector2 _normal;
    private Vector2 _newVelocity;
    private float _speed;
    void Start()
    {
        _rigidBody = GetComponent<Rigidbody2D>();      
    }

    void Update()
    {
        _velocity = _rigidBody.velocity;
    }

    void OnCollisionEnter(Collision collision)
    {
        _speed = _velocity.magnitude;
        _normal = collision.contacts[0].normal;
        _newVelocity = Vector2.Reflect(_velocity, _normal);
    }
}
