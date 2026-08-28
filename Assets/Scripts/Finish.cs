using UnityEngine;

public class Finish : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        Player p = other.GetComponent<Player>();

        if (p == null)
            return;

        UIManager.Instance.ShowNotiText($"YOU WIN!!!!\nPoints: {p.Point}");
        UIManager.Instance.ShowHideRestartButton(true);
        Time.timeScale = 0.5f;

    }
}
