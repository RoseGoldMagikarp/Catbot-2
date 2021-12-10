using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catbotMovement : MonoBehaviour
{
    public CharacterController controller;
    public float speed;
    public KeyCode right;
    public KeyCode left;
    public KeyCode forward;
    public KeyCode backward;

    public Vector3 minBounds;
    public Vector3 maxBounds;

    private void Update()
    {
        float xMovement = 0;
        float yMovement = 0;

        if (Input.GetKey(right))
        {
            xMovement += speed;
        }
        else if (Input.GetKey(left))
        {
            xMovement -= speed;
        }
        if (Input.GetKey(forward))
        {
            yMovement += speed;
        }
        else if (Input.GetKey(backward))
        {
            yMovement -= speed;
        }

        this.gameObject.transform.position += new Vector3(xMovement * Time.deltaTime, yMovement * Time.deltaTime, 0);

        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, minBounds.x, maxBounds.x),
            Mathf.Clamp(transform.position.y, minBounds.y, maxBounds.y),
            Mathf.Clamp(transform.position.z, minBounds.z, maxBounds.z));    
    }
}
