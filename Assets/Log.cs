using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Log : MonoBehaviour
{
    private TextMeshPro logger;
    // Start is called before the first frame update
    void Start()
    {
        this.logger=this.GetComponent<TextMeshPro>();
        
    }

    // Update is called once per frame
    void Update()
    {
        this.logger.text = string.Format(
            "Primary Joystick: X: {0}, Y: {1}", Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")
        );


    }
}
