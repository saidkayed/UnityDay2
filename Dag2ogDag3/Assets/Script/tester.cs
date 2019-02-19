using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tester : MonoBehaviour


{

    public float speed;
    float posX;
    float posY;
    float posZ;





    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("MoveCoin");
        posX = transform.position.x;
        posY = transform.position.y;
        posZ = transform.position.z;



    }



    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }


    IEnumerator MoveCoin()
    {
        print("movecoin");
        yield return new WaitForSeconds(1);
    }
}
