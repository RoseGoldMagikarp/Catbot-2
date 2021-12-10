using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySpawner : MonoBehaviour
{
    public void OnParticleCollision(GameObject other)
    {
        if (other.tag == "playerBullet")
        {
            GameObject.Find("Game Manager").GetComponent<spawnerCreation>().hubCount -= 1;
            GameObject.Find("Game Manager").GetComponent<scoreTimer>().destroyedHub += 10;
            this.gameObject.SetActive(false);
        }

        print("Sussus Amongus");
    }
}
