using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class shieldActivate : MonoBehaviour
{
    public KeyCode activate;
    public GameObject shield;
    public float durability;
    public Text duraDisplay;

    private void Start()
    {
        durability = 5f;

    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey(activate) & durability > 0)
        {
            shield.gameObject.SetActive(true);
            durability = durability - Time.deltaTime;
        }
        else
        {
            shield.gameObject.SetActive(false);
        }

        if (Input.GetKey(activate) == false && durability < 5)
        {
            durability = durability + (Time.deltaTime / 2);
        }

        duraDisplay.text = durability.ToString("F");
    }
}
