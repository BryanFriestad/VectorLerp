using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LerpScript : MonoBehaviour
{
    public Transform start_;
    public Transform end_;
    public float moveTime_;
    public bool isClamped_;

    private bool started_ = false;
    private float startTime_;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            started_ = true;
            startTime_ = Time.time;
        }
    }

    private void FixedUpdate()
    {
        if (started_)
        {
            if (isClamped_)
            {
                float delta = Time.time - startTime_;
                transform.position = Vector3.Lerp(start_.position, end_.position, delta / moveTime_);
            }
            else
            {
                float delta = Time.time - startTime_;
                transform.position = Vector3.LerpUnclamped(start_.position, end_.position, delta / moveTime_);
            }
        }
    }
}
