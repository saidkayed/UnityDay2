using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaneScrip : MonoBehaviour
{
    public Text Points;
    private int Count;


    private void Start()
    {
        Count = 0;
    }
   
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Points"))
        {


            GetComponent<AudioSource>().Play();
            other.gameObject.SetActive(false);

            Count++;
            Points.text = "Points " + Count.ToString();


           
        }
        else
        {
            print("none");
        }



    }
}
