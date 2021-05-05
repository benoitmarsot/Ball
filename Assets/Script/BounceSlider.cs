using Microsoft.MixedReality.Toolkit.UI;
using TMPro;
using UnityEngine;

public class BounceSlider : MonoBehaviour
{
    private TextMeshPro bouncynessLabel;
    private PhysicMaterial mBall;
    // Start is called before the first frame update
    void Start()
    {
        this.bouncynessLabel = this.GetComponent<TextMeshPro>();
        GameObject ball = GameObject.Find("/Ball");
        SphereCollider sc = ball.GetComponent<SphereCollider>();
        this.mBall=sc.material;
        this.bouncynessLabel.text = this.text;

    }

    public void OnSliderUpdated(SliderEventData eventData)
    {
        if (this.mBall == null || this.bouncynessLabel == null)
            return;
        this.mBall.bounciness = eventData.NewValue;
        this.bouncynessLabel.text = this.text;
    }

    public string text => "Bounce: " + $"{this.mBall.bounciness:F2}";
}
