using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Rigidbody2D rb;
    public GameObject collisionParticle;

    void Start()
    {
        Destroy(this.gameObject, 12f);
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag == "Wall")
        {
            rb.constraints = RigidbodyConstraints2D.FreezeAll;
            Instantiate(collisionParticle, transform.position, Quaternion.identity);
        }
    }
}
