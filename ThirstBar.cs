using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThirstBar : MonoBehaviour
{
    public Slider ThirstSlider;
    public float Thirst;
    float maxThirst = 100f;

    void Start()
    {
        Thirst = maxThirst;
    }

    void Update()
    {
        ThirstSlider.value = Thirst;

        Thirst -= 0.7f * Time.deltaTime;

        if (Thirst == 0)
        {
            Destroy(this.gameObject);
        }
    }

    public void IncreaseThirst()
    {
        Thirst = maxThirst;
    }
}
