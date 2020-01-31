using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    float speed = 5;

    float radius;

    Vector2 dir;
    // Start is called before the first frame update
    void Start()
    {
        dir = Vector2.one.normalized;
        radius = transform.localScale.x / 2;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(dir * speed * Time.deltaTime);

        if (transform.position.y < GameManager.bottomLeft.y + radius && dir.y < 0)
        {
            dir.y = -dir.y;
        }
        if (transform.position.y > GameManager.topRight.y - radius && dir.y > 0)
        {
            dir.y = -dir.y;
        }


        if (transform.position.x < GameManager.bottomLeft.x + radius && dir.x < 0)
        {
            Debug.Log("Right player wins");
        }
        if (transform.position.x > GameManager.topRight.x - radius && dir.x > 0)
        {
            Debug.Log("Left player wins");

        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Paddle")
        {
            bool isRight = collision.GetComponent<Paddle>().isRight;
            if (isRight && dir.x > 0)
            {
                dir.x = -dir.x;
            }
            if (!isRight && dir.x < 0)
            {
                dir.x = -dir.x;
            }
        }
    }
}
