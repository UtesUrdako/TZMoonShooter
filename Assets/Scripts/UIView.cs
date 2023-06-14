using InnerProtocol;
using TMPro;
using UnityEngine;

public class UIView : MonoBehaviour
{
    [SerializeField] private TMP_Text shootCountText;
    [SerializeField] private TMP_Text speedBullet;
    [SerializeField] private TMP_Text damageBullet;

    private int shootCount;
    private CustomEvent onPowerUp;
    private CustomSignal onShoot;

    void Start()
    {
        onPowerUp = OnPowerUp;
        onShoot = OnShoot;
        Translator.Add<BaseProtocol>(onPowerUp);
        Translator.Add<BaseProtocol>(onShoot);
    }

    private void OnPowerUp(System.Enum code, ISendData data)
    {
        switch (code)
        {
            case BaseProtocol.PowerUpMessage:
                StringArray message = (StringArray)data;
                speedBullet.text = message.value[0];
                damageBullet.text = message.value[1];
                break;
        }
    }

    private void OnShoot(System.Enum code)
    {
        switch (code)
        {
            case BaseProtocol.Shoot:
                shootCount++;
                shootCountText.text = shootCount.ToString();
                break;
        }
    }
}
