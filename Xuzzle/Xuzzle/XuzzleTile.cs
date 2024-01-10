using System;
using Xamarin.Forms;

namespace Xuzzle
{
    class XuzzleTile : ContentView
    {
        public XuzzleTile(int row, int col, ImageSource imageSource)
        {
            Row = row;
            Col = col;

            Padding = new Thickness(1);
            Content = new Image
            {
                Source = imageSource
            };
        }

        public int Row { set; get; }

        public int Col { set; get; }
    }
}