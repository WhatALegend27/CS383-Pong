using UnityEngine;

public class Paddle : MonoBehaviour
{

    [SerializeField]
    float speed;

    float height;

    string input;
    public bool isRight { get; private set; }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        height = transform.localScale.y;
    }
    
    public void Init(bool isRightPaddle)
    {

        isRight = isRightPaddle;

        Vector2 pos = Vector2.zero;

        if (isRightPaddle)
        {
            // Place on right of screen
            pos = new Vector2(GameManager.topRight.x, 0);
            pos -= Vector2.right * transform.localScale.x; // Offset from screen edge
            
            input = "PaddleRight";
        }
        else
        {
            // Place on left of screen
            pos = new Vector2(GameManager.bottomLeft.x, 0);
            pos += Vector2.right * transform.localScale.x; // Offset from screen edge
            
            input = "PaddleLeft";
        }

        // Update paddle position
        transform.position = pos;

        transform.name = input;
    }

    // Update is called once per frame
    void Update()
    {
        float move = Input.GetAxis(input) * Time.deltaTime * speed;

        if (transform.position.y < GameManager.bottomLeft.y + height / 2 && move < 0) move = 0;
        if (transform.position.y > GameManager.topRight.y - height / 2 && move > 0) move = 0;

        transform.Translate(move * Vector2.up);
        
        
    }
}
