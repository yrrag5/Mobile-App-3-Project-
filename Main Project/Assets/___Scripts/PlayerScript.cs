using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

    // constants
    private const string H_AXIS = "Horizontal";
    private const string V_AXIS = "Vertical";

    // fields
    // make available in the unity to test
    [SerializeField]
    private float speed = 15f;
    [SerializeField]
    private float xMin = -1.9f;
    [SerializeField]
    private float xMax = 1.9f;

    private Rigidbody2D rb;
    // Use this for initialization
    void Start()
    {
        // get the current object
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per view frame
    void Update()
    {

    }
    // update with the physics engine
    private void FixedUpdate()
    {
        //        Input.GetKey(KeyCode.UpArrow )

        // get movement on the axes
        float hMovement = Input.GetAxis(H_AXIS);
        float vMovement = Input.GetAxis(V_AXIS);
        // get the current body and change the velocity
        // using the horizontal movement * speed value
        rb.velocity = new Vector2(hMovement * speed,
                                vMovement * speed);

        // Mathf.Clamp
        // work out the xValue based on the limits
        float xValue = Mathf.Clamp(rb.position.x, xMin, xMax);

        /*
         * float xValue = Mathf.Clamp01(rb.position.x);
         */
        // keep position.x between two values
        rb.position = new Vector2(xValue, rb.position.y);

    }
}
