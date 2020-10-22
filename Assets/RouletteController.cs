using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //マウスが押されたら回転速度を設定する
        if (Input.GetMouseButtonDown(0))
        {
            this.rotSpeed = 10;
        }else if (Input.GetMouseButtonDown(1))
        {
            this.rotSpeed -= 3;
        }else if (Input.GetMouseButtonDown(2))
        {
            this.rotSpeed = 0;
        }

        transform.Rotate(0, 0, this.rotSpeed);

        //ルーレットを減速させる
        this.rotSpeed *= 0.99f;
    }
}
