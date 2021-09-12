using UnityEngine;

public class OutOfBounds : MonoBehaviour
{

    private Paddle player;

    public void Awake()
    {
        player = GameObject.Find("Paddle").GetComponent<Paddle>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //TODO: 

        // Complete
        // Implement functionality to reset the game somehow.
        // Resetting the game includes destroying the out of bounds ball and creating a new one ready to be launched from the paddle


        if (collision.tag == "Ball")
        {
            Destroy(collision.gameObject);

            player.SpawnBall();
        }
    }
}
