using UnityEngine;

public class Flag : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Player p = other.GetComponent<Player>();

        if (p == null)
            return;

        p.Point += 10;
        UIManager.Instance.ShowNotiText($"Flag Collected!\nPoints: {p.Point}");
        Destroy(gameObject);

    }
}
