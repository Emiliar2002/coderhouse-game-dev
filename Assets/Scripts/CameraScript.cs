using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameObject cam1;
    [SerializeField] private GameObject cam2;
    private bool switched = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cam1.SetActive(switched);
            cam2.SetActive(!switched);
            switched = !switched;
        }
    }
}
