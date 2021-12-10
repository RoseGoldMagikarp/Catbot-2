using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreTimer : MonoBehaviour
{
    public Text uiText;
    public float timer;
    public int mainTimer;
    public static int score;
    public GameObject Player;
    public int destroyedHub;

    void Start()
    {
        timer = 0;
        destroyedHub = 0;
    }

    void Update()
    {
        mainTimer = (int)timer;

        if (Player.activeInHierarchy == true)
        {
            timer += Time.deltaTime;
            score = mainTimer + destroyedHub;
            uiText.text = score.ToString("F");
        }
    }
}
