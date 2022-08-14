using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart : MonoBehaviour
{
    public GameObject Ball;
    public GameObject StartButton;
    public GameObject Paddles;
    public GameObject Scores;
    public GameObject Win;
    public GameObject Lose;

    public void StartGame()
    {
        StartButton.gameObject.SetActive(false);
        Scores.gameObject.SetActive(true);
        Ball.gameObject.SetActive(true);
        Paddles.gameObject.SetActive(true);
        Lose.gameObject.SetActive(false);
        Win.gameObject.SetActive(false);
    }

    public void ResetGame()
    {
        StartButton.gameObject.SetActive(true);
        Scores.SetActive(false);
        Ball.gameObject.SetActive(false);
        Paddles.gameObject.SetActive(false);
        
    }
}
