using UnityEngine;
using UnityEngine.InputSystem.Controls;
using System;

public class PlayerMovement : PaddleMovement
{
    private Vector3 _paddlePosition;
    private Vector2 _movement;

    void Update()
    {
        MovePaddle();
    }

    public override void MovePaddle()
    {
        _movement.x = -InputManager.Input.x;
        _movement.y = 0;

        _RigidBody.velocity = _movement * Speed;

        var bounds = Math.Clamp(transform.position.x, _LeftWallPos, _RightWallPos);

        _paddlePosition = transform.position;
        _paddlePosition.x = bounds;
        transform.position = _paddlePosition;
    }

}