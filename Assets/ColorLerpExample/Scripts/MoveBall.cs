using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    public float moveSpeed_;

    private Vector2 moveDirection_;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moveDirection_ = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
    }

    private void FixedUpdate()
    {
        Vector2 delta = (moveDirection_ * moveSpeed_ * Time.fixedDeltaTime);
        transform.position += new Vector3(delta.x, 0, delta.y);
    }
}
