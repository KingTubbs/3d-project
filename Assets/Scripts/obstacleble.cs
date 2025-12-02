using UnityEngine;

public class obstacleble : MonoBehaviour
{
    public ParticleSystem collideEffect;
    public AudioClip collectSound;

    private void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("Player"))
    {
        if (collideEffect)
            Instantiate(collideEffect, transform.position, Quaternion.identity);

        if (collectSound)
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
    }
}
}
