using UnityEngine;

public class ZamkaStenaProjektil : MonoBehaviour
{
    [SerializeField] Kretanje igrac;
    [SerializeField] GameObject projektil;
    [SerializeField] bool jeRoditelj;

    void Update()
    {
        if (!this.jeRoditelj)
            return;

        this.transform.position = Vector2.MoveTowards(this.transform.position, this.igrac.transform.position,
            (this.igrac.Brzina + 3.0f) * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision) => Destroy(this.gameObject);

    void OnDestroy() => this.projektil.GetComponent<ZamkaStenaProjektil>().enabled = true;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.collider.CompareTag("Igrac"))
            return;

        Destroy(collision.gameObject);
    }
}