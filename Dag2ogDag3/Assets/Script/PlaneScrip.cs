using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class PlaneScrip : MonoBehaviour
{
    public Text Points;
    private int Count;


    private void Start()
    {
        Count = 0;
    }

    private void Update()
    {
        Points.transform.DOScale(2, 50 * Time.deltaTime);
        Points.DOColor(Color.red, 50 * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Points"))
        {


            GetComponent<AudioSource>().Play();
            other.gameObject.SetActive(false);

            Count++;
            Points.text = "Points " + Count.ToString();
           
            Points.DOColor(Color.yellow,0);

            Points.transform.DOScale(3, 0);
          


        }
        else
        {
            
        }
        print("ikke noget");


    }

}
