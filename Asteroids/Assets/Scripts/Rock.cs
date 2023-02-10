using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Rock : MonoBehaviour
{
    Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnBecameInvisible()
    {
        Vector2 position = transform.position;

        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        float halfWidth = spriteRenderer.bounds.size.x / 2;
        float halfHeight = spriteRenderer.bounds.size.y / 2;

        if (position.x + halfWidth <= ScreenUtils.ScreenLeft ||
            position.x - halfWidth >= ScreenUtils.ScreenRight)
        {
            position.x *= -1;
        }
        if (position.y + halfHeight >= ScreenUtils.ScreenTop ||
            position.y - halfHeight <= ScreenUtils.ScreenBottom)
        {
            position.y *= -1;
        }

        transform.position = position;

    }
}
