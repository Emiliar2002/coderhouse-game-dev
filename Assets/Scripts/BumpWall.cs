using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BumpWall : MonoBehaviour
{
    [SerializeField] private float maxTime = 2f;
    private float timeElapsed;

    private void Start()
    {
        timeElapsed = 0f;
    }

    private void OnTriggerStay(Collider other)
    {
        if(timeElapsed >= maxTime)
        {
            transform.position = new Vector3(Random.Range(-10.0f, 10.0f), 0, Random.Range(-10.0f, 10.0f));
            transform.localEulerAngles = new Vector3(0f, Random.Range(0f, 360.0f), 0f);
            timeElapsed = 0f;
            return;
        }
        timeElapsed += Time.fixedDeltaTime;
    }

    private void OnTriggerExit(Collider other)
    {
        timeElapsed = 0f;
    }

}
