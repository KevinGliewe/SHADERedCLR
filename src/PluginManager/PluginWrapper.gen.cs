using System;
using System.Runtime.InteropServices;

namespace PluginManager {
    public partial class PluginWrapper {
        // field Renderer

        // field Messages

        // field Project

        // field UI

        // field ObjectManager

        // field PipelineManager

        // field Plugins

        // field Debugger

        // field AddObject
        public delegate void AddObjectDelegate(IntPtr objects, IntPtr name, IntPtr type, IntPtr data, UInt32 id, IntPtr owner);
        public AddObjectDelegate AddObject { get; protected set; }

        // field AddCustomPipelineItem
        public delegate bool AddCustomPipelineItemDelegate(IntPtr pipeline, IntPtr parent, IntPtr name, IntPtr type, IntPtr data, IntPtr owner);
        public AddCustomPipelineItemDelegate AddCustomPipelineItem { get; protected set; }

        // field AddMessage
        public delegate void AddMessageDelegate(IntPtr messages, PluginManager.MessageType mtype, IntPtr group, IntPtr txt, Int32 ln);
        public AddMessageDelegate AddMessage { get; protected set; }

        // field CreateRenderTexture
        public delegate bool CreateRenderTextureDelegate(IntPtr objects, IntPtr name);
        public CreateRenderTextureDelegate CreateRenderTexture { get; protected set; }

        // field CreateImage
        public delegate bool CreateImageDelegate(IntPtr objects, IntPtr name, Int32 width, Int32 height);
        public CreateImageDelegate CreateImage { get; protected set; }

        // field ResizeRenderTexture
        public delegate void ResizeRenderTextureDelegate(IntPtr objects, IntPtr name, Int32 width, Int32 height);
        public ResizeRenderTextureDelegate ResizeRenderTexture { get; protected set; }

        // field ResizeImage
        public delegate void ResizeImageDelegate(IntPtr objects, IntPtr name, Int32 width, Int32 height);
        public ResizeImageDelegate ResizeImage { get; protected set; }

        // field ExistsObject
        public delegate bool ExistsObjectDelegate(IntPtr objects, IntPtr name);
        public ExistsObjectDelegate ExistsObject { get; protected set; }

        // field RemoveGlobalObject
        public delegate void RemoveGlobalObjectDelegate(IntPtr objects, IntPtr name);
        public RemoveGlobalObjectDelegate RemoveGlobalObject { get; protected set; }

        // field GetProjectPath
        public delegate void GetProjectPathDelegate(IntPtr project, IntPtr filename, IntPtr out_);
        public GetProjectPathDelegate GetProjectPath { get; protected set; }

        // field GetRelativePath
        public delegate void GetRelativePathDelegate(IntPtr project, IntPtr filename, IntPtr out_);
        public GetRelativePathDelegate GetRelativePath { get; protected set; }

        // field GetProjectFilename
        public delegate void GetProjectFilenameDelegate(IntPtr project, IntPtr out_);
        public GetProjectFilenameDelegate GetProjectFilename { get; protected set; }

        // field GetProjectDirectory
        public delegate IntPtr GetProjectDirectoryDelegate(IntPtr project);
        public GetProjectDirectoryDelegate GetProjectDirectory { get; protected set; }

        // field IsProjectModified
        public delegate bool IsProjectModifiedDelegate(IntPtr project);
        public IsProjectModifiedDelegate IsProjectModified { get; protected set; }

        // field ModifyProject
        public delegate void ModifyProjectDelegate(IntPtr project);
        public ModifyProjectDelegate ModifyProject { get; protected set; }

        // field OpenProject
        public delegate void OpenProjectDelegate(IntPtr ui, IntPtr filename);
        public OpenProjectDelegate OpenProject { get; protected set; }

        // field SaveProject
        public delegate void SaveProjectDelegate(IntPtr project);
        public SaveProjectDelegate SaveProject { get; protected set; }

        // field SaveAsProject
        public delegate void SaveAsProjectDelegate(IntPtr project, IntPtr filename, bool copyFiles);
        public SaveAsProjectDelegate SaveAsProject { get; protected set; }

        // field IsPaused
        public delegate bool IsPausedDelegate(IntPtr renderer);
        public IsPausedDelegate IsPaused { get; protected set; }

        // field Pause
        public delegate void PauseDelegate(IntPtr renderer, bool state);
        public PauseDelegate Pause { get; protected set; }

        // field GetWindowColorTexture
        public delegate UInt32 GetWindowColorTextureDelegate(IntPtr renderer);
        public GetWindowColorTextureDelegate GetWindowColorTexture { get; protected set; }

        // field GetWindowDepthTexture
        public delegate UInt32 GetWindowDepthTextureDelegate(IntPtr renderer);
        public GetWindowDepthTextureDelegate GetWindowDepthTexture { get; protected set; }

        // field GetLastRenderSize
        public delegate void GetLastRenderSizeDelegate(IntPtr renderer, Int32 w, Int32 h);
        public GetLastRenderSizeDelegate GetLastRenderSize { get; protected set; }

        // field Render
        public delegate void RenderDelegate(IntPtr renderer, Int32 w, Int32 h);
        public RenderDelegate Render { get; protected set; }

        // field ExistsPipelineItem
        public delegate bool ExistsPipelineItemDelegate(IntPtr pipeline, IntPtr name);
        public ExistsPipelineItemDelegate ExistsPipelineItem { get; protected set; }

        // field GetPipelineItem
        public delegate IntPtr GetPipelineItemDelegate(IntPtr pipeline, IntPtr name);
        public GetPipelineItemDelegate GetPipelineItem { get; protected set; }

        // field BindShaderPassVariables
        public delegate void BindShaderPassVariablesDelegate(IntPtr shaderpass, IntPtr item);
        public BindShaderPassVariablesDelegate BindShaderPassVariables { get; protected set; }

        // field GetViewMatrix
        public delegate void GetViewMatrixDelegate(IntPtr out_);
        public GetViewMatrixDelegate GetViewMatrix { get; protected set; }

