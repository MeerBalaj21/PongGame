using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{ 
    private float x;
    private float y;
    private float turn;
    private float direction;
    private Rigidbody2D _rigidBody;

    [SerializeField]private float speed;
   
    private void OnEnable()
    {
        _rigidBody = GetComponent<Rigidbody2D>();

        speed = 10f;
        Invoke("BallStart", 1f);
    }

    private void BallStart()
    {
        x = Random.Range(.5f, 2f);
        y = Random.Range(1f, 2f);
        turn = Random.Range(0, 1f);
        direction = Random.Range(0, 1f);

        if ( turn > 0.5 && direction > 0.5 )
        {
            _rigidBody.AddForce(new Vector2(x, y) * speed);
        }
        else if (turn > 0.5 && direction < 0.5)
        {
            _rigidBody.AddForce(new Vector2(-x, y) * speed);
        }
        else if (turn < 0.5 && direction > 0.5)
        {
            _rigidBody.AddForce(new Vector2(x, -y) * speed);
        }
        else
        {
            _rigidBody.AddForce(new Vector2(-x, -y) * speed);
        }

    }

}
