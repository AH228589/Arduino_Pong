using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    public bool isRight;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void Init(bool isRightpPaddle)
    {
        Vector2 pos = Vector2.zero;
        isRight = isRightpPaddle;
        if (isRightpPaddle)
        {
            pos = new Vector2(GameManager.topRight.x, 0);
            pos -= Vector2.right * transform.localScale.x;
            transform.name = "PaddleRight";
        }
        else
        {
            pos = new Vector2(GameManager.bottomLeft.x, 0);
            pos += Vector2.right * transform.localScale.x;
            transform.name = "PaddleLeft";


        }
        transform.position = pos;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
