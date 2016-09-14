using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File.Classes
{
    public enum AppCommand
    {
        None = 0,
        Open = 1,
        ZoomIn = 2,
        ZoomOut = 3,
        Pan = 4,
        Measure = 5,
        MeasureArea = 6,
        Select = 7,
        CloseProject = 8,
        SaveProject = 9,
        Identify = 10,
        RemoveLayer = 11,
        ZoomToLayer = 12,
        SetProjection = 13,
        AddVector = 14,
        AddRaster = 15,
        CreateLayer = 16,
        ZoomToSelected = 17,
        ClearSelection = 18,
        SaveProjectAs = 19,
        CloseApp = 20,
        LoadProject = 21,
        Search = 22,
        SelectByPolygon = 23,
        HighlightShapes = 24,
        AddDatabase = 25,
        Snapshot = 26,
        ZoomMax = 27,
        LoadData = 28
    }

    public enum FileType
    {
        Project = 0,
    }

    public enum LayerType
    {
        Vector = 0,
        Raster = 1,
        All = 2,
    }

    public enum EditorCommand
    {
        None = 0,
        AddShape = 1,
        EditShape = 2,
        AddPart = 3,
        RemovePart = 4,
        EditLayer = 5,
        CreateLayer = 6,
        Undo = 7,
        Redo = 8,
        SplitShapes = 9,
        MergeShapes = 10,
        RotateShapes = 11,
        MoveShapes = 12,
        RemoveShapes = 13,
        Copy = 14,
        Paste = 15,
        Cut = 16,
        SplitByPolyline = 17,
        EraseByPolygon = 18,
        ClipByPolygon = 19,
        SplitByPolygon = 20,
        VertexEditor = 21,
        PartEditor = 22,
        ClearEditor = 23,
        SaveShape = 24,
        SelectByRectangle = 25,
        ClearSelection = 26,
        SnappingNone = 27,
        SnappingCurrent = 28,
        SnappingAll = 29,
        HighlightingNone = 30,
        HighlightingCurrent = 31,
        HighlightingAll = 32,
    }

    public enum ProjectState
    {
        NotSaved = 0,
        HasChanges = 1,
        NoChanges = 2,
        Empty = 3,
    }

    
}
