
using UnityEngine;

public class PlaneController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float turnSpeed = 60f;
    public float verticalSpeed = 5f;

    public AudioClip collisionSound;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);

        float horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.up * horizontal * turnSpeed * Time.deltaTime);

        float vertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * vertical * verticalSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            if (collisionSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(collisionSound);
            }

            Debug.Log("飛機碰到障礙物：" + other.name);
        }
    }
}
