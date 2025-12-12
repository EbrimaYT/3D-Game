// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class PlayerController : MonoBehaviour
// {
//     // Start is called before the first frame update
//    // public PlayerState State = PlayerState.Idle;
// 	public float playerSpeed = 3f;
// 	public Rigidbody2D playerBody;
// 	public float jumpForce = 100;
// 	public bool isJumping = false;
//     public float Speed = 3f;
//     public float Stun = 1;
//     public float Timer = 1;
// 	//Player Health
//
//     // If time is set to 0 u move, if its at 1, u frezze. should be a if else statement with using moveplayer();
//     //1 code should be the varibles of the stun. then a code that would say how each is given. lastly 1 that runs the stuns 
//     //  public void Stun()
//     //  {
//     //     if 
//     //  }
//     // {
//     //     None=0;
//     //     Idle=1;
//     //     MovePlayer=2;
//     //     Stunned=3;
//     // }
// 	//public int maxHealth = 20;
// 	//public int currentHealth;
// 	//public HealthBar HealthBarScript;
//
// 	// "Flip direction varibles"
// 	public bool flippedLeft; //keeps track of which way our sprite is currently facing
// 	public bool facingLeft; //keeps track of which way our sprite should be face facing
//
//     void Start()
//     {
// 		playerSpeed = 3f; 
//         //MovePlayer();
//       //  currentHealth = maxHealth;
// 		//HealthBarScript.SetMaxHealth(maxHealth);
//     }
//
//     // Update is called once per frame
//     void Update()
//     {
//         Stun -= Time.deltaTime;
//         if (Stun >= 0)
//         {
//             return;
//         }
// 		 Debug.Log("playerSpeed = " + playerSpeed);
//        MovePlayer();
//        Jump();
//         // if(State == PlayerState.Stunned)
//         // {
//         //     StunTimer -= Time.deltaTime;
//         //     if (StunTimer <= 0)
//         //     {
//         //         SetState(PlayerState.Idle);
//         //     }
//         //     return;
//         // }
//
//     }
//
//     private void MovePlayer()
// 	{
// 	Vector3 vel = new Vector3(0,playerBody.linearVelocity.y);
// 	
// 	if(Input.GetKey(KeyCode.A))
// 	{
// 		vel.x = -Speed;
//         //newPos.x -= playerSpeed; //*Time.deltaTime;
// 		facingLeft = false;
// 		Flip(facingLeft);
// 	}
// 	else if(Input.GetKey(KeyCode.D))
// 	{
// 		vel.x = Speed;
//         //newPos.x += playerSpeed; //* Time.deltaTime;
// 		facingLeft = true;
// 		Flip(facingLeft);
// 	}
//     playerBody.linearVelocity = vel;
// 	//transform.position = newPos;
//
// 	}
//
// 	private void Jump()
// 	{
// 		if(!isJumping  && Input.GetKeyDown(KeyCode.W))
// 		{
// 			Debug.Log("jump called");
// 			playerBody.AddForce(new Vector3(0, jumpForce, 0), ForceMode2D.Impulse);
// 			isJumping = true;
// 		}
// 	}
// 	
// 	private void OnCollisionEnter2D(Collision2D collision)
// 	{
//         
// 		if(collision.gameObject.tag == "Surface")
// 		{
// 			isJumping = false;
// 		}
//    // }    
// 		if(collision.gameObject.tag == "Enemy")
// 		{
//             Stun = 1f;
// 			// if(transform.position.y + 1 < collision.gameObject.transform.position.y)
//             // {
//             //       {
// 	        //         Timer -= Time.deltaTime;
// 	        //             if (Timer >= 0)
//                     
// 	        //          {
// 		                  
// 	        //           }
//             //      }
//             // }
//             //  if(transform.position.x < collision.gameObject.transform.position.x)
//             // {
//             // }
//
// 	    }
//     }
// 	//public void TakeDamage(int damage)
// 	//{
// 	//	currentHealth -= damage;
// 		//HealthBarScript.SetHealth(currentHealth);
// 		// Debug.Log("take damage");
// 	//}
//
// 	// void Flip(bool facingLeft)
// 	// {
// 	// 	//Debug.Log("Flip() Called. facingRight = " + facingRight);
// 	// 	if(facingLeft && !flippedLeft)
// 	// 	{
// 	// 		transform.Rotate(0, -180, 0);
// 	// 		flippedLeft = true;
// 	// 	}
//
// 	// }
// 	  void Flip (bool facingLeft)
//     {
//         //Debug.Log("Flip() called. facingRight = " + facingRight);
//         if (facingLeft && !flippedLeft) //if player is facing Left but flipped Right (NOT flipped Left)...
//         {
//
//             transform.Rotate(0, -180, 0);//flip the whole sprite and it's childed Launch point                              
//             flippedLeft = true; //flippedLeft = true
//         }
//         if (!facingLeft && flippedLeft) //if player is facing right (NOT facing Left) but flipped Left...
//         {
//
//             transform.Rotate(0, -180, 0);//flip the whole sprite and it's childed Launch point 
//             flippedLeft = false; //flippedLeft = false
//         }
//     }
// 	// void Update()
//     // {
// 	// Timer -= Time.deltaTime;
// 	// // if (Timer <= 0)
// 	// // {
// 	// // 	SceneManager.LoadScene("EndScene")
// 	// // }
//     // }	
//     // public void SetState(PlayerState s)
//     // {
//     //     State = s;
//     //     if(State == PlayerState.Idle)
//     //     {
//     //         Anim.Play("Idle");
//     //     }
//     //     else if (State == PlayerState.Stunned)
//     //     {
//     //         StunTimer = 0.5f;
//     //         Anim.Play("Spin");
//     //     }
//     // }
// }