        // field GetProjectionMatrix
        public delegate void GetProjectionMatrixDelegate(IntPtr out_);
        public GetProjectionMatrixDelegate GetProjectionMatrix { get; protected set; }

        // field GetOrthographicMatrix
        public delegate void GetOrthographicMatrixDelegate(IntPtr out_);
        public GetOrthographicMatrixDelegate GetOrthographicMatrix { get; protected set; }

        // field GetViewportSize
        public delegate void GetViewportSizeDelegate(float w, float h);
        public GetViewportSizeDelegate GetViewportSize { get; protected set; }

        // field AdvanceTimer
        public delegate void AdvanceTimerDelegate(float t);
        public AdvanceTimerDelegate AdvanceTimer { get; protected set; }

        // field GetMousePosition
        public delegate void GetMousePositionDelegate(float x, float y);
        public GetMousePositionDelegate GetMousePosition { get; protected set; }

        // field GetFrameIndex
        public delegate Int32 GetFrameIndexDelegate();
        public GetFrameIndexDelegate GetFrameIndex { get; protected set; }

        // field GetTime
        public delegate float GetTimeDelegate();
        public GetTimeDelegate GetTime { get; protected set; }

        // field SetTime
        public delegate void SetTimeDelegate(float time);
        public SetTimeDelegate SetTime { get; protected set; }

        // field SetGeometryTransform
        public delegate void SetGeometryTransformDelegate(IntPtr item, IntPtr scale, IntPtr rota, IntPtr pos);
        public SetGeometryTransformDelegate SetGeometryTransform { get; protected set; }

        // field SetMousePosition
        public delegate void SetMousePositionDelegate(float x, float y);
        public SetMousePositionDelegate SetMousePosition { get; protected set; }

        // field SetKeysWASD
        public delegate void SetKeysWASDDelegate(bool w, bool a, bool s, bool d);
        public SetKeysWASDDelegate SetKeysWASD { get; protected set; }

        // field SetFrameIndex
        public delegate void SetFrameIndexDelegate(Int32 findex);
        public SetFrameIndexDelegate SetFrameIndex { get; protected set; }

        // field GetDPI
        public delegate float GetDPIDelegate();
        public GetDPIDelegate GetDPI { get; protected set; }

        // field FileExists
        public delegate bool FileExistsDelegate(IntPtr project, IntPtr path);
        public FileExistsDelegate FileExists { get; protected set; }

        // field ClearMessageGroup
        public delegate void ClearMessageGroupDelegate(IntPtr messages, IntPtr group);
        public ClearMessageGroupDelegate ClearMessageGroup { get; protected set; }

        // field Log
        public delegate void LogDelegate(IntPtr msg, bool error, IntPtr file, Int32 line);
        public LogDelegate Log { get; protected set; }

        // field GetObjectCount
        public delegate Int32 GetObjectCountDelegate(IntPtr objects);
        public GetObjectCountDelegate GetObjectCount { get; protected set; }

        // field GetObjectName
        public delegate IntPtr GetObjectNameDelegate(IntPtr objects, Int32 index);
        public GetObjectNameDelegate GetObjectName { get; protected set; }

        // field IsTexture
        public delegate bool IsTextureDelegate(IntPtr objects, IntPtr name);
        public IsTextureDelegate IsTexture { get; protected set; }

        // field GetTexture
        public delegate UInt32 GetTextureDelegate(IntPtr objects, IntPtr name);
        public GetTextureDelegate GetTexture { get; protected set; }

        // field GetFlippedTexture
        public delegate UInt32 GetFlippedTextureDelegate(IntPtr objects, IntPtr name);
        public GetFlippedTextureDelegate GetFlippedTexture { get; protected set; }

        // field GetTextureSize
        public delegate void GetTextureSizeDelegate(IntPtr objects, IntPtr name, Int32 w, Int32 h);
        public GetTextureSizeDelegate GetTextureSize { get; protected set; }

        // field BindDefaultState
        public delegate void BindDefaultStateDelegate();
        public BindDefaultStateDelegate BindDefaultState { get; protected set; }

        // field OpenInCodeEditor
        public delegate void OpenInCodeEditorDelegate(IntPtr UI, IntPtr item, IntPtr filename, Int32 id);
        public OpenInCodeEditorDelegate OpenInCodeEditor { get; protected set; }

        // field GetPipelineItemCount
        public delegate Int32 GetPipelineItemCountDelegate(IntPtr pipeline);
        public GetPipelineItemCountDelegate GetPipelineItemCount { get; protected set; }

        // field GetPipelineItemType
        public delegate PluginManager.PipelineItemType GetPipelineItemTypeDelegate(IntPtr item);
        public GetPipelineItemTypeDelegate GetPipelineItemType { get; protected set; }

        // field GetPipelineItemByIndex
        public delegate IntPtr GetPipelineItemByIndexDelegate(IntPtr pipeline, Int32 index);
        public GetPipelineItemByIndexDelegate GetPipelineItemByIndex { get; protected set; }

        // field GetPipelineItemName
        public delegate IntPtr GetPipelineItemNameDelegate(IntPtr item);
        public GetPipelineItemNameDelegate GetPipelineItemName { get; protected set; }

        // field GetPipelineItemPluginOwner
        public delegate IntPtr GetPipelineItemPluginOwnerDelegate(IntPtr item);
        public GetPipelineItemPluginOwnerDelegate GetPipelineItemPluginOwner { get; protected set; }

        // field GetPipelineItemVariableCount
        public delegate Int32 GetPipelineItemVariableCountDelegate(IntPtr item);
        public GetPipelineItemVariableCountDelegate GetPipelineItemVariableCount { get; protected set; }

        // field GetPipelineItemVariableName
        public delegate IntPtr GetPipelineItemVariableNameDelegate(IntPtr item, Int32 index);
        public GetPipelineItemVariableNameDelegate GetPipelineItemVariableName { get; protected set; }

