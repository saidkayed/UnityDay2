using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onClick : MonoBehaviour
{
    public GameObject Car;
    public GameObject Reset;
    // Start is called before the first frame update



   public void Respawn()
    {
        Reset.SetActive(false);
        Car.transform.eulerAngles = new Vector3(0, 0, 0);
        Car.transform.position = new Vector3(0, 5, 0);
       
    }
}
