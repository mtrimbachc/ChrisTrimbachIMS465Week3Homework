using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rigidBody = null;
    [SerializeField] private float moveSpeed = 1f;

    private bool launched = false;
    private Vector3 momentumVector = Vector3.up;

    //TODO: Add code to move ball along with code to delete pieces upon colliding with one

    // Complete
    // Ball should only move once its been launched

    public void FixedUpdate()
    {
        if (launched)
        {
            transform.Translate(momentumVector * Time.deltaTime * moveSpeed, Space.World);
        }
    }

    public void Launch()
    {
        launched = true;
    }
}
