using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeatherCycle : MonoBehaviour
{
    public GameObject rainEffect;

    void Start()
    {
        float rand = Random.Range(0, 30);
        if (rand > 15)
        {
            rainEffect.SetActive(true);       
        }

        if (rand < 15)
        {
            rainEffect.SetActive(false);
        }

        Debug.Log(rand);
    }
}
