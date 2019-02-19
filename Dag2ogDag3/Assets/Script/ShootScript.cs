using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootScript : MonoBehaviour

{
    public Rigidbody bullet;
   
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            float speed = 50;
            //GameObject bullet = Instantiate(Bullet,this.transform.position, Quaternion.identity);
            Rigidbody bulletClone = (Rigidbody)Instantiate(bullet, transform.position, transform.rotation);
            bulletClone.velocity = transform.forward * speed;


        }
    }
    



}
