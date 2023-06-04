using UnityEngine;

public class ZamkaSiljakStena : MonoBehaviour
{
    [SerializeField] Rigidbody2D siljakStena;

    void OnTriggerEnter2D(Collider2D collision) => Destroy(this.gameObject);

    void OnDestroy() => this.siljakStena.gravityScale = 1.0f;
}