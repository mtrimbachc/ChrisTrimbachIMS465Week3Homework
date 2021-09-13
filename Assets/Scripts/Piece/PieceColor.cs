using UnityEngine;

public class PieceColor : MonoBehaviour
{
    [SerializeField]
    private Sprite blueColor;
    [SerializeField]
    private Sprite redColor;
    [SerializeField]
    private Sprite greenColor;
    [SerializeField]
    private Sprite purpleColor;
    [SerializeField]
    private Sprite goldColor;
    [SerializeField]
    private Sprite greyColor;
    [SerializeField]
    private Sprite brownColor;

    [SerializeField]
    private SpriteRenderer spriteRenderer;

    private void Awake()
    {
        ChooseColor();
    }

    private void ChooseColor()
    {
        //TODO

        // Complete
        // set spriteRenderer.sprite to a random sprite that is present above



        int rand = Random.Range(0, 7);
        Sprite chosenPiece = null;

        switch(rand)
        {
            case 0:
                chosenPiece = blueColor;
                break;
            case 1:
                chosenPiece = redColor;
                break;
            case 2:
                chosenPiece = greenColor;
                break;
            case 3:
                chosenPiece = purpleColor;
                break;
            case 4:
                chosenPiece = goldColor;
                break;
            case 5:
                chosenPiece = greyColor;
                break;
            case 6:
                chosenPiece = brownColor;
                break;
        }

        spriteRenderer.sprite = chosenPiece;
    }
}
