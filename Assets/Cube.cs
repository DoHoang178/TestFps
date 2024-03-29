using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private int speed = 1;
    private float direction = 1;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Movement());
    }

    IEnumerator Movement()
    {
        while (true)
        {
            // Di chuyển vật thể theo chiều x
            transform.position += new Vector3(0,speed * direction * Time.deltaTime,0);

            // Kiểm tra xem vật thể đã đạt mốc 0 hoặc 2 chưa
            if (transform.position.y >= 2.0f)
            {
                direction = -1.0f; // Đảo chiều di chuyển
            }
            else if (transform.position.y <= 0.0f)
            {
                direction = 1.0f; // Đảo chiều di chuyển
            }

            // Đợi cho đến khi tiếp tục lần lặp tiếp theo
            yield return null;
        }
    }
}
