using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarScript : MonoBehaviour
{
    public GameObject Reset;
    // Start is called before the first frame update
    void Start()
    {
        Reset.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
       
            if (Vector3.Dot(transform.up, Vector3.down) > 0)
            {
      
            Reset.SetActive(true);
            print("RAMT");
            }
            else
            {
            Reset.SetActive(false);
            }

        
     
    }
}
