using UnityEngine;

public class ObjectPlayer : MonoBehaviour
{
    public AudioClip clip;

    // �浹 �� �Ŵ������� �ش� Ŭ���� �÷���, ������Ʈ �ı�
    private void OnCollsionEnter(Collision collision)
    {
        ADManger.Instance.Play(clip);

        Destroy(gameObject);
    }
}
