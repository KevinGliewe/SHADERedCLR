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
        public delegate bool InitDelegate_000(bool isWeb, Int32 sedVersion);
        public virtual bool Init(bool isWeb, Int32 sedVersion) {
            return false;
        }

        // function InitUI
        public delegate void InitUIDelegate_001(IntPtr ctx);
        public virtual void InitUI(IntPtr ctx) {
        }

        // function OnEvent
        public delegate void OnEventDelegate_002(IntPtr e);
        public virtual void OnEvent(IntPtr e) {
        }

        // function Update
        public delegate void UpdateDelegate_003(float delta);
        public virtual void Update(float delta) {
        }

        // function Destroy
        public delegate void DestroyDelegate_004();
        public virtual void Destroy() {
        }

        // function IsRequired
        public delegate bool IsRequiredDelegate_005();
        public virtual bool IsRequired() {
            return false;
        }

        // function IsVersionCompatible
        public delegate bool IsVersionCompatibleDelegate_006(Int32 version);
        public virtual bool IsVersionCompatible(Int32 version) {
            return false;
        }

        // function BeginRender
        public delegate void BeginRenderDelegate_007();
        public virtual void BeginRender() {
        }

        // function EndRender
        public delegate void EndRenderDelegate_008();
        public virtual void EndRender() {
        }

        // function Project_BeginLoad
        public delegate void Project_BeginLoadDelegate_009();
        public virtual void Project_BeginLoad() {
        }

        // function Project_EndLoad
        public delegate void Project_EndLoadDelegate_010();
        public virtual void Project_EndLoad() {
        }

        // function Project_BeginSave
        public delegate void Project_BeginSaveDelegate_011();
        public virtual void Project_BeginSave() {
        }

        // function Project_EndSave
        public delegate void Project_EndSaveDelegate_012();
        public virtual void Project_EndSave() {
        }

        // function Project_HasAdditionalData
        public delegate bool Project_HasAdditionalDataDelegate_013();
        public virtual bool Project_HasAdditionalData() {
            return false;
        }

        // function Project_ExportAdditionalData
        public delegate IntPtr Project_ExportAdditionalDataDelegate_014();
        public virtual IntPtr Project_ExportAdditionalData() {
            return IntPtr.Zero;
        }

        // function Project_ImportAdditionalData
        public delegate void Project_ImportAdditionalDataDelegate_015(IntPtr xml);
        public virtual void Project_ImportAdditionalData(IntPtr xml) {
        }

        // function Project_CopyFilesOnSave
        public delegate void Project_CopyFilesOnSaveDelegate_016(IntPtr dir);
        public virtual void Project_CopyFilesOnSave(IntPtr dir) {
        }

        // function HasCustomMenuItem
        public delegate bool HasCustomMenuItemDelegate_017();
        public virtual bool HasCustomMenuItem() {
            return false;
        }

        // function HasMenuItems
        public delegate bool HasMenuItemsDelegate_018(IntPtr name);
        public virtual bool HasMenuItems(IntPtr name) {
            return false;
        }

        // function ShowMenuItems
        public delegate void ShowMenuItemsDelegate_019(IntPtr name);
        public virtual void ShowMenuItems(IntPtr name) {
        }

        // function HasContextItems
        public delegate bool HasContextItemsDelegate_020(IntPtr name);
        public virtual bool HasContextItems(IntPtr name) {
            return false;
        }

        // function ShowContextItems
        public delegate void ShowContextItemsDelegate_021(IntPtr name, IntPtr owner, IntPtr extraData);
        public virtual void ShowContextItems(IntPtr name, IntPtr owner, IntPtr extraData) {
        }

        // function SystemVariables_GetNameCount
        public delegate Int32 SystemVariables_GetNameCountDelegate_022(PluginManager.VariableType varType);
        public virtual Int32 SystemVariables_GetNameCount(PluginManager.VariableType varType) {
            return 0;
        }

        // function SystemVariables_GetName
        public delegate IntPtr SystemVariables_GetNameDelegate_023(PluginManager.VariableType varType, Int32 index);
        public virtual IntPtr SystemVariables_GetName(PluginManager.VariableType varType, Int32 index) {
            return IntPtr.Zero;
        }

        // function SystemVariables_HasLastFrame
        public delegate bool SystemVariables_HasLastFrameDelegate_024(IntPtr name, PluginManager.VariableType varType);
        public virtual bool SystemVariables_HasLastFrame(IntPtr name, PluginManager.VariableType varType) {
            return false;
        }

        // function SystemVariables_UpdateValue
        public delegate void SystemVariables_UpdateValueDelegate_025(IntPtr data, IntPtr name, PluginManager.VariableType varType, bool isLastFrame);
        public virtual void SystemVariables_UpdateValue(IntPtr data, IntPtr name, PluginManager.VariableType varType, bool isLastFrame) {
        }

        // function VariableFunctions_GetNameCount
        public delegate Int32 VariableFunctions_GetNameCountDelegate_026(PluginManager.VariableType vtype);
        public virtual Int32 VariableFunctions_GetNameCount(PluginManager.VariableType vtype) {
            return 0;
        }

        // function VariableFunctions_GetName
        public delegate IntPtr VariableFunctions_GetNameDelegate_027(PluginManager.VariableType varType, Int32 index);
        public virtual IntPtr VariableFunctions_GetName(PluginManager.VariableType varType, Int32 index) {
            return IntPtr.Zero;
        }

        // function VariableFunctions_ShowArgumentEdit
        public delegate bool VariableFunctions_ShowArgumentEditDelegate_028(IntPtr fname, IntPtr args, PluginManager.VariableType vtype);
        public virtual bool VariableFunctions_ShowArgumentEdit(IntPtr fname, IntPtr args, PluginManager.VariableType vtype) {
            return false;
        }

        // function VariableFunctions_UpdateValue
        public delegate void VariableFunctions_UpdateValueDelegate_029(IntPtr data, IntPtr args, IntPtr fname, PluginManager.VariableType varType);
        public virtual void VariableFunctions_UpdateValue(IntPtr data, IntPtr args, IntPtr fname, PluginManager.VariableType varType) {
        }

        // function VariableFunctions_GetArgsSize
        public delegate Int32 VariableFunctions_GetArgsSizeDelegate_030(IntPtr fname, PluginManager.VariableType varType);
        public virtual Int32 VariableFunctions_GetArgsSize(IntPtr fname, PluginManager.VariableType varType) {
            return 0;
        }

        // function VariableFunctions_InitArguments
        public delegate void VariableFunctions_InitArgumentsDelegate_031(IntPtr args, IntPtr fname, PluginManager.VariableType vtype);
        public virtual void VariableFunctions_InitArguments(IntPtr args, IntPtr fname, PluginManager.VariableType vtype) {
        }

        // function VariableFunctions_ExportArguments
        public delegate IntPtr VariableFunctions_ExportArgumentsDelegate_032(IntPtr fname, PluginManager.VariableType vtype, IntPtr args);
        public virtual IntPtr VariableFunctions_ExportArguments(IntPtr fname, PluginManager.VariableType vtype, IntPtr args) {
            return IntPtr.Zero;
        }

        // function VariableFunctions_ImportArguments
        public delegate void VariableFunctions_ImportArgumentsDelegate_033(IntPtr fname, PluginManager.VariableType vtype, IntPtr args, IntPtr argsString);
        public virtual void VariableFunctions_ImportArguments(IntPtr fname, PluginManager.VariableType vtype, IntPtr args, IntPtr argsString) {
        }

        // function Object_HasPreview
        public delegate bool Object_HasPreviewDelegate_034(IntPtr type);
        public virtual bool Object_HasPreview(IntPtr type) {
            return false;
        }

        // function Object_ShowPreview
        public delegate void Object_ShowPreviewDelegate_035(IntPtr type, IntPtr data, UInt32 id);
        public virtual void Object_ShowPreview(IntPtr type, IntPtr data, UInt32 id) {
        }

        // function Object_IsBindable
        public delegate bool Object_IsBindableDelegate_036(IntPtr type);
        public virtual bool Object_IsBindable(IntPtr type) {
            return false;
        }

        // function Object_IsBindableUAV
        public delegate bool Object_IsBindableUAVDelegate_037(IntPtr type);
        public virtual bool Object_IsBindableUAV(IntPtr type) {
            return false;
        }

        // function Object_Remove
        public delegate void Object_RemoveDelegate_038(IntPtr name, IntPtr type, IntPtr data, UInt32 id);
        public virtual void Object_Remove(IntPtr name, IntPtr type, IntPtr data, UInt32 id) {
        }

        // function Object_HasExtendedPreview
        public delegate bool Object_HasExtendedPreviewDelegate_039(IntPtr type);
        public virtual bool Object_HasExtendedPreview(IntPtr type) {
            return false;
        }

        // function Object_ShowExtendedPreview
        public delegate void Object_ShowExtendedPreviewDelegate_040(IntPtr type, IntPtr data, UInt32 id);
        public virtual void Object_ShowExtendedPreview(IntPtr type, IntPtr data, UInt32 id) {
        }

        // function Object_HasProperties
        public delegate bool Object_HasPropertiesDelegate_041(IntPtr type);
        public virtual bool Object_HasProperties(IntPtr type) {
            return false;
        }

        // function Object_ShowProperties
        public delegate void Object_ShowPropertiesDelegate_042(IntPtr type, IntPtr data, UInt32 id);
        public virtual void Object_ShowProperties(IntPtr type, IntPtr data, UInt32 id) {
        }

        // function Object_Bind
        public delegate void Object_BindDelegate_043(IntPtr type, IntPtr data, UInt32 id);
        public virtual void Object_Bind(IntPtr type, IntPtr data, UInt32 id) {
        }

        // function Object_Export
        public delegate IntPtr Object_ExportDelegate_044(IntPtr type, IntPtr data, UInt32 id);
        public virtual IntPtr Object_Export(IntPtr type, IntPtr data, UInt32 id) {
            return IntPtr.Zero;
        }

        // function Object_Import
        public delegate void Object_ImportDelegate_045(IntPtr name, IntPtr type, IntPtr argsString);
        public virtual void Object_Import(IntPtr name, IntPtr type, IntPtr argsString) {
        }

        // function Object_HasContext
        public delegate bool Object_HasContextDelegate_046(IntPtr type);
        public virtual bool Object_HasContext(IntPtr type) {
            return false;
        }

        // function Object_ShowContext
        public delegate void Object_ShowContextDelegate_047(IntPtr type, IntPtr data);
        public virtual void Object_ShowContext(IntPtr type, IntPtr data) {
        }

        // function PipelineItem_HasProperties
        public delegate bool PipelineItem_HasPropertiesDelegate_048(IntPtr type, IntPtr data);
        public virtual bool PipelineItem_HasProperties(IntPtr type, IntPtr data) {
            return false;
        }

        // function PipelineItem_ShowProperties
        public delegate void PipelineItem_ShowPropertiesDelegate_049(IntPtr type, IntPtr data);
        public virtual void PipelineItem_ShowProperties(IntPtr type, IntPtr data) {
        }

        // function PipelineItem_IsPickable
        public delegate bool PipelineItem_IsPickableDelegate_050(IntPtr type, IntPtr data);
        public virtual bool PipelineItem_IsPickable(IntPtr type, IntPtr data) {
            return false;
        }

        // function PipelineItem_HasShaders
        public delegate bool PipelineItem_HasShadersDelegate_051(IntPtr type, IntPtr data);
        public virtual bool PipelineItem_HasShaders(IntPtr type, IntPtr data) {
            return false;
        }

        // function PipelineItem_OpenInEditor
        public delegate void PipelineItem_OpenInEditorDelegate_052(IntPtr type, IntPtr data);
        public virtual void PipelineItem_OpenInEditor(IntPtr type, IntPtr data) {
        }

        // function PipelineItem_CanHaveChild
        public delegate bool PipelineItem_CanHaveChildDelegate_053(IntPtr type, IntPtr data, PluginManager.PipelineItemType itemType);
        public virtual bool PipelineItem_CanHaveChild(IntPtr type, IntPtr data, PluginManager.PipelineItemType itemType) {
            return false;
        }

        // function PipelineItem_GetInputLayoutSize
        public delegate Int32 PipelineItem_GetInputLayoutSizeDelegate_054(IntPtr type, IntPtr data);
        public virtual Int32 PipelineItem_GetInputLayoutSize(IntPtr type, IntPtr data) {
            return 0;
        }

        // function PipelineItem_GetInputLayoutItem
        public delegate void PipelineItem_GetInputLayoutItemDelegate_055(IntPtr type, IntPtr data, Int32 index, InputLayoutItem out_);
        public virtual void PipelineItem_GetInputLayoutItem(IntPtr type, IntPtr data, Int32 index, InputLayoutItem out_) {
        }

        // function PipelineItem_Remove
        public delegate void PipelineItem_RemoveDelegate_056(IntPtr itemName, IntPtr type, IntPtr data);
        public virtual void PipelineItem_Remove(IntPtr itemName, IntPtr type, IntPtr data) {
        }

        // function PipelineItem_Rename
        public delegate void PipelineItem_RenameDelegate_057(IntPtr oldName, IntPtr newName);
        public virtual void PipelineItem_Rename(IntPtr oldName, IntPtr newName) {
        }

        // function PipelineItem_AddChild
        public delegate void PipelineItem_AddChildDelegate_058(IntPtr owner, IntPtr name, PluginManager.PipelineItemType type, IntPtr data);
        public virtual void PipelineItem_AddChild(IntPtr owner, IntPtr name, PluginManager.PipelineItemType type, IntPtr data) {
        }

        // function PipelineItem_CanHaveChildren
        public delegate bool PipelineItem_CanHaveChildrenDelegate_059(IntPtr type, IntPtr data);
        public virtual bool PipelineItem_CanHaveChildren(IntPtr type, IntPtr data) {
            return false;
        }

        // function PipelineItem_CopyData
        public delegate IntPtr PipelineItem_CopyDataDelegate_060(IntPtr type, IntPtr data);
        public virtual IntPtr PipelineItem_CopyData(IntPtr type, IntPtr data) {
            return IntPtr.Zero;
        }

        // function PipelineItem_Execute
        public delegate void PipelineItem_ExecuteDelegate_061(IntPtr Owner, PluginManager.PipelineItemType OwnerType, IntPtr type, IntPtr data);
        public virtual void PipelineItem_Execute(IntPtr Owner, PluginManager.PipelineItemType OwnerType, IntPtr type, IntPtr data) {
        }

        // function PipelineItem_Execute
        public delegate void PipelineItem_ExecuteDelegate_062(IntPtr type, IntPtr data, IntPtr children, Int32 count);
        public virtual void PipelineItem_Execute(IntPtr type, IntPtr data, IntPtr children, Int32 count) {
        }

        // function PipelineItem_GetWorldMatrix
        public delegate void PipelineItem_GetWorldMatrixDelegate_063(IntPtr type, IntPtr data, IntPtr pMat);
        public virtual void PipelineItem_GetWorldMatrix(IntPtr type, IntPtr data, IntPtr pMat) {
        }

        // function PipelineItem_Intersect
        public delegate bool PipelineItem_IntersectDelegate_064(IntPtr type, IntPtr data, IntPtr rayOrigin, IntPtr rayDir, float hitDist);
        public virtual bool PipelineItem_Intersect(IntPtr type, IntPtr data, IntPtr rayOrigin, IntPtr rayDir, float hitDist) {
            return false;
        }

        // function PipelineItem_GetBoundingBox
        public delegate void PipelineItem_GetBoundingBoxDelegate_065(IntPtr type, IntPtr data, IntPtr minPos, IntPtr maxPos);
        public virtual void PipelineItem_GetBoundingBox(IntPtr type, IntPtr data, IntPtr minPos, IntPtr maxPos) {
        }

        // function PipelineItem_HasContext
        public delegate bool PipelineItem_HasContextDelegate_066(IntPtr type, IntPtr data);
        public virtual bool PipelineItem_HasContext(IntPtr type, IntPtr data) {
            return false;
        }

        // function PipelineItem_ShowContext
        public delegate void PipelineItem_ShowContextDelegate_067(IntPtr type, IntPtr data);
        public virtual void PipelineItem_ShowContext(IntPtr type, IntPtr data) {
        }

        // function PipelineItem_Export
        public delegate IntPtr PipelineItem_ExportDelegate_068(IntPtr type, IntPtr data);
        public virtual IntPtr PipelineItem_Export(IntPtr type, IntPtr data) {
            return IntPtr.Zero;
        }

        // function PipelineItem_Import
        public delegate IntPtr PipelineItem_ImportDelegate_069(IntPtr ownerName, IntPtr name, IntPtr type, IntPtr argsString);
        public virtual IntPtr PipelineItem_Import(IntPtr ownerName, IntPtr name, IntPtr type, IntPtr argsString) {
            return IntPtr.Zero;
        }

        // function PipelineItem_MoveDown
        public delegate void PipelineItem_MoveDownDelegate_070(IntPtr ownerData, IntPtr ownerType, IntPtr itemName);
        public virtual void PipelineItem_MoveDown(IntPtr ownerData, IntPtr ownerType, IntPtr itemName) {
        }

        // function PipelineItem_MoveUp
        public delegate void PipelineItem_MoveUpDelegate_071(IntPtr ownerData, IntPtr ownerType, IntPtr itemName);
        public virtual void PipelineItem_MoveUp(IntPtr ownerData, IntPtr ownerType, IntPtr itemName) {
        }

        // function PipelineItem_ApplyGizmoTransform
        public delegate void PipelineItem_ApplyGizmoTransformDelegate_072(IntPtr type, IntPtr data, IntPtr transl, IntPtr scale, IntPtr rota);
        public virtual void PipelineItem_ApplyGizmoTransform(IntPtr type, IntPtr data, IntPtr transl, IntPtr scale, IntPtr rota) {
        }

        // function PipelineItem_GetTransform
        public delegate void PipelineItem_GetTransformDelegate_073(IntPtr type, IntPtr data, IntPtr transl, IntPtr scale, IntPtr rota);
        public virtual void PipelineItem_GetTransform(IntPtr type, IntPtr data, IntPtr transl, IntPtr scale, IntPtr rota) {
        }

        // function PipelineItem_DebugVertexExecute
        public delegate void PipelineItem_DebugVertexExecuteDelegate_074(IntPtr Owner, PluginManager.PipelineItemType OwnerType, IntPtr type, IntPtr data, UInt32 colorVarLoc);
        public virtual void PipelineItem_DebugVertexExecute(IntPtr Owner, PluginManager.PipelineItemType OwnerType, IntPtr type, IntPtr data, UInt32 colorVarLoc) {
        }

        // function PipelineItem_DebugVertexExecute
        public delegate Int32 PipelineItem_DebugVertexExecuteDelegate_075(IntPtr type, IntPtr data, IntPtr childName, float rx, float ry, Int32 vertexGroup);
        public virtual Int32 PipelineItem_DebugVertexExecute(IntPtr type, IntPtr data, IntPtr childName, float rx, float ry, Int32 vertexGroup) {
            return 0;
        }

        // function PipelineItem_DebugInstanceExecute
        public delegate void PipelineItem_DebugInstanceExecuteDelegate_076(IntPtr Owner, PluginManager.PipelineItemType OwnerType, IntPtr type, IntPtr data, UInt32 colorVarLoc);
        public virtual void PipelineItem_DebugInstanceExecute(IntPtr Owner, PluginManager.PipelineItemType OwnerType, IntPtr type, IntPtr data, UInt32 colorVarLoc) {
        }

        // function PipelineItem_DebugInstanceExecute
        public delegate Int32 PipelineItem_DebugInstanceExecuteDelegate_077(IntPtr type, IntPtr data, IntPtr childName, float rx, float ry, Int32 vertexGroup);
        public virtual Int32 PipelineItem_DebugInstanceExecute(IntPtr type, IntPtr data, IntPtr childName, float rx, float ry, Int32 vertexGroup) {
            return 0;
        }

        // function PipelineItem_GetVBO
        public delegate UInt32 PipelineItem_GetVBODelegate_078(IntPtr type, IntPtr data);
        public virtual UInt32 PipelineItem_GetVBO(IntPtr type, IntPtr data) {
            return 0;
        }

        // function PipelineItem_GetVBOStride
        public delegate UInt32 PipelineItem_GetVBOStrideDelegate_079(IntPtr type, IntPtr data);
        public virtual UInt32 PipelineItem_GetVBOStride(IntPtr type, IntPtr data) {
            return 0;
        }

        // function PipelineItem_CanChangeVariables
        public delegate bool PipelineItem_CanChangeVariablesDelegate_080(IntPtr type, IntPtr data);
        public virtual bool PipelineItem_CanChangeVariables(IntPtr type, IntPtr data) {
            return false;
        }

        // function PipelineItem_IsDebuggable
        public delegate bool PipelineItem_IsDebuggableDelegate_081(IntPtr type, IntPtr data);
        public virtual bool PipelineItem_IsDebuggable(IntPtr type, IntPtr data) {
            return false;
        }

        // function PipelineItem_IsStageDebuggable
        public delegate bool PipelineItem_IsStageDebuggableDelegate_082(IntPtr type, IntPtr data, PluginManager.ShaderStage stage);
        public virtual bool PipelineItem_IsStageDebuggable(IntPtr type, IntPtr data, PluginManager.ShaderStage stage) {
            return false;
        }

        // function PipelineItem_DebugExecute
        public delegate void PipelineItem_DebugExecuteDelegate_083(IntPtr type, IntPtr data, IntPtr children, Int32 count, IntPtr debugID);
        public virtual void PipelineItem_DebugExecute(IntPtr type, IntPtr data, IntPtr children, Int32 count, IntPtr debugID) {
        }

        // function PipelineItem_GetTopology
        public delegate UInt32 PipelineItem_GetTopologyDelegate_084(IntPtr type, IntPtr data);
        public virtual UInt32 PipelineItem_GetTopology(IntPtr type, IntPtr data) {
            return 0;
        }

        // function PipelineItem_GetVariableCount
        public delegate UInt32 PipelineItem_GetVariableCountDelegate_085(IntPtr type, IntPtr data);
        public virtual UInt32 PipelineItem_GetVariableCount(IntPtr type, IntPtr data) {
            return 0;
        }

        // function PipelineItem_GetVariableName
        public delegate IntPtr PipelineItem_GetVariableNameDelegate_086(IntPtr type, IntPtr data, UInt32 variable);
        public virtual IntPtr PipelineItem_GetVariableName(IntPtr type, IntPtr data, UInt32 variable) {
            return IntPtr.Zero;
        }

        // function PipelineItem_GetVariableType
        public delegate PluginManager.VariableType PipelineItem_GetVariableTypeDelegate_087(IntPtr type, IntPtr data, UInt32 variable);
        public virtual PluginManager.VariableType PipelineItem_GetVariableType(IntPtr type, IntPtr data, UInt32 variable) {
            return (PluginManager.VariableType)0;
        }

        // function PipelineItem_GetVariableValueFloat
        public delegate float PipelineItem_GetVariableValueFloatDelegate_088(IntPtr type, IntPtr data, UInt32 variable, Int32 col, Int32 row);
        public virtual float PipelineItem_GetVariableValueFloat(IntPtr type, IntPtr data, UInt32 variable, Int32 col, Int32 row) {
            return 0;
        }

        // function PipelineItem_GetVariableValueInteger
        public delegate Int32 PipelineItem_GetVariableValueIntegerDelegate_089(IntPtr type, IntPtr data, UInt32 variable, Int32 col);
        public virtual Int32 PipelineItem_GetVariableValueInteger(IntPtr type, IntPtr data, UInt32 variable, Int32 col) {
            return 0;
        }

        // function PipelineItem_GetVariableValueBoolean
        public delegate bool PipelineItem_GetVariableValueBooleanDelegate_090(IntPtr type, IntPtr data, UInt32 variable, Int32 col);
        public virtual bool PipelineItem_GetVariableValueBoolean(IntPtr type, IntPtr data, UInt32 variable, Int32 col) {
            return false;
        }

        // function PipelineItem_GetSPIRVSize
        public delegate UInt32 PipelineItem_GetSPIRVSizeDelegate_091(IntPtr type, IntPtr data, PluginManager.ShaderStage stage);
        public virtual UInt32 PipelineItem_GetSPIRVSize(IntPtr type, IntPtr data, PluginManager.ShaderStage stage) {
            return 0;
        }

        // function PipelineItem_GetSPIRV
        public delegate IntPtr PipelineItem_GetSPIRVDelegate_092(IntPtr type, IntPtr data, PluginManager.ShaderStage stage);
        public virtual IntPtr PipelineItem_GetSPIRV(IntPtr type, IntPtr data, PluginManager.ShaderStage stage) {
            return IntPtr.Zero;
        }

        // function PipelineItem_DebugPrepareVariables
        public delegate void PipelineItem_DebugPrepareVariablesDelegate_093(IntPtr type, IntPtr data, IntPtr name);
        public virtual void PipelineItem_DebugPrepareVariables(IntPtr type, IntPtr data, IntPtr name) {
        }

        // function PipelineItem_DebugUsesCustomTextures
        public delegate bool PipelineItem_DebugUsesCustomTexturesDelegate_094(IntPtr type, IntPtr data);
        public virtual bool PipelineItem_DebugUsesCustomTextures(IntPtr type, IntPtr data) {
            return false;
        }

        // function PipelineItem_DebugGetTexture
        public delegate UInt32 PipelineItem_DebugGetTextureDelegate_095(IntPtr type, IntPtr data, Int32 loc, IntPtr variableName);
        public virtual UInt32 PipelineItem_DebugGetTexture(IntPtr type, IntPtr data, Int32 loc, IntPtr variableName) {
            return 0;
        }

        // function PipelineItem_DebugGetTextureSize
        public delegate void PipelineItem_DebugGetTextureSizeDelegate_096(IntPtr type, IntPtr data, Int32 loc, IntPtr variableName, Int32 x, Int32 y, Int32 z);
        public virtual void PipelineItem_DebugGetTextureSize(IntPtr type, IntPtr data, Int32 loc, IntPtr variableName, Int32 x, Int32 y, Int32 z) {
        }

        // function Options_HasSection
        public delegate bool Options_HasSectionDelegate_097();
        public virtual bool Options_HasSection() {
            return false;
        }

        // function Options_RenderSection
        public delegate void Options_RenderSectionDelegate_098();
        public virtual void Options_RenderSection() {
        }

        // function Options_Parse
        public delegate void Options_ParseDelegate_099(IntPtr key, IntPtr val);
        public virtual void Options_Parse(IntPtr key, IntPtr val) {
        }

        // function Options_GetCount
        public delegate Int32 Options_GetCountDelegate_100();
        public virtual Int32 Options_GetCount() {
            return 0;
        }

        // function Options_GetKey
        public delegate IntPtr Options_GetKeyDelegate_101(Int32 index);
        public virtual IntPtr Options_GetKey(Int32 index) {
            return IntPtr.Zero;
        }

        // function Options_GetValue
        public delegate IntPtr Options_GetValueDelegate_102(Int32 index);
        public virtual IntPtr Options_GetValue(Int32 index) {
            return IntPtr.Zero;
        }

        // function CustomLanguage_GetCount
        public delegate Int32 CustomLanguage_GetCountDelegate_103();
        public virtual Int32 CustomLanguage_GetCount() {
            return 0;
        }

        // function CustomLanguage_GetName
        public delegate IntPtr CustomLanguage_GetNameDelegate_104(Int32 langID);
        public virtual IntPtr CustomLanguage_GetName(Int32 langID) {
            return IntPtr.Zero;
        }

        // function CustomLanguage_CompileToSPIRV
        public delegate IntPtr CustomLanguage_CompileToSPIRVDelegate_105(Int32 langID, IntPtr src, UInt64 src_len, PluginManager.ShaderStage stage, IntPtr entry, IntPtr macros, UInt64 macroCount, IntPtr spv_length, IntPtr compiled);
        public virtual IntPtr CustomLanguage_CompileToSPIRV(Int32 langID, IntPtr src, UInt64 src_len, PluginManager.ShaderStage stage, IntPtr entry, IntPtr macros, UInt64 macroCount, IntPtr spv_length, IntPtr compiled) {
            return IntPtr.Zero;
        }

        // function CustomLanguage_ProcessGeneratedGLSL
        public delegate IntPtr CustomLanguage_ProcessGeneratedGLSLDelegate_106(Int32 langID, IntPtr src);
        public virtual IntPtr CustomLanguage_ProcessGeneratedGLSL(Int32 langID, IntPtr src) {
            return IntPtr.Zero;
        }

        // function CustomLanguage_SupportsAutoUniforms
        public delegate bool CustomLanguage_SupportsAutoUniformsDelegate_107(Int32 langID);
        public virtual bool CustomLanguage_SupportsAutoUniforms(Int32 langID) {
            return false;
        }

        // function CustomLanguage_IsDebuggable
        public delegate bool CustomLanguage_IsDebuggableDelegate_108(Int32 langID);
        public virtual bool CustomLanguage_IsDebuggable(Int32 langID) {
            return false;
        }

        // function CustomLanguage_GetDefaultExtension
        public delegate IntPtr CustomLanguage_GetDefaultExtensionDelegate_109(Int32 langID);
        public virtual IntPtr CustomLanguage_GetDefaultExtension(Int32 langID) {
            return IntPtr.Zero;
        }

        // function ShaderEditor_Supports
        public delegate bool ShaderEditor_SupportsDelegate_110(Int32 langID);
        public virtual bool ShaderEditor_Supports(Int32 langID) {
            return false;
        }

        // function ShaderEditor_Open
        public delegate void ShaderEditor_OpenDelegate_111(Int32 langID, Int32 editorID, IntPtr data, Int32 dataLen);
        public virtual void ShaderEditor_Open(Int32 langID, Int32 editorID, IntPtr data, Int32 dataLen) {
        }

        // function ShaderEditor_Render
        public delegate void ShaderEditor_RenderDelegate_112(Int32 langID, Int32 editorID);
        public virtual void ShaderEditor_Render(Int32 langID, Int32 editorID) {
        }

        // function ShaderEditor_Close
        public delegate void ShaderEditor_CloseDelegate_113(Int32 langID, Int32 editorID);
        public virtual void ShaderEditor_Close(Int32 langID, Int32 editorID) {
        }

        // function ShaderEditor_GetContent
        public delegate IntPtr ShaderEditor_GetContentDelegate_114(Int32 langID, Int32 editorID, IntPtr dataLength);
        public virtual IntPtr ShaderEditor_GetContent(Int32 langID, Int32 editorID, IntPtr dataLength) {
            return IntPtr.Zero;
        }

        // function ShaderEditor_IsChanged
        public delegate bool ShaderEditor_IsChangedDelegate_115(Int32 langID, Int32 editorID);
        public virtual bool ShaderEditor_IsChanged(Int32 langID, Int32 editorID) {
            return false;
        }

        // function ShaderEditor_ResetChangeState
        public delegate void ShaderEditor_ResetChangeStateDelegate_116(Int32 langID, Int32 editorID);
        public virtual void ShaderEditor_ResetChangeState(Int32 langID, Int32 editorID) {
        }

        // function ShaderEditor_CanUndo
        public delegate bool ShaderEditor_CanUndoDelegate_117(Int32 langID, Int32 editorID);
        public virtual bool ShaderEditor_CanUndo(Int32 langID, Int32 editorID) {
            return false;
        }

        // function ShaderEditor_CanRedo
        public delegate bool ShaderEditor_CanRedoDelegate_118(Int32 langID, Int32 editorID);
        public virtual bool ShaderEditor_CanRedo(Int32 langID, Int32 editorID) {
            return false;
        }

        // function ShaderEditor_Undo
        public delegate void ShaderEditor_UndoDelegate_119(Int32 langID, Int32 editorID);
        public virtual void ShaderEditor_Undo(Int32 langID, Int32 editorID) {
        }

        // function ShaderEditor_Redo
        public delegate void ShaderEditor_RedoDelegate_120(Int32 langID, Int32 editorID);
        public virtual void ShaderEditor_Redo(Int32 langID, Int32 editorID) {
        }

        // function ShaderEditor_Cut
        public delegate void ShaderEditor_CutDelegate_121(Int32 langID, Int32 editorID);
        public virtual void ShaderEditor_Cut(Int32 langID, Int32 editorID) {
        }

        // function ShaderEditor_Paste
        public delegate void ShaderEditor_PasteDelegate_122(Int32 langID, Int32 editorID);
        public virtual void ShaderEditor_Paste(Int32 langID, Int32 editorID) {
        }

        // function ShaderEditor_Copy
        public delegate void ShaderEditor_CopyDelegate_123(Int32 langID, Int32 editorID);
        public virtual void ShaderEditor_Copy(Int32 langID, Int32 editorID) {
        }

        // function ShaderEditor_SelectAll
        public delegate void ShaderEditor_SelectAllDelegate_124(Int32 langID, Int32 editorID);
        public virtual void ShaderEditor_SelectAll(Int32 langID, Int32 editorID) {
        }

        // function ShaderEditor_HasStats
        public delegate bool ShaderEditor_HasStatsDelegate_125(Int32 langID, Int32 editorID);
        public virtual bool ShaderEditor_HasStats(Int32 langID, Int32 editorID) {
            return false;
        }

        // function CodeEditor_SaveItem
        public delegate void CodeEditor_SaveItemDelegate_126(IntPtr src, Int32 srcLen, IntPtr path);
        public virtual void CodeEditor_SaveItem(IntPtr src, Int32 srcLen, IntPtr path) {
        }

        // function CodeEditor_CloseItem
        public delegate void CodeEditor_CloseItemDelegate_127(IntPtr path);
        public virtual void CodeEditor_CloseItem(IntPtr path) {
        }

        // function LanguageDefinition_Exists
        public delegate bool LanguageDefinition_ExistsDelegate_128(Int32 id);
        public virtual bool LanguageDefinition_Exists(Int32 id) {
            return false;
        }

        // function LanguageDefinition_GetKeywordCount
        public delegate Int32 LanguageDefinition_GetKeywordCountDelegate_129(Int32 id);
        public virtual Int32 LanguageDefinition_GetKeywordCount(Int32 id) {
            return 0;
        }

        // function LanguageDefinition_GetKeywords
        public delegate IntPtr LanguageDefinition_GetKeywordsDelegate_130(Int32 id);
        public virtual IntPtr LanguageDefinition_GetKeywords(Int32 id) {
            return IntPtr.Zero;
        }

        // function LanguageDefinition_GetTokenRegexCount
        public delegate Int32 LanguageDefinition_GetTokenRegexCountDelegate_131(Int32 id);
        public virtual Int32 LanguageDefinition_GetTokenRegexCount(Int32 id) {
            return 0;
        }

        // function LanguageDefinition_GetTokenRegex
        public delegate IntPtr LanguageDefinition_GetTokenRegexDelegate_132(Int32 index, PluginManager.TextEditorPaletteIndex palIndex, Int32 id);
        public virtual IntPtr LanguageDefinition_GetTokenRegex(Int32 index, PluginManager.TextEditorPaletteIndex palIndex, Int32 id) {
            return IntPtr.Zero;
        }

        // function LanguageDefinition_GetIdentifierCount
        public delegate Int32 LanguageDefinition_GetIdentifierCountDelegate_133(Int32 id);
        public virtual Int32 LanguageDefinition_GetIdentifierCount(Int32 id) {
            return 0;
        }

        // function LanguageDefinition_GetIdentifier
        public delegate IntPtr LanguageDefinition_GetIdentifierDelegate_134(Int32 index, Int32 id);
        public virtual IntPtr LanguageDefinition_GetIdentifier(Int32 index, Int32 id) {
            return IntPtr.Zero;
        }

        // function LanguageDefinition_GetIdentifierDesc
        public delegate IntPtr LanguageDefinition_GetIdentifierDescDelegate_135(Int32 index, Int32 id);
        public virtual IntPtr LanguageDefinition_GetIdentifierDesc(Int32 index, Int32 id) {
            return IntPtr.Zero;
        }

        // function LanguageDefinition_GetCommentStart
        public delegate IntPtr LanguageDefinition_GetCommentStartDelegate_136(Int32 id);
        public virtual IntPtr LanguageDefinition_GetCommentStart(Int32 id) {
            return IntPtr.Zero;
        }

        // function LanguageDefinition_GetCommentEnd
        public delegate IntPtr LanguageDefinition_GetCommentEndDelegate_137(Int32 id);
        public virtual IntPtr LanguageDefinition_GetCommentEnd(Int32 id) {
            return IntPtr.Zero;
        }

        // function LanguageDefinition_GetLineComment
        public delegate IntPtr LanguageDefinition_GetLineCommentDelegate_138(Int32 id);
        public virtual IntPtr LanguageDefinition_GetLineComment(Int32 id) {
            return IntPtr.Zero;
        }

        // function LanguageDefinition_IsCaseSensitive
        public delegate bool LanguageDefinition_IsCaseSensitiveDelegate_139(Int32 id);
        public virtual bool LanguageDefinition_IsCaseSensitive(Int32 id) {
            return false;
        }

        // function LanguageDefinition_GetAutoIndent
        public delegate bool LanguageDefinition_GetAutoIndentDelegate_140(Int32 id);
        public virtual bool LanguageDefinition_GetAutoIndent(Int32 id) {
            return false;
        }

        // function LanguageDefinition_GetName
        public delegate IntPtr LanguageDefinition_GetNameDelegate_141(Int32 id);
        public virtual IntPtr LanguageDefinition_GetName(Int32 id) {
            return IntPtr.Zero;
        }

        // function LanguageDefinition_GetNameAbbreviation
        public delegate IntPtr LanguageDefinition_GetNameAbbreviationDelegate_142(Int32 id);
        public virtual IntPtr LanguageDefinition_GetNameAbbreviation(Int32 id) {
            return IntPtr.Zero;
        }

        // function Autocomplete_GetCount
        public delegate Int32 Autocomplete_GetCountDelegate_143(PluginManager.ShaderStage stage);
        public virtual Int32 Autocomplete_GetCount(PluginManager.ShaderStage stage) {
            return 0;
        }

        // function Autocomplete_GetDisplayString
        public delegate IntPtr Autocomplete_GetDisplayStringDelegate_144(PluginManager.ShaderStage stage, Int32 index);
        public virtual IntPtr Autocomplete_GetDisplayString(PluginManager.ShaderStage stage, Int32 index) {
            return IntPtr.Zero;
        }

        // function Autocomplete_GetSearchString
        public delegate IntPtr Autocomplete_GetSearchStringDelegate_145(PluginManager.ShaderStage stage, Int32 index);
        public virtual IntPtr Autocomplete_GetSearchString(PluginManager.ShaderStage stage, Int32 index) {
            return IntPtr.Zero;
        }

        // function Autocomplete_GetValue
        public delegate IntPtr Autocomplete_GetValueDelegate_146(PluginManager.ShaderStage stage, Int32 index);
        public virtual IntPtr Autocomplete_GetValue(PluginManager.ShaderStage stage, Int32 index) {
            return IntPtr.Zero;
        }

        // function ShaderFilePath_GetCount
        public delegate Int32 ShaderFilePath_GetCountDelegate_147();
        public virtual Int32 ShaderFilePath_GetCount() {
            return 0;
        }

        // function ShaderFilePath_Get
        public delegate IntPtr ShaderFilePath_GetDelegate_148(Int32 index);
        public virtual IntPtr ShaderFilePath_Get(Int32 index) {
            return IntPtr.Zero;
        }

        // function ShaderFilePath_HasChanged
        public delegate bool ShaderFilePath_HasChangedDelegate_149();
        public virtual bool ShaderFilePath_HasChanged() {
            return false;
        }

        // function ShaderFilePath_Update
        public delegate void ShaderFilePath_UpdateDelegate_150();
        public virtual void ShaderFilePath_Update() {
        }

        // function HandleDropFile
        public delegate bool HandleDropFileDelegate_151(IntPtr filename);
        public virtual bool HandleDropFile(IntPtr filename) {
            return false;
        }

        // function HandleRecompile
        public delegate void HandleRecompileDelegate_152(IntPtr itemName);
        public virtual void HandleRecompile(IntPtr itemName) {
        }

        // function HandleRecompileFromSource
        public delegate void HandleRecompileFromSourceDelegate_153(IntPtr itemName, Int32 sid, IntPtr shaderCode, Int32 shaderSize);
        public virtual void HandleRecompileFromSource(IntPtr itemName, Int32 sid, IntPtr shaderCode, Int32 shaderSize) {
        }

        // function HandleShortcut
        public delegate void HandleShortcutDelegate_154(IntPtr name);
        public virtual void HandleShortcut(IntPtr name) {
        }

        // function HandlePluginMessage
        public delegate void HandlePluginMessageDelegate_155(IntPtr sender, IntPtr msg, Int32 msgLen);
        public virtual void HandlePluginMessage(IntPtr sender, IntPtr msg, Int32 msgLen) {
        }

        // function HandleApplicationEvent
        public delegate void HandleApplicationEventDelegate_156(PluginManager.ApplicationEvent event_, IntPtr data1, IntPtr data2);
        public virtual void HandleApplicationEvent(PluginManager.ApplicationEvent event_, IntPtr data1, IntPtr data2) {
        }

        // function HandleNotification
        public delegate void HandleNotificationDelegate_157(Int32 id);
        public virtual void HandleNotification(Int32 id) {
        }

        // function PipelineItem_SupportsImmediateMode
        public delegate bool PipelineItem_SupportsImmediateModeDelegate_158(IntPtr type, IntPtr data, PluginManager.ShaderStage stage);
        public virtual bool PipelineItem_SupportsImmediateMode(IntPtr type, IntPtr data, PluginManager.ShaderStage stage) {
            return false;
        }

        // function PipelineItem_HasCustomImmediateModeCompiler
        public delegate bool PipelineItem_HasCustomImmediateModeCompilerDelegate_159(IntPtr type, IntPtr data, PluginManager.ShaderStage stage);
        public virtual bool PipelineItem_HasCustomImmediateModeCompiler(IntPtr type, IntPtr data, PluginManager.ShaderStage stage) {
            return false;
        }

        // function PipelineItem_ImmediateModeCompile
        public delegate bool PipelineItem_ImmediateModeCompileDelegate_160(IntPtr type, IntPtr data, PluginManager.ShaderStage stage, IntPtr expression);
        public virtual bool PipelineItem_ImmediateModeCompile(IntPtr type, IntPtr data, PluginManager.ShaderStage stage, IntPtr expression) {
            return false;
        }

        // function ImmediateMode_GetSPIRVSize
        public delegate UInt32 ImmediateMode_GetSPIRVSizeDelegate_161();
        public virtual UInt32 ImmediateMode_GetSPIRVSize() {
            return 0;
        }

        // function ImmediateMode_GetSPIRV
        public delegate IntPtr ImmediateMode_GetSPIRVDelegate_162();
        public virtual IntPtr ImmediateMode_GetSPIRV() {
            return IntPtr.Zero;
        }

        // function ImmediateMode_GetVariableCount
        public delegate UInt32 ImmediateMode_GetVariableCountDelegate_163();
        public virtual UInt32 ImmediateMode_GetVariableCount() {
            return 0;
        }

        // function ImmediateMode_GetVariableName
        public delegate IntPtr ImmediateMode_GetVariableNameDelegate_164(UInt32 index);
        public virtual IntPtr ImmediateMode_GetVariableName(UInt32 index) {
            return IntPtr.Zero;
        }

        // function ImmediateMode_GetResultID
        public delegate Int32 ImmediateMode_GetResultIDDelegate_165();
        public virtual Int32 ImmediateMode_GetResultID() {
            return 0;
        }

        // function PluginManager_RegisterPlugins
        public delegate void PluginManager_RegisterPluginsDelegate_166();
        public virtual void PluginManager_RegisterPlugins() {
        }
        protected void __SetDelegates(PluginManager.InteropData.ManagedPointerCollection a_MPC) {
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
        protected PluginManager.InteropData.UnmanagedPointerCollection __GetFunctionPointers() {
            var upc = new PluginManager.InteropData.UnmanagedPointerCollection();
            upc.Init_000 = Marshal.GetFunctionPointerForDelegate(new InitDelegate_000(this.Init));
            upc.InitUI_001 = Marshal.GetFunctionPointerForDelegate(new InitUIDelegate_001(this.InitUI));
            upc.OnEvent_002 = Marshal.GetFunctionPointerForDelegate(new OnEventDelegate_002(this.OnEvent));
            upc.Update_003 = Marshal.GetFunctionPointerForDelegate(new UpdateDelegate_003(this.Update));
            upc.Destroy_004 = Marshal.GetFunctionPointerForDelegate(new DestroyDelegate_004(this.Destroy));
            upc.IsRequired_005 = Marshal.GetFunctionPointerForDelegate(new IsRequiredDelegate_005(this.IsRequired));
            upc.IsVersionCompatible_006 = Marshal.GetFunctionPointerForDelegate(new IsVersionCompatibleDelegate_006(this.IsVersionCompatible));
            upc.BeginRender_007 = Marshal.GetFunctionPointerForDelegate(new BeginRenderDelegate_007(this.BeginRender));
            upc.EndRender_008 = Marshal.GetFunctionPointerForDelegate(new EndRenderDelegate_008(this.EndRender));
            upc.Project_BeginLoad_009 = Marshal.GetFunctionPointerForDelegate(new Project_BeginLoadDelegate_009(this.Project_BeginLoad));
            upc.Project_EndLoad_010 = Marshal.GetFunctionPointerForDelegate(new Project_EndLoadDelegate_010(this.Project_EndLoad));
            upc.Project_BeginSave_011 = Marshal.GetFunctionPointerForDelegate(new Project_BeginSaveDelegate_011(this.Project_BeginSave));
            upc.Project_EndSave_012 = Marshal.GetFunctionPointerForDelegate(new Project_EndSaveDelegate_012(this.Project_EndSave));
            upc.Project_HasAdditionalData_013 = Marshal.GetFunctionPointerForDelegate(new Project_HasAdditionalDataDelegate_013(this.Project_HasAdditionalData));
            upc.Project_ExportAdditionalData_014 = Marshal.GetFunctionPointerForDelegate(new Project_ExportAdditionalDataDelegate_014(this.Project_ExportAdditionalData));
            upc.Project_ImportAdditionalData_015 = Marshal.GetFunctionPointerForDelegate(new Project_ImportAdditionalDataDelegate_015(this.Project_ImportAdditionalData));
            upc.Project_CopyFilesOnSave_016 = Marshal.GetFunctionPointerForDelegate(new Project_CopyFilesOnSaveDelegate_016(this.Project_CopyFilesOnSave));
            upc.HasCustomMenuItem_017 = Marshal.GetFunctionPointerForDelegate(new HasCustomMenuItemDelegate_017(this.HasCustomMenuItem));
            upc.HasMenuItems_018 = Marshal.GetFunctionPointerForDelegate(new HasMenuItemsDelegate_018(this.HasMenuItems));
            upc.ShowMenuItems_019 = Marshal.GetFunctionPointerForDelegate(new ShowMenuItemsDelegate_019(this.ShowMenuItems));
            upc.HasContextItems_020 = Marshal.GetFunctionPointerForDelegate(new HasContextItemsDelegate_020(this.HasContextItems));
            upc.ShowContextItems_021 = Marshal.GetFunctionPointerForDelegate(new ShowContextItemsDelegate_021(this.ShowContextItems));
            upc.SystemVariables_GetNameCount_022 = Marshal.GetFunctionPointerForDelegate(new SystemVariables_GetNameCountDelegate_022(this.SystemVariables_GetNameCount));
            upc.SystemVariables_GetName_023 = Marshal.GetFunctionPointerForDelegate(new SystemVariables_GetNameDelegate_023(this.SystemVariables_GetName));
            upc.SystemVariables_HasLastFrame_024 = Marshal.GetFunctionPointerForDelegate(new SystemVariables_HasLastFrameDelegate_024(this.SystemVariables_HasLastFrame));
            upc.SystemVariables_UpdateValue_025 = Marshal.GetFunctionPointerForDelegate(new SystemVariables_UpdateValueDelegate_025(this.SystemVariables_UpdateValue));
            upc.VariableFunctions_GetNameCount_026 = Marshal.GetFunctionPointerForDelegate(new VariableFunctions_GetNameCountDelegate_026(this.VariableFunctions_GetNameCount));
            upc.VariableFunctions_GetName_027 = Marshal.GetFunctionPointerForDelegate(new VariableFunctions_GetNameDelegate_027(this.VariableFunctions_GetName));
            upc.VariableFunctions_ShowArgumentEdit_028 = Marshal.GetFunctionPointerForDelegate(new VariableFunctions_ShowArgumentEditDelegate_028(this.VariableFunctions_ShowArgumentEdit));
            upc.VariableFunctions_UpdateValue_029 = Marshal.GetFunctionPointerForDelegate(new VariableFunctions_UpdateValueDelegate_029(this.VariableFunctions_UpdateValue));
            upc.VariableFunctions_GetArgsSize_030 = Marshal.GetFunctionPointerForDelegate(new VariableFunctions_GetArgsSizeDelegate_030(this.VariableFunctions_GetArgsSize));
            upc.VariableFunctions_InitArguments_031 = Marshal.GetFunctionPointerForDelegate(new VariableFunctions_InitArgumentsDelegate_031(this.VariableFunctions_InitArguments));
            upc.VariableFunctions_ExportArguments_032 = Marshal.GetFunctionPointerForDelegate(new VariableFunctions_ExportArgumentsDelegate_032(this.VariableFunctions_ExportArguments));
            upc.VariableFunctions_ImportArguments_033 = Marshal.GetFunctionPointerForDelegate(new VariableFunctions_ImportArgumentsDelegate_033(this.VariableFunctions_ImportArguments));
            upc.Object_HasPreview_034 = Marshal.GetFunctionPointerForDelegate(new Object_HasPreviewDelegate_034(this.Object_HasPreview));
            upc.Object_ShowPreview_035 = Marshal.GetFunctionPointerForDelegate(new Object_ShowPreviewDelegate_035(this.Object_ShowPreview));
            upc.Object_IsBindable_036 = Marshal.GetFunctionPointerForDelegate(new Object_IsBindableDelegate_036(this.Object_IsBindable));
            upc.Object_IsBindableUAV_037 = Marshal.GetFunctionPointerForDelegate(new Object_IsBindableUAVDelegate_037(this.Object_IsBindableUAV));
            upc.Object_Remove_038 = Marshal.GetFunctionPointerForDelegate(new Object_RemoveDelegate_038(this.Object_Remove));
            upc.Object_HasExtendedPreview_039 = Marshal.GetFunctionPointerForDelegate(new Object_HasExtendedPreviewDelegate_039(this.Object_HasExtendedPreview));
            upc.Object_ShowExtendedPreview_040 = Marshal.GetFunctionPointerForDelegate(new Object_ShowExtendedPreviewDelegate_040(this.Object_ShowExtendedPreview));
            upc.Object_HasProperties_041 = Marshal.GetFunctionPointerForDelegate(new Object_HasPropertiesDelegate_041(this.Object_HasProperties));
            upc.Object_ShowProperties_042 = Marshal.GetFunctionPointerForDelegate(new Object_ShowPropertiesDelegate_042(this.Object_ShowProperties));
            upc.Object_Bind_043 = Marshal.GetFunctionPointerForDelegate(new Object_BindDelegate_043(this.Object_Bind));
            upc.Object_Export_044 = Marshal.GetFunctionPointerForDelegate(new Object_ExportDelegate_044(this.Object_Export));
            upc.Object_Import_045 = Marshal.GetFunctionPointerForDelegate(new Object_ImportDelegate_045(this.Object_Import));
            upc.Object_HasContext_046 = Marshal.GetFunctionPointerForDelegate(new Object_HasContextDelegate_046(this.Object_HasContext));
            upc.Object_ShowContext_047 = Marshal.GetFunctionPointerForDelegate(new Object_ShowContextDelegate_047(this.Object_ShowContext));
            upc.PipelineItem_HasProperties_048 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_HasPropertiesDelegate_048(this.PipelineItem_HasProperties));
            upc.PipelineItem_ShowProperties_049 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_ShowPropertiesDelegate_049(this.PipelineItem_ShowProperties));
            upc.PipelineItem_IsPickable_050 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_IsPickableDelegate_050(this.PipelineItem_IsPickable));
            upc.PipelineItem_HasShaders_051 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_HasShadersDelegate_051(this.PipelineItem_HasShaders));
            upc.PipelineItem_OpenInEditor_052 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_OpenInEditorDelegate_052(this.PipelineItem_OpenInEditor));
            upc.PipelineItem_CanHaveChild_053 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_CanHaveChildDelegate_053(this.PipelineItem_CanHaveChild));
            upc.PipelineItem_GetInputLayoutSize_054 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_GetInputLayoutSizeDelegate_054(this.PipelineItem_GetInputLayoutSize));
            upc.PipelineItem_GetInputLayoutItem_055 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_GetInputLayoutItemDelegate_055(this.PipelineItem_GetInputLayoutItem));
            upc.PipelineItem_Remove_056 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_RemoveDelegate_056(this.PipelineItem_Remove));
            upc.PipelineItem_Rename_057 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_RenameDelegate_057(this.PipelineItem_Rename));
            upc.PipelineItem_AddChild_058 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_AddChildDelegate_058(this.PipelineItem_AddChild));
            upc.PipelineItem_CanHaveChildren_059 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_CanHaveChildrenDelegate_059(this.PipelineItem_CanHaveChildren));
            upc.PipelineItem_CopyData_060 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_CopyDataDelegate_060(this.PipelineItem_CopyData));
            upc.PipelineItem_Execute_061 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_ExecuteDelegate_061(this.PipelineItem_Execute));
            upc.PipelineItem_Execute_062 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_ExecuteDelegate_062(this.PipelineItem_Execute));
            upc.PipelineItem_GetWorldMatrix_063 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_GetWorldMatrixDelegate_063(this.PipelineItem_GetWorldMatrix));
            upc.PipelineItem_Intersect_064 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_IntersectDelegate_064(this.PipelineItem_Intersect));
            upc.PipelineItem_GetBoundingBox_065 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_GetBoundingBoxDelegate_065(this.PipelineItem_GetBoundingBox));
            upc.PipelineItem_HasContext_066 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_HasContextDelegate_066(this.PipelineItem_HasContext));
            upc.PipelineItem_ShowContext_067 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_ShowContextDelegate_067(this.PipelineItem_ShowContext));
            upc.PipelineItem_Export_068 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_ExportDelegate_068(this.PipelineItem_Export));
            upc.PipelineItem_Import_069 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_ImportDelegate_069(this.PipelineItem_Import));
            upc.PipelineItem_MoveDown_070 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_MoveDownDelegate_070(this.PipelineItem_MoveDown));
            upc.PipelineItem_MoveUp_071 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_MoveUpDelegate_071(this.PipelineItem_MoveUp));
            upc.PipelineItem_ApplyGizmoTransform_072 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_ApplyGizmoTransformDelegate_072(this.PipelineItem_ApplyGizmoTransform));
            upc.PipelineItem_GetTransform_073 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_GetTransformDelegate_073(this.PipelineItem_GetTransform));
            upc.PipelineItem_DebugVertexExecute_074 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_DebugVertexExecuteDelegate_074(this.PipelineItem_DebugVertexExecute));
            upc.PipelineItem_DebugVertexExecute_075 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_DebugVertexExecuteDelegate_075(this.PipelineItem_DebugVertexExecute));
            upc.PipelineItem_DebugInstanceExecute_076 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_DebugInstanceExecuteDelegate_076(this.PipelineItem_DebugInstanceExecute));
            upc.PipelineItem_DebugInstanceExecute_077 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_DebugInstanceExecuteDelegate_077(this.PipelineItem_DebugInstanceExecute));
            upc.PipelineItem_GetVBO_078 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_GetVBODelegate_078(this.PipelineItem_GetVBO));
            upc.PipelineItem_GetVBOStride_079 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_GetVBOStrideDelegate_079(this.PipelineItem_GetVBOStride));
            upc.PipelineItem_CanChangeVariables_080 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_CanChangeVariablesDelegate_080(this.PipelineItem_CanChangeVariables));
            upc.PipelineItem_IsDebuggable_081 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_IsDebuggableDelegate_081(this.PipelineItem_IsDebuggable));
            upc.PipelineItem_IsStageDebuggable_082 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_IsStageDebuggableDelegate_082(this.PipelineItem_IsStageDebuggable));
            upc.PipelineItem_DebugExecute_083 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_DebugExecuteDelegate_083(this.PipelineItem_DebugExecute));
            upc.PipelineItem_GetTopology_084 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_GetTopologyDelegate_084(this.PipelineItem_GetTopology));
            upc.PipelineItem_GetVariableCount_085 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_GetVariableCountDelegate_085(this.PipelineItem_GetVariableCount));
            upc.PipelineItem_GetVariableName_086 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_GetVariableNameDelegate_086(this.PipelineItem_GetVariableName));
            upc.PipelineItem_GetVariableType_087 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_GetVariableTypeDelegate_087(this.PipelineItem_GetVariableType));
            upc.PipelineItem_GetVariableValueFloat_088 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_GetVariableValueFloatDelegate_088(this.PipelineItem_GetVariableValueFloat));
            upc.PipelineItem_GetVariableValueInteger_089 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_GetVariableValueIntegerDelegate_089(this.PipelineItem_GetVariableValueInteger));
            upc.PipelineItem_GetVariableValueBoolean_090 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_GetVariableValueBooleanDelegate_090(this.PipelineItem_GetVariableValueBoolean));
            upc.PipelineItem_GetSPIRVSize_091 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_GetSPIRVSizeDelegate_091(this.PipelineItem_GetSPIRVSize));
            upc.PipelineItem_GetSPIRV_092 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_GetSPIRVDelegate_092(this.PipelineItem_GetSPIRV));
            upc.PipelineItem_DebugPrepareVariables_093 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_DebugPrepareVariablesDelegate_093(this.PipelineItem_DebugPrepareVariables));
            upc.PipelineItem_DebugUsesCustomTextures_094 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_DebugUsesCustomTexturesDelegate_094(this.PipelineItem_DebugUsesCustomTextures));
            upc.PipelineItem_DebugGetTexture_095 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_DebugGetTextureDelegate_095(this.PipelineItem_DebugGetTexture));
            upc.PipelineItem_DebugGetTextureSize_096 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_DebugGetTextureSizeDelegate_096(this.PipelineItem_DebugGetTextureSize));
            upc.Options_HasSection_097 = Marshal.GetFunctionPointerForDelegate(new Options_HasSectionDelegate_097(this.Options_HasSection));
            upc.Options_RenderSection_098 = Marshal.GetFunctionPointerForDelegate(new Options_RenderSectionDelegate_098(this.Options_RenderSection));
            upc.Options_Parse_099 = Marshal.GetFunctionPointerForDelegate(new Options_ParseDelegate_099(this.Options_Parse));
            upc.Options_GetCount_100 = Marshal.GetFunctionPointerForDelegate(new Options_GetCountDelegate_100(this.Options_GetCount));
            upc.Options_GetKey_101 = Marshal.GetFunctionPointerForDelegate(new Options_GetKeyDelegate_101(this.Options_GetKey));
            upc.Options_GetValue_102 = Marshal.GetFunctionPointerForDelegate(new Options_GetValueDelegate_102(this.Options_GetValue));
            upc.CustomLanguage_GetCount_103 = Marshal.GetFunctionPointerForDelegate(new CustomLanguage_GetCountDelegate_103(this.CustomLanguage_GetCount));
            upc.CustomLanguage_GetName_104 = Marshal.GetFunctionPointerForDelegate(new CustomLanguage_GetNameDelegate_104(this.CustomLanguage_GetName));
            upc.CustomLanguage_CompileToSPIRV_105 = Marshal.GetFunctionPointerForDelegate(new CustomLanguage_CompileToSPIRVDelegate_105(this.CustomLanguage_CompileToSPIRV));
            upc.CustomLanguage_ProcessGeneratedGLSL_106 = Marshal.GetFunctionPointerForDelegate(new CustomLanguage_ProcessGeneratedGLSLDelegate_106(this.CustomLanguage_ProcessGeneratedGLSL));
            upc.CustomLanguage_SupportsAutoUniforms_107 = Marshal.GetFunctionPointerForDelegate(new CustomLanguage_SupportsAutoUniformsDelegate_107(this.CustomLanguage_SupportsAutoUniforms));
            upc.CustomLanguage_IsDebuggable_108 = Marshal.GetFunctionPointerForDelegate(new CustomLanguage_IsDebuggableDelegate_108(this.CustomLanguage_IsDebuggable));
            upc.CustomLanguage_GetDefaultExtension_109 = Marshal.GetFunctionPointerForDelegate(new CustomLanguage_GetDefaultExtensionDelegate_109(this.CustomLanguage_GetDefaultExtension));
            upc.ShaderEditor_Supports_110 = Marshal.GetFunctionPointerForDelegate(new ShaderEditor_SupportsDelegate_110(this.ShaderEditor_Supports));
            upc.ShaderEditor_Open_111 = Marshal.GetFunctionPointerForDelegate(new ShaderEditor_OpenDelegate_111(this.ShaderEditor_Open));
            upc.ShaderEditor_Render_112 = Marshal.GetFunctionPointerForDelegate(new ShaderEditor_RenderDelegate_112(this.ShaderEditor_Render));
            upc.ShaderEditor_Close_113 = Marshal.GetFunctionPointerForDelegate(new ShaderEditor_CloseDelegate_113(this.ShaderEditor_Close));
            upc.ShaderEditor_GetContent_114 = Marshal.GetFunctionPointerForDelegate(new ShaderEditor_GetContentDelegate_114(this.ShaderEditor_GetContent));
            upc.ShaderEditor_IsChanged_115 = Marshal.GetFunctionPointerForDelegate(new ShaderEditor_IsChangedDelegate_115(this.ShaderEditor_IsChanged));
            upc.ShaderEditor_ResetChangeState_116 = Marshal.GetFunctionPointerForDelegate(new ShaderEditor_ResetChangeStateDelegate_116(this.ShaderEditor_ResetChangeState));
            upc.ShaderEditor_CanUndo_117 = Marshal.GetFunctionPointerForDelegate(new ShaderEditor_CanUndoDelegate_117(this.ShaderEditor_CanUndo));
            upc.ShaderEditor_CanRedo_118 = Marshal.GetFunctionPointerForDelegate(new ShaderEditor_CanRedoDelegate_118(this.ShaderEditor_CanRedo));
            upc.ShaderEditor_Undo_119 = Marshal.GetFunctionPointerForDelegate(new ShaderEditor_UndoDelegate_119(this.ShaderEditor_Undo));
            upc.ShaderEditor_Redo_120 = Marshal.GetFunctionPointerForDelegate(new ShaderEditor_RedoDelegate_120(this.ShaderEditor_Redo));
            upc.ShaderEditor_Cut_121 = Marshal.GetFunctionPointerForDelegate(new ShaderEditor_CutDelegate_121(this.ShaderEditor_Cut));
            upc.ShaderEditor_Paste_122 = Marshal.GetFunctionPointerForDelegate(new ShaderEditor_PasteDelegate_122(this.ShaderEditor_Paste));
            upc.ShaderEditor_Copy_123 = Marshal.GetFunctionPointerForDelegate(new ShaderEditor_CopyDelegate_123(this.ShaderEditor_Copy));
            upc.ShaderEditor_SelectAll_124 = Marshal.GetFunctionPointerForDelegate(new ShaderEditor_SelectAllDelegate_124(this.ShaderEditor_SelectAll));
            upc.ShaderEditor_HasStats_125 = Marshal.GetFunctionPointerForDelegate(new ShaderEditor_HasStatsDelegate_125(this.ShaderEditor_HasStats));
            upc.CodeEditor_SaveItem_126 = Marshal.GetFunctionPointerForDelegate(new CodeEditor_SaveItemDelegate_126(this.CodeEditor_SaveItem));
            upc.CodeEditor_CloseItem_127 = Marshal.GetFunctionPointerForDelegate(new CodeEditor_CloseItemDelegate_127(this.CodeEditor_CloseItem));
            upc.LanguageDefinition_Exists_128 = Marshal.GetFunctionPointerForDelegate(new LanguageDefinition_ExistsDelegate_128(this.LanguageDefinition_Exists));
            upc.LanguageDefinition_GetKeywordCount_129 = Marshal.GetFunctionPointerForDelegate(new LanguageDefinition_GetKeywordCountDelegate_129(this.LanguageDefinition_GetKeywordCount));
            upc.LanguageDefinition_GetKeywords_130 = Marshal.GetFunctionPointerForDelegate(new LanguageDefinition_GetKeywordsDelegate_130(this.LanguageDefinition_GetKeywords));
            upc.LanguageDefinition_GetTokenRegexCount_131 = Marshal.GetFunctionPointerForDelegate(new LanguageDefinition_GetTokenRegexCountDelegate_131(this.LanguageDefinition_GetTokenRegexCount));
            upc.LanguageDefinition_GetTokenRegex_132 = Marshal.GetFunctionPointerForDelegate(new LanguageDefinition_GetTokenRegexDelegate_132(this.LanguageDefinition_GetTokenRegex));
            upc.LanguageDefinition_GetIdentifierCount_133 = Marshal.GetFunctionPointerForDelegate(new LanguageDefinition_GetIdentifierCountDelegate_133(this.LanguageDefinition_GetIdentifierCount));
            upc.LanguageDefinition_GetIdentifier_134 = Marshal.GetFunctionPointerForDelegate(new LanguageDefinition_GetIdentifierDelegate_134(this.LanguageDefinition_GetIdentifier));
            upc.LanguageDefinition_GetIdentifierDesc_135 = Marshal.GetFunctionPointerForDelegate(new LanguageDefinition_GetIdentifierDescDelegate_135(this.LanguageDefinition_GetIdentifierDesc));
            upc.LanguageDefinition_GetCommentStart_136 = Marshal.GetFunctionPointerForDelegate(new LanguageDefinition_GetCommentStartDelegate_136(this.LanguageDefinition_GetCommentStart));
            upc.LanguageDefinition_GetCommentEnd_137 = Marshal.GetFunctionPointerForDelegate(new LanguageDefinition_GetCommentEndDelegate_137(this.LanguageDefinition_GetCommentEnd));
            upc.LanguageDefinition_GetLineComment_138 = Marshal.GetFunctionPointerForDelegate(new LanguageDefinition_GetLineCommentDelegate_138(this.LanguageDefinition_GetLineComment));
            upc.LanguageDefinition_IsCaseSensitive_139 = Marshal.GetFunctionPointerForDelegate(new LanguageDefinition_IsCaseSensitiveDelegate_139(this.LanguageDefinition_IsCaseSensitive));
            upc.LanguageDefinition_GetAutoIndent_140 = Marshal.GetFunctionPointerForDelegate(new LanguageDefinition_GetAutoIndentDelegate_140(this.LanguageDefinition_GetAutoIndent));
            upc.LanguageDefinition_GetName_141 = Marshal.GetFunctionPointerForDelegate(new LanguageDefinition_GetNameDelegate_141(this.LanguageDefinition_GetName));
            upc.LanguageDefinition_GetNameAbbreviation_142 = Marshal.GetFunctionPointerForDelegate(new LanguageDefinition_GetNameAbbreviationDelegate_142(this.LanguageDefinition_GetNameAbbreviation));
            upc.Autocomplete_GetCount_143 = Marshal.GetFunctionPointerForDelegate(new Autocomplete_GetCountDelegate_143(this.Autocomplete_GetCount));
            upc.Autocomplete_GetDisplayString_144 = Marshal.GetFunctionPointerForDelegate(new Autocomplete_GetDisplayStringDelegate_144(this.Autocomplete_GetDisplayString));
            upc.Autocomplete_GetSearchString_145 = Marshal.GetFunctionPointerForDelegate(new Autocomplete_GetSearchStringDelegate_145(this.Autocomplete_GetSearchString));
            upc.Autocomplete_GetValue_146 = Marshal.GetFunctionPointerForDelegate(new Autocomplete_GetValueDelegate_146(this.Autocomplete_GetValue));
            upc.ShaderFilePath_GetCount_147 = Marshal.GetFunctionPointerForDelegate(new ShaderFilePath_GetCountDelegate_147(this.ShaderFilePath_GetCount));
            upc.ShaderFilePath_Get_148 = Marshal.GetFunctionPointerForDelegate(new ShaderFilePath_GetDelegate_148(this.ShaderFilePath_Get));
            upc.ShaderFilePath_HasChanged_149 = Marshal.GetFunctionPointerForDelegate(new ShaderFilePath_HasChangedDelegate_149(this.ShaderFilePath_HasChanged));
            upc.ShaderFilePath_Update_150 = Marshal.GetFunctionPointerForDelegate(new ShaderFilePath_UpdateDelegate_150(this.ShaderFilePath_Update));
            upc.HandleDropFile_151 = Marshal.GetFunctionPointerForDelegate(new HandleDropFileDelegate_151(this.HandleDropFile));
            upc.HandleRecompile_152 = Marshal.GetFunctionPointerForDelegate(new HandleRecompileDelegate_152(this.HandleRecompile));
            upc.HandleRecompileFromSource_153 = Marshal.GetFunctionPointerForDelegate(new HandleRecompileFromSourceDelegate_153(this.HandleRecompileFromSource));
            upc.HandleShortcut_154 = Marshal.GetFunctionPointerForDelegate(new HandleShortcutDelegate_154(this.HandleShortcut));
            upc.HandlePluginMessage_155 = Marshal.GetFunctionPointerForDelegate(new HandlePluginMessageDelegate_155(this.HandlePluginMessage));
            upc.HandleApplicationEvent_156 = Marshal.GetFunctionPointerForDelegate(new HandleApplicationEventDelegate_156(this.HandleApplicationEvent));
            upc.HandleNotification_157 = Marshal.GetFunctionPointerForDelegate(new HandleNotificationDelegate_157(this.HandleNotification));
            upc.PipelineItem_SupportsImmediateMode_158 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_SupportsImmediateModeDelegate_158(this.PipelineItem_SupportsImmediateMode));
            upc.PipelineItem_HasCustomImmediateModeCompiler_159 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_HasCustomImmediateModeCompilerDelegate_159(this.PipelineItem_HasCustomImmediateModeCompiler));
            upc.PipelineItem_ImmediateModeCompile_160 = Marshal.GetFunctionPointerForDelegate(new PipelineItem_ImmediateModeCompileDelegate_160(this.PipelineItem_ImmediateModeCompile));
            upc.ImmediateMode_GetSPIRVSize_161 = Marshal.GetFunctionPointerForDelegate(new ImmediateMode_GetSPIRVSizeDelegate_161(this.ImmediateMode_GetSPIRVSize));
            upc.ImmediateMode_GetSPIRV_162 = Marshal.GetFunctionPointerForDelegate(new ImmediateMode_GetSPIRVDelegate_162(this.ImmediateMode_GetSPIRV));
            upc.ImmediateMode_GetVariableCount_163 = Marshal.GetFunctionPointerForDelegate(new ImmediateMode_GetVariableCountDelegate_163(this.ImmediateMode_GetVariableCount));
            upc.ImmediateMode_GetVariableName_164 = Marshal.GetFunctionPointerForDelegate(new ImmediateMode_GetVariableNameDelegate_164(this.ImmediateMode_GetVariableName));
            upc.ImmediateMode_GetResultID_165 = Marshal.GetFunctionPointerForDelegate(new ImmediateMode_GetResultIDDelegate_165(this.ImmediateMode_GetResultID));
            upc.PluginManager_RegisterPlugins_166 = Marshal.GetFunctionPointerForDelegate(new PluginManager_RegisterPluginsDelegate_166(this.PluginManager_RegisterPlugins));
            return upc;
        }
    }
}
