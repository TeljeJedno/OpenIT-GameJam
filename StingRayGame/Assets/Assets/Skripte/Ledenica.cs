using UnityEngine;

public class Ledenica : MonoBehaviour
{
    [SerializeField] Rigidbody2D siljak;

    void OnTriggerEnter2D(Collider2D other) => Destroy(this.gameObject);

    void OnDestroy() => this.siljak.gravityScale = 1.0f;
}