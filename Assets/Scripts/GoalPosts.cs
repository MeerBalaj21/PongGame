using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GoalPosts : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.transform.position.y > 0 && collision.gameObject.CompareTag("Ball"))
        {
            ScoreManager.GoalTop.Invoke();
            BallReset.ResetBall.Invoke();
        }
        if (gameObject.transform.position.y < 0 && collision.gameObject.CompareTag("Ball"))
        {
            ScoreManager.GoalBottom.Invoke();
            BallReset.ResetBall.Invoke();
        }
    }
}
