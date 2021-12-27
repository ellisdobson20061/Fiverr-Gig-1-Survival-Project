using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIHealth : MonoBehaviour
{
    public float health;
    public float damage;
    public GameObject foodPickup;

    void Update()
    {
        if(health == 0)
        {
            Instantiate(foodPickup, transform.position, Quaternion.identity);
            Destroy(this.gameObject);
        }
    }

    void DecreaseHealth()
    {
        health -= damage;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Arrow")
        {
            DecreaseHealth();
        }
    }
}
