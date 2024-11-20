using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KickObj : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D theRB;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = transform.right * moveSpeed;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }
}
