using Unity.Hierarchy;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.GraphicsBuffer;

public class BallSpawner : MonoBehaviour
{
    public Transform ballPrefab;
    public Transform aimPrefab;

    public GameObject aimPoint;
    private Camera mainCam;

    public float ballDelay = 0.5f;
    public float aimDelay = 0f;
    private float zRotation;
    public float timeBetweenBalls = 0.5f;
    public float timeBetweenAimLine = 0.5f;
    Rigidbody2D rb;

    Vector2 shootLine;
    public float shootPower = 1;
    Vector3 mousePos;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        shootLine = aimPoint.transform.position - transform.position;
        mousePos = mainCam.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector3 rotation = mousePos - transform.position;

        zRotation = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        if (zRotation >= -20)
        {
            zRotation = -20;
        }
        if (zRotation <= -160)
        {
            zRotation = -160;
        }

        transform.rotation = Quaternion.Euler(0, 0, zRotation - 90);
        Debug.Log(zRotation);

        if (ballDelay <= 0 && Mouse.current.leftButton.isPressed)
        {
            ballDelay = timeBetweenBalls;
            SpawnBall();




        }
        else if (aimDelay <= 0)
        {
            aimDelay = timeBetweenAimLine;
            AimLine();
        }

        ballDelay -= Time.deltaTime;
        aimDelay -= Time.deltaTime;
 
    }

    void SpawnBall()
    {

        Transform ball = Instantiate(ballPrefab, transform.position, transform.rotation);

        ball.GetComponent<Rigidbody2D>().AddForce(shootLine * shootPower, ForceMode2D.Impulse);
    }

    void AimLine()
    {
        Transform aimLine = Instantiate(aimPrefab, transform.position, transform.rotation);

        aimLine.GetComponent<Rigidbody2D>().AddForce(shootLine * shootPower, ForceMode2D.Impulse);
    }
}
