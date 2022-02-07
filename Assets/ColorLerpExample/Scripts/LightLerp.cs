using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightLerp : MonoBehaviour
{
    public Light light_;
    public GameObject distanceTarget_;
    public float distanceFactor_;
    public Color closeColor_;
    public Color farColor_;

    private void FixedUpdate()
    {
        float distance = Vector3.Distance(transform.position, distanceTarget_.transform.position);
        // There is also Color.Lerp()
        light_.color = Vector4.LerpUnclamped(closeColor_, farColor_, distance/distanceFactor_);
    }
}
