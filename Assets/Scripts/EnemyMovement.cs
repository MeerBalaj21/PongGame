using UnityEngine;
using System;

public class EnemyMovement : PaddleMovement
{
    public GameObject Ball;
    private Vector3 _paddlePosition;
    private Vector2 _movement;

    void Update()
    {
        MovePaddle();
    }

    public override void MovePaddle()
    {
        _movement.x = Ball.transform.position.x;
        _movement.y = 0;

        _RigidBody.velocity = _movement * 2;

        var bounds = Math.Clamp(transform.position.x, _LeftWallPos, _RightWallPos);

        _paddlePosition = transform.position;
        _paddlePosition.x = bounds;
        transform.position = _paddlePosition;
    }
}
