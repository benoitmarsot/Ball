using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BringBack : MonoBehaviour
{
    private GameObject ball;

    // Start is called before the first frame update
    void Start()
    {
        this.ball = GameObject.Find("/Ball");

    }

    // Update is called once per frame
    public void bringBack()
    {
        if(this.ball != null )
        {
            this.ball.transform.position = new Vector3(-.02f,0f,1f);
        }
        
    } 
}
  