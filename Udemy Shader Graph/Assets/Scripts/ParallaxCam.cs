using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxCam : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        transform.position += new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0f) * speed * Time.deltaTime;
    }
}
