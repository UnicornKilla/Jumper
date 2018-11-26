using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CubeMoving : MonoBehaviour {
    public Text countText;
    private int count;
    float speed;
    float horizontal;    
    Rigidbody2D rb;

	void Start ()
    {
        rb = GetComponent<Rigidbody2D>();
        count = 0;
        setCount();
    }
	
	

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Platform")
        {
            rb.velocity = Vector2.zero;
            rb.AddForce(transform.up * 15f, ForceMode2D.Impulse);
            
        }
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Coin")
        {
            Destroy(other.gameObject);
            count++;
            setCount();
        }
        
    }

    void setCount()
    {
        countText.text = count.ToString();
    }
}
