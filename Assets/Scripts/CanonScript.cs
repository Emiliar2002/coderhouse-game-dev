using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CanonScript : MonoBehaviour
{

    public bool shooting = false;

    public GameObject bulletPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.Space) & !shooting)
        //{
        //    Instantiate(bulletPrefab, this.transform, false);
        //    shooting = true;
            
        //}
        //else if (!Input.GetKey(KeyCode.Space))
        //{
        //    shooting = false;
        //}

        if(Input.GetKey(KeyCode.J) & Input.GetKey(KeyCode.K) & Input.GetKey(KeyCode.L) & !shooting)
        {
            for(int i = 0; i < 3; i++)
            {
                Instantiate(bulletPrefab, this.transform, false);
            }
            shooting = true;
        }
        else if(!(Input.GetKey(KeyCode.J) & Input.GetKey(KeyCode.K) & Input.GetKey(KeyCode.L)))
        {
            shooting = false;
        }


    }
}
