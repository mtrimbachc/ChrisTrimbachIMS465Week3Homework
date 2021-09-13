using UnityEngine;

public class GameManager : MonoBehaviour
{
    public const float ROW_HEIGHT = 0.48f;
    public const int PIECE_COUNT_PER_ROW = 13;
    public const float PIECE_LENGTH = 0.96f;
    public const int TOTAL_ROWS = 10;

    [SerializeField]
    private Transform pieces = null;

    [SerializeField]
    private GameObject piecePrefab = null;

    [SerializeField]
    private EdgeCollider2D border;


    //TODO

    // Complete
    //Using const data defined above "Instantiate" new pieces to fill the view with

    private void Awake()
    {
        for (int i = 0; i < TOTAL_ROWS; i++)
        {
            for (int j = 0; j < PIECE_COUNT_PER_ROW; j++)
            {
                Vector3 nextPos = new Vector3(pieces.transform.position.x + PIECE_LENGTH * j, pieces.transform.position.y - ROW_HEIGHT * i, pieces.transform.position.z);

                Instantiate(piecePrefab, nextPos, pieces.transform.rotation ,pieces);
            }
        }
    }
}
