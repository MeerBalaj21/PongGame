using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BallReset : MonoBehaviour
{
    public static UnityEvent ResetBall;
    public GameObject Ball;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _rigidbody = Ball.GetComponent<Rigidbody2D>();
        ResetBall = new UnityEvent();
        ResetBall.AddListener(Reset);
    }
    private void Reset()
    {
        Ball.SetActive(false);
        Ball.gameObject.transform.position = Vector2.zero;
        _rigidbody.velocity = Vector2.zero;
        Ball.SetActive(true);
    }
}
