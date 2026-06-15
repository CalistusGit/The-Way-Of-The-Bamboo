using UnityEngine;

public class Player : MonoBehaviour
{
    public string playername = "main character"; // This is the var/string for the MC name need to change later.

    public int health = 6; // This is the var/int for health

    public int heal = 3; // This is the var/int for heal

    public int score = 0; // This is the var/int for score

    public float movespeed = 2.5f; // This is the var/float for movement speed for the player speed.

    public float jumpforce = 8; //how high the player can jump.



    public Rigidbody2D rb;
    void Update()
    {
        handlemovement();
        jump();
    }


    private void FixedUpdate()
    {
        // all cooldown needs to done in fixedupdate because the normal update is based on fps.
    }

    private void handlemovement()
    {
        rb.linearVelocity = new Vector2(Input.GetAxisRaw("Horizontal") * movespeed, rb.linearVelocityY);
    }

    private void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpforce);
        }
    }
    private void takedamage(int damage)
    {
        health = health + damage;
    }
    private void playerheal()
    {
        health = health + heal;
    }
}
