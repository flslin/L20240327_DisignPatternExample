using UnityEngine;

class NetworkManager : TSingleton<NetworkManager>
{
    public void OnConnectNetworkServer()
    {

    }
}

public class LoginSystem : MonoBehaviour
{
    private void Awake()
    {
        NetworkManager.Instance.OnConnectNetworkServer(); // instance를 만들지 않았지만 사용가능 -> TSingleton에서 작성
    }
}

