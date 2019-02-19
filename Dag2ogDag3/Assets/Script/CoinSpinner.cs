using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CoinSpinner : MonoBehaviour
{
    public float speed = 20;
   
    //bool right = true;

    
   
    void Start()
    {
       
        StartCoroutine("Movecoin");
    }

    void Update()
    {
        
       // transform.Rotate(Vector3.up, speed * Time.deltaTime);


    }


    IEnumerator Movecoin()
    {


        float random = Random.Range(0, 2);
        while (true)
        {
            if (random == 0)
            {
                yield return new WaitForSeconds(5);

                transform.DOMoveX(810, 2);
            }
            else if (random == 1)
            {
                yield return new WaitForSeconds(5);

                transform.DOMoveX(202, 2);
            }

           
            yield return new WaitForSeconds(5);
            transform.DOMoveX(405, 2);
        }   
      
    }
  
}
