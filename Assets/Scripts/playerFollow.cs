using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerFollow : MonoBehaviour
{
    private int count;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = pos;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag=="Asteroid")
        {
            Debug.Log("Asteroid destroyed");
            Destroy(collision.gameObject);
            count++;
            Debug.Log("Count: " + count);
        }
    }
}
