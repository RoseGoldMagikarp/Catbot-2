using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkingcat : MonoBehaviour
{
    float dirX, movespeed;

    Animator anim;


    

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        movespeed = 5f;
    }

    // Update is called once per frame
    void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal") * movespeed * Time.deltaTime;

        transform.position = new Vector2(transform.position.x + dirX, transform.position.y);

        if (dirX != 0 && !anim.GetCurrentAnimatorStateInfo(0).IsName("catbot2_walk"))
        {
            anim.SetBool("isWalking", true);
        }
        else
        {
            anim.SetBool("isWalking", false);
        }
    }
}
