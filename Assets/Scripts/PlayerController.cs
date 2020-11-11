using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Animator playerAnim;
    int speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        playerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
		{
            playerAnim.SetBool("isStrafe", true);
            transform.Translate(Vector3.forward * Time.deltaTime * speed);
		}
        if (Input.GetKeyUp(KeyCode.W))
		{
            playerAnim.SetBool("isStrafe", false);
		}
        if (Input.GetKey(KeyCode.Space))
		{
            playerAnim.SetBool("isAttack", true);
		}
        if (Input.GetKeyUp(KeyCode.Space))
		{
            playerAnim.SetBool("isAttack", false);
		}
    }
}
