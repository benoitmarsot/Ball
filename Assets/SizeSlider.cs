using Microsoft.MixedReality.Toolkit.UI;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SizeSlider : MonoBehaviour
{
    private float size;
    private TextMeshPro sizeLabel;
    private GameObject ball;
    // Start is called before the first frame update
    void Start() {
        size = .02F;
        this.sizeLabel = this.GetComponent<TextMeshPro>();
        this.sizeLabel.text = this.text;
        this.ball = GameObject.Find("/Ball");
    }

    public void OnSliderUpdated(SliderEventData eventData) {
        if (this.ball == null || this.sizeLabel == null)
            return;
        this.size = eventData.NewValue;
        this.ball.transform.localScale = new Vector3(this.size, this.size, this.size);
        this.sizeLabel.text = this.text;
    }

    public string text => "Size: " + $"{this.size:F2}";
}
