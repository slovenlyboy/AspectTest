using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraController : MonoBehaviour
{
    
    //ボタン操作用ヴァーチャルカメラ
    [SerializeField]
    CinemachineVirtualCamera _vcam1;
    [SerializeField]
    CinemachineVirtualCamera _vcam2;

    public float _aspectX = 9.0f;
    public float _aspectY = 16.0f;
    Camera camera;

    void Awake()
    {
        camera = GetComponent<Camera>();
        Rect rect = calcAspect(_aspectX, _aspectY);
        camera.rect = rect;
    }

    private void Update()
    {
        //カメラ優先度変化テスト
        if (Input.GetKeyDown("space"))
        {
            if (_vcam1.Priority > _vcam2.Priority)
            {
                _vcam1.Priority = 1;
                _vcam2.Priority = 2;
            }
            else
            {
                _vcam1.Priority = 2;
                _vcam2.Priority = 1;
            }

        }

        Rect rect = calcAspect(_aspectX, _aspectY);
        camera.rect = rect;
    }

    private Rect calcAspect(float width, float height)
    {
        float target_aspect = width / height;
        float window_aspect = (float)Screen.width / (float)Screen.height;
        float scale_height = window_aspect / target_aspect;
        Rect rect = new Rect(0.0f, 0.0f, 1.0f, 1.0f);

        if (1.0f > scale_height)
        {
            rect.x = 0;
            rect.y = (1.0f - scale_height) / 2.0f;
            rect.width = 1.0f;
            rect.height = scale_height;
        }
        else
        {
            float scale_width = 1.0f / scale_height;
            rect.x = (1.0f - scale_width) / 2.0f;
            rect.y = 0.0f;
            rect.width = scale_width;
            rect.height = 1.0f;
        }
        return rect;
    }
}