        // field GetPipelineItemVariableValue
        public delegate IntPtr GetPipelineItemVariableValueDelegate(IntPtr item, Int32 index);
        public GetPipelineItemVariableValueDelegate GetPipelineItemVariableValue { get; protected set; }

        // field GetPipelineItemVariableType
        public delegate PluginManager.VariableType GetPipelineItemVariableTypeDelegate(IntPtr item, Int32 index);
        public GetPipelineItemVariableTypeDelegate GetPipelineItemVariableType { get; protected set; }

        // field AddPipelineItemVariable
        public delegate bool AddPipelineItemVariableDelegate(IntPtr item, IntPtr name, PluginManager.VariableType type);
        public AddPipelineItemVariableDelegate AddPipelineItemVariable { get; protected set; }

        // field GetPipelineItemChildrenCount
        public delegate Int32 GetPipelineItemChildrenCountDelegate(IntPtr item);
        public GetPipelineItemChildrenCountDelegate GetPipelineItemChildrenCount { get; protected set; }

        // field GetPipelineItemChild
        public delegate IntPtr GetPipelineItemChildDelegate(IntPtr item, Int32 index);
        public GetPipelineItemChildDelegate GetPipelineItemChild { get; protected set; }

        // field SetPipelineItemPosition
        public delegate void SetPipelineItemPositionDelegate(IntPtr item, float x, float y, float z);
        public SetPipelineItemPositionDelegate SetPipelineItemPosition { get; protected set; }

        // field SetPipelineItemRotation
        public delegate void SetPipelineItemRotationDelegate(IntPtr item, float x, float y, float z);
        public SetPipelineItemRotationDelegate SetPipelineItemRotation { get; protected set; }

        // field SetPipelineItemScale
        public delegate void SetPipelineItemScaleDelegate(IntPtr item, float x, float y, float z);
        public SetPipelineItemScaleDelegate SetPipelineItemScale { get; protected set; }

        // field GetPipelineItemPosition
        public delegate void GetPipelineItemPositionDelegate(IntPtr item, IntPtr pos);
        public GetPipelineItemPositionDelegate GetPipelineItemPosition { get; protected set; }

        // field GetPipelineItemRotation
        public delegate void GetPipelineItemRotationDelegate(IntPtr item, IntPtr rot);
        public GetPipelineItemRotationDelegate GetPipelineItemRotation { get; protected set; }

        // field GetPipelineItemScale
        public delegate void GetPipelineItemScaleDelegate(IntPtr item, IntPtr scale);
        public GetPipelineItemScaleDelegate GetPipelineItemScale { get; protected set; }

        // field DEPRECATED_GetOpenDirectoryDialog
        public delegate bool DEPRECATED_GetOpenDirectoryDialogDelegate(IntPtr out_);
        public DEPRECATED_GetOpenDirectoryDialogDelegate DEPRECATED_GetOpenDirectoryDialog { get; protected set; }

        // field DEPRECATED_GetOpenFileDialog
        public delegate bool DEPRECATED_GetOpenFileDialogDelegate(IntPtr out_, IntPtr files);
        public DEPRECATED_GetOpenFileDialogDelegate DEPRECATED_GetOpenFileDialog { get; protected set; }

        // field DEPRECATED_GetSaveFileDialog
        public delegate bool DEPRECATED_GetSaveFileDialogDelegate(IntPtr out_, IntPtr files);
        public DEPRECATED_GetSaveFileDialogDelegate DEPRECATED_GetSaveFileDialog { get; protected set; }

        // field GetIncludePathCount
        public delegate Int32 GetIncludePathCountDelegate();
        public GetIncludePathCountDelegate GetIncludePathCount { get; protected set; }

        // field GetIncludePath
        public delegate IntPtr GetIncludePathDelegate(IntPtr project, Int32 index);
        public GetIncludePathDelegate GetIncludePath { get; protected set; }

        // field GetMessagesCurrentItem
        public delegate IntPtr GetMessagesCurrentItemDelegate(IntPtr messages);
        public GetMessagesCurrentItemDelegate GetMessagesCurrentItem { get; protected set; }

        // field OnEditorContentChange
        public delegate void OnEditorContentChangeDelegate(IntPtr UI, IntPtr plugin, Int32 langID, Int32 editorID);
        public OnEditorContentChangeDelegate OnEditorContentChange { get; protected set; }

        // field GetPipelineItemSPIRV
        public delegate IntPtr GetPipelineItemSPIRVDelegate(IntPtr item, PluginManager.ShaderStage stage, IntPtr dataLen);
        public GetPipelineItemSPIRVDelegate GetPipelineItemSPIRV { get; protected set; }

        // field RegisterShortcut
        public delegate void RegisterShortcutDelegate(IntPtr plugin, IntPtr name);
        public RegisterShortcutDelegate RegisterShortcut { get; protected set; }

        // field GetSettingsBoolean
        public delegate bool GetSettingsBooleanDelegate(IntPtr name);
        public GetSettingsBooleanDelegate GetSettingsBoolean { get; protected set; }

        // field GetSettingsString
        public delegate IntPtr GetSettingsStringDelegate(IntPtr name);
        public GetSettingsStringDelegate GetSettingsString { get; protected set; }

        // field GetSettingsInteger
        public delegate Int32 GetSettingsIntegerDelegate(IntPtr name);
        public GetSettingsIntegerDelegate GetSettingsInteger { get; protected set; }

        // field GetSettingsFloat
        public delegate float GetSettingsFloatDelegate(IntPtr name);
        public GetSettingsFloatDelegate GetSettingsFloat { get; protected set; }

        // field GetPreviewUIRect
        public delegate void GetPreviewUIRectDelegate(IntPtr ui, IntPtr out_);
        public GetPreviewUIRectDelegate GetPreviewUIRect { get; protected set; }

        // field GetPlugin
        public delegate IntPtr GetPluginDelegate(IntPtr pluginManager, IntPtr name);
        public GetPluginDelegate GetPlugin { get; protected set; }

