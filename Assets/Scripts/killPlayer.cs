using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class killPlayer : MonoBehaviour
{
    public void OnParticleCollision(GameObject other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.SetActive(false);
            SceneManager.LoadScene("Game Over");
        }


    }
}
