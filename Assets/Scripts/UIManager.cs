using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    public static UIManager Instance;

    [SerializeField]
    private TMP_Text notiText;

    [SerializeField]
    private GameObject restartButton;

    [SerializeField]
    private Player player;


    private void Awake()
    {
        Instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowNotiText(string s)
    {
        notiText.text = s;
    }

    public void RestartGame()
    {
        player.transform.position = new Vector3(0.38f, 87.5f, -85.4f);
        player.HP = 100;
        player.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
        player.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        ShowNotiText("Restart");
        ShowNotiText($"Your Points\n{player.Point}");
        Time.timeScale = 1f;
        ShowHideRestartButton(false);

    }

    public void ShowHideRestartButton(bool flag)
    {
        restartButton.SetActive(flag);
    }
}
