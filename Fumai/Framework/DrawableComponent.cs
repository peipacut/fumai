using Microsoft.Xna.Framework.Graphics;

namespace Fumai.Framework;

public class DrawableComponent : IDrawable
{
    public bool IsVisible { get; set; }
    
    public List<IDrawable> Children { get; set; } = new List<IDrawable>();
    
    public void Draw(SpriteBatch sb)
    {
        if (!IsVisible)
            return;
        
        foreach (var c in Children)
            c.Draw(sb);
    }
}