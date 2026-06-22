using UnityEngine.InputSystem;
using UnityEngine;

public class cameralook : MonoBehaviour
{
    [SerializeField] float lookSpeed = 5f;
    [SerializeField] float minPitch = -56f;
    [SerializeField] float maxPitch = 56f;
    float currentpitch = 0f;
    public void Look(InputAction.CallbackContext context)
    {
        Vector2 LookInput = context.ReadValue<Vector2>();
        LookUpDown(LookInput.y);
    }

    void LookUpDown(float LookInput)
    {
        currentpitch -= LookInput * lookSpeed * Time.deltaTime;
        currentpitch = Mathf.Clamp(currentpitch, minPitch, maxPitch);
        transform.localRotation = Quaternion.Euler(currentpitch, 0f, 0f);
    }
}
