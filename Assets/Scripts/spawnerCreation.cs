using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerCreation : MonoBehaviour
{
    public GameObject[] bulletHub;
    public GameObject activeHub;
    public float xPos;
    public float yPos;
    public int hubCount;

    private void Start()
    {
        InvokeRepeating("hubSpawning", 1, 5);
    }

    void hubSpawning()
    {
        if (hubCount < 4)
        {
            xPos = Random.Range(4, 26);
            yPos = Random.Range(7, 18);
            activeHub = bulletHub[Random.Range(0, bulletHub.Length)];
            Instantiate(activeHub, new Vector3(xPos, yPos, -5), Quaternion.Euler(new Vector3(90, 0, 0)));
            hubCount += 1;
        }
    }

}
