using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Sprite upS, downS, horizS;
    public float moveSpeed;
    private float speedX, speedY;
    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        speedY = Input.GetAxisRaw("Vertical") * moveSpeed;

        rb.velocity = new Vector2 (speedX, speedY);

        if(rb.velocity.y != 0)
        {
            // Set to vertical sprite
            if (rb.velocity.y > 0) { spriteRenderer.sprite = upS; }
            else { spriteRenderer.sprite = downS; }
        }
        else if(rb.velocity.x != 0)
        {
            //Set to horizontal sprite
            spriteRenderer.sprite = horizS;
            if (rb.velocity.x < 0) { spriteRenderer.flipX = true; }
            else { spriteRenderer.flipX = false; }
        }
    }
}
