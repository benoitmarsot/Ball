using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamePad : MonoBehaviour
{
    public float magnitude;
    private Rigidbody rbody;
    // Start is called before the first frame update
    void Start()
    {
        this.rbody=this.GetComponent<Rigidbody>();
        this.magnitude = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.rbody != null)
        {
            this.rbody.AddForce(
                new Vector3(
                    Input.GetAxis("Horizontal") * this.magnitude
                    //Todo fix with the other joystic on controller
                    , 0
                    , Input.GetAxis("Vertical") * this.magnitude
                ), ForceMode.Force);
        }
    }
}
