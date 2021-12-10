using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shieldCharge : MonoBehaviour
{
    public float charge;
    public GameObject shield;
    public ParticleSystem enemyAttack;
    public Transform playerAttack;
    public KeyCode playerFire;
    public Material charge0;
    public Material charge1;
    public Material charge2;
    public Material charge3;
    public Material charge4;

    public void Start()
    {
        charge = 0;
    }

    public void OnParticleCollision(GameObject other)
    {
        if (other.transform.tag == "enemyAttack")
        {
            charge = charge + 1;
        }
    }

    public void Update()
    {
        if (charge >= 10 && charge < 20)
        {
            this.gameObject.GetComponent<MeshRenderer>().material = charge1;
        }
        else if (charge >= 20 && charge < 30)
        {
            this.gameObject.GetComponent<MeshRenderer>().material = charge2;
        }
        else if (charge >= 30 && charge < 40)
        {
            this.gameObject.GetComponent<MeshRenderer>().material = charge3;
        }
        else if (charge >= 40)
        {
            this.gameObject.GetComponent<MeshRenderer>().material = charge4;
        }
        else
        {
            this.gameObject.GetComponent<MeshRenderer>().material = charge0;
        }

        if (charge > 40)
        {
            charge = 40;
        }

        if (Input.GetKeyDown(playerFire) && charge >= 10 && shield.activeInHierarchy == true)
        {
            Instantiate(playerAttack, shield.transform.position, shield.transform.rotation).Rotate(new Vector3(0, 0, -90));
            charge = charge - 10;
        }

        if (charge < 0)
        {
            charge = 0;
        }
    }
}
