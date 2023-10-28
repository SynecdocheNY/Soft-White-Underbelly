using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float speed;

    Vector2 direction = Vector2.zero;
    Animator animator;

    DialogueTextScript dialogueTextScript;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        dialogueTextScript = transform.parent.GetChild(1).GetComponentInChildren<DialogueTextScript>();

        // Test/Placeholder
        dialogueTextScript.InjectText("Wow.");
    }

    // Update is called once per frame
    void Update()
    {


        /* Movement and Animation (bad) */
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                direction = new Vector2(0, 1);
                animator.Play("PlayerWalkUp");
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                direction = new Vector2(-1, 0);
                animator.Play("PlayerWalkLeft");
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                direction = new Vector2(0, -1);
                animator.Play("PlayerWalkDown");
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                direction = new Vector2(1, 0);
                animator.Play("PlayerWalkRight");
            }

            if (!Input.anyKey)
            {
                direction = Vector2.zero;
                animator.Play("PlayerIdle");
            }

            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
}
