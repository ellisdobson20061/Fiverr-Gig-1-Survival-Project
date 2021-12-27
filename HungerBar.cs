using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerBar : MonoBehaviour
{
    public Slider HungerSlider;
    public float Hunger;
    float maxHunger = 100f;

    void Start()
    {
        Hunger = maxHunger;
    }

    void Update()
    {
        HungerSlider.value = Hunger;

        Hunger -= 0.3f * Time.deltaTime;

        if(Hunger == 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void IncreaseHunger()
    {
        Hunger = maxHunger;
    }

}
