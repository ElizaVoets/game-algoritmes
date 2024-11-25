using UnityEngine;

public class FloodFill : MonoBehaviour
{
    [SerializeField] private Color replaceColor = Color.red;

    public Color ReplaceColor => replaceColor;

    public void StartFloodFill(ColorGrid colorGrid, int startX, int startY, Color newColor)
    {
        if (colorGrid == null) return;

        if (startX < 0 || startX >= colorGrid.Width || startY < 0 || startY >= colorGrid.Height) return;

        Color targetColor = colorGrid.GetPixel(startX, startY);
        FloodFillArea(colorGrid, startX, startY, targetColor, newColor);
    }


    private void FloodFillArea(ColorGrid colorGrid, int x, int y, Color targetColor, Color replacementColor)
    {
        
    }
}