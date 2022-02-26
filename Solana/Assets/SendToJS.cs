using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Runtime.InteropServices;
public class SendToJS : MonoBehaviour
{
    [DllImport("__Internal")]
    private static extern void ConnectWallet();

    [DllImport("__Internal")]
    private static extern void DisonnectWallet();

    public Button connectButton;
    public TMP_Text publicKey;

    private void Start()
    {
        connectButton.onClick.AddListener(() => { ConnectWallet(); });
    }

    public void ShowPublicKey(string _text)
    {
        publicKey.text = _text;
    }

    public void SayHi()
    {
        publicKey.text = "hi";
    }
}
