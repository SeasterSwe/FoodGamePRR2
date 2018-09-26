using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : MonoBehaviour {

    private Vector2 direction;
    private Rigidbody2D rb2;
	void Start ()
    {
        ChangeD();
        rb2 = GetComponent<Rigidbody2D>();
    }
	
	void Update ()
    {
        BorderCheck();
        rb2.velocity = direction;
    }

    public void ChangeD(float xR = 0f, float yR = 0f)
    {
        float x = Random.Range(-1f, 1f);
        float y = Random.Range(-1f, 1f);
        direction = new Vector2(x, y);
        direction = direction.normalized * 5;
    }

    public void BorderCheck()
    {
        if (transform.position.x < -10f || transform.position.x > 8f)
            ChangeD();
        else if (transform.position.y < -5.4f || transform.position.y > 5.5f)
            ChangeD();
    }
}
