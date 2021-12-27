using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLogic : MonoBehaviour
{
    public float Speed;

    Rigidbody2D rb;
    float movX;
    float movY;

    public Camera cam;
    Vector2 mousePosition;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        movX = Input.GetAxisRaw("Horizontal");
        movY = Input.GetAxisRaw("Vertical");

        rb.velocity = new Vector2(movX * Speed, movY * Speed);
        mousePosition = cam.ScreenToWorldPoint(Input.mousePosition);
        Vector2 aimDirection = mousePosition - rb.position;
        float aimAngle = Mathf.Atan2(aimDirection.y, aimDirection.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = aimAngle;

    }

}
