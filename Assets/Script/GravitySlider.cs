using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
              
public class GravitySlider : MonoBehaviour
{
    private float oriGravity;
    private TextMeshPro gravityLabel;
    // Start is called before the first frame update
    void Start() {
        oriGravity = -9.807F;
        this.gravityLabel = this.GetComponent<TextMeshPro>();
        this.gravityLabel.text = this.Text;
    }

    public void OnSliderUpdated(SliderEventData eventData)
    {
        Physics.gravity = new Vector3(0,(eventData.NewValue * 2) * this.oriGravity,0);
        if(this.gravityLabel!=null) {
            this.gravityLabel.SetText(this.Text);
        }
    }

    public string Text => "Gravity: " + $"{Physics.gravity.y:F2}";
}