        // field GetPluginListSize
        public delegate Int32 GetPluginListSizeDelegate(IntPtr pluginManager);
        public GetPluginListSizeDelegate GetPluginListSize { get; protected set; }

        // field GetPluginName
        public delegate IntPtr GetPluginNameDelegate(IntPtr pluginManager, Int32 index);
        public GetPluginNameDelegate GetPluginName { get; protected set; }

        // field SendPluginMessage
        public delegate void SendPluginMessageDelegate(IntPtr pluginManager, IntPtr plugin, IntPtr receiver, IntPtr msg, Int32 msgLen);
        public SendPluginMessageDelegate SendPluginMessage { get; protected set; }

        // field BroadcastPluginMessage
        public delegate void BroadcastPluginMessageDelegate(IntPtr pluginManager, IntPtr plugin, IntPtr msg, Int32 msgLen);
        public BroadcastPluginMessageDelegate BroadcastPluginMessage { get; protected set; }

        // field ToggleFullscreen
        public delegate void ToggleFullscreenDelegate(IntPtr UI);
        public ToggleFullscreenDelegate ToggleFullscreen { get; protected set; }

        // field IsFullscreen
        public delegate bool IsFullscreenDelegate(IntPtr UI);
        public IsFullscreenDelegate IsFullscreen { get; protected set; }

        // field TogglePerformanceMode
        public delegate void TogglePerformanceModeDelegate(IntPtr UI);
        public TogglePerformanceModeDelegate TogglePerformanceMode { get; protected set; }

        // field IsInPerformanceMode
        public delegate bool IsInPerformanceModeDelegate(IntPtr UI);
        public IsInPerformanceModeDelegate IsInPerformanceMode { get; protected set; }

        // field PushNotification
        public delegate void PushNotificationDelegate(IntPtr UI, IntPtr plugin, Int32 id, IntPtr text, IntPtr buttonText);
        public PushNotificationDelegate PushNotification { get; protected set; }

        // field DebuggerJump
        public delegate void DebuggerJumpDelegate(IntPtr Debugger, IntPtr TextEditor, Int32 line);
        public DebuggerJumpDelegate DebuggerJump { get; protected set; }

        // field DebuggerContinue
        public delegate void DebuggerContinueDelegate(IntPtr Debugger, IntPtr TextEditor);
        public DebuggerContinueDelegate DebuggerContinue { get; protected set; }

        // field DebuggerStep
        public delegate void DebuggerStepDelegate(IntPtr Debugger, IntPtr TextEditor);
        public DebuggerStepDelegate DebuggerStep { get; protected set; }

        // field DebuggerStepInto
        public delegate void DebuggerStepIntoDelegate(IntPtr Debugger, IntPtr TextEditor);
        public DebuggerStepIntoDelegate DebuggerStepInto { get; protected set; }

        // field DebuggerStepOut
        public delegate void DebuggerStepOutDelegate(IntPtr Debugger, IntPtr TextEditor);
        public DebuggerStepOutDelegate DebuggerStepOut { get; protected set; }

        // field DebuggerCheckBreakpoint
        public delegate bool DebuggerCheckBreakpointDelegate(IntPtr Debugger, IntPtr TextEditor, Int32 line);
        public DebuggerCheckBreakpointDelegate DebuggerCheckBreakpoint { get; protected set; }

        // field DebuggerIsDebugging
        public delegate bool DebuggerIsDebuggingDelegate(IntPtr Debugger, IntPtr TextEditor);
        public DebuggerIsDebuggingDelegate DebuggerIsDebugging { get; protected set; }

        // field DebuggerGetCurrentLine
        public delegate Int32 DebuggerGetCurrentLineDelegate(IntPtr Debugger);
        public DebuggerGetCurrentLineDelegate DebuggerGetCurrentLine { get; protected set; }

        // field IsRenderTexture
        public delegate bool IsRenderTextureDelegate(IntPtr objects, IntPtr name);
        public IsRenderTextureDelegate IsRenderTexture { get; protected set; }

        // field GetRenderTextureSize
        public delegate void GetRenderTextureSizeDelegate(IntPtr objects, IntPtr name, Int32 w, Int32 h);
        public GetRenderTextureSizeDelegate GetRenderTextureSize { get; protected set; }

        // field GetDepthTexture
        public delegate UInt32 GetDepthTextureDelegate(IntPtr objects, IntPtr name);
        public GetDepthTextureDelegate GetDepthTexture { get; protected set; }

        // field ScaleSize
        public delegate float ScaleSizeDelegate(float size);
        public ScaleSizeDelegate ScaleSize { get; protected set; }

        // field GetHostIPluginMaxVersion
        public delegate Int32 GetHostIPluginMaxVersionDelegate();
        public GetHostIPluginMaxVersionDelegate GetHostIPluginMaxVersion { get; protected set; }

        // field ImGuiFileDialogOpen
        public delegate void ImGuiFileDialogOpenDelegate(IntPtr key, IntPtr title, IntPtr filter);
        public ImGuiFileDialogOpenDelegate ImGuiFileDialogOpen { get; protected set; }

        // field ImGuiDirectoryDialogOpen
        public delegate void ImGuiDirectoryDialogOpenDelegate(IntPtr key, IntPtr title);
        public ImGuiDirectoryDialogOpenDelegate ImGuiDirectoryDialogOpen { get; protected set; }

        // field ImGuiFileDialogIsDone
        public delegate bool ImGuiFileDialogIsDoneDelegate(IntPtr key);
        public ImGuiFileDialogIsDoneDelegate ImGuiFileDialogIsDone { get; protected set; }

        // field ImGuiFileDialogClose
        public delegate void ImGuiFileDialogCloseDelegate(IntPtr key);
        public ImGuiFileDialogCloseDelegate ImGuiFileDialogClose { get; protected set; }

        // field ImGuiFileDialogGetResult
        public delegate bool ImGuiFileDialogGetResultDelegate();
        public ImGuiFileDialogGetResultDelegate ImGuiFileDialogGetResult { get; protected set; }

