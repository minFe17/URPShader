using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;
using UnityEngine.UI;

public class RPController : MonoBehaviour
{
    [SerializeField] UniversalRenderPipelineAsset _normalAssets;
    [SerializeField] UniversalRenderPipelineAsset _overrideAssets;

    [SerializeField] Slider _slider;

    void Start()
    {
        GraphicsSettings.defaultRenderPipeline = _normalAssets;
        _overrideAssets.supportsHDR = false;
        QualitySettings.renderPipeline = _overrideAssets;
    }

    public void SliderValueChange()
    {
        _overrideAssets.renderScale = _slider.value * 2;
        QualitySettings.renderPipeline = _overrideAssets;
    }

    public void NormalRPButton()
    {
        if (GraphicsSettings.defaultRenderPipeline == _normalAssets)
        {
            GraphicsSettings.defaultRenderPipeline = null;
        }
        else
        {
            GraphicsSettings.defaultRenderPipeline = _normalAssets;
        }
    }

    public void OverrideRPButton()
    {
        if (QualitySettings.renderPipeline == _overrideAssets)
        {
            QualitySettings.renderPipeline = null;
        }
        else
        {
            QualitySettings.renderPipeline = _overrideAssets;
        }
    }
}
