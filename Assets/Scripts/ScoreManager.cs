using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class ScoreManager : GameStart
{
    public static UnityEvent GoalTop;
    public static UnityEvent GoalBottom;
    public GameObject PlayerWin;
    public GameObject PlayerLose;
    public TMP_Text PlayerWinText;
    public TMP_Text PlayerLoseText;

    public int ScorePlayer;
    public int ScoreEnemy;

    private void Start()
    {
        PlayerLose.SetActive(false);
        ScorePlayer = 0;
        GoalTop = new UnityEvent();
        GoalTop.AddListener(ScoreTop);

        PlayerWin.SetActive(false);
        ScoreEnemy = 0;
        GoalBottom = new UnityEvent();
        GoalBottom.AddListener(ScoreBottom);
    }

    private void ScoreTop()
    {
        ScorePlayer = ScorePlayer + 1; 
    }

    private void ScoreBottom()
    {
        ScoreEnemy = ScoreEnemy + 1;
    }

    private void ResetScore()
    {
        ScoreEnemy = 0;
        ScorePlayer = 0;
    }

    private void Update()
    {
        PlayerLoseText.text = ScoreEnemy.ToString();
        PlayerWinText.text = ScorePlayer.ToString();

        if (ScoreEnemy == 10)
        {
            PlayerLose.SetActive(true);
            ResetScore();
            ResetGame();
        }
        if (ScorePlayer == 10)
        {
            PlayerWin.SetActive(true);
            ResetScore();
            ResetGame();
        }

    }
}
