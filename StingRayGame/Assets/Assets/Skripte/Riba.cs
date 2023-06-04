using UnityEngine;

public class Riba : MonoBehaviour
{
    Igrac igrac;
    bool jeOtrovna;

    void Start()
    {
        this.jeOtrovna = Random.Range(-1, 1) == 1;
        this.igrac = GameObject.FindGameObjectWithTag("Igrac").GetComponent<Igrac>();
    }

    void Update()
    {
        Vector2 igracPoz = this.igrac.transform.position;
        if (this.transform.position.x < igracPoz.x && Vector2.Distance(igracPoz, this.transform.position) < 100.0f)
        {
            Destroy(gameObject);
            return;
        }

        Vector2 pozicija = this.transform.position;
        pozicija.x -= 5.0f * Time.deltaTime;
        this.transform.position = pozicija;
    }

    void OnCollisionEnter(Collision c)
    {
        if (c.collider.gameObject.CompareTag("Igrac"))
            this.igrac.Gorivo += this.jeOtrovna ? -20.0f : 20.0f;

        Destroy(this.gameObject);
    }
}