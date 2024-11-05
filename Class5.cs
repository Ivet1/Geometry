﻿using System.Windows.Media;
using System.Windows.Shapes;
namespace GeometricShapesApp

public class TriangleShape : ShapeBase
{
    public override Shape CreateShape(double width, double height, Color color)
    {
        var polygon = new Polygon
        {
            Points = new PointCollection
            {
                new Point(0, height),
                new Point(width / 2, 0),
                new Point(width, height)
            },
            Fill = new SolidColorBrush(color),
            Stroke = Brushes.Black,
            StrokeThickness = 2
        };
        return polygon;
    }
}

