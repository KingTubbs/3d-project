using UnityEngine;

public class Hazard : MonoBehaviour
{
    public ParticleSystem hitEffect;
    public AudioClip hitSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (hitEffect) 
                Instantiate(hitEffect, transform.position, Quaternion.identity);

            if (hitSound) 
                AudioSource.PlayClipAtPoint(hitSound, transform.position);

            GameManager.Instance.GameOver();
        }
    }
}