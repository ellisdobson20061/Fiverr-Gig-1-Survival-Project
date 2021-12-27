using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapWeapons : MonoBehaviour
{
    public GameObject weapon1;
    public GameObject weapon2;

    void Start()
    {
        weapon1.SetActive(true);
        weapon2.SetActive(false);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            weapon1.SetActive(false);
            weapon2.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            weapon1.SetActive(true);
            weapon2.SetActive(false);
        }
    }
}
