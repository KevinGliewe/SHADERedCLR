using System;
using System.Runtime.InteropServices;

namespace SHADERedCLR.Wrapper {
    // ed::plugin::PipelineItemType
    public enum PipelineItemType {
        ShaderPass = 0,
        Geometry = 1,
        RenderState = 2,
        Model = 3,
        VertexBuffer = 4,
        ComputePass = 5,
        AudioPass = 6,
        PluginItem = 7,
        Count = 8,
    }

    // ed::plugin::VariableType
    public enum VariableType {
        Boolean1 = 0,
        Boolean2 = 1,
        Boolean3 = 2,
        Boolean4 = 3,
        Integer1 = 4,
        Integer2 = 5,
        Integer3 = 6,
        Integer4 = 7,
        Float1 = 8,
        Float2 = 9,
        Float3 = 10,
        Float4 = 11,
        Float2x2 = 12,
        Float3x3 = 13,
        Float4x4 = 14,
        Count = 15,
    }

    // ed::plugin::InputLayoutValue
    public enum InputLayoutValue {
        Position = 0,
        Normal = 1,
        Texcoord = 2,
        Tangent = 3,
        Binormal = 4,
        Color = 5,
        MaxCount = 6,
    }

    // ed::plugin::MessageType
    public enum MessageType {
        Error = 0,
        Warning = 1,
        Message = 2,
    }

    // ed::plugin::TextEditorPaletteIndex
    public enum TextEditorPaletteIndex {
        Default = 0,
        Keyword = 1,
        Number = 2,
        String = 3,
        CharLiteral = 4,
        Punctuation = 5,
        Preprocessor = 6,
        Identifier = 7,
        KnownIdentifier = 8,
        PreprocIdentifier = 9,
        Comment = 10,
        MultiLineComment = 11,
        Background = 12,
        Cursor = 13,
        Selection = 14,
        ErrorMarker = 15,
        Breakpoint = 16,
        BreakpointOutline = 17,
        CurrentLineIndicator = 18,
        CurrentLineIndicatorOutline = 19,
        LineNumber = 20,
        CurrentLineFill = 21,
        CurrentLineFillInactive = 22,
        CurrentLineEdge = 23,
        ErrorMessage = 24,
        BreakpointDisabled = 25,
        UserFunction = 26,
        UserType = 27,
        UniformVariable = 28,
        GlobalVariable = 29,
        LocalVariable = 30,
        FunctionArgument = 31,
        Max = 32,
    }

    // ed::plugin::ShaderStage
    public enum ShaderStage {
        Vertex = 0,
        Pixel = 1,
        Geometry = 2,
        Compute = 3,
        Audio = 4,
        Plugin = 5,
        Count = 6,
    }

    // ed::plugin::ApplicationEvent
    public enum ApplicationEvent {
        PipelineItemCompiled = 0,
        PipelineItemAdded = 1,
        PipelineItemDeleted = 2,
        PipelineItemRenamed = 3,
        DebuggerStarted = 4,
        DebuggerStepped = 5,
        DebuggerStopped = 6,
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct InputLayoutItem {
        // Value - SHADERedCLR.Wrapper.InputLayoutValue
        // Semantic - IntPtr
    }

    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct ShaderMacro {
        // Active - bool
        // Name - IntPtr
        // Value - IntPtr
    }
}
