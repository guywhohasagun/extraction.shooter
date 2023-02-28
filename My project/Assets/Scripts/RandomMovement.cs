using UnityEngine;

public class RandomMovement : MonoBehaviour
{
    // the boundries of where the code can go
    public Vector3 minPosition;
    public Vector3 maxPosition;
    
    // how long inbetween movements
    public float delayTime = 3.0f;

    // how fast it moves
    public float moveSpeed = 1.0f;

    // the varible for the target loaction
    private Vector3 targetPosition;

    private float elapsedTime = 0.0f;

    void Start()
    {
        // Set the starting pos
        targetPosition = GetRandomPosition();
    }

    void Update()
    {
        //code that 

        //increment of the elapsed time by real time
        elapsedTime += Time.deltaTime;

        //check if the delay time has elapsed
        if (elapsedTime >= delayTime)
        {
            //reset the elapsed time
            elapsedTime = 0.0f;

            //set a new target position
            targetPosition = GetRandomPosition();
        }

        // moves/bounces towards the target position at the correct speed
        transform.position = Vector3.Lerp(transform.position, targetPosition, moveSpeed * Time.deltaTime);
    }

    private Vector3 GetRandomPosition()
    {
        // generates a random position within the min and max bounds for the cube ro move to
        float x = Random.Range(minPosition.x, maxPosition.x);
        float y = Random.Range(minPosition.y, maxPosition.y);
        float z = Random.Range(minPosition.z, maxPosition.z);
        return new Vector3(x, y, z);
    }
}