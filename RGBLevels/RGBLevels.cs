using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace RGBLevels
{
  public partial class RGBBalance : Form
  {
    [DllImport("gdi32.dll")]
    private unsafe static extern bool SetDeviceGammaRamp(Int32 hdc, void* ramp);
    
    private Int32 hdc;
    private int red;
    private int green;
    private int blue;

    public RGBBalance()
    {
      hdc = Graphics.FromHwnd(IntPtr.Zero).GetHdc().ToInt32();

      Console.WriteLine();
      String[] arguments = Environment.GetCommandLineArgs();
      if (arguments.Length == 4)
      {
        red = Convert.ToInt32(arguments[1]);
        green = Convert.ToInt32(arguments[2]);
        blue = Convert.ToInt32(arguments[3]);
        UpdateBrightness();
        Environment.Exit(0);
      }
      else
      {

        InitializeComponent();
        red = trackBarRed.Value;
        green = trackBarGreen.Value;
        blue = trackBarBlue.Value;
        UpdateBrightness();
      }
    }

    public unsafe bool UpdateBrightness()
    {
      Console.WriteLine("Red: " + red + ", Green: " + green + ", Blue: " + blue);

      short* ramp = stackalloc short[3 * 256];
      short* idx = ramp;
      for (int i = 0; i < 256; i++)
      {
        int arrayVal = i * (red + 128);
        if (arrayVal > 65535)
          arrayVal = 65535;
        *idx = (short)arrayVal;
        idx++;
      }
      for (int i = 0; i < 256; i++)
      {
        int arrayVal = i * (green + 128);
        if (arrayVal > 65535)
          arrayVal = 65535;
        *idx = (short)arrayVal;
        idx++;
      }
      for (int i = 0; i < 256; i++)
      {
        int arrayVal = i * (blue + 128);
        if (arrayVal > 65535)
          arrayVal = 65535;
        *idx = (short)arrayVal;
        idx++;
      }

      return SetDeviceGammaRamp(hdc, ramp);
    }

    private void trackBarRed_Scroll(object sender, EventArgs e)
    {
      red = trackBarRed.Value;
      UpdateBrightness();
    }

    private void trackBarGreen_Scroll(object sender, EventArgs e)
    {
      green = trackBarGreen.Value;
      UpdateBrightness();
    }

    private void trackBarBlue_Scroll(object sender, EventArgs e)
    {
      blue = trackBarBlue.Value;
      UpdateBrightness();
    }
  }
}
