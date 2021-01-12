using UnityEngine;
using UnityEngine.UI;

namespace AS.CanvasScalerPS
{
    public class CanvasScalerPS : CanvasScaler
    {
        [System.Serializable]
        public struct scaleFactors
        {
            public float diagonalInch;
            public float scaleFactor;
        }

        public scaleFactors[] m_scales = {
        new scaleFactors
        {
            diagonalInch = 5,
            scaleFactor = 0.9f
        },
        new scaleFactors
        {
            diagonalInch = 9,
            scaleFactor = 1f
        },
        new scaleFactors
        {
            diagonalInch = 10,
            scaleFactor = 1.2f
        }
    };

        public float getCurrentScreenScale(int h, int w, float dpi)
        {
            if (m_scales == null || m_scales.Length == 0)
                return 1;

            float dI = Mathf.Sqrt(h * h + w * w) / dpi;
            int i = 0;
            while ((i + 1) < m_scales.Length && m_scales[i].diagonalInch < dI)
            {
                i++;
            }

            return m_scales[i].scaleFactor;
        }

        protected override void HandleConstantPhysicalSize()
        {
            float currentDpi = Screen.dpi;
            float dpi = (currentDpi == 0 ? m_FallbackScreenDPI : currentDpi);
            float targetDPI = 1;
            switch (m_PhysicalUnit)
            {
                case Unit.Centimeters:
                    targetDPI = 2.54f;
                    break;
                case Unit.Millimeters:
                    targetDPI = 25.4f;
                    break;
                case Unit.Inches:
                    targetDPI = 1;
                    break;
                case Unit.Points:
                    targetDPI = 72;
                    break;
                case Unit.Picas:
                    targetDPI = 6;
                    break;
            }

            float scale = getCurrentScreenScale(Screen.height, Screen.width, dpi);
            SetScaleFactor(dpi / targetDPI * scale);
            SetReferencePixelsPerUnit(m_ReferencePixelsPerUnit * targetDPI / m_DefaultSpriteDPI / scale);
        }
    }
}


