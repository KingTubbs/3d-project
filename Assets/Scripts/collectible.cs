using UnityEngine;

public class Collectible : MonoBehaviour
{
    public ParticleSystem collectEffect;
    public AudioClip collectSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (collectEffect) 
                Instantiate(collectEffect, transform.position, Quaternion.identity);

            if (collectSound) 
                AudioSource.PlayClipAtPoint(collectSound, transform.position);

            GameManager.Instance.AddScore(1);
            Destroy(gameObject);
        }
    }
}