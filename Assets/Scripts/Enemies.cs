using UnityEngine;

public class Enemies : MonoBehaviour
{
    [HideInInspector]
    private float speed;
    private Rigidbody2D mybody;
    private SpriteRenderer sr;
    private Animator anim;

    void Awake()
    {
        mybody = GetComponent<Rigidbody2d>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mybody.velocity = new Vector2(speed, mybody.velocity.y); 
    }
}
