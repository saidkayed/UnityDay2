using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarScript : MonoBehaviour
{
    public Text text;
    int timer = 20;
    public GameObject Reset;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Reset.SetActive(false);
        StartCoroutine("countdown");

    }

    // Update is called once per frame
    void Update()
    {
       
        text.text = "Seconds left " + timer;
        if(timer == 0)
        {
            SceneManager.LoadScene(1);
        }
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

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Points"))
        {


            timer += 10;
            other.gameObject.SetActive(false);



        }
        else
        {

        }
        print("ikke noget");


    }
    IEnumerator countdown()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timer--;

        }
    }
}
