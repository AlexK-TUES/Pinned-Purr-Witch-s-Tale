using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameObject myselfLmao;
    public float moveSpeed;
    private float speedX, speedY;
    public Rigidbody2D rb;
    private GameObject[] children = new GameObject[3];
    private bool isWalking = false;

    // Start is called before the first frame update
    void Start()
    {  
        children[0] = GameObject.Find("PlayerFront");
        children[1] = GameObject.Find("PlayerBack");
        children[2] = GameObject.Find("PlayerSide");
        children[1].SetActive(false);
        children[2].SetActive(false);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        speedX = Input.GetAxisRaw("Horizontal") * moveSpeed;
        speedY = Input.GetAxisRaw("Vertical") * moveSpeed;

        rb.velocity = new Vector2 (speedX, speedY);

        if(rb.velocity.y != 0){
            // Set to vertical sprite
            if (rb.velocity.y > 0) { children[1].SetActive(true); children[0].SetActive(false); children[2].SetActive(false); }
            else { children[0].SetActive(true); children[1].SetActive(false); children[2].SetActive(false); }
        }
        else if(rb.velocity.x != 0){
            //Set to horizontal sprite
            children[2].SetActive(true);
            children[0].SetActive(false);
            children[1].SetActive(false);
            if (rb.velocity.x < 0) { children[2].transform.localScale = new Vector3(-1.0f,1.0f,1.0f); }
            else { children[2].transform.localScale = new Vector3(1.0f,1.0f,1.0f); }
        }

        if((speedX>0.01 || speedY>0.01 || speedX<-0.01 || speedY<-0.01)){
            foreach(GameObject child in children){
                child.GetComponent<Animator>().SetBool("isWalking", true);
            }
            isWalking = true;
        }else if(!(speedX>0.01 || speedY>0.01 || speedX<-0.01 || speedY<-0.01)){
            foreach(GameObject child in children){
                child.GetComponent<Animator>().SetBool("isWalking", false);
            }
            isWalking = false;
        }

    }
}
