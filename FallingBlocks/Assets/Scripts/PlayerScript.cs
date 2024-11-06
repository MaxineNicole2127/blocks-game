using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    [SerializeField] private Rigidbody2D rb;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 touchPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            if (touchPos.x < 0)
            {
                MoveLeft();
            }
            else
            {
                MoveRight();
            }
        } else
        {
            StopMoving();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Block")
        {
            Debug.Log("BLOCK!");
            SceneManager.LoadScene(0);
        }
    }

    private void MoveLeft()
    {
        rb.AddForce(Vector2.left * moveSpeed);
    }

    private void MoveRight()
    {
        rb.AddForce(Vector2.right * moveSpeed);
    }

    private void StopMoving()
    {
        rb.velocity = Vector2.zero;
    }



}