        // field ImGuiFileDialogGetPath
        public delegate void ImGuiFileDialogGetPathDelegate(IntPtr outPath);
        public ImGuiFileDialogGetPathDelegate ImGuiFileDialogGetPath { get; protected set; }

        // field DebuggerImmediate
        public delegate IntPtr DebuggerImmediateDelegate(IntPtr Debugger, IntPtr expr);
        public DebuggerImmediateDelegate DebuggerImmediate { get; protected set; }

        // field RegisterPlugin
        public delegate void RegisterPluginDelegate(IntPtr pluginManager, IntPtr plugin, IntPtr pname, Int32 apiVer, Int32 pluginVer, IntPtr procDLL);
        public RegisterPluginDelegate RegisterPlugin { get; protected set; }

        // function Init

        // function InitUI

        // function OnEvent

        // function Update

        // function Destroy

        // function IsRequired

        // function IsVersionCompatible

        // function BeginRender

        // function EndRender

        // function Project_BeginLoad

        // function Project_EndLoad

        // function Project_BeginSave

        // function Project_EndSave

        // function Project_HasAdditionalData

        // function Project_ExportAdditionalData

        // function Project_ImportAdditionalData

        // function Project_CopyFilesOnSave

        // function HasCustomMenuItem

        // function HasMenuItems

        // function ShowMenuItems

        // function HasContextItems

        // function ShowContextItems

        // function SystemVariables_GetNameCount

        // function SystemVariables_GetName

        // function SystemVariables_HasLastFrame

        // function SystemVariables_UpdateValue

        // function VariableFunctions_GetNameCount

        // function VariableFunctions_GetName

        // function VariableFunctions_ShowArgumentEdit

        // function VariableFunctions_UpdateValue

        // function VariableFunctions_GetArgsSize

        // function VariableFunctions_InitArguments

        // function VariableFunctions_ExportArguments

        // function VariableFunctions_ImportArguments

        // function Object_HasPreview

        // function Object_ShowPreview

        // function Object_IsBindable

        // function Object_IsBindableUAV

        // function Object_Remove

        // function Object_HasExtendedPreview

        // function Object_ShowExtendedPreview

        // function Object_HasProperties

        // function Object_ShowProperties

        // function Object_Bind

        // function Object_Export

        // function Object_Import

        // function Object_HasContext

        // function Object_ShowContext

        // function PipelineItem_HasProperties

        // function PipelineItem_ShowProperties

        // function PipelineItem_IsPickable

        // function PipelineItem_HasShaders

        // function PipelineItem_OpenInEditor

        // function PipelineItem_CanHaveChild

        // function PipelineItem_GetInputLayoutSize

        // function PipelineItem_GetInputLayoutItem

        // function PipelineItem_Remove

        // function PipelineItem_Rename

        // function PipelineItem_AddChild

        // function PipelineItem_CanHaveChildren

        // function PipelineItem_CopyData

        // function PipelineItem_Execute

        // function PipelineItem_Execute

        // function PipelineItem_GetWorldMatrix

        // function PipelineItem_Intersect

        // function PipelineItem_GetBoundingBox

        // function PipelineItem_HasContext

        // function PipelineItem_ShowContext

        // function PipelineItem_Export

        // function PipelineItem_Import

        // function PipelineItem_MoveDown

        // function PipelineItem_MoveUp

        // function PipelineItem_ApplyGizmoTransform

        // function PipelineItem_GetTransform

        // function PipelineItem_DebugVertexExecute

        // function PipelineItem_DebugVertexExecute

        // function PipelineItem_DebugInstanceExecute

        // function PipelineItem_DebugInstanceExecute

        // function PipelineItem_GetVBO

        // function PipelineItem_GetVBOStride

        // function PipelineItem_CanChangeVariables

        // function PipelineItem_IsDebuggable

        // function PipelineItem_IsStageDebuggable

        // function PipelineItem_DebugExecute

        // function PipelineItem_GetTopology

        // function PipelineItem_GetVariableCount

        // function PipelineItem_GetVariableName

        // function PipelineItem_GetVariableType

        // function PipelineItem_GetVariableValueFloat

        // function PipelineItem_GetVariableValueInteger

        // function PipelineItem_GetVariableValueBoolean

        // function PipelineItem_GetSPIRVSize

        // function PipelineItem_GetSPIRV

        // function PipelineItem_DebugPrepareVariables

        // function PipelineItem_DebugUsesCustomTextures

        // function PipelineItem_DebugGetTexture

        // function PipelineItem_DebugGetTextureSize

        // function Options_HasSection

        // function Options_RenderSection

        // function Options_Parse

        // function Options_GetCount

        // function Options_GetKey

        // function Options_GetValue

        // function CustomLanguage_GetCount

        // function CustomLanguage_GetName

        // function CustomLanguage_CompileToSPIRV

        // function CustomLanguage_ProcessGeneratedGLSL

        // function CustomLanguage_SupportsAutoUniforms

        // function CustomLanguage_IsDebuggable

        // function CustomLanguage_GetDefaultExtension

        // function ShaderEditor_Supports

        // function ShaderEditor_Open

        // function ShaderEditor_Render

        // function ShaderEditor_Close

        // function ShaderEditor_GetContent

        // function ShaderEditor_IsChanged

        // function ShaderEditor_ResetChangeState

        // function ShaderEditor_CanUndo

        // function ShaderEditor_CanRedo

        // function ShaderEditor_Undo

        // function ShaderEditor_Redo

        // function ShaderEditor_Cut

        // function ShaderEditor_Paste

        // function ShaderEditor_Copy

        // function ShaderEditor_SelectAll

        // function ShaderEditor_HasStats

        // function CodeEditor_SaveItem

        // function CodeEditor_CloseItem

        // function LanguageDefinition_Exists

        // function LanguageDefinition_GetKeywordCount

        // function LanguageDefinition_GetKeywords

        // function LanguageDefinition_GetTokenRegexCount

        // function LanguageDefinition_GetTokenRegex

        // function LanguageDefinition_GetIdentifierCount

