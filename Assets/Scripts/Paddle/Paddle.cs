using UnityEngine;

public class Paddle : MonoBehaviour
{
    //TODO
    // Paddle should be able to launch the ball upon space bar being pressed
    // A launched ball will then bounce around, changing its direction upon any collision

    //Complete
    // Move paddle left and right using keyboard keys, mapping is up to you

    [SerializeField] private float moveSpeed = 1f;

    

    public void Update()
    {
        // Movement Code
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * moveSpeed, Space.World);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * moveSpeed, Space.World);
        }

        var xpos = Mathf.Clamp(transform.position.x, -10.5f, 10.5f);
        transform.position = new Vector3(xpos, transform.position.y, transform.position.z);
    }
}
