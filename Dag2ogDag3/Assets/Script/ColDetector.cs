using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColDetector : MonoBehaviour
{
   
  
    public GameObject Explosion;
  


    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
        {

           
            GetComponent<AudioSource>().Play();
            Destroy(collision.gameObject);
            Destroy(this.gameObject,2);
        
           Instantiate(Explosion, gameObject.transform.position, gameObject.transform.rotation);
        }
        else
        {
            print("none");
        }
    }
}
