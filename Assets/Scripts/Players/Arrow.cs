using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Rigidbody2D rb;
    bool hasHit;
    public int damage = 30;
    private int arrowNumbers=20;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (hasHit == false)
        {
            float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
        else
        {
            Destroy(rb);
        }
    }


    void OnCollisionEnter2D(Collision2D hitInfo)
    {
        if (hitInfo.gameObject.tag.Equals("Arrow"))
        {
            if (arrowNumbers<=0){
                if (gameObject != null)
            {
                // Destroy(gameObject);
                // Destroy(hitInfo.gameObject);
            }
            }
            else{
                arrowNumbers -=1;
            }

            

        }
        //Destroy(gameObject);
    }
}