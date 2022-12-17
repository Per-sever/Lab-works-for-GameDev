using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{
    public float moveSpeed = 3f;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += movement * Time.deltaTime * moveSpeed;

        if (Input.GetAxis("Horizontal") < 0) {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        if (Input.GetAxis("Horizontal") > 0) {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

          if (Input.GetAxis("Horizontal") != 0) {
            anim.SetBool("isRun", true);
        }
        if (Input.GetAxis("Horizontal") == 0) {
            anim.SetBool("isRun", false);
        }
    }
}
