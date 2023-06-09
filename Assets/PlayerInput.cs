using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    float verticalAxis;
    float horizontalAxis;
      
    public float moveSpeed = 20;

    // Start is called before the first frame update
    void Start()
    {
       
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalAxis = Input.GetAxis("Vertical");
        horizontalAxis = Input.GetAxis("Horizontal");

        //moove up and down
        this.transform.Translate(new Vector3(horizontalAxis, verticalAxis, 0)*moveSpeed*Time.deltaTime);
    }

    
}
