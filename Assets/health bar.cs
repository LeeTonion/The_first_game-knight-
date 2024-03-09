using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Slider healthbarSlider;
    public void maxhealth(int blood)
    {
        healthbarSlider.maxValue = blood;
        healthbarSlider.value = blood;
    }

    // Update is called once per frame
    public void health(int blood)
    {
        healthbarSlider.value = blood;
    }
}
