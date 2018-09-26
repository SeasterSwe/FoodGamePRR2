using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwayEffect : MonoBehaviour
{
    private float startPos;
    [Range(0,2)]
    public float swayEf;

    private void Start()
    {
        startPos = transform.position.y;
    }

    void FixedUpdate ()
    {
        transform.position = new Vector2(transform.position.x, startPos + Mathf.Sin(4 * Time.time) * swayEf);
    }
}
