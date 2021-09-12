using UnityEngine;

public class Paddle : MonoBehaviour
{
    //TODO
    // A launched ball will then bounce around, changing its direction upon any collision

    //Complete
    // Move paddle left and right using keyboard keys, mapping is up to you
    // Paddle should be able to launch the ball upon space bar being pressed

    [SerializeField] private float moveSpeed = 1f;
    [SerializeField] private GameObject Ball;
    private GameObject BallLauncher;
    private GameObject activeBall;
    private bool ballLaunched = false;

    private void Start()
    {
        BallLauncher = GameObject.Find("BallLauncher");

        SpawnBall();
    }


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

        if (activeBall != null && !ballLaunched)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Ball ball = activeBall.GetComponent<Ball>();
                ball.Launch();
                ballLaunched = true;
            }
        }

    }

    public void SpawnBall()
    {
        if (Ball != null && BallLauncher != null)
        {
            activeBall = Instantiate(Ball, BallLauncher.transform);
            ballLaunched = false;
        }
    }
}
