using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirstInteractable : MonoBehaviour
{
    private ThirstBar bar;
    public GameObject parentOBJ;

    public void ChangeThirst()
    {
        bar = GameObject.FindGameObjectWithTag("Player").GetComponent<ThirstBar>();
        bar.IncreaseThirst();
        Destroy(parentOBJ, 0.1f);
    }
}