using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class highScoreDisplay : MonoBehaviour
{
    public Text uiText;

    void Start()
    {
        uiText.text = "Highscore: " + scoreDisplay.highScore.ToString("F");
    }
}
