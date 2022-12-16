using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkingPlatformScript : MonoBehaviour
{
    public float shrinkFactor;
    public float shrinkSpeed;
    public bool onPlatform;

    public void OnCollisionEnter2D(Collision2D other)
    {
        onPlatform = true;
    }

    public void OnCollisionExit2D(Collision2D other)
    {
        onPlatform = false;
    }

    private void Update()
    {
        if (onPlatform == true)
        {

            Shrinking();
        }
    }

    private void Shrinking()
    {
        if (transform.localScale.x > 0 || transform.localScale.y > 0)
        {
            transform.localScale = new Vector3(transform.localScale.x - shrinkFactor * shrinkSpeed * Time.deltaTime,
                                            transform.localScale.y - shrinkFactor * shrinkSpeed * Time.deltaTime);
        }
        if (transform.localScale.x < 0)
        {
            Destroy(gameObject);
        }
    }


}
