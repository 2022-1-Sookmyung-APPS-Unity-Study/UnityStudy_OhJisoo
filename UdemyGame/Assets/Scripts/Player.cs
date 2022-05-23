using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text healthDisplay;

    public GameObject losePanel;

    public float speed;
    private float input;

    Rigidbody2D rb;
    Animator anim;
    AudioSource source;

    public int health;

    public float startDashTime;
    private float dashTime;
    public float extraSpeed;
    private bool isDashing;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>(); //storing 2D components that is attached to the player character
        healthDisplay.text = health.ToString();
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

        if (Input.GetKeyDown(KeyCode.Space) && isDashing == false)
        {
            speed += extraSpeed;
            isDashing = true;
            dashTime = startDashTime;
        }
        if (dashTime <= 0 && isDashing == true) 
        {
            isDashing = false;
            speed -= extraSpeed;
        }
        else
        {
            dashTime -= Time.deltaTime;
        }
    }

    // Update is called once per frame
    void FixedUpdate() //physics�� �Բ��۾�? FixedUpdate()�� ����������. 
    {
        //����Ű�� -1, ������Ű�� 1
        //Storing player's move
        //float input = Input.GetAxis("Horizontal"); GetAxis -> �ٷ� -1, 1�� �ٲ�°� �ƴ϶� ���� -1�̳� 1�� �ٰ���.
        input = Input.GetAxisRaw("Horizontal"); // GetAxisRaw -> �ٷ� -1, 1�� �ٲ�


        //Moving player
        rb.velocity = new Vector2(input * speed, rb.velocity.y); //(x-���ο�����, y-���ο�����)
        //y�� ������ �ʿ䰡 ��� �׳� rb.velocity.y�� current value �� ��������.
    }

    public void TakeDamage(int damageAmount)
    {
        source.Play();
        health -= damageAmount;
        healthDisplay.text = health.ToString();

        if (health <= 0)
        {
            losePanel.SetActive(true);
            //DESTROY PLAYER
            Destroy(gameObject);

        }
    }
}
