using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public float speed;
    private float input;

    Rigidbody2D rb;
    Animator anim;

    public int health;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>(); //storing 2D components that is attached to the player character
    }

    private void Update()
    {
        if (input != 0)
        {
            anim.SetBool("isRunning", true);
        }
        else{
            anim.SetBool("isRunning", false);
        }

        if (input > 0) //moving right
        {
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if(input < 0){ //moving left
            transform.eulerAngles = new Vector3(0, 180, 0);
        }
    }

    // Update is called once per frame
    void FixedUpdate() //physics와 함께작업? FixedUpdate()를 사용해줘야함. 
    {
        //왼쪽키는 -1, 오른쪽키는 1
        //Storing player's move
        //float input = Input.GetAxis("Horizontal"); GetAxis -> 바로 -1, 1로 바뀌는게 아니라 점점 -1이나 1로 다가감.
        input = Input.GetAxisRaw("Horizontal"); // GetAxisRaw -> 바로 -1, 1로 바뀜


        //Moving player
        rb.velocity = new Vector2(input * speed, rb.velocity.y); //(x-가로움직임, y-세로움직임)
        //y는 조작할 필요가 없어서 그냥 rb.velocity.y로 current value 로 설정해줌.
    }

    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;

        if(health <= 0)
        {
            //DESTROY PLAYER
            Destroy(gameObject);
        }
    }
}
