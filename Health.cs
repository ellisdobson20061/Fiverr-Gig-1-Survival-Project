
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public float health;
    public float damage;

    public GameObject rockPickup;
    public GameObject destroy;

    public void RemoveHealth()
    {
        health -= damage;
    }

    void Update()
    {
        if(health == 0)
        {
            Instantiate(rockPickup, transform.position, transform.rotation);
            Destroy(this.gameObject);
        }
    }
}
