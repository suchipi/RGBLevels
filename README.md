# RGBLevels

RGBLevels is an app that uses the [SetDeviceGammaRamp](https://docs.microsoft.com/en-us/windows/desktop/api/wingdi/nf-wingdi-setdevicegammaramp) API to adjust the red/green/blue balance of your monitor.

![Screenshot; three sliders, one for red, one for green, one for blue](https://github.com/suchipi/RGBLevels/raw/master/screenshot.png)

You can run it normally to show the sliders, or run it with command-line-arguments to set the colors without showing the UI:

```
RGBLevels.exe <red> <green> <blue>
# eg
RGBLevels.exe 128 64 0
```

Download [here](https://github.com/suchipi/RGBLevels/releases/download/0.0.2/RGBLevels.exe)

## Notes/Troubleshooting

Some monitors won't change color *at all* if any of the colors are set below 128. If it's not working, try moving all your sliders above 128.
