using System.Collections.ObjectModel;
using System.Windows.Media;
using SciChart.Charting.HistoryManagers;
using SciChart.Charting.Model.ChartSeries;
using SciChart.Charting.Visuals.Annotations;

namespace WpfTestApp;

public class ChartViewModel
{
    public IZoomHistoryManager ZoomHistoryManager { get; set; }

    public ObservableCollection<IAnnotationViewModel> Annotations { get; set; } = new();

    public string MenuItemText => "Test";

    public ChartViewModel()
    {
        ZoomHistoryManager = new ZoomHistoryManager() { HistoryDepth = 10 };

        var textAnnotationViewModel = new TextAnnotationViewModel()
        {
            AnnotationCanvas = AnnotationCanvas.YAxis,
            CanEditText = false,
            IsHidden = false,
            Text = "Test",
            Background = Brushes.Red,
            CoordinateMode = AnnotationCoordinateMode.Relative,
            X1 = 0,
            Y1 = 0
        };
        Annotations.Add(textAnnotationViewModel);
    }
}