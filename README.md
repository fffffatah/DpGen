# Getting Started

This is a simple package to generate images from the first character of a string. The images later can be used as default profile pictures.
Sample [Here]: [https://github.com/fffffatah/DpGen/blob/master/Sample/dp.jpeg]

## How to Use
First, add the package to your project via Nuget Package manager or running the following command in project directory.
```sh
Install-Package fffffatah.DpGen -Version 1.0.0
```

>Example use case,
```cs
using System.Drawing.Imaging;
class Program{
    public static void Main(string[] args){
        string text = "hello";
        int dimensions = 480;
        int textSize = 256;
        var img = DpGen.Dp.Generate(text, dimensions, textSize);
        img.Save("path/to/save/dp.jpeg", ImageFormat.Jpeg);
    }
}
```
