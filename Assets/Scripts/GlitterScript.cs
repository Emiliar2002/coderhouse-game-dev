using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlitterScript : MonoBehaviour
{
    [SerializeField] private float glitterIntensity = 2f;
    [SerializeField] private float maxIntensity = 50f;
    [SerializeField] private float minIntensity = 5f;
    private bool pastMax = false;
    // Start is called before the first frame update
    void Start()
    {
        Light light = GetComponent<Light>();
        light.intensity = minIntensity;
    }

    // Update is called once per frame
    void Update()
    {
        Light light  = GetComponent<Light>();
        if(light.intensity > maxIntensity || light.intensity < minIntensity )
        {
            pastMax = !pastMax;
        }

        if(pastMax)
        {
            light.intensity -= glitterIntensity * Time.deltaTime;
            return;
        }

        light.intensity += glitterIntensity * Time.deltaTime;

    }
}
