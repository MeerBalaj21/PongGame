using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PaddleMovement : MonoBehaviour
{
    public float Speed;
    protected Rigidbody2D _RigidBody;
    protected float _LeftWallPos;
    protected float _RightWallPos;
    private void Awake()
    {
        _RigidBody = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        _LeftWallPos = -(SceneBuilder._width/2) + (transform.localScale.x / 1.5f);
        _RightWallPos = (SceneBuilder._width/2) - (transform.localScale.x / 1.5f);
    }
    public abstract void MovePaddle();


}

