using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Rigidbody2D theRB;
    public float moveSpeed;


    public Transform firePoint;
    public GameObject Box;
    public float timeBetweenKicks;
    private float Kicks;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical")) * moveSpeed;
        Vector2 mousePos = Input.mousePosition;
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        Vector2 mouseDistance = mousePos - screenPos;
        float angle = Mathf.Atan2(mouseDistance.y, mouseDistance.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, 0f, angle);

        if (Input.GetMouseButton(0))
        {
            Kicks -= Time.deltaTime;

            if (Kicks <= 0)
            {
                Kicks = timeBetweenKicks;
                Instantiate(Box, firePoint.position, firePoint.rotation);
            }
        }
    }
}
