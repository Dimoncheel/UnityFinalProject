using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private float CharacterSpeed = 2.0f;
    private CharacterController characterController;

    public static bool _canDie;

    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float jumpHeight = 2.0f;
    private float gravityValue = -9.81f;
    private bool _isGrounded;


    void Start()
    {
        characterController = GetComponent<CharacterController>();
        _canDie = false;
    }

    // Update is called once per frame
    void Update()
    {
        bool isRun = Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift);
        float factor = CharacterSpeed;//*Time.deltaTime
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            //Stamina -= Time.deltaTime / staminaTime;
            //if (Stamina < 0) Stamina = 0;
            factor *= 2;
        }
        else
        {
        //    Stamina += Time.deltaTime / staminaTime; ;
        //    if (Stamina > 1) Stamina = 1;
        }
        float dx = Input.GetAxis("Horizontal");  // <-, ->, A, D
        float dy = Input.GetAxis("Vertical");

        Vector3 moveDirection =
            (dx * this.transform.right + dy * this.transform.forward);

        if (moveDirection != Vector3.zero)
        {
            moveDirection = moveDirection.normalized;
            float speed = moveDirection.magnitude;
        }

        moveDirection *= factor;

        //  characterController.SimpleMove(moveDirection);



        groundedPlayer = _isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            if(this.transform.parent != null)
            {
                this.transform.parent = null;
            }  
            playerVelocity.y +=
                Mathf.Sqrt(jumpHeight * -2.0f * gravityValue);
           
            //if (isRun)
            //{
               
            //    playerVelocity.y *= 2;
            //} 
            _isGrounded = false;
        }
        
        playerVelocity.y += gravityValue * Time.deltaTime;
        moveDirection.y = playerVelocity.y;
        characterController.Move(moveDirection * CharacterSpeed*Time.deltaTime);
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.tag == "SecondTest")
        {
            this.transform.parent = hit.transform;
            _canDie = true;
        }
        if (hit.gameObject.tag == "FirstTestKube")
        {
          
            _canDie = true;
        }
        if(hit.gameObject.tag == "ThirdTest")
        {
            _canDie= true;
        }
        if (hit.gameObject.tag == "NotDie")
        {
            _canDie = false;
        }
        if (hit.gameObject.name == "Terrain"&& _canDie)
        {
            AllGameData.IsDie = true;
        }
        _isGrounded = true;
    }
    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.name == "Meat")
    //    {
            
    //        Debug.Log("Meat from character");
    //    }
    //}
    //}

}
