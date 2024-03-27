using UnityEngine;

public class ObjectPlayer : MonoBehaviour
{
    public AudioClip clip;

    // 충돌 시 매니저에서 해당 클립을 플레이, 오브젝트 파괴
    private void OnCollsionEnter(Collision collision)
    {
        ADManger.Instance.Play(clip);

        Destroy(gameObject);
    }
}
