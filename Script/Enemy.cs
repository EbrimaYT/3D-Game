using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    //Varibles
   // public int damage;
    public PlayerController PlayerControllerScript;
    
    //public PlayerState State = PlayerState.Idle;
    //Move da enemy
    public Transform [] patrolPoints;
    public float moveSpeed = 3;
    public int patrolDestination;


    void Start()
    {
      // damage = 5; 
    }

    // Update is called once per frame
    void Update()
    {
       EnemyMovement(); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            //Debug.Log("hit player");
            if(transform.position.y + 1 < collision.gameObject.transform.position.y)
            {
               // Destroy(gameObject);
                //PlayerControllerScript.TakeDamage(0);
            }
            else //if(transform.position.y < collision.gameObject.transform.position.y)
            {
               // PlayerControllerScript.TakeDamage(damage);
            }
        }
    }

    private void EnemyMovement()
    {
        if (patrolDestination ==0)
        {
            transform.position = Vector3.MoveTowards(transform.position, patrolPoints[0].position, moveSpeed * Time.deltaTime);
           
            if (Vector3.Distance(transform.position, patrolPoints[0].position) < 0.5)
            {
                patrolDestination = 1;
            }
        }

        if (patrolDestination == 1)
        {
             transform.position = Vector3.MoveTowards(transform.position, patrolPoints[1].position, moveSpeed * Time.deltaTime);
           
            if (Vector3.Distance(transform.position, patrolPoints[1].position) < 0.5)
            {
                patrolDestination = 0;
            }
           // Debug.Log("change direction");
        }
    }

    // public void SetState(PlayerState s)
    // {
    //     State = s;
    //     if(State == PlayerState.Idle)
    //     {
    //         Anim.Play("Idle");
    //     }
    //     else if ()
    // }
}

