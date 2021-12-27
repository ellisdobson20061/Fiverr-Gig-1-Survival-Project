using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HungerInteractable : MonoBehaviour
{
    private HungerBar bar;
    public GameObject parentOBJ;

    public void ChangeHunger()
    {
        bar = GameObject.FindGameObjectWithTag("Player").GetComponent<HungerBar>();
        bar.IncreaseHunger();
        Destroy(parentOBJ);
    }
}
