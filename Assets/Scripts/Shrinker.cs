using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrinker : MonoBehaviour
{
    [SerializeField] private float maxTime = 2;
    private float timeElapsed;
    private bool leftPortal;
    private void OnTriggerEnter(Collider collision)
    {
        if(!leftPortal)
        {
            if (collision.gameObject.transform.localScale.x == 1f)
            {
                collision.gameObject.transform.localScale = new Vector3(0.25f, 0.25f, 0.25f);
                return;
            }
            collision.gameObject.transform.localScale = new Vector3(1f, 1f, 1f);
            return;
        }
        
    }

    private void OnTriggerExit(Collider collision)
    {
        leftPortal = true;
    }

    private void Start()
    {
        leftPortal = false;
        timeElapsed = 0f;
    }
    private void Update()
    {
        if (leftPortal)
        {
            if(timeElapsed >= maxTime)
            {
                timeElapsed = 0;
                leftPortal = false;
                return;
            }
            timeElapsed += Time.deltaTime;
        }
    }
}
