using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BRAD_script : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public CircleCollider2D myCirclecollider2d;
    public float flapSTR;
    public Logic_script logic;
    public bool alive = true;
    public GameObject BRAD;
    public SpriteRenderer spriteRenderer;
    public Sprite upSprite;
    public Sprite dSprite;
    public float deathTime;
    private float timer = 0;
    private float velocitySave;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic_script>();
        myRigidbody = GetComponent<Rigidbody2D>();
        logic.gameOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        velocitySave = myRigidbody.velocity.y;
        if(velocitySave < 0)
        {
            spriteRenderer.sprite = dSprite;
        }
        else
        {
            spriteRenderer.sprite = upSprite;
        }
        if (Input.GetKeyDown(KeyCode.Space) == true & alive == true) {
            myRigidbody.velocity = Vector2.up * flapSTR;               
        }
        if (alive == false)
        {
            if (timer < deathTime)
            {
                timer += Time.deltaTime;
            }
            else
            {
                Destroy(gameObject);
            }
        }
        if (logic.gameOn == false)
        {
            Destroy(gameObject);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {   
        if(logic.gameOn == true) { 
            logic.gameOver();
            alive = false;
            myCirclecollider2d.enabled = false;
            myRigidbody.velocity = new Vector2(1 * flapSTR, 2 * flapSTR);
        }
        else
        {
            alive = false;
            myCirclecollider2d.enabled = false;
            myRigidbody.velocity = Vector2.up * flapSTR * 2;
            myRigidbody.velocity = Vector2.right * flapSTR * 2;
        }
    }
}
