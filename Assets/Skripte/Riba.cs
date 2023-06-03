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
        if (transform.position.x < igracPoz.x && Vector2.Distance(igracPoz, this.transform.position) < 100.0f)
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
        if (!c.collider.gameObject.CompareTag("Igrac"))
            return;

        Igrac igrac = c.collider.gameObject.GetComponent<Igrac>();
        igrac.Gorivo += 10;
        Destroy(gameObject);
    }
}