using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5;
    private Rigidbody2D rb;
    private float direction;
    
    public float shotDelay = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        direction = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(rb.velocity.x, direction * moveSpeed);

        /*directionX = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(directionX * moveSpeed, rb.velocity.y);*/
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Bonus" )
        {
            Destroy(collision.gameObject);
            StartCoroutine(TimeBetween());
        }
    }

    IEnumerator TimeBetween()
    {
        Shooting.instance.timeBetweenShots -= 0.5f;
        yield return new WaitForSeconds(shotDelay);
        Shooting.instance.timeBetweenShots += 0.5f;
    }
}
