using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour {

    // Setting enemy patrol movement 
    [SerializeField]
    private float enemyPatrolMov = 2f;

    private Rigidbody2D rb;



    // Use this for initialization
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }
    // Players  movement speed
    private void FixedUpdate()
    {
        rb.velocity = Vector2.left * enemyPatrolMov;

    }

    // Update is called once per frame
    void Update()
    {

    }
}
