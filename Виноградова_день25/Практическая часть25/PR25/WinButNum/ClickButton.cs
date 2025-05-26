using System;
using System.Windows.Forms;

public class ClickButton : System.Windows.Forms.Button
{
    private int mClicks;

    public int Clicks
    {
        get { return mClicks; }
    }

    protected override void OnClick(EventArgs e)
    {
        mClicks++; 
        base.OnClick(e); 
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent); 
        System.Drawing.Graphics g = pevent.Graphics;
        System.Drawing.SizeF stringsize;

        stringsize = g.MeasureString(Clicks.ToString(), this.Font, this.Width);

        g.DrawString(Clicks.ToString(), this.Font,
            System.Drawing.SystemBrushes.ControlText,
            this.Width - stringsize.Width - 3, this.Height - stringsize.Height - 3);
    }
}