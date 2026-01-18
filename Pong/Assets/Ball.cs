using UnityEngine;

public class Ball : MonoBehaviour
{
    [Header("Speed Settings")]
    float startSpeed = 8f;
    float speedIncrease = 0.5f;
    float maxSpeed = 15f;

    [Header("External References")]
    public Scoreboard scoreboard;

    float speed;
    float radius;
    Vector2 direction;
    AudioSource hitSound;

    int leftScore = 0;
    int rightScore = 0;

    void Start()
    {
        if (scoreboard == null)
            scoreboard = FindAnyObjectByType<Scoreboard>();

        radius = transform.localScale.x / 2;
        hitSound = GetComponent<AudioSource>();

        ResetBall();
    }

    void Update()
    {
        transform.Translate (direction * speed * Time.deltaTime);

        if ((transform.position.y < GameManager.bottomLeft.y + radius && direction.y < 0) || 
            (transform.position.y > GameManager.topRight.y - radius && direction.y > 0))
        {
            direction.y = -direction.y;
            hitSound.pitch = Random.Range(0.9f, 1.1f);
            hitSound.Play();
        }
        
        if (transform.position.x < GameManager.bottomLeft.x + radius && direction.x < 0)
        {
            Debug.Log ("Right scored a point");
            rightScore++;

            if (scoreboard != null) scoreboard.UpdateScore(leftScore, rightScore);

            ResetBall();
            
        }

        if (transform.position.x > GameManager.topRight.x - radius && direction.x > 0)
        {
            Debug.Log ("Left scored a point");
            leftScore++;

            if (scoreboard != null) scoreboard.UpdateScore(leftScore, rightScore);
    
            ResetBall();
        }
    }
    
    void ResetBall()
    {
        transform.position = Vector2.zero;

        speed = startSpeed;

        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;
        direction = new Vector2(x, y).normalized;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Paddle")
        {
            hitSound.pitch = Random.Range(0.9f, 1.1f);
            hitSound.Play();
            
            bool isRight = other.GetComponent<Paddle> ().isRight;
            
            if ((isRight && direction.x > 0) || (!isRight && direction.x <0)) 
                direction.x = -direction.x;

            if (speed < maxSpeed)
                speed += speedIncrease;
        }
    }
}
