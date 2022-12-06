using UnityEngine;
using UnityEngine.UI;

public class BarrierManager: MonoBehaviour
{
    public Button barrier1;
    public Button barrier2;
    public GameObject Player;
    public AudioSource Sound;
    public void Schranken1()
    {
        barrier1.image.enabled = false;

    }
    public void Schranken2()
    {
        barrier2.image.enabled = false;
    }

    public void SchrankenOffen()
    {
        if (barrier1.image.enabled == false && barrier2.image.enabled == false)
        {
            Player.transform.position = new Vector3(6.24f, 0f, 0f);
            Sound.Play();
        }
    }
}
