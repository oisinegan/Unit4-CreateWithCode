using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    private float speed = 3.0f;
    private GameObject player;
    private Rigidbody enemyRb;
    
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 lookForward = (player.transform.position - transform
            .position).normalized;
        enemyRb.AddForce(lookForward * speed);

        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
