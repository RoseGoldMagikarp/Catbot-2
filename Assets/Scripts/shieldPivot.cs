using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldPivot : MonoBehaviour
{
    public GameObject player;
    private Vector3 shieldPos;
    private float angle;
    public float distance = 1f;

    private void Update()
    {
        shieldPos = Input.mousePosition;
        shieldPos.z = (player.transform.position.z - Camera.main.transform.position.z);
        shieldPos = Camera.main.ScreenToWorldPoint(shieldPos);
        shieldPos = shieldPos - player.transform.position;
        angle = Mathf.Atan2(shieldPos.y, shieldPos.x) * Mathf.Rad2Deg;

        if(angle < 0f)
        {
            angle += 360f;
        }

        transform.localEulerAngles = new Vector3(0, 0, angle);

        float xPos = Mathf.Cos(Mathf.Deg2Rad * angle) * distance;
        float yPos = Mathf.Sin(Mathf.Deg2Rad * angle) * distance;
        transform.localPosition = new Vector3(player.transform.position.x + xPos, player.transform.position.y + yPos, -5);
    }

    /***
    public Transform catbot;
    public float radius;

    private Transform pivot;

    private void Start()
    {
        pivot = catbot.transform;
        transform.parent = pivot;
        transform.position += Vector3.up * radius;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 catbotVector = Camera.main.WorldToScreenPoint(catbot.position);
        catbotVector = Input.mousePosition - catbotVector;
        float angle = Mathf.Atan2(catbotVector.y, catbotVector.x) * Mathf.Rad2Deg;

        pivot.position = catbot.position;
        pivot.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);

    }
    ***/
}
