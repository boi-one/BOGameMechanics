using UnityEngine;


public class MouseLook : MonoBehaviour
{
    #region PUBLIC FIELDS

    [Header("Mouse Lock")] public bool isMouseLocked;
    [Header("Camera Field Of View")] public float cameraFieldOfViewMin;
    public float cameraFieldOfViewMax;
    public float fieldOfViewIncrement;
    public float cameraRotateXMin;
    public float cameraRotateXMax;

    [Header("Mouse Smoothing")] public float mouseSmooth;



    #endregion


    #region PRIVATE FIELDS

    private float m_mouseX;
    private float m_mouseY;
    private float m_rotateX;
    private float m_mouseScrollWheel;
    private Transform m_parent;
    private Camera m_camera;
    private float m_fieldOfView;

    #endregion

    #region UNITY_ROUTINES

    private void Awake()
    {
        m_parent = transform.parent;
        m_camera = Camera.main;
        if (m_camera != null) m_fieldOfView = m_camera.fieldOfView;
        MouseLock();
    }

    private void Update()
    {
        MouseInput();
        RotatePlayY();
        RotateCameraX();
        CameraZoom();
    }

    #endregion

    #region HELPER ROUTINES

    private void MouseInput()
    {
        m_mouseX = Input.GetAxisRaw("Mouse X") * mouseSmooth;
        m_mouseY = Input.GetAxisRaw("Mouse Y") * mouseSmooth;
        m_mouseScrollWheel = Input.GetAxisRaw("Mouse ScrollWheel");
    }

    private void RotatePlayY()
    {
        m_parent.Rotate(Vector3.up * m_mouseX);
    }

    private void RotateCameraX()
    {
        m_rotateX += m_mouseY;
        m_rotateX = Mathf.Clamp(m_rotateX, cameraRotateXMin, cameraRotateXMax);
        m_camera.transform.localRotation = Quaternion.Euler(-m_rotateX, 0f, 0f);
    }

    private void MouseLock()
    {
        if (isMouseLocked)
        {
            Cursor.lockState = CursorLockMode.Locked;
            return;
        }

        Cursor.lockState = CursorLockMode.None;
    }

    private void CameraZoom()
    {
        if (m_mouseScrollWheel > 0.0f)
        {
            if (m_fieldOfView + fieldOfViewIncrement >= cameraFieldOfViewMin &&
                m_fieldOfView + fieldOfViewIncrement <= cameraFieldOfViewMax)
            {
                m_fieldOfView += fieldOfViewIncrement;
                m_camera.fieldOfView = m_fieldOfView;
            }

        }

        if (m_mouseScrollWheel < 0.0f)
        {
            if (m_fieldOfView - fieldOfViewIncrement >= cameraFieldOfViewMin &&
                m_fieldOfView - fieldOfViewIncrement <= cameraFieldOfViewMax)
            {
                m_fieldOfView -= fieldOfViewIncrement;
                m_camera.fieldOfView = m_fieldOfView;
            }
        }

    }

    #endregion
}