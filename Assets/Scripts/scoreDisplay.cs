using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreDisplay : MonoBehaviour
{
    public Text uiText;
    public GameObject record;
    public static int playerScore;
    public int latestScore;
    public static int highScore;

    void Start()
    {
        playerScore = scoreTimer.score;
        latestScore = playerScore;
        uiText.text = "Score: " + playerScore.ToString("F");
        if (latestScore > highScore)
        {
            highScore = latestScore;
            record.gameObject.SetActive(true);
        }
        else
        {
            record.gameObject.SetActive(false);
        }
    }

}
