using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordLogic : MonoBehaviour
{
    public float timeBtwAttack;
    public float startTimeBtwAttack;
    public Transform attackPos;
    public float attackRange;
    public int damage;

    public LayerMask damageable;

    void Update()
    {
        if(timeBtwAttack <= 0)
        {
            if(Input.GetMouseButtonDown(0))
            {
                Collider2D[] objectsToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, damageable);
                for(int i = 0; i < objectsToDamage.Length; i++)
                {
                    objectsToDamage[i].GetComponent<Health>().RemoveHealth();
                }

                timeBtwAttack = startTimeBtwAttack;
            }
        }
        else
        {
            timeBtwAttack -= Time.deltaTime;
        }
    }
}
