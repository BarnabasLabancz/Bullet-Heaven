using UnityEngine;

public class SquareScript : MonoBehaviour
{
    int timer = 0;
    int teleportPeriod = 30;

    float rotationSpeed;
    SpriteRenderer spriteRenderer;

	private void Start()
	{
	    spriteRenderer = GetComponent<SpriteRenderer>();
        rotationSpeed = Random.Range(50, 150);
	}

	void FixedUpdate()
    {
        timer++;
        if (timer > teleportPeriod)
        {
            transform.position = new Vector3(Random.Range(-9, 9), Random.Range(-4, 6), 0);
            transform.localScale = new Vector3(Random.Range(0.4f, 1.8f), Random.Range(0.4f, 1.8f), 0);
            spriteRenderer.color = Random.ColorHSV();

            timer = 0;
        }

        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
