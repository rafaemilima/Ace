using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRandom : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float steerSpeed = 100f;
    [SerializeField] float stamina = 1.0f;
    [SerializeField] bool isMove = false;
    [SerializeField] GameObject target;
    [SerializeField] ArrayList teste;
    Rigidbody2D rb2d;
    
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        
        
    }

    void Update()
    {
        if (isMove)
        {
            float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
            float moveAmount =  moveSpeed * Time.deltaTime * stamina;
            float x = transform.position.x;
            float y = transform.position.y;
            transform.Rotate(0, 0, target.transform.position.y/2);
            transform.Translate(moveAmount, 0, 0);
        }
    }
}
