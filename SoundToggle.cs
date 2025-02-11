using UnityEngine;
using UnityEngine.UI;

public class SoundToggle : MonoBehaviour
{
    public Sprite soundOnIcon;
    public Sprite soundOffIcon;
    private bool isMuted = false;
    private Button button;

    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(ToggleSound);
        UpdateIcon();
    }

    void ToggleSound()
    {
        isMuted = !isMuted;
        AudioListener.pause = isMuted;
        UpdateIcon();
    }

    void UpdateIcon()
    {
        if (isMuted)
        {
            button.image.sprite = soundOffIcon;
        }
        else
        {
            button.image.sprite = soundOnIcon;
        }
    }
}
