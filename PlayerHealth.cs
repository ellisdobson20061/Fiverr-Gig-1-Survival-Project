using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Slider healthSlider;
    public float health;
    private float maxHealth = 100f;
    public float damage;
    
    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        healthSlider.value = health;
    }

    void DecreaseHealth()
    {
        health -= damage;
    }

    public void IncreaseHealth()
    {
        health = maxHealth;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Enemy")
        {
            DecreaseHealth();
        }
    }
}