        // function LanguageDefinition_GetIdentifier

        // function LanguageDefinition_GetIdentifierDesc

        // function LanguageDefinition_GetCommentStart

        // function LanguageDefinition_GetCommentEnd

        // function LanguageDefinition_GetLineComment

        // function LanguageDefinition_IsCaseSensitive

        // function LanguageDefinition_GetAutoIndent

        // function LanguageDefinition_GetName

        // function LanguageDefinition_GetNameAbbreviation

        // function Autocomplete_GetCount

        // function Autocomplete_GetDisplayString

        // function Autocomplete_GetSearchString

        // function Autocomplete_GetValue

        // function ShaderFilePath_GetCount

        // function ShaderFilePath_Get

        // function ShaderFilePath_HasChanged

        // function ShaderFilePath_Update

        // function HandleDropFile

        // function HandleRecompile

        // function HandleRecompileFromSource

        // function HandleShortcut

        // function HandlePluginMessage

        // function HandleApplicationEvent

        // function HandleNotification

        // function PipelineItem_SupportsImmediateMode

        // function PipelineItem_HasCustomImmediateModeCompiler

        // function PipelineItem_ImmediateModeCompile

        // function ImmediateMode_GetSPIRVSize

        // function ImmediateMode_GetSPIRV

        // function ImmediateMode_GetVariableCount

        // function ImmediateMode_GetVariableName

        // function ImmediateMode_GetResultID

