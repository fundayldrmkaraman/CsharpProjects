using BarcodeLib;
using System.Drawing;
using System.Drawing.Imaging;

namespace CSharpBarcodeGenerator
{
    public class Program
    {
        static void Main(string[] args)
        {
            Barcode barcodLib = new Barcode();

            int imageWidth = 290;  
            int imageHeight = 120; 
            Color foreColor = Color.Black; 
            Color backColor = Color.White; 

            string NumericString = "038000350216";
            Image barcodeImage = barcodLib.Encode(TYPE.UPCA, NumericString, foreColor, backColor, imageWidth, imageHeight);
            barcodeImage.Save(@"C:\Users\Lenovo\Desktop\Barcode2.png", ImageFormat.Png);
        }
    }
}