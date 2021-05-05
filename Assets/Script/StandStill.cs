using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandStill : MonoBehaviour
{
    private float elapsedTime;
    private Vector3 currentGravity;
    // Start is called before the first frame update
    void Start()
    {
        this.elapsedTime = 0;
        this.currentGravity = Physics.gravity;
        Physics.gravity = new Vector3( 0, 0, 0 );
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        //if more than 5 sec
        if(elapsedTime >= 5) {
            Physics.gravity = this.currentGravity;
            elapsedTime = 0;
        }
    }
}




















