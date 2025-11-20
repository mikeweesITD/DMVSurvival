using UnityEngine;
using Unity.Cinemachine;   // Make sure this resolves once project files are regenerated!

public class CameraSwitcher : MonoBehaviour
{
    public CinemachineCamera firstPersonCam;
    public CinemachineCamera thirdPersonCam;

    private bool usingFirstPerson = true;

    private void Start()
    {
        // Start in first-person view
        if (firstPersonCam != null) firstPersonCam.Priority = 10;
        if (thirdPersonCam != null) thirdPersonCam.Priority = 0;
    }

    private void Update()
    {
        // Press V to switch views
        if (Input.GetKeyDown(KeyCode.V))
        {
            ToggleCamera();
        }
    }

    private void ToggleCamera()
    {
        usingFirstPerson = !usingFirstPerson;

        if (usingFirstPerson)
        {
            firstPersonCam.Priority = 10;
            thirdPersonCam.Priority = 0;
        }
        else
        {
            firstPersonCam.Priority = 0;
            thirdPersonCam.Priority = 10;
        }
    }
}