        // function PluginManager_RegisterPlugins
        protected void InitDelegates(PluginManager.InteropData.ManagedPointerCollection a_MPC) {
            this.AddObject = (AddObjectDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.AddObject_008,typeof(AddObjectDelegate));
            this.AddCustomPipelineItem = (AddCustomPipelineItemDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.AddCustomPipelineItem_009,typeof(AddCustomPipelineItemDelegate));
            this.AddMessage = (AddMessageDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.AddMessage_010,typeof(AddMessageDelegate));
            this.CreateRenderTexture = (CreateRenderTextureDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.CreateRenderTexture_011,typeof(CreateRenderTextureDelegate));
            this.CreateImage = (CreateImageDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.CreateImage_012,typeof(CreateImageDelegate));
            this.ResizeRenderTexture = (ResizeRenderTextureDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.ResizeRenderTexture_013,typeof(ResizeRenderTextureDelegate));
            this.ResizeImage = (ResizeImageDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.ResizeImage_014,typeof(ResizeImageDelegate));
            this.ExistsObject = (ExistsObjectDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.ExistsObject_015,typeof(ExistsObjectDelegate));
            this.RemoveGlobalObject = (RemoveGlobalObjectDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.RemoveGlobalObject_016,typeof(RemoveGlobalObjectDelegate));
            this.GetProjectPath = (GetProjectPathDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetProjectPath_017,typeof(GetProjectPathDelegate));
            this.GetRelativePath = (GetRelativePathDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetRelativePath_018,typeof(GetRelativePathDelegate));
            this.GetProjectFilename = (GetProjectFilenameDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetProjectFilename_019,typeof(GetProjectFilenameDelegate));
            this.GetProjectDirectory = (GetProjectDirectoryDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetProjectDirectory_020,typeof(GetProjectDirectoryDelegate));
            this.IsProjectModified = (IsProjectModifiedDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.IsProjectModified_021,typeof(IsProjectModifiedDelegate));
            this.ModifyProject = (ModifyProjectDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.ModifyProject_022,typeof(ModifyProjectDelegate));
            this.OpenProject = (OpenProjectDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.OpenProject_023,typeof(OpenProjectDelegate));
            this.SaveProject = (SaveProjectDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.SaveProject_024,typeof(SaveProjectDelegate));
            this.SaveAsProject = (SaveAsProjectDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.SaveAsProject_025,typeof(SaveAsProjectDelegate));
            this.IsPaused = (IsPausedDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.IsPaused_026,typeof(IsPausedDelegate));
            this.Pause = (PauseDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.Pause_027,typeof(PauseDelegate));
            this.GetWindowColorTexture = (GetWindowColorTextureDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetWindowColorTexture_028,typeof(GetWindowColorTextureDelegate));
            this.GetWindowDepthTexture = (GetWindowDepthTextureDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetWindowDepthTexture_029,typeof(GetWindowDepthTextureDelegate));
            this.GetLastRenderSize = (GetLastRenderSizeDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetLastRenderSize_030,typeof(GetLastRenderSizeDelegate));
            this.Render = (RenderDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.Render_031,typeof(RenderDelegate));
            this.ExistsPipelineItem = (ExistsPipelineItemDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.ExistsPipelineItem_032,typeof(ExistsPipelineItemDelegate));
            this.GetPipelineItem = (GetPipelineItemDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetPipelineItem_033,typeof(GetPipelineItemDelegate));
            this.BindShaderPassVariables = (BindShaderPassVariablesDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.BindShaderPassVariables_034,typeof(BindShaderPassVariablesDelegate));
            this.GetViewMatrix = (GetViewMatrixDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetViewMatrix_035,typeof(GetViewMatrixDelegate));
            this.GetProjectionMatrix = (GetProjectionMatrixDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetProjectionMatrix_036,typeof(GetProjectionMatrixDelegate));
            this.GetOrthographicMatrix = (GetOrthographicMatrixDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetOrthographicMatrix_037,typeof(GetOrthographicMatrixDelegate));
            this.GetViewportSize = (GetViewportSizeDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetViewportSize_038,typeof(GetViewportSizeDelegate));
            this.AdvanceTimer = (AdvanceTimerDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.AdvanceTimer_039,typeof(AdvanceTimerDelegate));
            this.GetMousePosition = (GetMousePositionDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetMousePosition_040,typeof(GetMousePositionDelegate));
            this.GetFrameIndex = (GetFrameIndexDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetFrameIndex_041,typeof(GetFrameIndexDelegate));
            this.GetTime = (GetTimeDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetTime_042,typeof(GetTimeDelegate));
            this.SetTime = (SetTimeDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.SetTime_043,typeof(SetTimeDelegate));
            this.SetGeometryTransform = (SetGeometryTransformDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.SetGeometryTransform_044,typeof(SetGeometryTransformDelegate));
            this.SetMousePosition = (SetMousePositionDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.SetMousePosition_045,typeof(SetMousePositionDelegate));
            this.SetKeysWASD = (SetKeysWASDDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.SetKeysWASD_046,typeof(SetKeysWASDDelegate));
            this.SetFrameIndex = (SetFrameIndexDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.SetFrameIndex_047,typeof(SetFrameIndexDelegate));
            this.GetDPI = (GetDPIDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetDPI_048,typeof(GetDPIDelegate));
            this.FileExists = (FileExistsDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.FileExists_049,typeof(FileExistsDelegate));
            this.ClearMessageGroup = (ClearMessageGroupDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.ClearMessageGroup_050,typeof(ClearMessageGroupDelegate));
            this.Log = (LogDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.Log_051,typeof(LogDelegate));
            this.GetObjectCount = (GetObjectCountDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetObjectCount_052,typeof(GetObjectCountDelegate));
            this.GetObjectName = (GetObjectNameDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetObjectName_053,typeof(GetObjectNameDelegate));
            this.IsTexture = (IsTextureDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.IsTexture_054,typeof(IsTextureDelegate));
            this.GetTexture = (GetTextureDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetTexture_055,typeof(GetTextureDelegate));
            this.GetFlippedTexture = (GetFlippedTextureDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetFlippedTexture_056,typeof(GetFlippedTextureDelegate));
            this.GetTextureSize = (GetTextureSizeDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetTextureSize_057,typeof(GetTextureSizeDelegate));
            this.BindDefaultState = (BindDefaultStateDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.BindDefaultState_058,typeof(BindDefaultStateDelegate));
            this.OpenInCodeEditor = (OpenInCodeEditorDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.OpenInCodeEditor_059,typeof(OpenInCodeEditorDelegate));
            this.GetPipelineItemCount = (GetPipelineItemCountDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetPipelineItemCount_060,typeof(GetPipelineItemCountDelegate));
            this.GetPipelineItemType = (GetPipelineItemTypeDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetPipelineItemType_061,typeof(GetPipelineItemTypeDelegate));
            this.GetPipelineItemByIndex = (GetPipelineItemByIndexDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetPipelineItemByIndex_062,typeof(GetPipelineItemByIndexDelegate));
            this.GetPipelineItemName = (GetPipelineItemNameDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetPipelineItemName_063,typeof(GetPipelineItemNameDelegate));
            this.GetPipelineItemPluginOwner = (GetPipelineItemPluginOwnerDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetPipelineItemPluginOwner_064,typeof(GetPipelineItemPluginOwnerDelegate));
            this.GetPipelineItemVariableCount = (GetPipelineItemVariableCountDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetPipelineItemVariableCount_065,typeof(GetPipelineItemVariableCountDelegate));
            this.GetPipelineItemVariableName = (GetPipelineItemVariableNameDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetPipelineItemVariableName_066,typeof(GetPipelineItemVariableNameDelegate));
            this.GetPipelineItemVariableValue = (GetPipelineItemVariableValueDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetPipelineItemVariableValue_067,typeof(GetPipelineItemVariableValueDelegate));
            this.GetPipelineItemVariableType = (GetPipelineItemVariableTypeDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetPipelineItemVariableType_068,typeof(GetPipelineItemVariableTypeDelegate));
            this.AddPipelineItemVariable = (AddPipelineItemVariableDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.AddPipelineItemVariable_069,typeof(AddPipelineItemVariableDelegate));
            this.GetPipelineItemChildrenCount = (GetPipelineItemChildrenCountDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetPipelineItemChildrenCount_070,typeof(GetPipelineItemChildrenCountDelegate));
            this.GetPipelineItemChild = (GetPipelineItemChildDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetPipelineItemChild_071,typeof(GetPipelineItemChildDelegate));
            this.SetPipelineItemPosition = (SetPipelineItemPositionDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.SetPipelineItemPosition_072,typeof(SetPipelineItemPositionDelegate));
            this.SetPipelineItemRotation = (SetPipelineItemRotationDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.SetPipelineItemRotation_073,typeof(SetPipelineItemRotationDelegate));
            this.SetPipelineItemScale = (SetPipelineItemScaleDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.SetPipelineItemScale_074,typeof(SetPipelineItemScaleDelegate));
            this.GetPipelineItemPosition = (GetPipelineItemPositionDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetPipelineItemPosition_075,typeof(GetPipelineItemPositionDelegate));
            this.GetPipelineItemRotation = (GetPipelineItemRotationDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetPipelineItemRotation_076,typeof(GetPipelineItemRotationDelegate));
            this.GetPipelineItemScale = (GetPipelineItemScaleDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetPipelineItemScale_077,typeof(GetPipelineItemScaleDelegate));
            this.DEPRECATED_GetOpenDirectoryDialog = (DEPRECATED_GetOpenDirectoryDialogDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.DEPRECATED_GetOpenDirectoryDialog_078,typeof(DEPRECATED_GetOpenDirectoryDialogDelegate));
            this.DEPRECATED_GetOpenFileDialog = (DEPRECATED_GetOpenFileDialogDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.DEPRECATED_GetOpenFileDialog_079,typeof(DEPRECATED_GetOpenFileDialogDelegate));
            this.DEPRECATED_GetSaveFileDialog = (DEPRECATED_GetSaveFileDialogDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.DEPRECATED_GetSaveFileDialog_080,typeof(DEPRECATED_GetSaveFileDialogDelegate));
            this.GetIncludePathCount = (GetIncludePathCountDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetIncludePathCount_081,typeof(GetIncludePathCountDelegate));
            this.GetIncludePath = (GetIncludePathDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetIncludePath_082,typeof(GetIncludePathDelegate));
            this.GetMessagesCurrentItem = (GetMessagesCurrentItemDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetMessagesCurrentItem_083,typeof(GetMessagesCurrentItemDelegate));
            this.OnEditorContentChange = (OnEditorContentChangeDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.OnEditorContentChange_084,typeof(OnEditorContentChangeDelegate));
            this.GetPipelineItemSPIRV = (GetPipelineItemSPIRVDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetPipelineItemSPIRV_085,typeof(GetPipelineItemSPIRVDelegate));
            this.RegisterShortcut = (RegisterShortcutDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.RegisterShortcut_086,typeof(RegisterShortcutDelegate));
            this.GetSettingsBoolean = (GetSettingsBooleanDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetSettingsBoolean_087,typeof(GetSettingsBooleanDelegate));
            this.GetSettingsString = (GetSettingsStringDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetSettingsString_088,typeof(GetSettingsStringDelegate));
            this.GetSettingsInteger = (GetSettingsIntegerDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetSettingsInteger_089,typeof(GetSettingsIntegerDelegate));
            this.GetSettingsFloat = (GetSettingsFloatDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetSettingsFloat_090,typeof(GetSettingsFloatDelegate));
            this.GetPreviewUIRect = (GetPreviewUIRectDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetPreviewUIRect_091,typeof(GetPreviewUIRectDelegate));
            this.GetPlugin = (GetPluginDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetPlugin_092,typeof(GetPluginDelegate));
            this.GetPluginListSize = (GetPluginListSizeDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetPluginListSize_093,typeof(GetPluginListSizeDelegate));
            this.GetPluginName = (GetPluginNameDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetPluginName_094,typeof(GetPluginNameDelegate));
            this.SendPluginMessage = (SendPluginMessageDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.SendPluginMessage_095,typeof(SendPluginMessageDelegate));
            this.BroadcastPluginMessage = (BroadcastPluginMessageDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.BroadcastPluginMessage_096,typeof(BroadcastPluginMessageDelegate));
            this.ToggleFullscreen = (ToggleFullscreenDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.ToggleFullscreen_097,typeof(ToggleFullscreenDelegate));
            this.IsFullscreen = (IsFullscreenDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.IsFullscreen_098,typeof(IsFullscreenDelegate));
            this.TogglePerformanceMode = (TogglePerformanceModeDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.TogglePerformanceMode_099,typeof(TogglePerformanceModeDelegate));
            this.IsInPerformanceMode = (IsInPerformanceModeDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.IsInPerformanceMode_100,typeof(IsInPerformanceModeDelegate));
            this.PushNotification = (PushNotificationDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.PushNotification_101,typeof(PushNotificationDelegate));
            this.DebuggerJump = (DebuggerJumpDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.DebuggerJump_102,typeof(DebuggerJumpDelegate));
            this.DebuggerContinue = (DebuggerContinueDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.DebuggerContinue_103,typeof(DebuggerContinueDelegate));
            this.DebuggerStep = (DebuggerStepDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.DebuggerStep_104,typeof(DebuggerStepDelegate));
            this.DebuggerStepInto = (DebuggerStepIntoDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.DebuggerStepInto_105,typeof(DebuggerStepIntoDelegate));
            this.DebuggerStepOut = (DebuggerStepOutDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.DebuggerStepOut_106,typeof(DebuggerStepOutDelegate));
            this.DebuggerCheckBreakpoint = (DebuggerCheckBreakpointDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.DebuggerCheckBreakpoint_107,typeof(DebuggerCheckBreakpointDelegate));
            this.DebuggerIsDebugging = (DebuggerIsDebuggingDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.DebuggerIsDebugging_108,typeof(DebuggerIsDebuggingDelegate));
            this.DebuggerGetCurrentLine = (DebuggerGetCurrentLineDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.DebuggerGetCurrentLine_109,typeof(DebuggerGetCurrentLineDelegate));
            this.IsRenderTexture = (IsRenderTextureDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.IsRenderTexture_110,typeof(IsRenderTextureDelegate));
            this.GetRenderTextureSize = (GetRenderTextureSizeDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetRenderTextureSize_111,typeof(GetRenderTextureSizeDelegate));
            this.GetDepthTexture = (GetDepthTextureDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetDepthTexture_112,typeof(GetDepthTextureDelegate));
            this.ScaleSize = (ScaleSizeDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.ScaleSize_113,typeof(ScaleSizeDelegate));
            this.GetHostIPluginMaxVersion = (GetHostIPluginMaxVersionDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.GetHostIPluginMaxVersion_114,typeof(GetHostIPluginMaxVersionDelegate));
            this.ImGuiFileDialogOpen = (ImGuiFileDialogOpenDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.ImGuiFileDialogOpen_115,typeof(ImGuiFileDialogOpenDelegate));
            this.ImGuiDirectoryDialogOpen = (ImGuiDirectoryDialogOpenDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.ImGuiDirectoryDialogOpen_116,typeof(ImGuiDirectoryDialogOpenDelegate));
            this.ImGuiFileDialogIsDone = (ImGuiFileDialogIsDoneDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.ImGuiFileDialogIsDone_117,typeof(ImGuiFileDialogIsDoneDelegate));
            this.ImGuiFileDialogClose = (ImGuiFileDialogCloseDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.ImGuiFileDialogClose_118,typeof(ImGuiFileDialogCloseDelegate));
            this.ImGuiFileDialogGetResult = (ImGuiFileDialogGetResultDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.ImGuiFileDialogGetResult_119,typeof(ImGuiFileDialogGetResultDelegate));
            this.ImGuiFileDialogGetPath = (ImGuiFileDialogGetPathDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.ImGuiFileDialogGetPath_120,typeof(ImGuiFileDialogGetPathDelegate));
            this.DebuggerImmediate = (DebuggerImmediateDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.DebuggerImmediate_121,typeof(DebuggerImmediateDelegate));
            this.RegisterPlugin = (RegisterPluginDelegate)Marshal.GetDelegateForFunctionPointer(a_MPC.RegisterPlugin_122,typeof(RegisterPluginDelegate));
        }
    }
}
