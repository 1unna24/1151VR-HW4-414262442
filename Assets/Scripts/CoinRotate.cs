
using UnityEngine;

public class CoinRotate : MonoBehaviour
{
    public float rotateSpeed = 120f;
    public AudioClip collectSound;

    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        // 金幣持續直立旋轉
        transform.Rotate(Vector3.right * rotateSpeed * Time.deltaTime);
    }

   
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("金幣偵測到物件：" + other.name);

        PlaneController plane = other.GetComponentInParent<PlaneController>();

        if (plane != null)
        {
            Debug.Log("飛機經過金幣！準備播放音效");

            if (collectSound != null && audioSource != null)
            {
                audioSource.PlayOneShot(collectSound);
            }
            else
            {
                Debug.LogWarning("缺少收集音效或 Audio Source！");
            }
        }
    }

}
