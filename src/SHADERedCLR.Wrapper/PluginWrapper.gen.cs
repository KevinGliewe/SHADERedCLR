using System;
using System.Runtime.InteropServices;

namespace SHADERedCLR.Wrapper {
    public partial class PluginWrapper {
        public class Delegates{








            public delegate void AddObjectDelegate(IntPtr objects, IntPtr name, IntPtr type, IntPtr data, UInt32 id, IntPtr owner);

            public delegate bool AddCustomPipelineItemDelegate(IntPtr pipeline, IntPtr parent, IntPtr name, IntPtr type, IntPtr data, IntPtr owner);

            public delegate void AddMessageDelegate(IntPtr messages, SHADERedCLR.Wrapper.MessageType mtype, IntPtr group, IntPtr txt, Int32 ln);

            public delegate bool CreateRenderTextureDelegate(IntPtr objects, IntPtr name);

            public delegate bool CreateImageDelegate(IntPtr objects, IntPtr name, Int32 width, Int32 height);

            public delegate void ResizeRenderTextureDelegate(IntPtr objects, IntPtr name, Int32 width, Int32 height);

            public delegate void ResizeImageDelegate(IntPtr objects, IntPtr name, Int32 width, Int32 height);

            public delegate bool ExistsObjectDelegate(IntPtr objects, IntPtr name);

            public delegate void RemoveGlobalObjectDelegate(IntPtr objects, IntPtr name);

            public delegate void GetProjectPathDelegate(IntPtr project, IntPtr filename, IntPtr out_);

            public delegate void GetRelativePathDelegate(IntPtr project, IntPtr filename, IntPtr out_);

            public delegate void GetProjectFilenameDelegate(IntPtr project, IntPtr out_);

            public delegate IntPtr GetProjectDirectoryDelegate(IntPtr project);

            public delegate bool IsProjectModifiedDelegate(IntPtr project);

            public delegate void ModifyProjectDelegate(IntPtr project);

            public delegate void OpenProjectDelegate(IntPtr ui, IntPtr filename);

            public delegate void SaveProjectDelegate(IntPtr project);

            public delegate void SaveAsProjectDelegate(IntPtr project, IntPtr filename, bool copyFiles);

            public delegate bool IsPausedDelegate(IntPtr renderer);

            public delegate void PauseDelegate(IntPtr renderer, bool state);

            public delegate UInt32 GetWindowColorTextureDelegate(IntPtr renderer);

            public delegate UInt32 GetWindowDepthTextureDelegate(IntPtr renderer);

            public delegate void GetLastRenderSizeDelegate(IntPtr renderer, Int32 w, Int32 h);

            public delegate void RenderDelegate(IntPtr renderer, Int32 w, Int32 h);

            public delegate bool ExistsPipelineItemDelegate(IntPtr pipeline, IntPtr name);

            public delegate IntPtr GetPipelineItemDelegate(IntPtr pipeline, IntPtr name);

            public delegate void BindShaderPassVariablesDelegate(IntPtr shaderpass, IntPtr item);

            public delegate void GetViewMatrixDelegate(IntPtr out_);

            public delegate void GetProjectionMatrixDelegate(IntPtr out_);

            public delegate void GetOrthographicMatrixDelegate(IntPtr out_);

            public delegate void GetViewportSizeDelegate(float w, float h);

            public delegate void AdvanceTimerDelegate(float t);

            public delegate void GetMousePositionDelegate(float x, float y);

            public delegate Int32 GetFrameIndexDelegate();

            public delegate float GetTimeDelegate();

            public delegate void SetTimeDelegate(float time);

            public delegate void SetGeometryTransformDelegate(IntPtr item, ArrPointer3<float> scale, ArrPointer3<float> rota, ArrPointer3<float> pos);

            public delegate void SetMousePositionDelegate(float x, float y);

            public delegate void SetKeysWASDDelegate(bool w, bool a, bool s, bool d);

            public delegate void SetFrameIndexDelegate(Int32 findex);

            public delegate float GetDPIDelegate();

            public delegate bool FileExistsDelegate(IntPtr project, IntPtr path);

            public delegate void ClearMessageGroupDelegate(IntPtr messages, IntPtr group);

            public delegate void LogDelegate(IntPtr msg, bool error, IntPtr file, Int32 line);

            public delegate Int32 GetObjectCountDelegate(IntPtr objects);

            public delegate IntPtr GetObjectNameDelegate(IntPtr objects, Int32 index);

            public delegate bool IsTextureDelegate(IntPtr objects, IntPtr name);

            public delegate UInt32 GetTextureDelegate(IntPtr objects, IntPtr name);

            public delegate UInt32 GetFlippedTextureDelegate(IntPtr objects, IntPtr name);

            public delegate void GetTextureSizeDelegate(IntPtr objects, IntPtr name, Int32 w, Int32 h);

            public delegate void BindDefaultStateDelegate();

            public delegate void OpenInCodeEditorDelegate(IntPtr UI, IntPtr item, IntPtr filename, Int32 id);

            public delegate Int32 GetPipelineItemCountDelegate(IntPtr pipeline);

            public delegate SHADERedCLR.Wrapper.PipelineItemType GetPipelineItemTypeDelegate(IntPtr item);

            public delegate IntPtr GetPipelineItemByIndexDelegate(IntPtr pipeline, Int32 index);

            public delegate IntPtr GetPipelineItemNameDelegate(IntPtr item);

            public delegate IntPtr GetPipelineItemPluginOwnerDelegate(IntPtr item);

            public delegate Int32 GetPipelineItemVariableCountDelegate(IntPtr item);

            public delegate IntPtr GetPipelineItemVariableNameDelegate(IntPtr item, Int32 index);

            public delegate IntPtr GetPipelineItemVariableValueDelegate(IntPtr item, Int32 index);

            public delegate SHADERedCLR.Wrapper.VariableType GetPipelineItemVariableTypeDelegate(IntPtr item, Int32 index);

            public delegate bool AddPipelineItemVariableDelegate(IntPtr item, IntPtr name, SHADERedCLR.Wrapper.VariableType type);

            public delegate Int32 GetPipelineItemChildrenCountDelegate(IntPtr item);

            public delegate IntPtr GetPipelineItemChildDelegate(IntPtr item, Int32 index);

            public delegate void SetPipelineItemPositionDelegate(IntPtr item, float x, float y, float z);

            public delegate void SetPipelineItemRotationDelegate(IntPtr item, float x, float y, float z);

            public delegate void SetPipelineItemScaleDelegate(IntPtr item, float x, float y, float z);

            public delegate void GetPipelineItemPositionDelegate(IntPtr item, IntPtr pos);

            public delegate void GetPipelineItemRotationDelegate(IntPtr item, IntPtr rot);

            public delegate void GetPipelineItemScaleDelegate(IntPtr item, IntPtr scale);

            public delegate bool DEPRECATED_GetOpenDirectoryDialogDelegate(IntPtr out_);

            public delegate bool DEPRECATED_GetOpenFileDialogDelegate(IntPtr out_, IntPtr files);

            public delegate bool DEPRECATED_GetSaveFileDialogDelegate(IntPtr out_, IntPtr files);

            public delegate Int32 GetIncludePathCountDelegate();

            public delegate IntPtr GetIncludePathDelegate(IntPtr project, Int32 index);

            public delegate IntPtr GetMessagesCurrentItemDelegate(IntPtr messages);

            public delegate void OnEditorContentChangeDelegate(IntPtr UI, IntPtr plugin, Int32 langID, Int32 editorID);

            public delegate IntPtr GetPipelineItemSPIRVDelegate(IntPtr item, SHADERedCLR.Wrapper.ShaderStage stage, IntPtr dataLen);

            public delegate void RegisterShortcutDelegate(IntPtr plugin, IntPtr name);

            public delegate bool GetSettingsBooleanDelegate(IntPtr name);

            public delegate IntPtr GetSettingsStringDelegate(IntPtr name);

            public delegate Int32 GetSettingsIntegerDelegate(IntPtr name);

            public delegate float GetSettingsFloatDelegate(IntPtr name);

            public delegate void GetPreviewUIRectDelegate(IntPtr ui, IntPtr out_);

            public delegate IntPtr GetPluginDelegate(IntPtr pluginManager, IntPtr name);

            public delegate Int32 GetPluginListSizeDelegate(IntPtr pluginManager);

            public delegate IntPtr GetPluginNameDelegate(IntPtr pluginManager, Int32 index);

            public delegate void SendPluginMessageDelegate(IntPtr pluginManager, IntPtr plugin, IntPtr receiver, IntPtr msg, Int32 msgLen);

            public delegate void BroadcastPluginMessageDelegate(IntPtr pluginManager, IntPtr plugin, IntPtr msg, Int32 msgLen);

            public delegate void ToggleFullscreenDelegate(IntPtr UI);

            public delegate bool IsFullscreenDelegate(IntPtr UI);

            public delegate void TogglePerformanceModeDelegate(IntPtr UI);

            public delegate bool IsInPerformanceModeDelegate(IntPtr UI);

            public delegate void PushNotificationDelegate(IntPtr UI, IntPtr plugin, Int32 id, IntPtr text, IntPtr buttonText);

            public delegate void DebuggerJumpDelegate(IntPtr Debugger, IntPtr TextEditor, Int32 line);

            public delegate void DebuggerContinueDelegate(IntPtr Debugger, IntPtr TextEditor);

            public delegate void DebuggerStepDelegate(IntPtr Debugger, IntPtr TextEditor);

            public delegate void DebuggerStepIntoDelegate(IntPtr Debugger, IntPtr TextEditor);

            public delegate void DebuggerStepOutDelegate(IntPtr Debugger, IntPtr TextEditor);

            public delegate bool DebuggerCheckBreakpointDelegate(IntPtr Debugger, IntPtr TextEditor, Int32 line);

            public delegate bool DebuggerIsDebuggingDelegate(IntPtr Debugger, IntPtr TextEditor);

            public delegate Int32 DebuggerGetCurrentLineDelegate(IntPtr Debugger);

            public delegate bool IsRenderTextureDelegate(IntPtr objects, IntPtr name);

            public delegate void GetRenderTextureSizeDelegate(IntPtr objects, IntPtr name, Int32 w, Int32 h);

            public delegate UInt32 GetDepthTextureDelegate(IntPtr objects, IntPtr name);

            public delegate float ScaleSizeDelegate(float size);

            public delegate Int32 GetHostIPluginMaxVersionDelegate();

            public delegate void ImGuiFileDialogOpenDelegate(IntPtr key, IntPtr title, IntPtr filter);

            public delegate void ImGuiDirectoryDialogOpenDelegate(IntPtr key, IntPtr title);

            public delegate bool ImGuiFileDialogIsDoneDelegate(IntPtr key);

            public delegate void ImGuiFileDialogCloseDelegate(IntPtr key);

            public delegate bool ImGuiFileDialogGetResultDelegate();

            public delegate void ImGuiFileDialogGetPathDelegate(IntPtr outPath);

            public delegate IntPtr DebuggerImmediateDelegate(IntPtr Debugger, IntPtr expr);

            public delegate void RegisterPluginDelegate(IntPtr pluginManager, IntPtr plugin, IntPtr pname, Int32 apiVer, Int32 pluginVer, IntPtr procDLL);

            public delegate IntPtr GetEditorPipelineItemDelegate(IntPtr UI, IntPtr plugin, Int32 langID, Int32 editorID);

            public delegate void SetViewportSizeDelegate(float w, float h);

            public delegate Int32 IsObjectBoundDelegate(IntPtr Objects, IntPtr name, IntPtr pipelineItem);

            public delegate void DebuggerStepIntoPluginEditorDelegate(IntPtr Debugger, IntPtr Code, IntPtr Plugin, Int32 lang, Int32 editor);

            public delegate void DebuggerGetVariableValueDelegate(IntPtr Debugger, IntPtr name, IntPtr value, Int32 valueLength);

            public delegate void DebuggerStopPluginEditorDelegate(IntPtr Debugger, IntPtr Code, IntPtr Plugin, Int32 lang, Int32 editor);

            public delegate bool DebuggerIsVMRunningDelegate(IntPtr Debugger);

            // function Init
            public delegate bool InitDelegate_000(bool isWeb, Int32 sedVersion);
            public InitDelegate_000 Init_000;

            // function InitUI
            public delegate void InitUIDelegate_001(IntPtr ctx);
            public InitUIDelegate_001 InitUI_001;

            // function OnEvent
            public delegate void OnEventDelegate_002(IntPtr e);
            public OnEventDelegate_002 OnEvent_002;

            // function Update
            public delegate void UpdateDelegate_003(float delta);
            public UpdateDelegate_003 Update_003;

            // function Destroy
            public delegate void DestroyDelegate_004();
            public DestroyDelegate_004 Destroy_004;

            // function IsRequired
            public delegate bool IsRequiredDelegate_005();
            public IsRequiredDelegate_005 IsRequired_005;

            // function IsVersionCompatible
            public delegate bool IsVersionCompatibleDelegate_006(Int32 version);
            public IsVersionCompatibleDelegate_006 IsVersionCompatible_006;

            // function BeginRender
            public delegate void BeginRenderDelegate_007();
            public BeginRenderDelegate_007 BeginRender_007;

            // function EndRender
            public delegate void EndRenderDelegate_008();
            public EndRenderDelegate_008 EndRender_008;

            // function Project_BeginLoad
            public delegate void Project_BeginLoadDelegate_009();
            public Project_BeginLoadDelegate_009 Project_BeginLoad_009;

            // function Project_EndLoad
            public delegate void Project_EndLoadDelegate_010();
            public Project_EndLoadDelegate_010 Project_EndLoad_010;

            // function Project_BeginSave
            public delegate void Project_BeginSaveDelegate_011();
            public Project_BeginSaveDelegate_011 Project_BeginSave_011;

            // function Project_EndSave
            public delegate void Project_EndSaveDelegate_012();
            public Project_EndSaveDelegate_012 Project_EndSave_012;

            // function Project_HasAdditionalData
            public delegate bool Project_HasAdditionalDataDelegate_013();
            public Project_HasAdditionalDataDelegate_013 Project_HasAdditionalData_013;

            // function Project_ExportAdditionalData
            public delegate IntPtr Project_ExportAdditionalDataDelegate_014();
            public Project_ExportAdditionalDataDelegate_014 Project_ExportAdditionalData_014;

            // function Project_ImportAdditionalData
            public delegate void Project_ImportAdditionalDataDelegate_015(IntPtr xml);
            public Project_ImportAdditionalDataDelegate_015 Project_ImportAdditionalData_015;

            // function Project_CopyFilesOnSave
            public delegate void Project_CopyFilesOnSaveDelegate_016(IntPtr dir);
            public Project_CopyFilesOnSaveDelegate_016 Project_CopyFilesOnSave_016;

            // function HasCustomMenuItem
            public delegate bool HasCustomMenuItemDelegate_017();
            public HasCustomMenuItemDelegate_017 HasCustomMenuItem_017;

            // function HasMenuItems
            public delegate bool HasMenuItemsDelegate_018(IntPtr name);
            public HasMenuItemsDelegate_018 HasMenuItems_018;

            // function ShowMenuItems
            public delegate void ShowMenuItemsDelegate_019(IntPtr name);
            public ShowMenuItemsDelegate_019 ShowMenuItems_019;

            // function HasContextItems
            public delegate bool HasContextItemsDelegate_020(IntPtr name);
            public HasContextItemsDelegate_020 HasContextItems_020;

            // function ShowContextItems
            public delegate void ShowContextItemsDelegate_021(IntPtr name, IntPtr owner, IntPtr extraData);
            public ShowContextItemsDelegate_021 ShowContextItems_021;

            // function SystemVariables_GetNameCount
            public delegate Int32 SystemVariables_GetNameCountDelegate_022(SHADERedCLR.Wrapper.VariableType varType);
            public SystemVariables_GetNameCountDelegate_022 SystemVariables_GetNameCount_022;

            // function SystemVariables_GetName
            public delegate IntPtr SystemVariables_GetNameDelegate_023(SHADERedCLR.Wrapper.VariableType varType, Int32 index);
            public SystemVariables_GetNameDelegate_023 SystemVariables_GetName_023;

            // function SystemVariables_HasLastFrame
            public delegate bool SystemVariables_HasLastFrameDelegate_024(IntPtr name, SHADERedCLR.Wrapper.VariableType varType);
            public SystemVariables_HasLastFrameDelegate_024 SystemVariables_HasLastFrame_024;

            // function SystemVariables_UpdateValue
            public delegate void SystemVariables_UpdateValueDelegate_025(IntPtr data, IntPtr name, SHADERedCLR.Wrapper.VariableType varType, bool isLastFrame);
            public SystemVariables_UpdateValueDelegate_025 SystemVariables_UpdateValue_025;

            // function VariableFunctions_GetNameCount
            public delegate Int32 VariableFunctions_GetNameCountDelegate_026(SHADERedCLR.Wrapper.VariableType vtype);
            public VariableFunctions_GetNameCountDelegate_026 VariableFunctions_GetNameCount_026;

            // function VariableFunctions_GetName
            public delegate IntPtr VariableFunctions_GetNameDelegate_027(SHADERedCLR.Wrapper.VariableType varType, Int32 index);
            public VariableFunctions_GetNameDelegate_027 VariableFunctions_GetName_027;

            // function VariableFunctions_ShowArgumentEdit
            public delegate bool VariableFunctions_ShowArgumentEditDelegate_028(IntPtr fname, IntPtr args, SHADERedCLR.Wrapper.VariableType vtype);
            public VariableFunctions_ShowArgumentEditDelegate_028 VariableFunctions_ShowArgumentEdit_028;

            // function VariableFunctions_UpdateValue
            public delegate void VariableFunctions_UpdateValueDelegate_029(IntPtr data, IntPtr args, IntPtr fname, SHADERedCLR.Wrapper.VariableType varType);
            public VariableFunctions_UpdateValueDelegate_029 VariableFunctions_UpdateValue_029;

            // function VariableFunctions_GetArgsSize
            public delegate Int32 VariableFunctions_GetArgsSizeDelegate_030(IntPtr fname, SHADERedCLR.Wrapper.VariableType varType);
            public VariableFunctions_GetArgsSizeDelegate_030 VariableFunctions_GetArgsSize_030;

            // function VariableFunctions_InitArguments
            public delegate void VariableFunctions_InitArgumentsDelegate_031(IntPtr args, IntPtr fname, SHADERedCLR.Wrapper.VariableType vtype);
            public VariableFunctions_InitArgumentsDelegate_031 VariableFunctions_InitArguments_031;

            // function VariableFunctions_ExportArguments
            public delegate IntPtr VariableFunctions_ExportArgumentsDelegate_032(IntPtr fname, SHADERedCLR.Wrapper.VariableType vtype, IntPtr args);
            public VariableFunctions_ExportArgumentsDelegate_032 VariableFunctions_ExportArguments_032;

            // function VariableFunctions_ImportArguments
            public delegate void VariableFunctions_ImportArgumentsDelegate_033(IntPtr fname, SHADERedCLR.Wrapper.VariableType vtype, IntPtr args, IntPtr argsString);
            public VariableFunctions_ImportArgumentsDelegate_033 VariableFunctions_ImportArguments_033;

            // function Object_HasPreview
            public delegate bool Object_HasPreviewDelegate_034(IntPtr type);
            public Object_HasPreviewDelegate_034 Object_HasPreview_034;

            // function Object_ShowPreview
            public delegate void Object_ShowPreviewDelegate_035(IntPtr type, IntPtr data, UInt32 id);
            public Object_ShowPreviewDelegate_035 Object_ShowPreview_035;

            // function Object_IsBindable
            public delegate bool Object_IsBindableDelegate_036(IntPtr type);
            public Object_IsBindableDelegate_036 Object_IsBindable_036;

            // function Object_IsBindableUAV
            public delegate bool Object_IsBindableUAVDelegate_037(IntPtr type);
            public Object_IsBindableUAVDelegate_037 Object_IsBindableUAV_037;

            // function Object_Remove
            public delegate void Object_RemoveDelegate_038(IntPtr name, IntPtr type, IntPtr data, UInt32 id);
            public Object_RemoveDelegate_038 Object_Remove_038;

            // function Object_HasExtendedPreview
            public delegate bool Object_HasExtendedPreviewDelegate_039(IntPtr type);
            public Object_HasExtendedPreviewDelegate_039 Object_HasExtendedPreview_039;

            // function Object_ShowExtendedPreview
            public delegate void Object_ShowExtendedPreviewDelegate_040(IntPtr type, IntPtr data, UInt32 id);
            public Object_ShowExtendedPreviewDelegate_040 Object_ShowExtendedPreview_040;

            // function Object_HasProperties
            public delegate bool Object_HasPropertiesDelegate_041(IntPtr type);
            public Object_HasPropertiesDelegate_041 Object_HasProperties_041;

            // function Object_ShowProperties
            public delegate void Object_ShowPropertiesDelegate_042(IntPtr type, IntPtr data, UInt32 id);
            public Object_ShowPropertiesDelegate_042 Object_ShowProperties_042;

            // function Object_Bind
            public delegate void Object_BindDelegate_043(IntPtr type, IntPtr data, UInt32 id);
            public Object_BindDelegate_043 Object_Bind_043;

            // function Object_Export
            public delegate IntPtr Object_ExportDelegate_044(IntPtr type, IntPtr data, UInt32 id);
            public Object_ExportDelegate_044 Object_Export_044;

            // function Object_Import
            public delegate void Object_ImportDelegate_045(IntPtr name, IntPtr type, IntPtr argsString);
            public Object_ImportDelegate_045 Object_Import_045;

            // function Object_HasContext
            public delegate bool Object_HasContextDelegate_046(IntPtr type);
            public Object_HasContextDelegate_046 Object_HasContext_046;

            // function Object_ShowContext
            public delegate void Object_ShowContextDelegate_047(IntPtr type, IntPtr data);
            public Object_ShowContextDelegate_047 Object_ShowContext_047;

            // function PipelineItem_HasProperties
            public delegate bool PipelineItem_HasPropertiesDelegate_048(IntPtr type, IntPtr data);
            public PipelineItem_HasPropertiesDelegate_048 PipelineItem_HasProperties_048;

            // function PipelineItem_ShowProperties
            public delegate void PipelineItem_ShowPropertiesDelegate_049(IntPtr type, IntPtr data);
            public PipelineItem_ShowPropertiesDelegate_049 PipelineItem_ShowProperties_049;

            // function PipelineItem_IsPickable
            public delegate bool PipelineItem_IsPickableDelegate_050(IntPtr type, IntPtr data);
            public PipelineItem_IsPickableDelegate_050 PipelineItem_IsPickable_050;

            // function PipelineItem_HasShaders
            public delegate bool PipelineItem_HasShadersDelegate_051(IntPtr type, IntPtr data);
            public PipelineItem_HasShadersDelegate_051 PipelineItem_HasShaders_051;

            // function PipelineItem_OpenInEditor
            public delegate void PipelineItem_OpenInEditorDelegate_052(IntPtr type, IntPtr data);
            public PipelineItem_OpenInEditorDelegate_052 PipelineItem_OpenInEditor_052;

            // function PipelineItem_CanHaveChild
            public delegate bool PipelineItem_CanHaveChildDelegate_053(IntPtr type, IntPtr data, SHADERedCLR.Wrapper.PipelineItemType itemType);
            public PipelineItem_CanHaveChildDelegate_053 PipelineItem_CanHaveChild_053;

            // function PipelineItem_GetInputLayoutSize
            public delegate Int32 PipelineItem_GetInputLayoutSizeDelegate_054(IntPtr type, IntPtr data);
            public PipelineItem_GetInputLayoutSizeDelegate_054 PipelineItem_GetInputLayoutSize_054;

            // function PipelineItem_GetInputLayoutItem
            public delegate void PipelineItem_GetInputLayoutItemDelegate_055(IntPtr type, IntPtr data, Int32 index, InputLayoutItem out_);
            public PipelineItem_GetInputLayoutItemDelegate_055 PipelineItem_GetInputLayoutItem_055;

            // function PipelineItem_Remove
            public delegate void PipelineItem_RemoveDelegate_056(IntPtr itemName, IntPtr type, IntPtr data);
            public PipelineItem_RemoveDelegate_056 PipelineItem_Remove_056;

            // function PipelineItem_Rename
            public delegate void PipelineItem_RenameDelegate_057(IntPtr oldName, IntPtr newName);
            public PipelineItem_RenameDelegate_057 PipelineItem_Rename_057;

            // function PipelineItem_AddChild
            public delegate void PipelineItem_AddChildDelegate_058(IntPtr owner, IntPtr name, SHADERedCLR.Wrapper.PipelineItemType type, IntPtr data);
            public PipelineItem_AddChildDelegate_058 PipelineItem_AddChild_058;

            // function PipelineItem_CanHaveChildren
            public delegate bool PipelineItem_CanHaveChildrenDelegate_059(IntPtr type, IntPtr data);
            public PipelineItem_CanHaveChildrenDelegate_059 PipelineItem_CanHaveChildren_059;

            // function PipelineItem_CopyData
            public delegate IntPtr PipelineItem_CopyDataDelegate_060(IntPtr type, IntPtr data);
            public PipelineItem_CopyDataDelegate_060 PipelineItem_CopyData_060;

            // function PipelineItem_Execute
            public delegate void PipelineItem_ExecuteDelegate_061(IntPtr Owner, SHADERedCLR.Wrapper.PipelineItemType OwnerType, IntPtr type, IntPtr data);
            public PipelineItem_ExecuteDelegate_061 PipelineItem_Execute_061;

            // function PipelineItem_Execute
            public delegate void PipelineItem_ExecuteDelegate_062(IntPtr type, IntPtr data, IntPtr children, Int32 count);
            public PipelineItem_ExecuteDelegate_062 PipelineItem_Execute_062;

            // function PipelineItem_GetWorldMatrix
            public delegate void PipelineItem_GetWorldMatrixDelegate_063(IntPtr type, IntPtr data, ArrPointer16<float> pMat);
            public PipelineItem_GetWorldMatrixDelegate_063 PipelineItem_GetWorldMatrix_063;

            // function PipelineItem_Intersect
            public delegate bool PipelineItem_IntersectDelegate_064(IntPtr type, IntPtr data, IntPtr rayOrigin, IntPtr rayDir, float hitDist);
            public PipelineItem_IntersectDelegate_064 PipelineItem_Intersect_064;

            // function PipelineItem_GetBoundingBox
            public delegate void PipelineItem_GetBoundingBoxDelegate_065(IntPtr type, IntPtr data, ArrPointer3<float> minPos, ArrPointer3<float> maxPos);
            public PipelineItem_GetBoundingBoxDelegate_065 PipelineItem_GetBoundingBox_065;

            // function PipelineItem_HasContext
            public delegate bool PipelineItem_HasContextDelegate_066(IntPtr type, IntPtr data);
            public PipelineItem_HasContextDelegate_066 PipelineItem_HasContext_066;

            // function PipelineItem_ShowContext
            public delegate void PipelineItem_ShowContextDelegate_067(IntPtr type, IntPtr data);
            public PipelineItem_ShowContextDelegate_067 PipelineItem_ShowContext_067;

            // function PipelineItem_Export
            public delegate IntPtr PipelineItem_ExportDelegate_068(IntPtr type, IntPtr data);
            public PipelineItem_ExportDelegate_068 PipelineItem_Export_068;

            // function PipelineItem_Import
            public delegate IntPtr PipelineItem_ImportDelegate_069(IntPtr ownerName, IntPtr name, IntPtr type, IntPtr argsString);
            public PipelineItem_ImportDelegate_069 PipelineItem_Import_069;

            // function PipelineItem_MoveDown
            public delegate void PipelineItem_MoveDownDelegate_070(IntPtr ownerData, IntPtr ownerType, IntPtr itemName);
            public PipelineItem_MoveDownDelegate_070 PipelineItem_MoveDown_070;

            // function PipelineItem_MoveUp
            public delegate void PipelineItem_MoveUpDelegate_071(IntPtr ownerData, IntPtr ownerType, IntPtr itemName);
            public PipelineItem_MoveUpDelegate_071 PipelineItem_MoveUp_071;

            // function PipelineItem_ApplyGizmoTransform
            public delegate void PipelineItem_ApplyGizmoTransformDelegate_072(IntPtr type, IntPtr data, IntPtr transl, IntPtr scale, IntPtr rota);
            public PipelineItem_ApplyGizmoTransformDelegate_072 PipelineItem_ApplyGizmoTransform_072;

            // function PipelineItem_GetTransform
            public delegate void PipelineItem_GetTransformDelegate_073(IntPtr type, IntPtr data, IntPtr transl, IntPtr scale, IntPtr rota);
            public PipelineItem_GetTransformDelegate_073 PipelineItem_GetTransform_073;

            // function PipelineItem_DebugVertexExecute
            public delegate void PipelineItem_DebugVertexExecuteDelegate_074(IntPtr Owner, SHADERedCLR.Wrapper.PipelineItemType OwnerType, IntPtr type, IntPtr data, UInt32 colorVarLoc);
            public PipelineItem_DebugVertexExecuteDelegate_074 PipelineItem_DebugVertexExecute_074;

            // function PipelineItem_DebugVertexExecute
            public delegate Int32 PipelineItem_DebugVertexExecuteDelegate_075(IntPtr type, IntPtr data, IntPtr childName, float rx, float ry, Int32 vertexGroup);
            public PipelineItem_DebugVertexExecuteDelegate_075 PipelineItem_DebugVertexExecute_075;

            // function PipelineItem_DebugInstanceExecute
            public delegate void PipelineItem_DebugInstanceExecuteDelegate_076(IntPtr Owner, SHADERedCLR.Wrapper.PipelineItemType OwnerType, IntPtr type, IntPtr data, UInt32 colorVarLoc);
            public PipelineItem_DebugInstanceExecuteDelegate_076 PipelineItem_DebugInstanceExecute_076;

            // function PipelineItem_DebugInstanceExecute
            public delegate Int32 PipelineItem_DebugInstanceExecuteDelegate_077(IntPtr type, IntPtr data, IntPtr childName, float rx, float ry, Int32 vertexGroup);
            public PipelineItem_DebugInstanceExecuteDelegate_077 PipelineItem_DebugInstanceExecute_077;

            // function PipelineItem_GetVBO
            public delegate UInt32 PipelineItem_GetVBODelegate_078(IntPtr type, IntPtr data);
            public PipelineItem_GetVBODelegate_078 PipelineItem_GetVBO_078;

            // function PipelineItem_GetVBOStride
            public delegate UInt32 PipelineItem_GetVBOStrideDelegate_079(IntPtr type, IntPtr data);
            public PipelineItem_GetVBOStrideDelegate_079 PipelineItem_GetVBOStride_079;

            // function PipelineItem_CanChangeVariables
            public delegate bool PipelineItem_CanChangeVariablesDelegate_080(IntPtr type, IntPtr data);
            public PipelineItem_CanChangeVariablesDelegate_080 PipelineItem_CanChangeVariables_080;

            // function PipelineItem_IsDebuggable
            public delegate bool PipelineItem_IsDebuggableDelegate_081(IntPtr type, IntPtr data);
            public PipelineItem_IsDebuggableDelegate_081 PipelineItem_IsDebuggable_081;

            // function PipelineItem_IsStageDebuggable
            public delegate bool PipelineItem_IsStageDebuggableDelegate_082(IntPtr type, IntPtr data, SHADERedCLR.Wrapper.ShaderStage stage);
            public PipelineItem_IsStageDebuggableDelegate_082 PipelineItem_IsStageDebuggable_082;

            // function PipelineItem_DebugExecute
            public delegate void PipelineItem_DebugExecuteDelegate_083(IntPtr type, IntPtr data, IntPtr children, Int32 count, IntPtr debugID);
            public PipelineItem_DebugExecuteDelegate_083 PipelineItem_DebugExecute_083;

            // function PipelineItem_GetTopology
            public delegate UInt32 PipelineItem_GetTopologyDelegate_084(IntPtr type, IntPtr data);
            public PipelineItem_GetTopologyDelegate_084 PipelineItem_GetTopology_084;

            // function PipelineItem_GetVariableCount
            public delegate UInt32 PipelineItem_GetVariableCountDelegate_085(IntPtr type, IntPtr data);
            public PipelineItem_GetVariableCountDelegate_085 PipelineItem_GetVariableCount_085;

            // function PipelineItem_GetVariableName
            public delegate IntPtr PipelineItem_GetVariableNameDelegate_086(IntPtr type, IntPtr data, UInt32 variable);
            public PipelineItem_GetVariableNameDelegate_086 PipelineItem_GetVariableName_086;

            // function PipelineItem_GetVariableType
            public delegate SHADERedCLR.Wrapper.VariableType PipelineItem_GetVariableTypeDelegate_087(IntPtr type, IntPtr data, UInt32 variable);
            public PipelineItem_GetVariableTypeDelegate_087 PipelineItem_GetVariableType_087;

            // function PipelineItem_GetVariableValueFloat
            public delegate float PipelineItem_GetVariableValueFloatDelegate_088(IntPtr type, IntPtr data, UInt32 variable, Int32 col, Int32 row);
            public PipelineItem_GetVariableValueFloatDelegate_088 PipelineItem_GetVariableValueFloat_088;

            // function PipelineItem_GetVariableValueInteger
            public delegate Int32 PipelineItem_GetVariableValueIntegerDelegate_089(IntPtr type, IntPtr data, UInt32 variable, Int32 col);
            public PipelineItem_GetVariableValueIntegerDelegate_089 PipelineItem_GetVariableValueInteger_089;

            // function PipelineItem_GetVariableValueBoolean
            public delegate bool PipelineItem_GetVariableValueBooleanDelegate_090(IntPtr type, IntPtr data, UInt32 variable, Int32 col);
            public PipelineItem_GetVariableValueBooleanDelegate_090 PipelineItem_GetVariableValueBoolean_090;

            // function PipelineItem_GetSPIRVSize
            public delegate UInt32 PipelineItem_GetSPIRVSizeDelegate_091(IntPtr type, IntPtr data, SHADERedCLR.Wrapper.ShaderStage stage);
            public PipelineItem_GetSPIRVSizeDelegate_091 PipelineItem_GetSPIRVSize_091;

            // function PipelineItem_GetSPIRV
            public delegate IntPtr PipelineItem_GetSPIRVDelegate_092(IntPtr type, IntPtr data, SHADERedCLR.Wrapper.ShaderStage stage);
            public PipelineItem_GetSPIRVDelegate_092 PipelineItem_GetSPIRV_092;

            // function PipelineItem_DebugPrepareVariables
            public delegate void PipelineItem_DebugPrepareVariablesDelegate_093(IntPtr type, IntPtr data, IntPtr name);
            public PipelineItem_DebugPrepareVariablesDelegate_093 PipelineItem_DebugPrepareVariables_093;

            // function PipelineItem_DebugUsesCustomTextures
            public delegate bool PipelineItem_DebugUsesCustomTexturesDelegate_094(IntPtr type, IntPtr data);
            public PipelineItem_DebugUsesCustomTexturesDelegate_094 PipelineItem_DebugUsesCustomTextures_094;

            // function PipelineItem_DebugGetTexture
            public delegate UInt32 PipelineItem_DebugGetTextureDelegate_095(IntPtr type, IntPtr data, Int32 loc, IntPtr variableName);
            public PipelineItem_DebugGetTextureDelegate_095 PipelineItem_DebugGetTexture_095;

            // function PipelineItem_DebugGetTextureSize
            public delegate void PipelineItem_DebugGetTextureSizeDelegate_096(IntPtr type, IntPtr data, Int32 loc, IntPtr variableName, Int32 x, Int32 y, Int32 z);
            public PipelineItem_DebugGetTextureSizeDelegate_096 PipelineItem_DebugGetTextureSize_096;

            // function Options_HasSection
            public delegate bool Options_HasSectionDelegate_097();
            public Options_HasSectionDelegate_097 Options_HasSection_097;

            // function Options_RenderSection
            public delegate void Options_RenderSectionDelegate_098();
            public Options_RenderSectionDelegate_098 Options_RenderSection_098;

            // function Options_Parse
            public delegate void Options_ParseDelegate_099(IntPtr key, IntPtr val);
            public Options_ParseDelegate_099 Options_Parse_099;

            // function Options_GetCount
            public delegate Int32 Options_GetCountDelegate_100();
            public Options_GetCountDelegate_100 Options_GetCount_100;

            // function Options_GetKey
            public delegate IntPtr Options_GetKeyDelegate_101(Int32 index);
            public Options_GetKeyDelegate_101 Options_GetKey_101;

            // function Options_GetValue
            public delegate IntPtr Options_GetValueDelegate_102(Int32 index);
            public Options_GetValueDelegate_102 Options_GetValue_102;

            // function CustomLanguage_GetCount
            public delegate Int32 CustomLanguage_GetCountDelegate_103();
            public CustomLanguage_GetCountDelegate_103 CustomLanguage_GetCount_103;

            // function CustomLanguage_GetName
            public delegate IntPtr CustomLanguage_GetNameDelegate_104(Int32 langID);
            public CustomLanguage_GetNameDelegate_104 CustomLanguage_GetName_104;

            // function CustomLanguage_CompileToSPIRV
            public delegate IntPtr CustomLanguage_CompileToSPIRVDelegate_105(Int32 langID, IntPtr src, UInt64 src_len, SHADERedCLR.Wrapper.ShaderStage stage, IntPtr entry, IntPtr macros, UInt64 macroCount, IntPtr spv_length, IntPtr compiled);
            public CustomLanguage_CompileToSPIRVDelegate_105 CustomLanguage_CompileToSPIRV_105;

            // function CustomLanguage_ProcessGeneratedGLSL
            public delegate IntPtr CustomLanguage_ProcessGeneratedGLSLDelegate_106(Int32 langID, IntPtr src);
            public CustomLanguage_ProcessGeneratedGLSLDelegate_106 CustomLanguage_ProcessGeneratedGLSL_106;

            // function CustomLanguage_SupportsAutoUniforms
            public delegate bool CustomLanguage_SupportsAutoUniformsDelegate_107(Int32 langID);
            public CustomLanguage_SupportsAutoUniformsDelegate_107 CustomLanguage_SupportsAutoUniforms_107;

            // function CustomLanguage_IsDebuggable
            public delegate bool CustomLanguage_IsDebuggableDelegate_108(Int32 langID);
            public CustomLanguage_IsDebuggableDelegate_108 CustomLanguage_IsDebuggable_108;

            // function CustomLanguage_GetDefaultExtension
            public delegate IntPtr CustomLanguage_GetDefaultExtensionDelegate_109(Int32 langID);
            public CustomLanguage_GetDefaultExtensionDelegate_109 CustomLanguage_GetDefaultExtension_109;

            // function ShaderEditor_Supports
            public delegate bool ShaderEditor_SupportsDelegate_110(Int32 langID);
            public ShaderEditor_SupportsDelegate_110 ShaderEditor_Supports_110;

            // function ShaderEditor_Open
            public delegate void ShaderEditor_OpenDelegate_111(Int32 langID, Int32 editorID, IntPtr data, Int32 dataLen);
            public ShaderEditor_OpenDelegate_111 ShaderEditor_Open_111;

            // function ShaderEditor_Render
            public delegate void ShaderEditor_RenderDelegate_112(Int32 langID, Int32 editorID);
            public ShaderEditor_RenderDelegate_112 ShaderEditor_Render_112;

            // function ShaderEditor_Close
            public delegate void ShaderEditor_CloseDelegate_113(Int32 langID, Int32 editorID);
            public ShaderEditor_CloseDelegate_113 ShaderEditor_Close_113;

            // function ShaderEditor_GetContent
            public delegate IntPtr ShaderEditor_GetContentDelegate_114(Int32 langID, Int32 editorID, IntPtr dataLength);
            public ShaderEditor_GetContentDelegate_114 ShaderEditor_GetContent_114;

            // function ShaderEditor_IsChanged
            public delegate bool ShaderEditor_IsChangedDelegate_115(Int32 langID, Int32 editorID);
            public ShaderEditor_IsChangedDelegate_115 ShaderEditor_IsChanged_115;

            // function ShaderEditor_ResetChangeState
            public delegate void ShaderEditor_ResetChangeStateDelegate_116(Int32 langID, Int32 editorID);
            public ShaderEditor_ResetChangeStateDelegate_116 ShaderEditor_ResetChangeState_116;

            // function ShaderEditor_CanUndo
            public delegate bool ShaderEditor_CanUndoDelegate_117(Int32 langID, Int32 editorID);
            public ShaderEditor_CanUndoDelegate_117 ShaderEditor_CanUndo_117;

            // function ShaderEditor_CanRedo
            public delegate bool ShaderEditor_CanRedoDelegate_118(Int32 langID, Int32 editorID);
            public ShaderEditor_CanRedoDelegate_118 ShaderEditor_CanRedo_118;

            // function ShaderEditor_Undo
            public delegate void ShaderEditor_UndoDelegate_119(Int32 langID, Int32 editorID);
            public ShaderEditor_UndoDelegate_119 ShaderEditor_Undo_119;

            // function ShaderEditor_Redo
            public delegate void ShaderEditor_RedoDelegate_120(Int32 langID, Int32 editorID);
            public ShaderEditor_RedoDelegate_120 ShaderEditor_Redo_120;

            // function ShaderEditor_Cut
            public delegate void ShaderEditor_CutDelegate_121(Int32 langID, Int32 editorID);
            public ShaderEditor_CutDelegate_121 ShaderEditor_Cut_121;

            // function ShaderEditor_Paste
            public delegate void ShaderEditor_PasteDelegate_122(Int32 langID, Int32 editorID);
            public ShaderEditor_PasteDelegate_122 ShaderEditor_Paste_122;

            // function ShaderEditor_Copy
            public delegate void ShaderEditor_CopyDelegate_123(Int32 langID, Int32 editorID);
            public ShaderEditor_CopyDelegate_123 ShaderEditor_Copy_123;

            // function ShaderEditor_SelectAll
            public delegate void ShaderEditor_SelectAllDelegate_124(Int32 langID, Int32 editorID);
            public ShaderEditor_SelectAllDelegate_124 ShaderEditor_SelectAll_124;

            // function ShaderEditor_HasStats
            public delegate bool ShaderEditor_HasStatsDelegate_125(Int32 langID, Int32 editorID);
            public ShaderEditor_HasStatsDelegate_125 ShaderEditor_HasStats_125;

            // function CodeEditor_SaveItem
            public delegate void CodeEditor_SaveItemDelegate_126(IntPtr src, Int32 srcLen, IntPtr path);
            public CodeEditor_SaveItemDelegate_126 CodeEditor_SaveItem_126;

            // function CodeEditor_CloseItem
            public delegate void CodeEditor_CloseItemDelegate_127(IntPtr path);
            public CodeEditor_CloseItemDelegate_127 CodeEditor_CloseItem_127;

            // function LanguageDefinition_Exists
            public delegate bool LanguageDefinition_ExistsDelegate_128(Int32 id);
            public LanguageDefinition_ExistsDelegate_128 LanguageDefinition_Exists_128;

            // function LanguageDefinition_GetKeywordCount
            public delegate Int32 LanguageDefinition_GetKeywordCountDelegate_129(Int32 id);
            public LanguageDefinition_GetKeywordCountDelegate_129 LanguageDefinition_GetKeywordCount_129;

            // function LanguageDefinition_GetKeywords
            public delegate IntPtr LanguageDefinition_GetKeywordsDelegate_130(Int32 id);
            public LanguageDefinition_GetKeywordsDelegate_130 LanguageDefinition_GetKeywords_130;

            // function LanguageDefinition_GetTokenRegexCount
            public delegate Int32 LanguageDefinition_GetTokenRegexCountDelegate_131(Int32 id);
            public LanguageDefinition_GetTokenRegexCountDelegate_131 LanguageDefinition_GetTokenRegexCount_131;

            // function LanguageDefinition_GetTokenRegex
            public delegate IntPtr LanguageDefinition_GetTokenRegexDelegate_132(Int32 index, SHADERedCLR.Wrapper.TextEditorPaletteIndex palIndex, Int32 id);
            public LanguageDefinition_GetTokenRegexDelegate_132 LanguageDefinition_GetTokenRegex_132;

            // function LanguageDefinition_GetIdentifierCount
            public delegate Int32 LanguageDefinition_GetIdentifierCountDelegate_133(Int32 id);
            public LanguageDefinition_GetIdentifierCountDelegate_133 LanguageDefinition_GetIdentifierCount_133;

            // function LanguageDefinition_GetIdentifier
            public delegate IntPtr LanguageDefinition_GetIdentifierDelegate_134(Int32 index, Int32 id);
            public LanguageDefinition_GetIdentifierDelegate_134 LanguageDefinition_GetIdentifier_134;

            // function LanguageDefinition_GetIdentifierDesc
            public delegate IntPtr LanguageDefinition_GetIdentifierDescDelegate_135(Int32 index, Int32 id);
            public LanguageDefinition_GetIdentifierDescDelegate_135 LanguageDefinition_GetIdentifierDesc_135;

            // function LanguageDefinition_GetCommentStart
            public delegate IntPtr LanguageDefinition_GetCommentStartDelegate_136(Int32 id);
            public LanguageDefinition_GetCommentStartDelegate_136 LanguageDefinition_GetCommentStart_136;

            // function LanguageDefinition_GetCommentEnd
            public delegate IntPtr LanguageDefinition_GetCommentEndDelegate_137(Int32 id);
            public LanguageDefinition_GetCommentEndDelegate_137 LanguageDefinition_GetCommentEnd_137;

            // function LanguageDefinition_GetLineComment
            public delegate IntPtr LanguageDefinition_GetLineCommentDelegate_138(Int32 id);
            public LanguageDefinition_GetLineCommentDelegate_138 LanguageDefinition_GetLineComment_138;

            // function LanguageDefinition_IsCaseSensitive
            public delegate bool LanguageDefinition_IsCaseSensitiveDelegate_139(Int32 id);
            public LanguageDefinition_IsCaseSensitiveDelegate_139 LanguageDefinition_IsCaseSensitive_139;

            // function LanguageDefinition_GetAutoIndent
            public delegate bool LanguageDefinition_GetAutoIndentDelegate_140(Int32 id);
            public LanguageDefinition_GetAutoIndentDelegate_140 LanguageDefinition_GetAutoIndent_140;

            // function LanguageDefinition_GetName
            public delegate IntPtr LanguageDefinition_GetNameDelegate_141(Int32 id);
            public LanguageDefinition_GetNameDelegate_141 LanguageDefinition_GetName_141;

            // function LanguageDefinition_GetNameAbbreviation
            public delegate IntPtr LanguageDefinition_GetNameAbbreviationDelegate_142(Int32 id);
            public LanguageDefinition_GetNameAbbreviationDelegate_142 LanguageDefinition_GetNameAbbreviation_142;

            // function Autocomplete_GetCount
            public delegate Int32 Autocomplete_GetCountDelegate_143(SHADERedCLR.Wrapper.ShaderStage stage);
            public Autocomplete_GetCountDelegate_143 Autocomplete_GetCount_143;

            // function Autocomplete_GetDisplayString
            public delegate IntPtr Autocomplete_GetDisplayStringDelegate_144(SHADERedCLR.Wrapper.ShaderStage stage, Int32 index);
            public Autocomplete_GetDisplayStringDelegate_144 Autocomplete_GetDisplayString_144;

            // function Autocomplete_GetSearchString
            public delegate IntPtr Autocomplete_GetSearchStringDelegate_145(SHADERedCLR.Wrapper.ShaderStage stage, Int32 index);
            public Autocomplete_GetSearchStringDelegate_145 Autocomplete_GetSearchString_145;

            // function Autocomplete_GetValue
            public delegate IntPtr Autocomplete_GetValueDelegate_146(SHADERedCLR.Wrapper.ShaderStage stage, Int32 index);
            public Autocomplete_GetValueDelegate_146 Autocomplete_GetValue_146;

            // function ShaderFilePath_GetCount
            public delegate Int32 ShaderFilePath_GetCountDelegate_147();
            public ShaderFilePath_GetCountDelegate_147 ShaderFilePath_GetCount_147;

            // function ShaderFilePath_Get
            public delegate IntPtr ShaderFilePath_GetDelegate_148(Int32 index);
            public ShaderFilePath_GetDelegate_148 ShaderFilePath_Get_148;

            // function ShaderFilePath_HasChanged
            public delegate bool ShaderFilePath_HasChangedDelegate_149();
            public ShaderFilePath_HasChangedDelegate_149 ShaderFilePath_HasChanged_149;

            // function ShaderFilePath_Update
            public delegate void ShaderFilePath_UpdateDelegate_150();
            public ShaderFilePath_UpdateDelegate_150 ShaderFilePath_Update_150;

            // function HandleDropFile
            public delegate bool HandleDropFileDelegate_151(IntPtr filename);
            public HandleDropFileDelegate_151 HandleDropFile_151;

            // function HandleRecompile
            public delegate void HandleRecompileDelegate_152(IntPtr itemName);
            public HandleRecompileDelegate_152 HandleRecompile_152;

            // function HandleRecompileFromSource
            public delegate void HandleRecompileFromSourceDelegate_153(IntPtr itemName, Int32 sid, IntPtr shaderCode, Int32 shaderSize);
            public HandleRecompileFromSourceDelegate_153 HandleRecompileFromSource_153;

            // function HandleShortcut
            public delegate void HandleShortcutDelegate_154(IntPtr name);
            public HandleShortcutDelegate_154 HandleShortcut_154;

            // function HandlePluginMessage
            public delegate void HandlePluginMessageDelegate_155(IntPtr sender, IntPtr msg, Int32 msgLen);
            public HandlePluginMessageDelegate_155 HandlePluginMessage_155;

            // function HandleApplicationEvent
            public delegate void HandleApplicationEventDelegate_156(SHADERedCLR.Wrapper.ApplicationEvent event_, IntPtr data1, IntPtr data2);
            public HandleApplicationEventDelegate_156 HandleApplicationEvent_156;

            // function HandleNotification
            public delegate void HandleNotificationDelegate_157(Int32 id);
            public HandleNotificationDelegate_157 HandleNotification_157;

            // function PipelineItem_SupportsImmediateMode
            public delegate bool PipelineItem_SupportsImmediateModeDelegate_158(IntPtr type, IntPtr data, SHADERedCLR.Wrapper.ShaderStage stage);
            public PipelineItem_SupportsImmediateModeDelegate_158 PipelineItem_SupportsImmediateMode_158;

            // function PipelineItem_HasCustomImmediateModeCompiler
            public delegate bool PipelineItem_HasCustomImmediateModeCompilerDelegate_159(IntPtr type, IntPtr data, SHADERedCLR.Wrapper.ShaderStage stage);
            public PipelineItem_HasCustomImmediateModeCompilerDelegate_159 PipelineItem_HasCustomImmediateModeCompiler_159;

            // function PipelineItem_ImmediateModeCompile
            public delegate bool PipelineItem_ImmediateModeCompileDelegate_160(IntPtr type, IntPtr data, SHADERedCLR.Wrapper.ShaderStage stage, IntPtr expression);
            public PipelineItem_ImmediateModeCompileDelegate_160 PipelineItem_ImmediateModeCompile_160;

            // function ImmediateMode_GetSPIRVSize
            public delegate UInt32 ImmediateMode_GetSPIRVSizeDelegate_161();
            public ImmediateMode_GetSPIRVSizeDelegate_161 ImmediateMode_GetSPIRVSize_161;

            // function ImmediateMode_GetSPIRV
            public delegate IntPtr ImmediateMode_GetSPIRVDelegate_162();
            public ImmediateMode_GetSPIRVDelegate_162 ImmediateMode_GetSPIRV_162;

            // function ImmediateMode_GetVariableCount
            public delegate UInt32 ImmediateMode_GetVariableCountDelegate_163();
            public ImmediateMode_GetVariableCountDelegate_163 ImmediateMode_GetVariableCount_163;

            // function ImmediateMode_GetVariableName
            public delegate IntPtr ImmediateMode_GetVariableNameDelegate_164(UInt32 index);
            public ImmediateMode_GetVariableNameDelegate_164 ImmediateMode_GetVariableName_164;

            // function ImmediateMode_GetResultID
            public delegate Int32 ImmediateMode_GetResultIDDelegate_165();
            public ImmediateMode_GetResultIDDelegate_165 ImmediateMode_GetResultID_165;

            // function PluginManager_RegisterPlugins
            public delegate void PluginManager_RegisterPluginsDelegate_166();
            public PluginManager_RegisterPluginsDelegate_166 PluginManager_RegisterPlugins_166;

            // function CustomLanguage_CompileToSPIRV2
            public delegate IntPtr CustomLanguage_CompileToSPIRV2Delegate_167(IntPtr item, Int32 langID, IntPtr src, UInt64 src_len, SHADERedCLR.Wrapper.ShaderStage stage, IntPtr entry, IntPtr macros, UInt64 macroCount, IntPtr spv_length, IntPtr compiled);
            public CustomLanguage_CompileToSPIRV2Delegate_167 CustomLanguage_CompileToSPIRV2_167;

            // function ShaderEditor_SetLineIndicator
            public delegate void ShaderEditor_SetLineIndicatorDelegate_168(Int32 langID, Int32 editorID, Int32 line);
            public ShaderEditor_SetLineIndicatorDelegate_168 ShaderEditor_SetLineIndicator_168;


        }








        public Delegates.AddObjectDelegate AddObject { get; protected set; }

        public Delegates.AddCustomPipelineItemDelegate AddCustomPipelineItem { get; protected set; }

        public Delegates.AddMessageDelegate AddMessage { get; protected set; }

        public Delegates.CreateRenderTextureDelegate CreateRenderTexture { get; protected set; }

        public Delegates.CreateImageDelegate CreateImage { get; protected set; }

        public Delegates.ResizeRenderTextureDelegate ResizeRenderTexture { get; protected set; }

        public Delegates.ResizeImageDelegate ResizeImage { get; protected set; }

        public Delegates.ExistsObjectDelegate ExistsObject { get; protected set; }

        public Delegates.RemoveGlobalObjectDelegate RemoveGlobalObject { get; protected set; }

        public Delegates.GetProjectPathDelegate GetProjectPath { get; protected set; }

        public Delegates.GetRelativePathDelegate GetRelativePath { get; protected set; }

        public Delegates.GetProjectFilenameDelegate GetProjectFilename { get; protected set; }

        public Delegates.GetProjectDirectoryDelegate GetProjectDirectory { get; protected set; }

        public Delegates.IsProjectModifiedDelegate IsProjectModified { get; protected set; }

        public Delegates.ModifyProjectDelegate ModifyProject { get; protected set; }

        public Delegates.OpenProjectDelegate OpenProject { get; protected set; }

        public Delegates.SaveProjectDelegate SaveProject { get; protected set; }

        public Delegates.SaveAsProjectDelegate SaveAsProject { get; protected set; }

        public Delegates.IsPausedDelegate IsPaused { get; protected set; }

        public Delegates.PauseDelegate Pause { get; protected set; }

        public Delegates.GetWindowColorTextureDelegate GetWindowColorTexture { get; protected set; }

        public Delegates.GetWindowDepthTextureDelegate GetWindowDepthTexture { get; protected set; }

        public Delegates.GetLastRenderSizeDelegate GetLastRenderSize { get; protected set; }

        public Delegates.RenderDelegate Render { get; protected set; }

        public Delegates.ExistsPipelineItemDelegate ExistsPipelineItem { get; protected set; }

        public Delegates.GetPipelineItemDelegate GetPipelineItem { get; protected set; }

        public Delegates.BindShaderPassVariablesDelegate BindShaderPassVariables { get; protected set; }

        public Delegates.GetViewMatrixDelegate GetViewMatrix { get; protected set; }

        public Delegates.GetProjectionMatrixDelegate GetProjectionMatrix { get; protected set; }

        public Delegates.GetOrthographicMatrixDelegate GetOrthographicMatrix { get; protected set; }

        public Delegates.GetViewportSizeDelegate GetViewportSize { get; protected set; }

        public Delegates.AdvanceTimerDelegate AdvanceTimer { get; protected set; }

        public Delegates.GetMousePositionDelegate GetMousePosition { get; protected set; }

        public Delegates.GetFrameIndexDelegate GetFrameIndex { get; protected set; }

        public Delegates.GetTimeDelegate GetTime { get; protected set; }

        public Delegates.SetTimeDelegate SetTime { get; protected set; }

        public Delegates.SetGeometryTransformDelegate SetGeometryTransform { get; protected set; }

        public Delegates.SetMousePositionDelegate SetMousePosition { get; protected set; }

        public Delegates.SetKeysWASDDelegate SetKeysWASD { get; protected set; }

        public Delegates.SetFrameIndexDelegate SetFrameIndex { get; protected set; }

        public Delegates.GetDPIDelegate GetDPI { get; protected set; }

        public Delegates.FileExistsDelegate FileExists { get; protected set; }

        public Delegates.ClearMessageGroupDelegate ClearMessageGroup { get; protected set; }

        public Delegates.LogDelegate Log { get; protected set; }

        public Delegates.GetObjectCountDelegate GetObjectCount { get; protected set; }

        public Delegates.GetObjectNameDelegate GetObjectName { get; protected set; }

        public Delegates.IsTextureDelegate IsTexture { get; protected set; }

        public Delegates.GetTextureDelegate GetTexture { get; protected set; }

        public Delegates.GetFlippedTextureDelegate GetFlippedTexture { get; protected set; }

        public Delegates.GetTextureSizeDelegate GetTextureSize { get; protected set; }

        public Delegates.BindDefaultStateDelegate BindDefaultState { get; protected set; }

        public Delegates.OpenInCodeEditorDelegate OpenInCodeEditor { get; protected set; }

        public Delegates.GetPipelineItemCountDelegate GetPipelineItemCount { get; protected set; }

        public Delegates.GetPipelineItemTypeDelegate GetPipelineItemType { get; protected set; }

        public Delegates.GetPipelineItemByIndexDelegate GetPipelineItemByIndex { get; protected set; }

        public Delegates.GetPipelineItemNameDelegate GetPipelineItemName { get; protected set; }

        public Delegates.GetPipelineItemPluginOwnerDelegate GetPipelineItemPluginOwner { get; protected set; }

        public Delegates.GetPipelineItemVariableCountDelegate GetPipelineItemVariableCount { get; protected set; }

        public Delegates.GetPipelineItemVariableNameDelegate GetPipelineItemVariableName { get; protected set; }

        public Delegates.GetPipelineItemVariableValueDelegate GetPipelineItemVariableValue { get; protected set; }

        public Delegates.GetPipelineItemVariableTypeDelegate GetPipelineItemVariableType { get; protected set; }

        public Delegates.AddPipelineItemVariableDelegate AddPipelineItemVariable { get; protected set; }

        public Delegates.GetPipelineItemChildrenCountDelegate GetPipelineItemChildrenCount { get; protected set; }

        public Delegates.GetPipelineItemChildDelegate GetPipelineItemChild { get; protected set; }

        public Delegates.SetPipelineItemPositionDelegate SetPipelineItemPosition { get; protected set; }

        public Delegates.SetPipelineItemRotationDelegate SetPipelineItemRotation { get; protected set; }

        public Delegates.SetPipelineItemScaleDelegate SetPipelineItemScale { get; protected set; }

        public Delegates.GetPipelineItemPositionDelegate GetPipelineItemPosition { get; protected set; }

        public Delegates.GetPipelineItemRotationDelegate GetPipelineItemRotation { get; protected set; }

        public Delegates.GetPipelineItemScaleDelegate GetPipelineItemScale { get; protected set; }

        public Delegates.DEPRECATED_GetOpenDirectoryDialogDelegate DEPRECATED_GetOpenDirectoryDialog { get; protected set; }

        public Delegates.DEPRECATED_GetOpenFileDialogDelegate DEPRECATED_GetOpenFileDialog { get; protected set; }

        public Delegates.DEPRECATED_GetSaveFileDialogDelegate DEPRECATED_GetSaveFileDialog { get; protected set; }

        public Delegates.GetIncludePathCountDelegate GetIncludePathCount { get; protected set; }

        public Delegates.GetIncludePathDelegate GetIncludePath { get; protected set; }

        public Delegates.GetMessagesCurrentItemDelegate GetMessagesCurrentItem { get; protected set; }

        public Delegates.OnEditorContentChangeDelegate OnEditorContentChange { get; protected set; }

        public Delegates.GetPipelineItemSPIRVDelegate GetPipelineItemSPIRV { get; protected set; }

        public Delegates.RegisterShortcutDelegate RegisterShortcut { get; protected set; }

        public Delegates.GetSettingsBooleanDelegate GetSettingsBoolean { get; protected set; }

        public Delegates.GetSettingsStringDelegate GetSettingsString { get; protected set; }

        public Delegates.GetSettingsIntegerDelegate GetSettingsInteger { get; protected set; }

        public Delegates.GetSettingsFloatDelegate GetSettingsFloat { get; protected set; }

        public Delegates.GetPreviewUIRectDelegate GetPreviewUIRect { get; protected set; }

        public Delegates.GetPluginDelegate GetPlugin { get; protected set; }

        public Delegates.GetPluginListSizeDelegate GetPluginListSize { get; protected set; }

        public Delegates.GetPluginNameDelegate GetPluginName { get; protected set; }

        public Delegates.SendPluginMessageDelegate SendPluginMessage { get; protected set; }

        public Delegates.BroadcastPluginMessageDelegate BroadcastPluginMessage { get; protected set; }

        public Delegates.ToggleFullscreenDelegate ToggleFullscreen { get; protected set; }

        public Delegates.IsFullscreenDelegate IsFullscreen { get; protected set; }

        public Delegates.TogglePerformanceModeDelegate TogglePerformanceMode { get; protected set; }

        public Delegates.IsInPerformanceModeDelegate IsInPerformanceMode { get; protected set; }

        public Delegates.PushNotificationDelegate PushNotification { get; protected set; }

        public Delegates.DebuggerJumpDelegate DebuggerJump { get; protected set; }

        public Delegates.DebuggerContinueDelegate DebuggerContinue { get; protected set; }

        public Delegates.DebuggerStepDelegate DebuggerStep { get; protected set; }

        public Delegates.DebuggerStepIntoDelegate DebuggerStepInto { get; protected set; }

        public Delegates.DebuggerStepOutDelegate DebuggerStepOut { get; protected set; }

        public Delegates.DebuggerCheckBreakpointDelegate DebuggerCheckBreakpoint { get; protected set; }

        public Delegates.DebuggerIsDebuggingDelegate DebuggerIsDebugging { get; protected set; }

        public Delegates.DebuggerGetCurrentLineDelegate DebuggerGetCurrentLine { get; protected set; }

        public Delegates.IsRenderTextureDelegate IsRenderTexture { get; protected set; }

        public Delegates.GetRenderTextureSizeDelegate GetRenderTextureSize { get; protected set; }

        public Delegates.GetDepthTextureDelegate GetDepthTexture { get; protected set; }

        public Delegates.ScaleSizeDelegate ScaleSize { get; protected set; }

        public Delegates.GetHostIPluginMaxVersionDelegate GetHostIPluginMaxVersion { get; protected set; }

        public Delegates.ImGuiFileDialogOpenDelegate ImGuiFileDialogOpen { get; protected set; }

        public Delegates.ImGuiDirectoryDialogOpenDelegate ImGuiDirectoryDialogOpen { get; protected set; }

        public Delegates.ImGuiFileDialogIsDoneDelegate ImGuiFileDialogIsDone { get; protected set; }

        public Delegates.ImGuiFileDialogCloseDelegate ImGuiFileDialogClose { get; protected set; }

        public Delegates.ImGuiFileDialogGetResultDelegate ImGuiFileDialogGetResult { get; protected set; }

        public Delegates.ImGuiFileDialogGetPathDelegate ImGuiFileDialogGetPath { get; protected set; }

        public Delegates.DebuggerImmediateDelegate DebuggerImmediate { get; protected set; }

        public Delegates.RegisterPluginDelegate RegisterPlugin { get; protected set; }

        public Delegates.GetEditorPipelineItemDelegate GetEditorPipelineItem { get; protected set; }

        public Delegates.SetViewportSizeDelegate SetViewportSize { get; protected set; }

        public Delegates.IsObjectBoundDelegate IsObjectBound { get; protected set; }

        public Delegates.DebuggerStepIntoPluginEditorDelegate DebuggerStepIntoPluginEditor { get; protected set; }

        public Delegates.DebuggerGetVariableValueDelegate DebuggerGetVariableValue { get; protected set; }

        public Delegates.DebuggerStopPluginEditorDelegate DebuggerStopPluginEditor { get; protected set; }

        public Delegates.DebuggerIsVMRunningDelegate DebuggerIsVMRunning { get; protected set; }

        // function Init
        public virtual bool Init(bool isWeb, Int32 sedVersion) {
            return false;
        }

        // function InitUI
        public virtual void InitUI(IntPtr ctx) {
        }

        // function OnEvent
        public virtual void OnEvent(IntPtr e) {
        }

        // function Update
        public virtual void Update(float delta) {
        }

        // function Destroy
        public virtual void Destroy() {
        }

        // function IsRequired
        public virtual bool IsRequired() {
            return false;
        }

        // function IsVersionCompatible
        public virtual bool IsVersionCompatible(Int32 version) {
            return false;
        }

        // function BeginRender
        public virtual void BeginRender() {
        }

        // function EndRender
        public virtual void EndRender() {
        }

        // function Project_BeginLoad
        public virtual void Project_BeginLoad() {
        }

        // function Project_EndLoad
        public virtual void Project_EndLoad() {
        }

        // function Project_BeginSave
        public virtual void Project_BeginSave() {
        }

        // function Project_EndSave
        public virtual void Project_EndSave() {
        }

        // function Project_HasAdditionalData
        public virtual bool Project_HasAdditionalData() {
            return false;
        }

        // function Project_ExportAdditionalData
        public virtual IntPtr Project_ExportAdditionalData() {
            return IntPtr.Zero;
        }

        // function Project_ImportAdditionalData
        public virtual void Project_ImportAdditionalData(IntPtr xml) {
        }

        // function Project_CopyFilesOnSave
        public virtual void Project_CopyFilesOnSave(IntPtr dir) {
        }

        // function HasCustomMenuItem
        public virtual bool HasCustomMenuItem() {
            return false;
        }

        // function HasMenuItems
        public virtual bool HasMenuItems(IntPtr name) {
            return false;
        }

        // function ShowMenuItems
        public virtual void ShowMenuItems(IntPtr name) {
        }

        // function HasContextItems
        public virtual bool HasContextItems(IntPtr name) {
            return false;
        }

        // function ShowContextItems
        public virtual void ShowContextItems(IntPtr name, IntPtr owner, IntPtr extraData) {
        }

        // function SystemVariables_GetNameCount
        public virtual Int32 SystemVariables_GetNameCount(SHADERedCLR.Wrapper.VariableType varType) {
            return 0;
        }

        // function SystemVariables_GetName
        public virtual IntPtr SystemVariables_GetName(SHADERedCLR.Wrapper.VariableType varType, Int32 index) {
            return IntPtr.Zero;
        }

        // function SystemVariables_HasLastFrame
        public virtual bool SystemVariables_HasLastFrame(IntPtr name, SHADERedCLR.Wrapper.VariableType varType) {
            return false;
        }

        // function SystemVariables_UpdateValue
        public virtual void SystemVariables_UpdateValue(IntPtr data, IntPtr name, SHADERedCLR.Wrapper.VariableType varType, bool isLastFrame) {
        }

        // function VariableFunctions_GetNameCount
        public virtual Int32 VariableFunctions_GetNameCount(SHADERedCLR.Wrapper.VariableType vtype) {
            return 0;
        }

        // function VariableFunctions_GetName
        public virtual IntPtr VariableFunctions_GetName(SHADERedCLR.Wrapper.VariableType varType, Int32 index) {
            return IntPtr.Zero;
        }

        // function VariableFunctions_ShowArgumentEdit
        public virtual bool VariableFunctions_ShowArgumentEdit(IntPtr fname, IntPtr args, SHADERedCLR.Wrapper.VariableType vtype) {
            return false;
        }

        // function VariableFunctions_UpdateValue
        public virtual void VariableFunctions_UpdateValue(IntPtr data, IntPtr args, IntPtr fname, SHADERedCLR.Wrapper.VariableType varType) {
        }

        // function VariableFunctions_GetArgsSize
        public virtual Int32 VariableFunctions_GetArgsSize(IntPtr fname, SHADERedCLR.Wrapper.VariableType varType) {
            return 0;
        }

        // function VariableFunctions_InitArguments
        public virtual void VariableFunctions_InitArguments(IntPtr args, IntPtr fname, SHADERedCLR.Wrapper.VariableType vtype) {
        }

        // function VariableFunctions_ExportArguments
        public virtual IntPtr VariableFunctions_ExportArguments(IntPtr fname, SHADERedCLR.Wrapper.VariableType vtype, IntPtr args) {
            return IntPtr.Zero;
        }

        // function VariableFunctions_ImportArguments
        public virtual void VariableFunctions_ImportArguments(IntPtr fname, SHADERedCLR.Wrapper.VariableType vtype, IntPtr args, IntPtr argsString) {
        }

        // function Object_HasPreview
        public virtual bool Object_HasPreview(IntPtr type) {
            return false;
        }

        // function Object_ShowPreview
        public virtual void Object_ShowPreview(IntPtr type, IntPtr data, UInt32 id) {
        }

        // function Object_IsBindable
        public virtual bool Object_IsBindable(IntPtr type) {
            return false;
        }

        // function Object_IsBindableUAV
        public virtual bool Object_IsBindableUAV(IntPtr type) {
            return false;
        }

        // function Object_Remove
        public virtual void Object_Remove(IntPtr name, IntPtr type, IntPtr data, UInt32 id) {
        }

        // function Object_HasExtendedPreview
        public virtual bool Object_HasExtendedPreview(IntPtr type) {
            return false;
        }

        // function Object_ShowExtendedPreview
        public virtual void Object_ShowExtendedPreview(IntPtr type, IntPtr data, UInt32 id) {
        }

        // function Object_HasProperties
        public virtual bool Object_HasProperties(IntPtr type) {
            return false;
        }

        // function Object_ShowProperties
        public virtual void Object_ShowProperties(IntPtr type, IntPtr data, UInt32 id) {
        }

        // function Object_Bind
        public virtual void Object_Bind(IntPtr type, IntPtr data, UInt32 id) {
        }

        // function Object_Export
        public virtual IntPtr Object_Export(IntPtr type, IntPtr data, UInt32 id) {
            return IntPtr.Zero;
        }

        // function Object_Import
        public virtual void Object_Import(IntPtr name, IntPtr type, IntPtr argsString) {
        }

        // function Object_HasContext
        public virtual bool Object_HasContext(IntPtr type) {
            return false;
        }

        // function Object_ShowContext
        public virtual void Object_ShowContext(IntPtr type, IntPtr data) {
        }

        // function PipelineItem_HasProperties
        public virtual bool PipelineItem_HasProperties(IntPtr type, IntPtr data) {
            return false;
        }

        // function PipelineItem_ShowProperties
        public virtual void PipelineItem_ShowProperties(IntPtr type, IntPtr data) {
        }

        // function PipelineItem_IsPickable
        public virtual bool PipelineItem_IsPickable(IntPtr type, IntPtr data) {
            return false;
        }

        // function PipelineItem_HasShaders
        public virtual bool PipelineItem_HasShaders(IntPtr type, IntPtr data) {
            return false;
        }

        // function PipelineItem_OpenInEditor
        public virtual void PipelineItem_OpenInEditor(IntPtr type, IntPtr data) {
        }

        // function PipelineItem_CanHaveChild
        public virtual bool PipelineItem_CanHaveChild(IntPtr type, IntPtr data, SHADERedCLR.Wrapper.PipelineItemType itemType) {
            return false;
        }

        // function PipelineItem_GetInputLayoutSize
        public virtual Int32 PipelineItem_GetInputLayoutSize(IntPtr type, IntPtr data) {
            return 0;
        }

        // function PipelineItem_GetInputLayoutItem
        public virtual void PipelineItem_GetInputLayoutItem(IntPtr type, IntPtr data, Int32 index, InputLayoutItem out_) {
        }

        // function PipelineItem_Remove
        public virtual void PipelineItem_Remove(IntPtr itemName, IntPtr type, IntPtr data) {
        }

        // function PipelineItem_Rename
        public virtual void PipelineItem_Rename(IntPtr oldName, IntPtr newName) {
        }

        // function PipelineItem_AddChild
        public virtual void PipelineItem_AddChild(IntPtr owner, IntPtr name, SHADERedCLR.Wrapper.PipelineItemType type, IntPtr data) {
        }

        // function PipelineItem_CanHaveChildren
        public virtual bool PipelineItem_CanHaveChildren(IntPtr type, IntPtr data) {
            return false;
        }

        // function PipelineItem_CopyData
        public virtual IntPtr PipelineItem_CopyData(IntPtr type, IntPtr data) {
            return IntPtr.Zero;
        }

        // function PipelineItem_Execute
        public virtual void PipelineItem_Execute(IntPtr Owner, SHADERedCLR.Wrapper.PipelineItemType OwnerType, IntPtr type, IntPtr data) {
        }

        // function PipelineItem_Execute
        public virtual void PipelineItem_Execute(IntPtr type, IntPtr data, IntPtr children, Int32 count) {
        }

        // function PipelineItem_GetWorldMatrix
        public virtual void PipelineItem_GetWorldMatrix(IntPtr type, IntPtr data, ArrPointer16<float> pMat) {
        }

        // function PipelineItem_Intersect
        public virtual bool PipelineItem_Intersect(IntPtr type, IntPtr data, IntPtr rayOrigin, IntPtr rayDir, float hitDist) {
            return false;
        }

        // function PipelineItem_GetBoundingBox
        public virtual void PipelineItem_GetBoundingBox(IntPtr type, IntPtr data, ArrPointer3<float> minPos, ArrPointer3<float> maxPos) {
        }

        // function PipelineItem_HasContext
        public virtual bool PipelineItem_HasContext(IntPtr type, IntPtr data) {
            return false;
        }

        // function PipelineItem_ShowContext
        public virtual void PipelineItem_ShowContext(IntPtr type, IntPtr data) {
        }

        // function PipelineItem_Export
        public virtual IntPtr PipelineItem_Export(IntPtr type, IntPtr data) {
            return IntPtr.Zero;
        }

        // function PipelineItem_Import
        public virtual IntPtr PipelineItem_Import(IntPtr ownerName, IntPtr name, IntPtr type, IntPtr argsString) {
            return IntPtr.Zero;
        }

        // function PipelineItem_MoveDown
        public virtual void PipelineItem_MoveDown(IntPtr ownerData, IntPtr ownerType, IntPtr itemName) {
        }

        // function PipelineItem_MoveUp
        public virtual void PipelineItem_MoveUp(IntPtr ownerData, IntPtr ownerType, IntPtr itemName) {
        }

        // function PipelineItem_ApplyGizmoTransform
        public virtual void PipelineItem_ApplyGizmoTransform(IntPtr type, IntPtr data, IntPtr transl, IntPtr scale, IntPtr rota) {
        }

        // function PipelineItem_GetTransform
        public virtual void PipelineItem_GetTransform(IntPtr type, IntPtr data, IntPtr transl, IntPtr scale, IntPtr rota) {
        }

        // function PipelineItem_DebugVertexExecute
        public virtual void PipelineItem_DebugVertexExecute(IntPtr Owner, SHADERedCLR.Wrapper.PipelineItemType OwnerType, IntPtr type, IntPtr data, UInt32 colorVarLoc) {
        }

        // function PipelineItem_DebugVertexExecute
        public virtual Int32 PipelineItem_DebugVertexExecute(IntPtr type, IntPtr data, IntPtr childName, float rx, float ry, Int32 vertexGroup) {
            return 0;
        }

        // function PipelineItem_DebugInstanceExecute
        public virtual void PipelineItem_DebugInstanceExecute(IntPtr Owner, SHADERedCLR.Wrapper.PipelineItemType OwnerType, IntPtr type, IntPtr data, UInt32 colorVarLoc) {
        }

        // function PipelineItem_DebugInstanceExecute
        public virtual Int32 PipelineItem_DebugInstanceExecute(IntPtr type, IntPtr data, IntPtr childName, float rx, float ry, Int32 vertexGroup) {
            return 0;
        }

        // function PipelineItem_GetVBO
        public virtual UInt32 PipelineItem_GetVBO(IntPtr type, IntPtr data) {
            return 0;
        }

        // function PipelineItem_GetVBOStride
        public virtual UInt32 PipelineItem_GetVBOStride(IntPtr type, IntPtr data) {
            return 0;
        }

        // function PipelineItem_CanChangeVariables
        public virtual bool PipelineItem_CanChangeVariables(IntPtr type, IntPtr data) {
            return false;
        }

        // function PipelineItem_IsDebuggable
        public virtual bool PipelineItem_IsDebuggable(IntPtr type, IntPtr data) {
            return false;
        }

        // function PipelineItem_IsStageDebuggable
        public virtual bool PipelineItem_IsStageDebuggable(IntPtr type, IntPtr data, SHADERedCLR.Wrapper.ShaderStage stage) {
            return false;
        }

        // function PipelineItem_DebugExecute
        public virtual void PipelineItem_DebugExecute(IntPtr type, IntPtr data, IntPtr children, Int32 count, IntPtr debugID) {
        }

        // function PipelineItem_GetTopology
        public virtual UInt32 PipelineItem_GetTopology(IntPtr type, IntPtr data) {
            return 0;
        }

        // function PipelineItem_GetVariableCount
        public virtual UInt32 PipelineItem_GetVariableCount(IntPtr type, IntPtr data) {
            return 0;
        }

        // function PipelineItem_GetVariableName
        public virtual IntPtr PipelineItem_GetVariableName(IntPtr type, IntPtr data, UInt32 variable) {
            return IntPtr.Zero;
        }

        // function PipelineItem_GetVariableType
        public virtual SHADERedCLR.Wrapper.VariableType PipelineItem_GetVariableType(IntPtr type, IntPtr data, UInt32 variable) {
            return (SHADERedCLR.Wrapper.VariableType)0;
        }

        // function PipelineItem_GetVariableValueFloat
        public virtual float PipelineItem_GetVariableValueFloat(IntPtr type, IntPtr data, UInt32 variable, Int32 col, Int32 row) {
            return 0;
        }

        // function PipelineItem_GetVariableValueInteger
        public virtual Int32 PipelineItem_GetVariableValueInteger(IntPtr type, IntPtr data, UInt32 variable, Int32 col) {
            return 0;
        }

        // function PipelineItem_GetVariableValueBoolean
        public virtual bool PipelineItem_GetVariableValueBoolean(IntPtr type, IntPtr data, UInt32 variable, Int32 col) {
            return false;
        }

        // function PipelineItem_GetSPIRVSize
        public virtual UInt32 PipelineItem_GetSPIRVSize(IntPtr type, IntPtr data, SHADERedCLR.Wrapper.ShaderStage stage) {
            return 0;
        }

        // function PipelineItem_GetSPIRV
        public virtual IntPtr PipelineItem_GetSPIRV(IntPtr type, IntPtr data, SHADERedCLR.Wrapper.ShaderStage stage) {
            return IntPtr.Zero;
        }

        // function PipelineItem_DebugPrepareVariables
        public virtual void PipelineItem_DebugPrepareVariables(IntPtr type, IntPtr data, IntPtr name) {
        }

        // function PipelineItem_DebugUsesCustomTextures
        public virtual bool PipelineItem_DebugUsesCustomTextures(IntPtr type, IntPtr data) {
            return false;
        }

        // function PipelineItem_DebugGetTexture
        public virtual UInt32 PipelineItem_DebugGetTexture(IntPtr type, IntPtr data, Int32 loc, IntPtr variableName) {
            return 0;
        }

        // function PipelineItem_DebugGetTextureSize
        public virtual void PipelineItem_DebugGetTextureSize(IntPtr type, IntPtr data, Int32 loc, IntPtr variableName, Int32 x, Int32 y, Int32 z) {
        }

        // function Options_HasSection
        public virtual bool Options_HasSection() {
            return false;
        }

        // function Options_RenderSection
        public virtual void Options_RenderSection() {
        }

        // function Options_Parse
        public virtual void Options_Parse(IntPtr key, IntPtr val) {
        }

        // function Options_GetCount
        public virtual Int32 Options_GetCount() {
            return 0;
        }

        // function Options_GetKey
        public virtual IntPtr Options_GetKey(Int32 index) {
            return IntPtr.Zero;
        }

        // function Options_GetValue
        public virtual IntPtr Options_GetValue(Int32 index) {
            return IntPtr.Zero;
        }

        // function CustomLanguage_GetCount
        public virtual Int32 CustomLanguage_GetCount() {
            return 0;
        }

        // function CustomLanguage_GetName
        public virtual IntPtr CustomLanguage_GetName(Int32 langID) {
            return IntPtr.Zero;
        }

        // function CustomLanguage_CompileToSPIRV
        public virtual IntPtr CustomLanguage_CompileToSPIRV(Int32 langID, IntPtr src, UInt64 src_len, SHADERedCLR.Wrapper.ShaderStage stage, IntPtr entry, IntPtr macros, UInt64 macroCount, IntPtr spv_length, IntPtr compiled) {
            return IntPtr.Zero;
        }

        // function CustomLanguage_ProcessGeneratedGLSL
        public virtual IntPtr CustomLanguage_ProcessGeneratedGLSL(Int32 langID, IntPtr src) {
            return IntPtr.Zero;
        }

        // function CustomLanguage_SupportsAutoUniforms
        public virtual bool CustomLanguage_SupportsAutoUniforms(Int32 langID) {
            return false;
        }

        // function CustomLanguage_IsDebuggable
        public virtual bool CustomLanguage_IsDebuggable(Int32 langID) {
            return false;
        }

        // function CustomLanguage_GetDefaultExtension
        public virtual IntPtr CustomLanguage_GetDefaultExtension(Int32 langID) {
            return IntPtr.Zero;
        }

        // function ShaderEditor_Supports
        public virtual bool ShaderEditor_Supports(Int32 langID) {
            return false;
        }

        // function ShaderEditor_Open
        public virtual void ShaderEditor_Open(Int32 langID, Int32 editorID, IntPtr data, Int32 dataLen) {
        }

        // function ShaderEditor_Render
        public virtual void ShaderEditor_Render(Int32 langID, Int32 editorID) {
        }

        // function ShaderEditor_Close
        public virtual void ShaderEditor_Close(Int32 langID, Int32 editorID) {
        }

        // function ShaderEditor_GetContent
        public virtual IntPtr ShaderEditor_GetContent(Int32 langID, Int32 editorID, IntPtr dataLength) {
            return IntPtr.Zero;
        }

        // function ShaderEditor_IsChanged
        public virtual bool ShaderEditor_IsChanged(Int32 langID, Int32 editorID) {
            return false;
        }

        // function ShaderEditor_ResetChangeState
        public virtual void ShaderEditor_ResetChangeState(Int32 langID, Int32 editorID) {
        }

        // function ShaderEditor_CanUndo
        public virtual bool ShaderEditor_CanUndo(Int32 langID, Int32 editorID) {
            return false;
        }

        // function ShaderEditor_CanRedo
        public virtual bool ShaderEditor_CanRedo(Int32 langID, Int32 editorID) {
            return false;
        }

        // function ShaderEditor_Undo
        public virtual void ShaderEditor_Undo(Int32 langID, Int32 editorID) {
        }

        // function ShaderEditor_Redo
        public virtual void ShaderEditor_Redo(Int32 langID, Int32 editorID) {
        }

        // function ShaderEditor_Cut
        public virtual void ShaderEditor_Cut(Int32 langID, Int32 editorID) {
        }

        // function ShaderEditor_Paste
        public virtual void ShaderEditor_Paste(Int32 langID, Int32 editorID) {
        }

        // function ShaderEditor_Copy
        public virtual void ShaderEditor_Copy(Int32 langID, Int32 editorID) {
        }

        // function ShaderEditor_SelectAll
        public virtual void ShaderEditor_SelectAll(Int32 langID, Int32 editorID) {
        }

        // function ShaderEditor_HasStats
        public virtual bool ShaderEditor_HasStats(Int32 langID, Int32 editorID) {
            return false;
        }

        // function CodeEditor_SaveItem
        public virtual void CodeEditor_SaveItem(IntPtr src, Int32 srcLen, IntPtr path) {
        }

        // function CodeEditor_CloseItem
        public virtual void CodeEditor_CloseItem(IntPtr path) {
        }

        // function LanguageDefinition_Exists
        public virtual bool LanguageDefinition_Exists(Int32 id) {
            return false;
        }

        // function LanguageDefinition_GetKeywordCount
        public virtual Int32 LanguageDefinition_GetKeywordCount(Int32 id) {
            return 0;
        }

        // function LanguageDefinition_GetKeywords
        public virtual IntPtr LanguageDefinition_GetKeywords(Int32 id) {
            return IntPtr.Zero;
        }

        // function LanguageDefinition_GetTokenRegexCount
        public virtual Int32 LanguageDefinition_GetTokenRegexCount(Int32 id) {
            return 0;
        }

        // function LanguageDefinition_GetTokenRegex
        public virtual IntPtr LanguageDefinition_GetTokenRegex(Int32 index, SHADERedCLR.Wrapper.TextEditorPaletteIndex palIndex, Int32 id) {
            return IntPtr.Zero;
        }

        // function LanguageDefinition_GetIdentifierCount
        public virtual Int32 LanguageDefinition_GetIdentifierCount(Int32 id) {
            return 0;
        }

        // function LanguageDefinition_GetIdentifier
        public virtual IntPtr LanguageDefinition_GetIdentifier(Int32 index, Int32 id) {
            return IntPtr.Zero;
        }

        // function LanguageDefinition_GetIdentifierDesc
        public virtual IntPtr LanguageDefinition_GetIdentifierDesc(Int32 index, Int32 id) {
            return IntPtr.Zero;
        }

        // function LanguageDefinition_GetCommentStart
        public virtual IntPtr LanguageDefinition_GetCommentStart(Int32 id) {
            return IntPtr.Zero;
        }

        // function LanguageDefinition_GetCommentEnd
        public virtual IntPtr LanguageDefinition_GetCommentEnd(Int32 id) {
            return IntPtr.Zero;
        }

        // function LanguageDefinition_GetLineComment
        public virtual IntPtr LanguageDefinition_GetLineComment(Int32 id) {
            return IntPtr.Zero;
        }

        // function LanguageDefinition_IsCaseSensitive
        public virtual bool LanguageDefinition_IsCaseSensitive(Int32 id) {
            return false;
        }

        // function LanguageDefinition_GetAutoIndent
        public virtual bool LanguageDefinition_GetAutoIndent(Int32 id) {
            return false;
        }

        // function LanguageDefinition_GetName
        public virtual IntPtr LanguageDefinition_GetName(Int32 id) {
            return IntPtr.Zero;
        }

        // function LanguageDefinition_GetNameAbbreviation
        public virtual IntPtr LanguageDefinition_GetNameAbbreviation(Int32 id) {
            return IntPtr.Zero;
        }

        // function Autocomplete_GetCount
        public virtual Int32 Autocomplete_GetCount(SHADERedCLR.Wrapper.ShaderStage stage) {
            return 0;
        }

        // function Autocomplete_GetDisplayString
        public virtual IntPtr Autocomplete_GetDisplayString(SHADERedCLR.Wrapper.ShaderStage stage, Int32 index) {
            return IntPtr.Zero;
        }

        // function Autocomplete_GetSearchString
        public virtual IntPtr Autocomplete_GetSearchString(SHADERedCLR.Wrapper.ShaderStage stage, Int32 index) {
            return IntPtr.Zero;
        }

        // function Autocomplete_GetValue
        public virtual IntPtr Autocomplete_GetValue(SHADERedCLR.Wrapper.ShaderStage stage, Int32 index) {
            return IntPtr.Zero;
        }

        // function ShaderFilePath_GetCount
        public virtual Int32 ShaderFilePath_GetCount() {
            return 0;
        }

        // function ShaderFilePath_Get
        public virtual IntPtr ShaderFilePath_Get(Int32 index) {
            return IntPtr.Zero;
        }

        // function ShaderFilePath_HasChanged
        public virtual bool ShaderFilePath_HasChanged() {
            return false;
        }

        // function ShaderFilePath_Update
        public virtual void ShaderFilePath_Update() {
        }

        // function HandleDropFile
        public virtual bool HandleDropFile(IntPtr filename) {
            return false;
        }

        // function HandleRecompile
        public virtual void HandleRecompile(IntPtr itemName) {
        }

        // function HandleRecompileFromSource
        public virtual void HandleRecompileFromSource(IntPtr itemName, Int32 sid, IntPtr shaderCode, Int32 shaderSize) {
        }

        // function HandleShortcut
        public virtual void HandleShortcut(IntPtr name) {
        }

        // function HandlePluginMessage
        public virtual void HandlePluginMessage(IntPtr sender, IntPtr msg, Int32 msgLen) {
        }

        // function HandleApplicationEvent
        public virtual void HandleApplicationEvent(SHADERedCLR.Wrapper.ApplicationEvent event_, IntPtr data1, IntPtr data2) {
        }

        // function HandleNotification
        public virtual void HandleNotification(Int32 id) {
        }

        // function PipelineItem_SupportsImmediateMode
        public virtual bool PipelineItem_SupportsImmediateMode(IntPtr type, IntPtr data, SHADERedCLR.Wrapper.ShaderStage stage) {
            return false;
        }

        // function PipelineItem_HasCustomImmediateModeCompiler
        public virtual bool PipelineItem_HasCustomImmediateModeCompiler(IntPtr type, IntPtr data, SHADERedCLR.Wrapper.ShaderStage stage) {
            return false;
        }

        // function PipelineItem_ImmediateModeCompile
        public virtual bool PipelineItem_ImmediateModeCompile(IntPtr type, IntPtr data, SHADERedCLR.Wrapper.ShaderStage stage, IntPtr expression) {
            return false;
        }

        // function ImmediateMode_GetSPIRVSize
        public virtual UInt32 ImmediateMode_GetSPIRVSize() {
            return 0;
        }

        // function ImmediateMode_GetSPIRV
        public virtual IntPtr ImmediateMode_GetSPIRV() {
            return IntPtr.Zero;
        }

        // function ImmediateMode_GetVariableCount
        public virtual UInt32 ImmediateMode_GetVariableCount() {
            return 0;
        }

        // function ImmediateMode_GetVariableName
        public virtual IntPtr ImmediateMode_GetVariableName(UInt32 index) {
            return IntPtr.Zero;
        }

        // function ImmediateMode_GetResultID
        public virtual Int32 ImmediateMode_GetResultID() {
            return 0;
        }

        // function PluginManager_RegisterPlugins
        public virtual void PluginManager_RegisterPlugins() {
        }

        // function CustomLanguage_CompileToSPIRV2
        public virtual IntPtr CustomLanguage_CompileToSPIRV2(IntPtr item, Int32 langID, IntPtr src, UInt64 src_len, SHADERedCLR.Wrapper.ShaderStage stage, IntPtr entry, IntPtr macros, UInt64 macroCount, IntPtr spv_length, IntPtr compiled) {
            return IntPtr.Zero;
        }

        // function ShaderEditor_SetLineIndicator
        public virtual void ShaderEditor_SetLineIndicator(Int32 langID, Int32 editorID, Int32 line) {
        }
        protected void __SetDelegates(SHADERedCLR.Wrapper.InteropData.UnmanagedPointerCollection a_UPC) {
            if(a_UPC.AddObject_008 != IntPtr.Zero)
                this.AddObject = (Delegates.AddObjectDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.AddObject_008,typeof(Delegates.AddObjectDelegate));
            if(a_UPC.AddCustomPipelineItem_009 != IntPtr.Zero)
                this.AddCustomPipelineItem = (Delegates.AddCustomPipelineItemDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.AddCustomPipelineItem_009,typeof(Delegates.AddCustomPipelineItemDelegate));
            if(a_UPC.AddMessage_010 != IntPtr.Zero)
                this.AddMessage = (Delegates.AddMessageDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.AddMessage_010,typeof(Delegates.AddMessageDelegate));
            if(a_UPC.CreateRenderTexture_011 != IntPtr.Zero)
                this.CreateRenderTexture = (Delegates.CreateRenderTextureDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.CreateRenderTexture_011,typeof(Delegates.CreateRenderTextureDelegate));
            if(a_UPC.CreateImage_012 != IntPtr.Zero)
                this.CreateImage = (Delegates.CreateImageDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.CreateImage_012,typeof(Delegates.CreateImageDelegate));
            if(a_UPC.ResizeRenderTexture_013 != IntPtr.Zero)
                this.ResizeRenderTexture = (Delegates.ResizeRenderTextureDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.ResizeRenderTexture_013,typeof(Delegates.ResizeRenderTextureDelegate));
            if(a_UPC.ResizeImage_014 != IntPtr.Zero)
                this.ResizeImage = (Delegates.ResizeImageDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.ResizeImage_014,typeof(Delegates.ResizeImageDelegate));
            if(a_UPC.ExistsObject_015 != IntPtr.Zero)
                this.ExistsObject = (Delegates.ExistsObjectDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.ExistsObject_015,typeof(Delegates.ExistsObjectDelegate));
            if(a_UPC.RemoveGlobalObject_016 != IntPtr.Zero)
                this.RemoveGlobalObject = (Delegates.RemoveGlobalObjectDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.RemoveGlobalObject_016,typeof(Delegates.RemoveGlobalObjectDelegate));
            if(a_UPC.GetProjectPath_017 != IntPtr.Zero)
                this.GetProjectPath = (Delegates.GetProjectPathDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetProjectPath_017,typeof(Delegates.GetProjectPathDelegate));
            if(a_UPC.GetRelativePath_018 != IntPtr.Zero)
                this.GetRelativePath = (Delegates.GetRelativePathDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetRelativePath_018,typeof(Delegates.GetRelativePathDelegate));
            if(a_UPC.GetProjectFilename_019 != IntPtr.Zero)
                this.GetProjectFilename = (Delegates.GetProjectFilenameDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetProjectFilename_019,typeof(Delegates.GetProjectFilenameDelegate));
            if(a_UPC.GetProjectDirectory_020 != IntPtr.Zero)
                this.GetProjectDirectory = (Delegates.GetProjectDirectoryDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetProjectDirectory_020,typeof(Delegates.GetProjectDirectoryDelegate));
            if(a_UPC.IsProjectModified_021 != IntPtr.Zero)
                this.IsProjectModified = (Delegates.IsProjectModifiedDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.IsProjectModified_021,typeof(Delegates.IsProjectModifiedDelegate));
            if(a_UPC.ModifyProject_022 != IntPtr.Zero)
                this.ModifyProject = (Delegates.ModifyProjectDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.ModifyProject_022,typeof(Delegates.ModifyProjectDelegate));
            if(a_UPC.OpenProject_023 != IntPtr.Zero)
                this.OpenProject = (Delegates.OpenProjectDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.OpenProject_023,typeof(Delegates.OpenProjectDelegate));
            if(a_UPC.SaveProject_024 != IntPtr.Zero)
                this.SaveProject = (Delegates.SaveProjectDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.SaveProject_024,typeof(Delegates.SaveProjectDelegate));
            if(a_UPC.SaveAsProject_025 != IntPtr.Zero)
                this.SaveAsProject = (Delegates.SaveAsProjectDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.SaveAsProject_025,typeof(Delegates.SaveAsProjectDelegate));
            if(a_UPC.IsPaused_026 != IntPtr.Zero)
                this.IsPaused = (Delegates.IsPausedDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.IsPaused_026,typeof(Delegates.IsPausedDelegate));
            if(a_UPC.Pause_027 != IntPtr.Zero)
                this.Pause = (Delegates.PauseDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.Pause_027,typeof(Delegates.PauseDelegate));
            if(a_UPC.GetWindowColorTexture_028 != IntPtr.Zero)
                this.GetWindowColorTexture = (Delegates.GetWindowColorTextureDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetWindowColorTexture_028,typeof(Delegates.GetWindowColorTextureDelegate));
            if(a_UPC.GetWindowDepthTexture_029 != IntPtr.Zero)
                this.GetWindowDepthTexture = (Delegates.GetWindowDepthTextureDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetWindowDepthTexture_029,typeof(Delegates.GetWindowDepthTextureDelegate));
            if(a_UPC.GetLastRenderSize_030 != IntPtr.Zero)
                this.GetLastRenderSize = (Delegates.GetLastRenderSizeDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetLastRenderSize_030,typeof(Delegates.GetLastRenderSizeDelegate));
            if(a_UPC.Render_031 != IntPtr.Zero)
                this.Render = (Delegates.RenderDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.Render_031,typeof(Delegates.RenderDelegate));
            if(a_UPC.ExistsPipelineItem_032 != IntPtr.Zero)
                this.ExistsPipelineItem = (Delegates.ExistsPipelineItemDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.ExistsPipelineItem_032,typeof(Delegates.ExistsPipelineItemDelegate));
            if(a_UPC.GetPipelineItem_033 != IntPtr.Zero)
                this.GetPipelineItem = (Delegates.GetPipelineItemDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetPipelineItem_033,typeof(Delegates.GetPipelineItemDelegate));
            if(a_UPC.BindShaderPassVariables_034 != IntPtr.Zero)
                this.BindShaderPassVariables = (Delegates.BindShaderPassVariablesDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.BindShaderPassVariables_034,typeof(Delegates.BindShaderPassVariablesDelegate));
            if(a_UPC.GetViewMatrix_035 != IntPtr.Zero)
                this.GetViewMatrix = (Delegates.GetViewMatrixDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetViewMatrix_035,typeof(Delegates.GetViewMatrixDelegate));
            if(a_UPC.GetProjectionMatrix_036 != IntPtr.Zero)
                this.GetProjectionMatrix = (Delegates.GetProjectionMatrixDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetProjectionMatrix_036,typeof(Delegates.GetProjectionMatrixDelegate));
            if(a_UPC.GetOrthographicMatrix_037 != IntPtr.Zero)
                this.GetOrthographicMatrix = (Delegates.GetOrthographicMatrixDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetOrthographicMatrix_037,typeof(Delegates.GetOrthographicMatrixDelegate));
            if(a_UPC.GetViewportSize_038 != IntPtr.Zero)
                this.GetViewportSize = (Delegates.GetViewportSizeDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetViewportSize_038,typeof(Delegates.GetViewportSizeDelegate));
            if(a_UPC.AdvanceTimer_039 != IntPtr.Zero)
                this.AdvanceTimer = (Delegates.AdvanceTimerDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.AdvanceTimer_039,typeof(Delegates.AdvanceTimerDelegate));
            if(a_UPC.GetMousePosition_040 != IntPtr.Zero)
                this.GetMousePosition = (Delegates.GetMousePositionDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetMousePosition_040,typeof(Delegates.GetMousePositionDelegate));
            if(a_UPC.GetFrameIndex_041 != IntPtr.Zero)
                this.GetFrameIndex = (Delegates.GetFrameIndexDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetFrameIndex_041,typeof(Delegates.GetFrameIndexDelegate));
            if(a_UPC.GetTime_042 != IntPtr.Zero)
                this.GetTime = (Delegates.GetTimeDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetTime_042,typeof(Delegates.GetTimeDelegate));
            if(a_UPC.SetTime_043 != IntPtr.Zero)
                this.SetTime = (Delegates.SetTimeDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.SetTime_043,typeof(Delegates.SetTimeDelegate));
            if(a_UPC.SetGeometryTransform_044 != IntPtr.Zero)
                this.SetGeometryTransform = (Delegates.SetGeometryTransformDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.SetGeometryTransform_044,typeof(Delegates.SetGeometryTransformDelegate));
            if(a_UPC.SetMousePosition_045 != IntPtr.Zero)
                this.SetMousePosition = (Delegates.SetMousePositionDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.SetMousePosition_045,typeof(Delegates.SetMousePositionDelegate));
            if(a_UPC.SetKeysWASD_046 != IntPtr.Zero)
                this.SetKeysWASD = (Delegates.SetKeysWASDDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.SetKeysWASD_046,typeof(Delegates.SetKeysWASDDelegate));
            if(a_UPC.SetFrameIndex_047 != IntPtr.Zero)
                this.SetFrameIndex = (Delegates.SetFrameIndexDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.SetFrameIndex_047,typeof(Delegates.SetFrameIndexDelegate));
            if(a_UPC.GetDPI_048 != IntPtr.Zero)
                this.GetDPI = (Delegates.GetDPIDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetDPI_048,typeof(Delegates.GetDPIDelegate));
            if(a_UPC.FileExists_049 != IntPtr.Zero)
                this.FileExists = (Delegates.FileExistsDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.FileExists_049,typeof(Delegates.FileExistsDelegate));
            if(a_UPC.ClearMessageGroup_050 != IntPtr.Zero)
                this.ClearMessageGroup = (Delegates.ClearMessageGroupDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.ClearMessageGroup_050,typeof(Delegates.ClearMessageGroupDelegate));
            if(a_UPC.Log_051 != IntPtr.Zero)
                this.Log = (Delegates.LogDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.Log_051,typeof(Delegates.LogDelegate));
            if(a_UPC.GetObjectCount_052 != IntPtr.Zero)
                this.GetObjectCount = (Delegates.GetObjectCountDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetObjectCount_052,typeof(Delegates.GetObjectCountDelegate));
            if(a_UPC.GetObjectName_053 != IntPtr.Zero)
                this.GetObjectName = (Delegates.GetObjectNameDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetObjectName_053,typeof(Delegates.GetObjectNameDelegate));
            if(a_UPC.IsTexture_054 != IntPtr.Zero)
                this.IsTexture = (Delegates.IsTextureDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.IsTexture_054,typeof(Delegates.IsTextureDelegate));
            if(a_UPC.GetTexture_055 != IntPtr.Zero)
                this.GetTexture = (Delegates.GetTextureDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetTexture_055,typeof(Delegates.GetTextureDelegate));
            if(a_UPC.GetFlippedTexture_056 != IntPtr.Zero)
                this.GetFlippedTexture = (Delegates.GetFlippedTextureDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetFlippedTexture_056,typeof(Delegates.GetFlippedTextureDelegate));
            if(a_UPC.GetTextureSize_057 != IntPtr.Zero)
                this.GetTextureSize = (Delegates.GetTextureSizeDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetTextureSize_057,typeof(Delegates.GetTextureSizeDelegate));
            if(a_UPC.BindDefaultState_058 != IntPtr.Zero)
                this.BindDefaultState = (Delegates.BindDefaultStateDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.BindDefaultState_058,typeof(Delegates.BindDefaultStateDelegate));
            if(a_UPC.OpenInCodeEditor_059 != IntPtr.Zero)
                this.OpenInCodeEditor = (Delegates.OpenInCodeEditorDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.OpenInCodeEditor_059,typeof(Delegates.OpenInCodeEditorDelegate));
            if(a_UPC.GetPipelineItemCount_060 != IntPtr.Zero)
                this.GetPipelineItemCount = (Delegates.GetPipelineItemCountDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetPipelineItemCount_060,typeof(Delegates.GetPipelineItemCountDelegate));
            if(a_UPC.GetPipelineItemType_061 != IntPtr.Zero)
                this.GetPipelineItemType = (Delegates.GetPipelineItemTypeDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetPipelineItemType_061,typeof(Delegates.GetPipelineItemTypeDelegate));
            if(a_UPC.GetPipelineItemByIndex_062 != IntPtr.Zero)
                this.GetPipelineItemByIndex = (Delegates.GetPipelineItemByIndexDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetPipelineItemByIndex_062,typeof(Delegates.GetPipelineItemByIndexDelegate));
            if(a_UPC.GetPipelineItemName_063 != IntPtr.Zero)
                this.GetPipelineItemName = (Delegates.GetPipelineItemNameDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetPipelineItemName_063,typeof(Delegates.GetPipelineItemNameDelegate));
            if(a_UPC.GetPipelineItemPluginOwner_064 != IntPtr.Zero)
                this.GetPipelineItemPluginOwner = (Delegates.GetPipelineItemPluginOwnerDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetPipelineItemPluginOwner_064,typeof(Delegates.GetPipelineItemPluginOwnerDelegate));
            if(a_UPC.GetPipelineItemVariableCount_065 != IntPtr.Zero)
                this.GetPipelineItemVariableCount = (Delegates.GetPipelineItemVariableCountDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetPipelineItemVariableCount_065,typeof(Delegates.GetPipelineItemVariableCountDelegate));
            if(a_UPC.GetPipelineItemVariableName_066 != IntPtr.Zero)
                this.GetPipelineItemVariableName = (Delegates.GetPipelineItemVariableNameDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetPipelineItemVariableName_066,typeof(Delegates.GetPipelineItemVariableNameDelegate));
            if(a_UPC.GetPipelineItemVariableValue_067 != IntPtr.Zero)
                this.GetPipelineItemVariableValue = (Delegates.GetPipelineItemVariableValueDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetPipelineItemVariableValue_067,typeof(Delegates.GetPipelineItemVariableValueDelegate));
            if(a_UPC.GetPipelineItemVariableType_068 != IntPtr.Zero)
                this.GetPipelineItemVariableType = (Delegates.GetPipelineItemVariableTypeDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetPipelineItemVariableType_068,typeof(Delegates.GetPipelineItemVariableTypeDelegate));
            if(a_UPC.AddPipelineItemVariable_069 != IntPtr.Zero)
                this.AddPipelineItemVariable = (Delegates.AddPipelineItemVariableDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.AddPipelineItemVariable_069,typeof(Delegates.AddPipelineItemVariableDelegate));
            if(a_UPC.GetPipelineItemChildrenCount_070 != IntPtr.Zero)
                this.GetPipelineItemChildrenCount = (Delegates.GetPipelineItemChildrenCountDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetPipelineItemChildrenCount_070,typeof(Delegates.GetPipelineItemChildrenCountDelegate));
            if(a_UPC.GetPipelineItemChild_071 != IntPtr.Zero)
                this.GetPipelineItemChild = (Delegates.GetPipelineItemChildDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetPipelineItemChild_071,typeof(Delegates.GetPipelineItemChildDelegate));
            if(a_UPC.SetPipelineItemPosition_072 != IntPtr.Zero)
                this.SetPipelineItemPosition = (Delegates.SetPipelineItemPositionDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.SetPipelineItemPosition_072,typeof(Delegates.SetPipelineItemPositionDelegate));
            if(a_UPC.SetPipelineItemRotation_073 != IntPtr.Zero)
                this.SetPipelineItemRotation = (Delegates.SetPipelineItemRotationDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.SetPipelineItemRotation_073,typeof(Delegates.SetPipelineItemRotationDelegate));
            if(a_UPC.SetPipelineItemScale_074 != IntPtr.Zero)
                this.SetPipelineItemScale = (Delegates.SetPipelineItemScaleDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.SetPipelineItemScale_074,typeof(Delegates.SetPipelineItemScaleDelegate));
            if(a_UPC.GetPipelineItemPosition_075 != IntPtr.Zero)
                this.GetPipelineItemPosition = (Delegates.GetPipelineItemPositionDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetPipelineItemPosition_075,typeof(Delegates.GetPipelineItemPositionDelegate));
            if(a_UPC.GetPipelineItemRotation_076 != IntPtr.Zero)
                this.GetPipelineItemRotation = (Delegates.GetPipelineItemRotationDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetPipelineItemRotation_076,typeof(Delegates.GetPipelineItemRotationDelegate));
            if(a_UPC.GetPipelineItemScale_077 != IntPtr.Zero)
                this.GetPipelineItemScale = (Delegates.GetPipelineItemScaleDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetPipelineItemScale_077,typeof(Delegates.GetPipelineItemScaleDelegate));
            if(a_UPC.DEPRECATED_GetOpenDirectoryDialog_078 != IntPtr.Zero)
                this.DEPRECATED_GetOpenDirectoryDialog = (Delegates.DEPRECATED_GetOpenDirectoryDialogDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.DEPRECATED_GetOpenDirectoryDialog_078,typeof(Delegates.DEPRECATED_GetOpenDirectoryDialogDelegate));
            if(a_UPC.DEPRECATED_GetOpenFileDialog_079 != IntPtr.Zero)
                this.DEPRECATED_GetOpenFileDialog = (Delegates.DEPRECATED_GetOpenFileDialogDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.DEPRECATED_GetOpenFileDialog_079,typeof(Delegates.DEPRECATED_GetOpenFileDialogDelegate));
            if(a_UPC.DEPRECATED_GetSaveFileDialog_080 != IntPtr.Zero)
                this.DEPRECATED_GetSaveFileDialog = (Delegates.DEPRECATED_GetSaveFileDialogDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.DEPRECATED_GetSaveFileDialog_080,typeof(Delegates.DEPRECATED_GetSaveFileDialogDelegate));
            if(a_UPC.GetIncludePathCount_081 != IntPtr.Zero)
                this.GetIncludePathCount = (Delegates.GetIncludePathCountDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetIncludePathCount_081,typeof(Delegates.GetIncludePathCountDelegate));
            if(a_UPC.GetIncludePath_082 != IntPtr.Zero)
                this.GetIncludePath = (Delegates.GetIncludePathDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetIncludePath_082,typeof(Delegates.GetIncludePathDelegate));
            if(a_UPC.GetMessagesCurrentItem_083 != IntPtr.Zero)
                this.GetMessagesCurrentItem = (Delegates.GetMessagesCurrentItemDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetMessagesCurrentItem_083,typeof(Delegates.GetMessagesCurrentItemDelegate));
            if(a_UPC.OnEditorContentChange_084 != IntPtr.Zero)
                this.OnEditorContentChange = (Delegates.OnEditorContentChangeDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.OnEditorContentChange_084,typeof(Delegates.OnEditorContentChangeDelegate));
            if(a_UPC.GetPipelineItemSPIRV_085 != IntPtr.Zero)
                this.GetPipelineItemSPIRV = (Delegates.GetPipelineItemSPIRVDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetPipelineItemSPIRV_085,typeof(Delegates.GetPipelineItemSPIRVDelegate));
            if(a_UPC.RegisterShortcut_086 != IntPtr.Zero)
                this.RegisterShortcut = (Delegates.RegisterShortcutDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.RegisterShortcut_086,typeof(Delegates.RegisterShortcutDelegate));
            if(a_UPC.GetSettingsBoolean_087 != IntPtr.Zero)
                this.GetSettingsBoolean = (Delegates.GetSettingsBooleanDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetSettingsBoolean_087,typeof(Delegates.GetSettingsBooleanDelegate));
            if(a_UPC.GetSettingsString_088 != IntPtr.Zero)
                this.GetSettingsString = (Delegates.GetSettingsStringDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetSettingsString_088,typeof(Delegates.GetSettingsStringDelegate));
            if(a_UPC.GetSettingsInteger_089 != IntPtr.Zero)
                this.GetSettingsInteger = (Delegates.GetSettingsIntegerDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetSettingsInteger_089,typeof(Delegates.GetSettingsIntegerDelegate));
            if(a_UPC.GetSettingsFloat_090 != IntPtr.Zero)
                this.GetSettingsFloat = (Delegates.GetSettingsFloatDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetSettingsFloat_090,typeof(Delegates.GetSettingsFloatDelegate));
            if(a_UPC.GetPreviewUIRect_091 != IntPtr.Zero)
                this.GetPreviewUIRect = (Delegates.GetPreviewUIRectDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetPreviewUIRect_091,typeof(Delegates.GetPreviewUIRectDelegate));
            if(a_UPC.GetPlugin_092 != IntPtr.Zero)
                this.GetPlugin = (Delegates.GetPluginDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetPlugin_092,typeof(Delegates.GetPluginDelegate));
            if(a_UPC.GetPluginListSize_093 != IntPtr.Zero)
                this.GetPluginListSize = (Delegates.GetPluginListSizeDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetPluginListSize_093,typeof(Delegates.GetPluginListSizeDelegate));
            if(a_UPC.GetPluginName_094 != IntPtr.Zero)
                this.GetPluginName = (Delegates.GetPluginNameDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetPluginName_094,typeof(Delegates.GetPluginNameDelegate));
            if(a_UPC.SendPluginMessage_095 != IntPtr.Zero)
                this.SendPluginMessage = (Delegates.SendPluginMessageDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.SendPluginMessage_095,typeof(Delegates.SendPluginMessageDelegate));
            if(a_UPC.BroadcastPluginMessage_096 != IntPtr.Zero)
                this.BroadcastPluginMessage = (Delegates.BroadcastPluginMessageDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.BroadcastPluginMessage_096,typeof(Delegates.BroadcastPluginMessageDelegate));
            if(a_UPC.ToggleFullscreen_097 != IntPtr.Zero)
                this.ToggleFullscreen = (Delegates.ToggleFullscreenDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.ToggleFullscreen_097,typeof(Delegates.ToggleFullscreenDelegate));
            if(a_UPC.IsFullscreen_098 != IntPtr.Zero)
                this.IsFullscreen = (Delegates.IsFullscreenDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.IsFullscreen_098,typeof(Delegates.IsFullscreenDelegate));
            if(a_UPC.TogglePerformanceMode_099 != IntPtr.Zero)
                this.TogglePerformanceMode = (Delegates.TogglePerformanceModeDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.TogglePerformanceMode_099,typeof(Delegates.TogglePerformanceModeDelegate));
            if(a_UPC.IsInPerformanceMode_100 != IntPtr.Zero)
                this.IsInPerformanceMode = (Delegates.IsInPerformanceModeDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.IsInPerformanceMode_100,typeof(Delegates.IsInPerformanceModeDelegate));
            if(a_UPC.PushNotification_101 != IntPtr.Zero)
                this.PushNotification = (Delegates.PushNotificationDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.PushNotification_101,typeof(Delegates.PushNotificationDelegate));
            if(a_UPC.DebuggerJump_102 != IntPtr.Zero)
                this.DebuggerJump = (Delegates.DebuggerJumpDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.DebuggerJump_102,typeof(Delegates.DebuggerJumpDelegate));
            if(a_UPC.DebuggerContinue_103 != IntPtr.Zero)
                this.DebuggerContinue = (Delegates.DebuggerContinueDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.DebuggerContinue_103,typeof(Delegates.DebuggerContinueDelegate));
            if(a_UPC.DebuggerStep_104 != IntPtr.Zero)
                this.DebuggerStep = (Delegates.DebuggerStepDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.DebuggerStep_104,typeof(Delegates.DebuggerStepDelegate));
            if(a_UPC.DebuggerStepInto_105 != IntPtr.Zero)
                this.DebuggerStepInto = (Delegates.DebuggerStepIntoDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.DebuggerStepInto_105,typeof(Delegates.DebuggerStepIntoDelegate));
            if(a_UPC.DebuggerStepOut_106 != IntPtr.Zero)
                this.DebuggerStepOut = (Delegates.DebuggerStepOutDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.DebuggerStepOut_106,typeof(Delegates.DebuggerStepOutDelegate));
            if(a_UPC.DebuggerCheckBreakpoint_107 != IntPtr.Zero)
                this.DebuggerCheckBreakpoint = (Delegates.DebuggerCheckBreakpointDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.DebuggerCheckBreakpoint_107,typeof(Delegates.DebuggerCheckBreakpointDelegate));
            if(a_UPC.DebuggerIsDebugging_108 != IntPtr.Zero)
                this.DebuggerIsDebugging = (Delegates.DebuggerIsDebuggingDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.DebuggerIsDebugging_108,typeof(Delegates.DebuggerIsDebuggingDelegate));
            if(a_UPC.DebuggerGetCurrentLine_109 != IntPtr.Zero)
                this.DebuggerGetCurrentLine = (Delegates.DebuggerGetCurrentLineDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.DebuggerGetCurrentLine_109,typeof(Delegates.DebuggerGetCurrentLineDelegate));
            if(a_UPC.IsRenderTexture_110 != IntPtr.Zero)
                this.IsRenderTexture = (Delegates.IsRenderTextureDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.IsRenderTexture_110,typeof(Delegates.IsRenderTextureDelegate));
            if(a_UPC.GetRenderTextureSize_111 != IntPtr.Zero)
                this.GetRenderTextureSize = (Delegates.GetRenderTextureSizeDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetRenderTextureSize_111,typeof(Delegates.GetRenderTextureSizeDelegate));
            if(a_UPC.GetDepthTexture_112 != IntPtr.Zero)
                this.GetDepthTexture = (Delegates.GetDepthTextureDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetDepthTexture_112,typeof(Delegates.GetDepthTextureDelegate));
            if(a_UPC.ScaleSize_113 != IntPtr.Zero)
                this.ScaleSize = (Delegates.ScaleSizeDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.ScaleSize_113,typeof(Delegates.ScaleSizeDelegate));
            if(a_UPC.GetHostIPluginMaxVersion_114 != IntPtr.Zero)
                this.GetHostIPluginMaxVersion = (Delegates.GetHostIPluginMaxVersionDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetHostIPluginMaxVersion_114,typeof(Delegates.GetHostIPluginMaxVersionDelegate));
            if(a_UPC.ImGuiFileDialogOpen_115 != IntPtr.Zero)
                this.ImGuiFileDialogOpen = (Delegates.ImGuiFileDialogOpenDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.ImGuiFileDialogOpen_115,typeof(Delegates.ImGuiFileDialogOpenDelegate));
            if(a_UPC.ImGuiDirectoryDialogOpen_116 != IntPtr.Zero)
                this.ImGuiDirectoryDialogOpen = (Delegates.ImGuiDirectoryDialogOpenDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.ImGuiDirectoryDialogOpen_116,typeof(Delegates.ImGuiDirectoryDialogOpenDelegate));
            if(a_UPC.ImGuiFileDialogIsDone_117 != IntPtr.Zero)
                this.ImGuiFileDialogIsDone = (Delegates.ImGuiFileDialogIsDoneDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.ImGuiFileDialogIsDone_117,typeof(Delegates.ImGuiFileDialogIsDoneDelegate));
            if(a_UPC.ImGuiFileDialogClose_118 != IntPtr.Zero)
                this.ImGuiFileDialogClose = (Delegates.ImGuiFileDialogCloseDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.ImGuiFileDialogClose_118,typeof(Delegates.ImGuiFileDialogCloseDelegate));
            if(a_UPC.ImGuiFileDialogGetResult_119 != IntPtr.Zero)
                this.ImGuiFileDialogGetResult = (Delegates.ImGuiFileDialogGetResultDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.ImGuiFileDialogGetResult_119,typeof(Delegates.ImGuiFileDialogGetResultDelegate));
            if(a_UPC.ImGuiFileDialogGetPath_120 != IntPtr.Zero)
                this.ImGuiFileDialogGetPath = (Delegates.ImGuiFileDialogGetPathDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.ImGuiFileDialogGetPath_120,typeof(Delegates.ImGuiFileDialogGetPathDelegate));
            if(a_UPC.DebuggerImmediate_121 != IntPtr.Zero)
                this.DebuggerImmediate = (Delegates.DebuggerImmediateDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.DebuggerImmediate_121,typeof(Delegates.DebuggerImmediateDelegate));
            if(a_UPC.RegisterPlugin_122 != IntPtr.Zero)
                this.RegisterPlugin = (Delegates.RegisterPluginDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.RegisterPlugin_122,typeof(Delegates.RegisterPluginDelegate));
            if(a_UPC.GetEditorPipelineItem_123 != IntPtr.Zero)
                this.GetEditorPipelineItem = (Delegates.GetEditorPipelineItemDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.GetEditorPipelineItem_123,typeof(Delegates.GetEditorPipelineItemDelegate));
            if(a_UPC.SetViewportSize_124 != IntPtr.Zero)
                this.SetViewportSize = (Delegates.SetViewportSizeDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.SetViewportSize_124,typeof(Delegates.SetViewportSizeDelegate));
            if(a_UPC.IsObjectBound_125 != IntPtr.Zero)
                this.IsObjectBound = (Delegates.IsObjectBoundDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.IsObjectBound_125,typeof(Delegates.IsObjectBoundDelegate));
            if(a_UPC.DebuggerStepIntoPluginEditor_126 != IntPtr.Zero)
                this.DebuggerStepIntoPluginEditor = (Delegates.DebuggerStepIntoPluginEditorDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.DebuggerStepIntoPluginEditor_126,typeof(Delegates.DebuggerStepIntoPluginEditorDelegate));
            if(a_UPC.DebuggerGetVariableValue_127 != IntPtr.Zero)
                this.DebuggerGetVariableValue = (Delegates.DebuggerGetVariableValueDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.DebuggerGetVariableValue_127,typeof(Delegates.DebuggerGetVariableValueDelegate));
            if(a_UPC.DebuggerStopPluginEditor_128 != IntPtr.Zero)
                this.DebuggerStopPluginEditor = (Delegates.DebuggerStopPluginEditorDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.DebuggerStopPluginEditor_128,typeof(Delegates.DebuggerStopPluginEditorDelegate));
            if(a_UPC.DebuggerIsVMRunning_129 != IntPtr.Zero)
                this.DebuggerIsVMRunning = (Delegates.DebuggerIsVMRunningDelegate)Marshal.GetDelegateForFunctionPointer(a_UPC.DebuggerIsVMRunning_129,typeof(Delegates.DebuggerIsVMRunningDelegate));
        }
        protected SHADERedCLR.Wrapper.InteropData.ManagedPointerCollection __GetFunctionPointers() {
            var mpc = new SHADERedCLR.Wrapper.InteropData.ManagedPointerCollection();
            if (this.GetType().GetMethod("Init", new Type[] {typeof(bool), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Init_000 = new Delegates.InitDelegate_000(this.Init);
                mpc.Init_000 = Marshal.GetFunctionPointerForDelegate(__delegates.Init_000);
            } else mpc.Init_000 = IntPtr.Zero;

            if (this.GetType().GetMethod("InitUI", new Type[] {typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.InitUI_001 = new Delegates.InitUIDelegate_001(this.InitUI);
                mpc.InitUI_001 = Marshal.GetFunctionPointerForDelegate(__delegates.InitUI_001);
            } else mpc.InitUI_001 = IntPtr.Zero;

            if (this.GetType().GetMethod("OnEvent", new Type[] {typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.OnEvent_002 = new Delegates.OnEventDelegate_002(this.OnEvent);
                mpc.OnEvent_002 = Marshal.GetFunctionPointerForDelegate(__delegates.OnEvent_002);
            } else mpc.OnEvent_002 = IntPtr.Zero;

            if (this.GetType().GetMethod("Update", new Type[] {typeof(float) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Update_003 = new Delegates.UpdateDelegate_003(this.Update);
                mpc.Update_003 = Marshal.GetFunctionPointerForDelegate(__delegates.Update_003);
            } else mpc.Update_003 = IntPtr.Zero;

            if (this.GetType().GetMethod("Destroy", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Destroy_004 = new Delegates.DestroyDelegate_004(this.Destroy);
                mpc.Destroy_004 = Marshal.GetFunctionPointerForDelegate(__delegates.Destroy_004);
            } else mpc.Destroy_004 = IntPtr.Zero;

            if (this.GetType().GetMethod("IsRequired", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.IsRequired_005 = new Delegates.IsRequiredDelegate_005(this.IsRequired);
                mpc.IsRequired_005 = Marshal.GetFunctionPointerForDelegate(__delegates.IsRequired_005);
            } else mpc.IsRequired_005 = IntPtr.Zero;

            if (this.GetType().GetMethod("IsVersionCompatible", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.IsVersionCompatible_006 = new Delegates.IsVersionCompatibleDelegate_006(this.IsVersionCompatible);
                mpc.IsVersionCompatible_006 = Marshal.GetFunctionPointerForDelegate(__delegates.IsVersionCompatible_006);
            } else mpc.IsVersionCompatible_006 = IntPtr.Zero;

            if (this.GetType().GetMethod("BeginRender", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.BeginRender_007 = new Delegates.BeginRenderDelegate_007(this.BeginRender);
                mpc.BeginRender_007 = Marshal.GetFunctionPointerForDelegate(__delegates.BeginRender_007);
            } else mpc.BeginRender_007 = IntPtr.Zero;

            if (this.GetType().GetMethod("EndRender", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.EndRender_008 = new Delegates.EndRenderDelegate_008(this.EndRender);
                mpc.EndRender_008 = Marshal.GetFunctionPointerForDelegate(__delegates.EndRender_008);
            } else mpc.EndRender_008 = IntPtr.Zero;

            if (this.GetType().GetMethod("Project_BeginLoad", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Project_BeginLoad_009 = new Delegates.Project_BeginLoadDelegate_009(this.Project_BeginLoad);
                mpc.Project_BeginLoad_009 = Marshal.GetFunctionPointerForDelegate(__delegates.Project_BeginLoad_009);
            } else mpc.Project_BeginLoad_009 = IntPtr.Zero;

            if (this.GetType().GetMethod("Project_EndLoad", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Project_EndLoad_010 = new Delegates.Project_EndLoadDelegate_010(this.Project_EndLoad);
                mpc.Project_EndLoad_010 = Marshal.GetFunctionPointerForDelegate(__delegates.Project_EndLoad_010);
            } else mpc.Project_EndLoad_010 = IntPtr.Zero;

            if (this.GetType().GetMethod("Project_BeginSave", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Project_BeginSave_011 = new Delegates.Project_BeginSaveDelegate_011(this.Project_BeginSave);
                mpc.Project_BeginSave_011 = Marshal.GetFunctionPointerForDelegate(__delegates.Project_BeginSave_011);
            } else mpc.Project_BeginSave_011 = IntPtr.Zero;

            if (this.GetType().GetMethod("Project_EndSave", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Project_EndSave_012 = new Delegates.Project_EndSaveDelegate_012(this.Project_EndSave);
                mpc.Project_EndSave_012 = Marshal.GetFunctionPointerForDelegate(__delegates.Project_EndSave_012);
            } else mpc.Project_EndSave_012 = IntPtr.Zero;

            if (this.GetType().GetMethod("Project_HasAdditionalData", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Project_HasAdditionalData_013 = new Delegates.Project_HasAdditionalDataDelegate_013(this.Project_HasAdditionalData);
                mpc.Project_HasAdditionalData_013 = Marshal.GetFunctionPointerForDelegate(__delegates.Project_HasAdditionalData_013);
            } else mpc.Project_HasAdditionalData_013 = IntPtr.Zero;

            if (this.GetType().GetMethod("Project_ExportAdditionalData", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Project_ExportAdditionalData_014 = new Delegates.Project_ExportAdditionalDataDelegate_014(this.Project_ExportAdditionalData);
                mpc.Project_ExportAdditionalData_014 = Marshal.GetFunctionPointerForDelegate(__delegates.Project_ExportAdditionalData_014);
            } else mpc.Project_ExportAdditionalData_014 = IntPtr.Zero;

            if (this.GetType().GetMethod("Project_ImportAdditionalData", new Type[] {typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Project_ImportAdditionalData_015 = new Delegates.Project_ImportAdditionalDataDelegate_015(this.Project_ImportAdditionalData);
                mpc.Project_ImportAdditionalData_015 = Marshal.GetFunctionPointerForDelegate(__delegates.Project_ImportAdditionalData_015);
            } else mpc.Project_ImportAdditionalData_015 = IntPtr.Zero;

            if (this.GetType().GetMethod("Project_CopyFilesOnSave", new Type[] {typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Project_CopyFilesOnSave_016 = new Delegates.Project_CopyFilesOnSaveDelegate_016(this.Project_CopyFilesOnSave);
                mpc.Project_CopyFilesOnSave_016 = Marshal.GetFunctionPointerForDelegate(__delegates.Project_CopyFilesOnSave_016);
            } else mpc.Project_CopyFilesOnSave_016 = IntPtr.Zero;

            if (this.GetType().GetMethod("HasCustomMenuItem", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.HasCustomMenuItem_017 = new Delegates.HasCustomMenuItemDelegate_017(this.HasCustomMenuItem);
                mpc.HasCustomMenuItem_017 = Marshal.GetFunctionPointerForDelegate(__delegates.HasCustomMenuItem_017);
            } else mpc.HasCustomMenuItem_017 = IntPtr.Zero;

            if (this.GetType().GetMethod("HasMenuItems", new Type[] {typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.HasMenuItems_018 = new Delegates.HasMenuItemsDelegate_018(this.HasMenuItems);
                mpc.HasMenuItems_018 = Marshal.GetFunctionPointerForDelegate(__delegates.HasMenuItems_018);
            } else mpc.HasMenuItems_018 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShowMenuItems", new Type[] {typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShowMenuItems_019 = new Delegates.ShowMenuItemsDelegate_019(this.ShowMenuItems);
                mpc.ShowMenuItems_019 = Marshal.GetFunctionPointerForDelegate(__delegates.ShowMenuItems_019);
            } else mpc.ShowMenuItems_019 = IntPtr.Zero;

            if (this.GetType().GetMethod("HasContextItems", new Type[] {typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.HasContextItems_020 = new Delegates.HasContextItemsDelegate_020(this.HasContextItems);
                mpc.HasContextItems_020 = Marshal.GetFunctionPointerForDelegate(__delegates.HasContextItems_020);
            } else mpc.HasContextItems_020 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShowContextItems", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShowContextItems_021 = new Delegates.ShowContextItemsDelegate_021(this.ShowContextItems);
                mpc.ShowContextItems_021 = Marshal.GetFunctionPointerForDelegate(__delegates.ShowContextItems_021);
            } else mpc.ShowContextItems_021 = IntPtr.Zero;

            if (this.GetType().GetMethod("SystemVariables_GetNameCount", new Type[] {typeof(SHADERedCLR.Wrapper.VariableType) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.SystemVariables_GetNameCount_022 = new Delegates.SystemVariables_GetNameCountDelegate_022(this.SystemVariables_GetNameCount);
                mpc.SystemVariables_GetNameCount_022 = Marshal.GetFunctionPointerForDelegate(__delegates.SystemVariables_GetNameCount_022);
            } else mpc.SystemVariables_GetNameCount_022 = IntPtr.Zero;

            if (this.GetType().GetMethod("SystemVariables_GetName", new Type[] {typeof(SHADERedCLR.Wrapper.VariableType), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.SystemVariables_GetName_023 = new Delegates.SystemVariables_GetNameDelegate_023(this.SystemVariables_GetName);
                mpc.SystemVariables_GetName_023 = Marshal.GetFunctionPointerForDelegate(__delegates.SystemVariables_GetName_023);
            } else mpc.SystemVariables_GetName_023 = IntPtr.Zero;

            if (this.GetType().GetMethod("SystemVariables_HasLastFrame", new Type[] {typeof(IntPtr), typeof(SHADERedCLR.Wrapper.VariableType) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.SystemVariables_HasLastFrame_024 = new Delegates.SystemVariables_HasLastFrameDelegate_024(this.SystemVariables_HasLastFrame);
                mpc.SystemVariables_HasLastFrame_024 = Marshal.GetFunctionPointerForDelegate(__delegates.SystemVariables_HasLastFrame_024);
            } else mpc.SystemVariables_HasLastFrame_024 = IntPtr.Zero;

            if (this.GetType().GetMethod("SystemVariables_UpdateValue", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(SHADERedCLR.Wrapper.VariableType), typeof(bool) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.SystemVariables_UpdateValue_025 = new Delegates.SystemVariables_UpdateValueDelegate_025(this.SystemVariables_UpdateValue);
                mpc.SystemVariables_UpdateValue_025 = Marshal.GetFunctionPointerForDelegate(__delegates.SystemVariables_UpdateValue_025);
            } else mpc.SystemVariables_UpdateValue_025 = IntPtr.Zero;

            if (this.GetType().GetMethod("VariableFunctions_GetNameCount", new Type[] {typeof(SHADERedCLR.Wrapper.VariableType) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.VariableFunctions_GetNameCount_026 = new Delegates.VariableFunctions_GetNameCountDelegate_026(this.VariableFunctions_GetNameCount);
                mpc.VariableFunctions_GetNameCount_026 = Marshal.GetFunctionPointerForDelegate(__delegates.VariableFunctions_GetNameCount_026);
            } else mpc.VariableFunctions_GetNameCount_026 = IntPtr.Zero;

            if (this.GetType().GetMethod("VariableFunctions_GetName", new Type[] {typeof(SHADERedCLR.Wrapper.VariableType), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.VariableFunctions_GetName_027 = new Delegates.VariableFunctions_GetNameDelegate_027(this.VariableFunctions_GetName);
                mpc.VariableFunctions_GetName_027 = Marshal.GetFunctionPointerForDelegate(__delegates.VariableFunctions_GetName_027);
            } else mpc.VariableFunctions_GetName_027 = IntPtr.Zero;

            if (this.GetType().GetMethod("VariableFunctions_ShowArgumentEdit", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(SHADERedCLR.Wrapper.VariableType) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.VariableFunctions_ShowArgumentEdit_028 = new Delegates.VariableFunctions_ShowArgumentEditDelegate_028(this.VariableFunctions_ShowArgumentEdit);
                mpc.VariableFunctions_ShowArgumentEdit_028 = Marshal.GetFunctionPointerForDelegate(__delegates.VariableFunctions_ShowArgumentEdit_028);
            } else mpc.VariableFunctions_ShowArgumentEdit_028 = IntPtr.Zero;

            if (this.GetType().GetMethod("VariableFunctions_UpdateValue", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(SHADERedCLR.Wrapper.VariableType) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.VariableFunctions_UpdateValue_029 = new Delegates.VariableFunctions_UpdateValueDelegate_029(this.VariableFunctions_UpdateValue);
                mpc.VariableFunctions_UpdateValue_029 = Marshal.GetFunctionPointerForDelegate(__delegates.VariableFunctions_UpdateValue_029);
            } else mpc.VariableFunctions_UpdateValue_029 = IntPtr.Zero;

            if (this.GetType().GetMethod("VariableFunctions_GetArgsSize", new Type[] {typeof(IntPtr), typeof(SHADERedCLR.Wrapper.VariableType) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.VariableFunctions_GetArgsSize_030 = new Delegates.VariableFunctions_GetArgsSizeDelegate_030(this.VariableFunctions_GetArgsSize);
                mpc.VariableFunctions_GetArgsSize_030 = Marshal.GetFunctionPointerForDelegate(__delegates.VariableFunctions_GetArgsSize_030);
            } else mpc.VariableFunctions_GetArgsSize_030 = IntPtr.Zero;

            if (this.GetType().GetMethod("VariableFunctions_InitArguments", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(SHADERedCLR.Wrapper.VariableType) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.VariableFunctions_InitArguments_031 = new Delegates.VariableFunctions_InitArgumentsDelegate_031(this.VariableFunctions_InitArguments);
                mpc.VariableFunctions_InitArguments_031 = Marshal.GetFunctionPointerForDelegate(__delegates.VariableFunctions_InitArguments_031);
            } else mpc.VariableFunctions_InitArguments_031 = IntPtr.Zero;

            if (this.GetType().GetMethod("VariableFunctions_ExportArguments", new Type[] {typeof(IntPtr), typeof(SHADERedCLR.Wrapper.VariableType), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.VariableFunctions_ExportArguments_032 = new Delegates.VariableFunctions_ExportArgumentsDelegate_032(this.VariableFunctions_ExportArguments);
                mpc.VariableFunctions_ExportArguments_032 = Marshal.GetFunctionPointerForDelegate(__delegates.VariableFunctions_ExportArguments_032);
            } else mpc.VariableFunctions_ExportArguments_032 = IntPtr.Zero;

            if (this.GetType().GetMethod("VariableFunctions_ImportArguments", new Type[] {typeof(IntPtr), typeof(SHADERedCLR.Wrapper.VariableType), typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.VariableFunctions_ImportArguments_033 = new Delegates.VariableFunctions_ImportArgumentsDelegate_033(this.VariableFunctions_ImportArguments);
                mpc.VariableFunctions_ImportArguments_033 = Marshal.GetFunctionPointerForDelegate(__delegates.VariableFunctions_ImportArguments_033);
            } else mpc.VariableFunctions_ImportArguments_033 = IntPtr.Zero;

            if (this.GetType().GetMethod("Object_HasPreview", new Type[] {typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Object_HasPreview_034 = new Delegates.Object_HasPreviewDelegate_034(this.Object_HasPreview);
                mpc.Object_HasPreview_034 = Marshal.GetFunctionPointerForDelegate(__delegates.Object_HasPreview_034);
            } else mpc.Object_HasPreview_034 = IntPtr.Zero;

            if (this.GetType().GetMethod("Object_ShowPreview", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(UInt32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Object_ShowPreview_035 = new Delegates.Object_ShowPreviewDelegate_035(this.Object_ShowPreview);
                mpc.Object_ShowPreview_035 = Marshal.GetFunctionPointerForDelegate(__delegates.Object_ShowPreview_035);
            } else mpc.Object_ShowPreview_035 = IntPtr.Zero;

            if (this.GetType().GetMethod("Object_IsBindable", new Type[] {typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Object_IsBindable_036 = new Delegates.Object_IsBindableDelegate_036(this.Object_IsBindable);
                mpc.Object_IsBindable_036 = Marshal.GetFunctionPointerForDelegate(__delegates.Object_IsBindable_036);
            } else mpc.Object_IsBindable_036 = IntPtr.Zero;

            if (this.GetType().GetMethod("Object_IsBindableUAV", new Type[] {typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Object_IsBindableUAV_037 = new Delegates.Object_IsBindableUAVDelegate_037(this.Object_IsBindableUAV);
                mpc.Object_IsBindableUAV_037 = Marshal.GetFunctionPointerForDelegate(__delegates.Object_IsBindableUAV_037);
            } else mpc.Object_IsBindableUAV_037 = IntPtr.Zero;

            if (this.GetType().GetMethod("Object_Remove", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(UInt32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Object_Remove_038 = new Delegates.Object_RemoveDelegate_038(this.Object_Remove);
                mpc.Object_Remove_038 = Marshal.GetFunctionPointerForDelegate(__delegates.Object_Remove_038);
            } else mpc.Object_Remove_038 = IntPtr.Zero;

            if (this.GetType().GetMethod("Object_HasExtendedPreview", new Type[] {typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Object_HasExtendedPreview_039 = new Delegates.Object_HasExtendedPreviewDelegate_039(this.Object_HasExtendedPreview);
                mpc.Object_HasExtendedPreview_039 = Marshal.GetFunctionPointerForDelegate(__delegates.Object_HasExtendedPreview_039);
            } else mpc.Object_HasExtendedPreview_039 = IntPtr.Zero;

            if (this.GetType().GetMethod("Object_ShowExtendedPreview", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(UInt32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Object_ShowExtendedPreview_040 = new Delegates.Object_ShowExtendedPreviewDelegate_040(this.Object_ShowExtendedPreview);
                mpc.Object_ShowExtendedPreview_040 = Marshal.GetFunctionPointerForDelegate(__delegates.Object_ShowExtendedPreview_040);
            } else mpc.Object_ShowExtendedPreview_040 = IntPtr.Zero;

            if (this.GetType().GetMethod("Object_HasProperties", new Type[] {typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Object_HasProperties_041 = new Delegates.Object_HasPropertiesDelegate_041(this.Object_HasProperties);
                mpc.Object_HasProperties_041 = Marshal.GetFunctionPointerForDelegate(__delegates.Object_HasProperties_041);
            } else mpc.Object_HasProperties_041 = IntPtr.Zero;

            if (this.GetType().GetMethod("Object_ShowProperties", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(UInt32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Object_ShowProperties_042 = new Delegates.Object_ShowPropertiesDelegate_042(this.Object_ShowProperties);
                mpc.Object_ShowProperties_042 = Marshal.GetFunctionPointerForDelegate(__delegates.Object_ShowProperties_042);
            } else mpc.Object_ShowProperties_042 = IntPtr.Zero;

            if (this.GetType().GetMethod("Object_Bind", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(UInt32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Object_Bind_043 = new Delegates.Object_BindDelegate_043(this.Object_Bind);
                mpc.Object_Bind_043 = Marshal.GetFunctionPointerForDelegate(__delegates.Object_Bind_043);
            } else mpc.Object_Bind_043 = IntPtr.Zero;

            if (this.GetType().GetMethod("Object_Export", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(UInt32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Object_Export_044 = new Delegates.Object_ExportDelegate_044(this.Object_Export);
                mpc.Object_Export_044 = Marshal.GetFunctionPointerForDelegate(__delegates.Object_Export_044);
            } else mpc.Object_Export_044 = IntPtr.Zero;

            if (this.GetType().GetMethod("Object_Import", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Object_Import_045 = new Delegates.Object_ImportDelegate_045(this.Object_Import);
                mpc.Object_Import_045 = Marshal.GetFunctionPointerForDelegate(__delegates.Object_Import_045);
            } else mpc.Object_Import_045 = IntPtr.Zero;

            if (this.GetType().GetMethod("Object_HasContext", new Type[] {typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Object_HasContext_046 = new Delegates.Object_HasContextDelegate_046(this.Object_HasContext);
                mpc.Object_HasContext_046 = Marshal.GetFunctionPointerForDelegate(__delegates.Object_HasContext_046);
            } else mpc.Object_HasContext_046 = IntPtr.Zero;

            if (this.GetType().GetMethod("Object_ShowContext", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Object_ShowContext_047 = new Delegates.Object_ShowContextDelegate_047(this.Object_ShowContext);
                mpc.Object_ShowContext_047 = Marshal.GetFunctionPointerForDelegate(__delegates.Object_ShowContext_047);
            } else mpc.Object_ShowContext_047 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_HasProperties", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_HasProperties_048 = new Delegates.PipelineItem_HasPropertiesDelegate_048(this.PipelineItem_HasProperties);
                mpc.PipelineItem_HasProperties_048 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_HasProperties_048);
            } else mpc.PipelineItem_HasProperties_048 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_ShowProperties", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_ShowProperties_049 = new Delegates.PipelineItem_ShowPropertiesDelegate_049(this.PipelineItem_ShowProperties);
                mpc.PipelineItem_ShowProperties_049 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_ShowProperties_049);
            } else mpc.PipelineItem_ShowProperties_049 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_IsPickable", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_IsPickable_050 = new Delegates.PipelineItem_IsPickableDelegate_050(this.PipelineItem_IsPickable);
                mpc.PipelineItem_IsPickable_050 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_IsPickable_050);
            } else mpc.PipelineItem_IsPickable_050 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_HasShaders", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_HasShaders_051 = new Delegates.PipelineItem_HasShadersDelegate_051(this.PipelineItem_HasShaders);
                mpc.PipelineItem_HasShaders_051 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_HasShaders_051);
            } else mpc.PipelineItem_HasShaders_051 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_OpenInEditor", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_OpenInEditor_052 = new Delegates.PipelineItem_OpenInEditorDelegate_052(this.PipelineItem_OpenInEditor);
                mpc.PipelineItem_OpenInEditor_052 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_OpenInEditor_052);
            } else mpc.PipelineItem_OpenInEditor_052 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_CanHaveChild", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(SHADERedCLR.Wrapper.PipelineItemType) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_CanHaveChild_053 = new Delegates.PipelineItem_CanHaveChildDelegate_053(this.PipelineItem_CanHaveChild);
                mpc.PipelineItem_CanHaveChild_053 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_CanHaveChild_053);
            } else mpc.PipelineItem_CanHaveChild_053 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_GetInputLayoutSize", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_GetInputLayoutSize_054 = new Delegates.PipelineItem_GetInputLayoutSizeDelegate_054(this.PipelineItem_GetInputLayoutSize);
                mpc.PipelineItem_GetInputLayoutSize_054 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_GetInputLayoutSize_054);
            } else mpc.PipelineItem_GetInputLayoutSize_054 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_GetInputLayoutItem", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(Int32), typeof(InputLayoutItem) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_GetInputLayoutItem_055 = new Delegates.PipelineItem_GetInputLayoutItemDelegate_055(this.PipelineItem_GetInputLayoutItem);
                mpc.PipelineItem_GetInputLayoutItem_055 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_GetInputLayoutItem_055);
            } else mpc.PipelineItem_GetInputLayoutItem_055 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_Remove", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_Remove_056 = new Delegates.PipelineItem_RemoveDelegate_056(this.PipelineItem_Remove);
                mpc.PipelineItem_Remove_056 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_Remove_056);
            } else mpc.PipelineItem_Remove_056 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_Rename", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_Rename_057 = new Delegates.PipelineItem_RenameDelegate_057(this.PipelineItem_Rename);
                mpc.PipelineItem_Rename_057 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_Rename_057);
            } else mpc.PipelineItem_Rename_057 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_AddChild", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(SHADERedCLR.Wrapper.PipelineItemType), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_AddChild_058 = new Delegates.PipelineItem_AddChildDelegate_058(this.PipelineItem_AddChild);
                mpc.PipelineItem_AddChild_058 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_AddChild_058);
            } else mpc.PipelineItem_AddChild_058 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_CanHaveChildren", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_CanHaveChildren_059 = new Delegates.PipelineItem_CanHaveChildrenDelegate_059(this.PipelineItem_CanHaveChildren);
                mpc.PipelineItem_CanHaveChildren_059 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_CanHaveChildren_059);
            } else mpc.PipelineItem_CanHaveChildren_059 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_CopyData", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_CopyData_060 = new Delegates.PipelineItem_CopyDataDelegate_060(this.PipelineItem_CopyData);
                mpc.PipelineItem_CopyData_060 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_CopyData_060);
            } else mpc.PipelineItem_CopyData_060 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_Execute", new Type[] {typeof(IntPtr), typeof(SHADERedCLR.Wrapper.PipelineItemType), typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_Execute_061 = new Delegates.PipelineItem_ExecuteDelegate_061(this.PipelineItem_Execute);
                mpc.PipelineItem_Execute_061 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_Execute_061);
            } else mpc.PipelineItem_Execute_061 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_Execute", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_Execute_062 = new Delegates.PipelineItem_ExecuteDelegate_062(this.PipelineItem_Execute);
                mpc.PipelineItem_Execute_062 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_Execute_062);
            } else mpc.PipelineItem_Execute_062 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_GetWorldMatrix", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(ArrPointer16<float>) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_GetWorldMatrix_063 = new Delegates.PipelineItem_GetWorldMatrixDelegate_063(this.PipelineItem_GetWorldMatrix);
                mpc.PipelineItem_GetWorldMatrix_063 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_GetWorldMatrix_063);
            } else mpc.PipelineItem_GetWorldMatrix_063 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_Intersect", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(float) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_Intersect_064 = new Delegates.PipelineItem_IntersectDelegate_064(this.PipelineItem_Intersect);
                mpc.PipelineItem_Intersect_064 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_Intersect_064);
            } else mpc.PipelineItem_Intersect_064 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_GetBoundingBox", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(ArrPointer3<float>), typeof(ArrPointer3<float>) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_GetBoundingBox_065 = new Delegates.PipelineItem_GetBoundingBoxDelegate_065(this.PipelineItem_GetBoundingBox);
                mpc.PipelineItem_GetBoundingBox_065 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_GetBoundingBox_065);
            } else mpc.PipelineItem_GetBoundingBox_065 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_HasContext", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_HasContext_066 = new Delegates.PipelineItem_HasContextDelegate_066(this.PipelineItem_HasContext);
                mpc.PipelineItem_HasContext_066 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_HasContext_066);
            } else mpc.PipelineItem_HasContext_066 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_ShowContext", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_ShowContext_067 = new Delegates.PipelineItem_ShowContextDelegate_067(this.PipelineItem_ShowContext);
                mpc.PipelineItem_ShowContext_067 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_ShowContext_067);
            } else mpc.PipelineItem_ShowContext_067 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_Export", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_Export_068 = new Delegates.PipelineItem_ExportDelegate_068(this.PipelineItem_Export);
                mpc.PipelineItem_Export_068 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_Export_068);
            } else mpc.PipelineItem_Export_068 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_Import", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_Import_069 = new Delegates.PipelineItem_ImportDelegate_069(this.PipelineItem_Import);
                mpc.PipelineItem_Import_069 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_Import_069);
            } else mpc.PipelineItem_Import_069 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_MoveDown", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_MoveDown_070 = new Delegates.PipelineItem_MoveDownDelegate_070(this.PipelineItem_MoveDown);
                mpc.PipelineItem_MoveDown_070 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_MoveDown_070);
            } else mpc.PipelineItem_MoveDown_070 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_MoveUp", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_MoveUp_071 = new Delegates.PipelineItem_MoveUpDelegate_071(this.PipelineItem_MoveUp);
                mpc.PipelineItem_MoveUp_071 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_MoveUp_071);
            } else mpc.PipelineItem_MoveUp_071 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_ApplyGizmoTransform", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_ApplyGizmoTransform_072 = new Delegates.PipelineItem_ApplyGizmoTransformDelegate_072(this.PipelineItem_ApplyGizmoTransform);
                mpc.PipelineItem_ApplyGizmoTransform_072 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_ApplyGizmoTransform_072);
            } else mpc.PipelineItem_ApplyGizmoTransform_072 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_GetTransform", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_GetTransform_073 = new Delegates.PipelineItem_GetTransformDelegate_073(this.PipelineItem_GetTransform);
                mpc.PipelineItem_GetTransform_073 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_GetTransform_073);
            } else mpc.PipelineItem_GetTransform_073 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_DebugVertexExecute", new Type[] {typeof(IntPtr), typeof(SHADERedCLR.Wrapper.PipelineItemType), typeof(IntPtr), typeof(IntPtr), typeof(UInt32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_DebugVertexExecute_074 = new Delegates.PipelineItem_DebugVertexExecuteDelegate_074(this.PipelineItem_DebugVertexExecute);
                mpc.PipelineItem_DebugVertexExecute_074 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_DebugVertexExecute_074);
            } else mpc.PipelineItem_DebugVertexExecute_074 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_DebugVertexExecute", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(float), typeof(float), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_DebugVertexExecute_075 = new Delegates.PipelineItem_DebugVertexExecuteDelegate_075(this.PipelineItem_DebugVertexExecute);
                mpc.PipelineItem_DebugVertexExecute_075 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_DebugVertexExecute_075);
            } else mpc.PipelineItem_DebugVertexExecute_075 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_DebugInstanceExecute", new Type[] {typeof(IntPtr), typeof(SHADERedCLR.Wrapper.PipelineItemType), typeof(IntPtr), typeof(IntPtr), typeof(UInt32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_DebugInstanceExecute_076 = new Delegates.PipelineItem_DebugInstanceExecuteDelegate_076(this.PipelineItem_DebugInstanceExecute);
                mpc.PipelineItem_DebugInstanceExecute_076 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_DebugInstanceExecute_076);
            } else mpc.PipelineItem_DebugInstanceExecute_076 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_DebugInstanceExecute", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(float), typeof(float), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_DebugInstanceExecute_077 = new Delegates.PipelineItem_DebugInstanceExecuteDelegate_077(this.PipelineItem_DebugInstanceExecute);
                mpc.PipelineItem_DebugInstanceExecute_077 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_DebugInstanceExecute_077);
            } else mpc.PipelineItem_DebugInstanceExecute_077 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_GetVBO", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_GetVBO_078 = new Delegates.PipelineItem_GetVBODelegate_078(this.PipelineItem_GetVBO);
                mpc.PipelineItem_GetVBO_078 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_GetVBO_078);
            } else mpc.PipelineItem_GetVBO_078 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_GetVBOStride", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_GetVBOStride_079 = new Delegates.PipelineItem_GetVBOStrideDelegate_079(this.PipelineItem_GetVBOStride);
                mpc.PipelineItem_GetVBOStride_079 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_GetVBOStride_079);
            } else mpc.PipelineItem_GetVBOStride_079 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_CanChangeVariables", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_CanChangeVariables_080 = new Delegates.PipelineItem_CanChangeVariablesDelegate_080(this.PipelineItem_CanChangeVariables);
                mpc.PipelineItem_CanChangeVariables_080 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_CanChangeVariables_080);
            } else mpc.PipelineItem_CanChangeVariables_080 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_IsDebuggable", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_IsDebuggable_081 = new Delegates.PipelineItem_IsDebuggableDelegate_081(this.PipelineItem_IsDebuggable);
                mpc.PipelineItem_IsDebuggable_081 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_IsDebuggable_081);
            } else mpc.PipelineItem_IsDebuggable_081 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_IsStageDebuggable", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(SHADERedCLR.Wrapper.ShaderStage) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_IsStageDebuggable_082 = new Delegates.PipelineItem_IsStageDebuggableDelegate_082(this.PipelineItem_IsStageDebuggable);
                mpc.PipelineItem_IsStageDebuggable_082 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_IsStageDebuggable_082);
            } else mpc.PipelineItem_IsStageDebuggable_082 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_DebugExecute", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr), typeof(Int32), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_DebugExecute_083 = new Delegates.PipelineItem_DebugExecuteDelegate_083(this.PipelineItem_DebugExecute);
                mpc.PipelineItem_DebugExecute_083 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_DebugExecute_083);
            } else mpc.PipelineItem_DebugExecute_083 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_GetTopology", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_GetTopology_084 = new Delegates.PipelineItem_GetTopologyDelegate_084(this.PipelineItem_GetTopology);
                mpc.PipelineItem_GetTopology_084 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_GetTopology_084);
            } else mpc.PipelineItem_GetTopology_084 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_GetVariableCount", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_GetVariableCount_085 = new Delegates.PipelineItem_GetVariableCountDelegate_085(this.PipelineItem_GetVariableCount);
                mpc.PipelineItem_GetVariableCount_085 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_GetVariableCount_085);
            } else mpc.PipelineItem_GetVariableCount_085 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_GetVariableName", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(UInt32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_GetVariableName_086 = new Delegates.PipelineItem_GetVariableNameDelegate_086(this.PipelineItem_GetVariableName);
                mpc.PipelineItem_GetVariableName_086 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_GetVariableName_086);
            } else mpc.PipelineItem_GetVariableName_086 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_GetVariableType", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(UInt32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_GetVariableType_087 = new Delegates.PipelineItem_GetVariableTypeDelegate_087(this.PipelineItem_GetVariableType);
                mpc.PipelineItem_GetVariableType_087 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_GetVariableType_087);
            } else mpc.PipelineItem_GetVariableType_087 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_GetVariableValueFloat", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(UInt32), typeof(Int32), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_GetVariableValueFloat_088 = new Delegates.PipelineItem_GetVariableValueFloatDelegate_088(this.PipelineItem_GetVariableValueFloat);
                mpc.PipelineItem_GetVariableValueFloat_088 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_GetVariableValueFloat_088);
            } else mpc.PipelineItem_GetVariableValueFloat_088 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_GetVariableValueInteger", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(UInt32), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_GetVariableValueInteger_089 = new Delegates.PipelineItem_GetVariableValueIntegerDelegate_089(this.PipelineItem_GetVariableValueInteger);
                mpc.PipelineItem_GetVariableValueInteger_089 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_GetVariableValueInteger_089);
            } else mpc.PipelineItem_GetVariableValueInteger_089 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_GetVariableValueBoolean", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(UInt32), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_GetVariableValueBoolean_090 = new Delegates.PipelineItem_GetVariableValueBooleanDelegate_090(this.PipelineItem_GetVariableValueBoolean);
                mpc.PipelineItem_GetVariableValueBoolean_090 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_GetVariableValueBoolean_090);
            } else mpc.PipelineItem_GetVariableValueBoolean_090 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_GetSPIRVSize", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(SHADERedCLR.Wrapper.ShaderStage) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_GetSPIRVSize_091 = new Delegates.PipelineItem_GetSPIRVSizeDelegate_091(this.PipelineItem_GetSPIRVSize);
                mpc.PipelineItem_GetSPIRVSize_091 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_GetSPIRVSize_091);
            } else mpc.PipelineItem_GetSPIRVSize_091 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_GetSPIRV", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(SHADERedCLR.Wrapper.ShaderStage) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_GetSPIRV_092 = new Delegates.PipelineItem_GetSPIRVDelegate_092(this.PipelineItem_GetSPIRV);
                mpc.PipelineItem_GetSPIRV_092 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_GetSPIRV_092);
            } else mpc.PipelineItem_GetSPIRV_092 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_DebugPrepareVariables", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_DebugPrepareVariables_093 = new Delegates.PipelineItem_DebugPrepareVariablesDelegate_093(this.PipelineItem_DebugPrepareVariables);
                mpc.PipelineItem_DebugPrepareVariables_093 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_DebugPrepareVariables_093);
            } else mpc.PipelineItem_DebugPrepareVariables_093 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_DebugUsesCustomTextures", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_DebugUsesCustomTextures_094 = new Delegates.PipelineItem_DebugUsesCustomTexturesDelegate_094(this.PipelineItem_DebugUsesCustomTextures);
                mpc.PipelineItem_DebugUsesCustomTextures_094 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_DebugUsesCustomTextures_094);
            } else mpc.PipelineItem_DebugUsesCustomTextures_094 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_DebugGetTexture", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(Int32), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_DebugGetTexture_095 = new Delegates.PipelineItem_DebugGetTextureDelegate_095(this.PipelineItem_DebugGetTexture);
                mpc.PipelineItem_DebugGetTexture_095 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_DebugGetTexture_095);
            } else mpc.PipelineItem_DebugGetTexture_095 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_DebugGetTextureSize", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(Int32), typeof(IntPtr), typeof(Int32), typeof(Int32), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_DebugGetTextureSize_096 = new Delegates.PipelineItem_DebugGetTextureSizeDelegate_096(this.PipelineItem_DebugGetTextureSize);
                mpc.PipelineItem_DebugGetTextureSize_096 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_DebugGetTextureSize_096);
            } else mpc.PipelineItem_DebugGetTextureSize_096 = IntPtr.Zero;

            if (this.GetType().GetMethod("Options_HasSection", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Options_HasSection_097 = new Delegates.Options_HasSectionDelegate_097(this.Options_HasSection);
                mpc.Options_HasSection_097 = Marshal.GetFunctionPointerForDelegate(__delegates.Options_HasSection_097);
            } else mpc.Options_HasSection_097 = IntPtr.Zero;

            if (this.GetType().GetMethod("Options_RenderSection", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Options_RenderSection_098 = new Delegates.Options_RenderSectionDelegate_098(this.Options_RenderSection);
                mpc.Options_RenderSection_098 = Marshal.GetFunctionPointerForDelegate(__delegates.Options_RenderSection_098);
            } else mpc.Options_RenderSection_098 = IntPtr.Zero;

            if (this.GetType().GetMethod("Options_Parse", new Type[] {typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Options_Parse_099 = new Delegates.Options_ParseDelegate_099(this.Options_Parse);
                mpc.Options_Parse_099 = Marshal.GetFunctionPointerForDelegate(__delegates.Options_Parse_099);
            } else mpc.Options_Parse_099 = IntPtr.Zero;

            if (this.GetType().GetMethod("Options_GetCount", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Options_GetCount_100 = new Delegates.Options_GetCountDelegate_100(this.Options_GetCount);
                mpc.Options_GetCount_100 = Marshal.GetFunctionPointerForDelegate(__delegates.Options_GetCount_100);
            } else mpc.Options_GetCount_100 = IntPtr.Zero;

            if (this.GetType().GetMethod("Options_GetKey", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Options_GetKey_101 = new Delegates.Options_GetKeyDelegate_101(this.Options_GetKey);
                mpc.Options_GetKey_101 = Marshal.GetFunctionPointerForDelegate(__delegates.Options_GetKey_101);
            } else mpc.Options_GetKey_101 = IntPtr.Zero;

            if (this.GetType().GetMethod("Options_GetValue", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Options_GetValue_102 = new Delegates.Options_GetValueDelegate_102(this.Options_GetValue);
                mpc.Options_GetValue_102 = Marshal.GetFunctionPointerForDelegate(__delegates.Options_GetValue_102);
            } else mpc.Options_GetValue_102 = IntPtr.Zero;

            if (this.GetType().GetMethod("CustomLanguage_GetCount", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.CustomLanguage_GetCount_103 = new Delegates.CustomLanguage_GetCountDelegate_103(this.CustomLanguage_GetCount);
                mpc.CustomLanguage_GetCount_103 = Marshal.GetFunctionPointerForDelegate(__delegates.CustomLanguage_GetCount_103);
            } else mpc.CustomLanguage_GetCount_103 = IntPtr.Zero;

            if (this.GetType().GetMethod("CustomLanguage_GetName", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.CustomLanguage_GetName_104 = new Delegates.CustomLanguage_GetNameDelegate_104(this.CustomLanguage_GetName);
                mpc.CustomLanguage_GetName_104 = Marshal.GetFunctionPointerForDelegate(__delegates.CustomLanguage_GetName_104);
            } else mpc.CustomLanguage_GetName_104 = IntPtr.Zero;

            if (this.GetType().GetMethod("CustomLanguage_CompileToSPIRV", new Type[] {typeof(Int32), typeof(IntPtr), typeof(UInt64), typeof(SHADERedCLR.Wrapper.ShaderStage), typeof(IntPtr), typeof(IntPtr), typeof(UInt64), typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.CustomLanguage_CompileToSPIRV_105 = new Delegates.CustomLanguage_CompileToSPIRVDelegate_105(this.CustomLanguage_CompileToSPIRV);
                mpc.CustomLanguage_CompileToSPIRV_105 = Marshal.GetFunctionPointerForDelegate(__delegates.CustomLanguage_CompileToSPIRV_105);
            } else mpc.CustomLanguage_CompileToSPIRV_105 = IntPtr.Zero;

            if (this.GetType().GetMethod("CustomLanguage_ProcessGeneratedGLSL", new Type[] {typeof(Int32), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.CustomLanguage_ProcessGeneratedGLSL_106 = new Delegates.CustomLanguage_ProcessGeneratedGLSLDelegate_106(this.CustomLanguage_ProcessGeneratedGLSL);
                mpc.CustomLanguage_ProcessGeneratedGLSL_106 = Marshal.GetFunctionPointerForDelegate(__delegates.CustomLanguage_ProcessGeneratedGLSL_106);
            } else mpc.CustomLanguage_ProcessGeneratedGLSL_106 = IntPtr.Zero;

            if (this.GetType().GetMethod("CustomLanguage_SupportsAutoUniforms", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.CustomLanguage_SupportsAutoUniforms_107 = new Delegates.CustomLanguage_SupportsAutoUniformsDelegate_107(this.CustomLanguage_SupportsAutoUniforms);
                mpc.CustomLanguage_SupportsAutoUniforms_107 = Marshal.GetFunctionPointerForDelegate(__delegates.CustomLanguage_SupportsAutoUniforms_107);
            } else mpc.CustomLanguage_SupportsAutoUniforms_107 = IntPtr.Zero;

            if (this.GetType().GetMethod("CustomLanguage_IsDebuggable", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.CustomLanguage_IsDebuggable_108 = new Delegates.CustomLanguage_IsDebuggableDelegate_108(this.CustomLanguage_IsDebuggable);
                mpc.CustomLanguage_IsDebuggable_108 = Marshal.GetFunctionPointerForDelegate(__delegates.CustomLanguage_IsDebuggable_108);
            } else mpc.CustomLanguage_IsDebuggable_108 = IntPtr.Zero;

            if (this.GetType().GetMethod("CustomLanguage_GetDefaultExtension", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.CustomLanguage_GetDefaultExtension_109 = new Delegates.CustomLanguage_GetDefaultExtensionDelegate_109(this.CustomLanguage_GetDefaultExtension);
                mpc.CustomLanguage_GetDefaultExtension_109 = Marshal.GetFunctionPointerForDelegate(__delegates.CustomLanguage_GetDefaultExtension_109);
            } else mpc.CustomLanguage_GetDefaultExtension_109 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderEditor_Supports", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderEditor_Supports_110 = new Delegates.ShaderEditor_SupportsDelegate_110(this.ShaderEditor_Supports);
                mpc.ShaderEditor_Supports_110 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderEditor_Supports_110);
            } else mpc.ShaderEditor_Supports_110 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderEditor_Open", new Type[] {typeof(Int32), typeof(Int32), typeof(IntPtr), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderEditor_Open_111 = new Delegates.ShaderEditor_OpenDelegate_111(this.ShaderEditor_Open);
                mpc.ShaderEditor_Open_111 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderEditor_Open_111);
            } else mpc.ShaderEditor_Open_111 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderEditor_Render", new Type[] {typeof(Int32), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderEditor_Render_112 = new Delegates.ShaderEditor_RenderDelegate_112(this.ShaderEditor_Render);
                mpc.ShaderEditor_Render_112 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderEditor_Render_112);
            } else mpc.ShaderEditor_Render_112 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderEditor_Close", new Type[] {typeof(Int32), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderEditor_Close_113 = new Delegates.ShaderEditor_CloseDelegate_113(this.ShaderEditor_Close);
                mpc.ShaderEditor_Close_113 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderEditor_Close_113);
            } else mpc.ShaderEditor_Close_113 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderEditor_GetContent", new Type[] {typeof(Int32), typeof(Int32), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderEditor_GetContent_114 = new Delegates.ShaderEditor_GetContentDelegate_114(this.ShaderEditor_GetContent);
                mpc.ShaderEditor_GetContent_114 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderEditor_GetContent_114);
            } else mpc.ShaderEditor_GetContent_114 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderEditor_IsChanged", new Type[] {typeof(Int32), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderEditor_IsChanged_115 = new Delegates.ShaderEditor_IsChangedDelegate_115(this.ShaderEditor_IsChanged);
                mpc.ShaderEditor_IsChanged_115 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderEditor_IsChanged_115);
            } else mpc.ShaderEditor_IsChanged_115 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderEditor_ResetChangeState", new Type[] {typeof(Int32), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderEditor_ResetChangeState_116 = new Delegates.ShaderEditor_ResetChangeStateDelegate_116(this.ShaderEditor_ResetChangeState);
                mpc.ShaderEditor_ResetChangeState_116 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderEditor_ResetChangeState_116);
            } else mpc.ShaderEditor_ResetChangeState_116 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderEditor_CanUndo", new Type[] {typeof(Int32), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderEditor_CanUndo_117 = new Delegates.ShaderEditor_CanUndoDelegate_117(this.ShaderEditor_CanUndo);
                mpc.ShaderEditor_CanUndo_117 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderEditor_CanUndo_117);
            } else mpc.ShaderEditor_CanUndo_117 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderEditor_CanRedo", new Type[] {typeof(Int32), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderEditor_CanRedo_118 = new Delegates.ShaderEditor_CanRedoDelegate_118(this.ShaderEditor_CanRedo);
                mpc.ShaderEditor_CanRedo_118 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderEditor_CanRedo_118);
            } else mpc.ShaderEditor_CanRedo_118 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderEditor_Undo", new Type[] {typeof(Int32), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderEditor_Undo_119 = new Delegates.ShaderEditor_UndoDelegate_119(this.ShaderEditor_Undo);
                mpc.ShaderEditor_Undo_119 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderEditor_Undo_119);
            } else mpc.ShaderEditor_Undo_119 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderEditor_Redo", new Type[] {typeof(Int32), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderEditor_Redo_120 = new Delegates.ShaderEditor_RedoDelegate_120(this.ShaderEditor_Redo);
                mpc.ShaderEditor_Redo_120 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderEditor_Redo_120);
            } else mpc.ShaderEditor_Redo_120 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderEditor_Cut", new Type[] {typeof(Int32), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderEditor_Cut_121 = new Delegates.ShaderEditor_CutDelegate_121(this.ShaderEditor_Cut);
                mpc.ShaderEditor_Cut_121 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderEditor_Cut_121);
            } else mpc.ShaderEditor_Cut_121 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderEditor_Paste", new Type[] {typeof(Int32), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderEditor_Paste_122 = new Delegates.ShaderEditor_PasteDelegate_122(this.ShaderEditor_Paste);
                mpc.ShaderEditor_Paste_122 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderEditor_Paste_122);
            } else mpc.ShaderEditor_Paste_122 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderEditor_Copy", new Type[] {typeof(Int32), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderEditor_Copy_123 = new Delegates.ShaderEditor_CopyDelegate_123(this.ShaderEditor_Copy);
                mpc.ShaderEditor_Copy_123 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderEditor_Copy_123);
            } else mpc.ShaderEditor_Copy_123 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderEditor_SelectAll", new Type[] {typeof(Int32), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderEditor_SelectAll_124 = new Delegates.ShaderEditor_SelectAllDelegate_124(this.ShaderEditor_SelectAll);
                mpc.ShaderEditor_SelectAll_124 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderEditor_SelectAll_124);
            } else mpc.ShaderEditor_SelectAll_124 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderEditor_HasStats", new Type[] {typeof(Int32), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderEditor_HasStats_125 = new Delegates.ShaderEditor_HasStatsDelegate_125(this.ShaderEditor_HasStats);
                mpc.ShaderEditor_HasStats_125 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderEditor_HasStats_125);
            } else mpc.ShaderEditor_HasStats_125 = IntPtr.Zero;

            if (this.GetType().GetMethod("CodeEditor_SaveItem", new Type[] {typeof(IntPtr), typeof(Int32), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.CodeEditor_SaveItem_126 = new Delegates.CodeEditor_SaveItemDelegate_126(this.CodeEditor_SaveItem);
                mpc.CodeEditor_SaveItem_126 = Marshal.GetFunctionPointerForDelegate(__delegates.CodeEditor_SaveItem_126);
            } else mpc.CodeEditor_SaveItem_126 = IntPtr.Zero;

            if (this.GetType().GetMethod("CodeEditor_CloseItem", new Type[] {typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.CodeEditor_CloseItem_127 = new Delegates.CodeEditor_CloseItemDelegate_127(this.CodeEditor_CloseItem);
                mpc.CodeEditor_CloseItem_127 = Marshal.GetFunctionPointerForDelegate(__delegates.CodeEditor_CloseItem_127);
            } else mpc.CodeEditor_CloseItem_127 = IntPtr.Zero;

            if (this.GetType().GetMethod("LanguageDefinition_Exists", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.LanguageDefinition_Exists_128 = new Delegates.LanguageDefinition_ExistsDelegate_128(this.LanguageDefinition_Exists);
                mpc.LanguageDefinition_Exists_128 = Marshal.GetFunctionPointerForDelegate(__delegates.LanguageDefinition_Exists_128);
            } else mpc.LanguageDefinition_Exists_128 = IntPtr.Zero;

            if (this.GetType().GetMethod("LanguageDefinition_GetKeywordCount", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.LanguageDefinition_GetKeywordCount_129 = new Delegates.LanguageDefinition_GetKeywordCountDelegate_129(this.LanguageDefinition_GetKeywordCount);
                mpc.LanguageDefinition_GetKeywordCount_129 = Marshal.GetFunctionPointerForDelegate(__delegates.LanguageDefinition_GetKeywordCount_129);
            } else mpc.LanguageDefinition_GetKeywordCount_129 = IntPtr.Zero;

            if (this.GetType().GetMethod("LanguageDefinition_GetKeywords", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.LanguageDefinition_GetKeywords_130 = new Delegates.LanguageDefinition_GetKeywordsDelegate_130(this.LanguageDefinition_GetKeywords);
                mpc.LanguageDefinition_GetKeywords_130 = Marshal.GetFunctionPointerForDelegate(__delegates.LanguageDefinition_GetKeywords_130);
            } else mpc.LanguageDefinition_GetKeywords_130 = IntPtr.Zero;

            if (this.GetType().GetMethod("LanguageDefinition_GetTokenRegexCount", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.LanguageDefinition_GetTokenRegexCount_131 = new Delegates.LanguageDefinition_GetTokenRegexCountDelegate_131(this.LanguageDefinition_GetTokenRegexCount);
                mpc.LanguageDefinition_GetTokenRegexCount_131 = Marshal.GetFunctionPointerForDelegate(__delegates.LanguageDefinition_GetTokenRegexCount_131);
            } else mpc.LanguageDefinition_GetTokenRegexCount_131 = IntPtr.Zero;

            if (this.GetType().GetMethod("LanguageDefinition_GetTokenRegex", new Type[] {typeof(Int32), typeof(SHADERedCLR.Wrapper.TextEditorPaletteIndex), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.LanguageDefinition_GetTokenRegex_132 = new Delegates.LanguageDefinition_GetTokenRegexDelegate_132(this.LanguageDefinition_GetTokenRegex);
                mpc.LanguageDefinition_GetTokenRegex_132 = Marshal.GetFunctionPointerForDelegate(__delegates.LanguageDefinition_GetTokenRegex_132);
            } else mpc.LanguageDefinition_GetTokenRegex_132 = IntPtr.Zero;

            if (this.GetType().GetMethod("LanguageDefinition_GetIdentifierCount", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.LanguageDefinition_GetIdentifierCount_133 = new Delegates.LanguageDefinition_GetIdentifierCountDelegate_133(this.LanguageDefinition_GetIdentifierCount);
                mpc.LanguageDefinition_GetIdentifierCount_133 = Marshal.GetFunctionPointerForDelegate(__delegates.LanguageDefinition_GetIdentifierCount_133);
            } else mpc.LanguageDefinition_GetIdentifierCount_133 = IntPtr.Zero;

            if (this.GetType().GetMethod("LanguageDefinition_GetIdentifier", new Type[] {typeof(Int32), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.LanguageDefinition_GetIdentifier_134 = new Delegates.LanguageDefinition_GetIdentifierDelegate_134(this.LanguageDefinition_GetIdentifier);
                mpc.LanguageDefinition_GetIdentifier_134 = Marshal.GetFunctionPointerForDelegate(__delegates.LanguageDefinition_GetIdentifier_134);
            } else mpc.LanguageDefinition_GetIdentifier_134 = IntPtr.Zero;

            if (this.GetType().GetMethod("LanguageDefinition_GetIdentifierDesc", new Type[] {typeof(Int32), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.LanguageDefinition_GetIdentifierDesc_135 = new Delegates.LanguageDefinition_GetIdentifierDescDelegate_135(this.LanguageDefinition_GetIdentifierDesc);
                mpc.LanguageDefinition_GetIdentifierDesc_135 = Marshal.GetFunctionPointerForDelegate(__delegates.LanguageDefinition_GetIdentifierDesc_135);
            } else mpc.LanguageDefinition_GetIdentifierDesc_135 = IntPtr.Zero;

            if (this.GetType().GetMethod("LanguageDefinition_GetCommentStart", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.LanguageDefinition_GetCommentStart_136 = new Delegates.LanguageDefinition_GetCommentStartDelegate_136(this.LanguageDefinition_GetCommentStart);
                mpc.LanguageDefinition_GetCommentStart_136 = Marshal.GetFunctionPointerForDelegate(__delegates.LanguageDefinition_GetCommentStart_136);
            } else mpc.LanguageDefinition_GetCommentStart_136 = IntPtr.Zero;

            if (this.GetType().GetMethod("LanguageDefinition_GetCommentEnd", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.LanguageDefinition_GetCommentEnd_137 = new Delegates.LanguageDefinition_GetCommentEndDelegate_137(this.LanguageDefinition_GetCommentEnd);
                mpc.LanguageDefinition_GetCommentEnd_137 = Marshal.GetFunctionPointerForDelegate(__delegates.LanguageDefinition_GetCommentEnd_137);
            } else mpc.LanguageDefinition_GetCommentEnd_137 = IntPtr.Zero;

            if (this.GetType().GetMethod("LanguageDefinition_GetLineComment", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.LanguageDefinition_GetLineComment_138 = new Delegates.LanguageDefinition_GetLineCommentDelegate_138(this.LanguageDefinition_GetLineComment);
                mpc.LanguageDefinition_GetLineComment_138 = Marshal.GetFunctionPointerForDelegate(__delegates.LanguageDefinition_GetLineComment_138);
            } else mpc.LanguageDefinition_GetLineComment_138 = IntPtr.Zero;

            if (this.GetType().GetMethod("LanguageDefinition_IsCaseSensitive", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.LanguageDefinition_IsCaseSensitive_139 = new Delegates.LanguageDefinition_IsCaseSensitiveDelegate_139(this.LanguageDefinition_IsCaseSensitive);
                mpc.LanguageDefinition_IsCaseSensitive_139 = Marshal.GetFunctionPointerForDelegate(__delegates.LanguageDefinition_IsCaseSensitive_139);
            } else mpc.LanguageDefinition_IsCaseSensitive_139 = IntPtr.Zero;

            if (this.GetType().GetMethod("LanguageDefinition_GetAutoIndent", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.LanguageDefinition_GetAutoIndent_140 = new Delegates.LanguageDefinition_GetAutoIndentDelegate_140(this.LanguageDefinition_GetAutoIndent);
                mpc.LanguageDefinition_GetAutoIndent_140 = Marshal.GetFunctionPointerForDelegate(__delegates.LanguageDefinition_GetAutoIndent_140);
            } else mpc.LanguageDefinition_GetAutoIndent_140 = IntPtr.Zero;

            if (this.GetType().GetMethod("LanguageDefinition_GetName", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.LanguageDefinition_GetName_141 = new Delegates.LanguageDefinition_GetNameDelegate_141(this.LanguageDefinition_GetName);
                mpc.LanguageDefinition_GetName_141 = Marshal.GetFunctionPointerForDelegate(__delegates.LanguageDefinition_GetName_141);
            } else mpc.LanguageDefinition_GetName_141 = IntPtr.Zero;

            if (this.GetType().GetMethod("LanguageDefinition_GetNameAbbreviation", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.LanguageDefinition_GetNameAbbreviation_142 = new Delegates.LanguageDefinition_GetNameAbbreviationDelegate_142(this.LanguageDefinition_GetNameAbbreviation);
                mpc.LanguageDefinition_GetNameAbbreviation_142 = Marshal.GetFunctionPointerForDelegate(__delegates.LanguageDefinition_GetNameAbbreviation_142);
            } else mpc.LanguageDefinition_GetNameAbbreviation_142 = IntPtr.Zero;

            if (this.GetType().GetMethod("Autocomplete_GetCount", new Type[] {typeof(SHADERedCLR.Wrapper.ShaderStage) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Autocomplete_GetCount_143 = new Delegates.Autocomplete_GetCountDelegate_143(this.Autocomplete_GetCount);
                mpc.Autocomplete_GetCount_143 = Marshal.GetFunctionPointerForDelegate(__delegates.Autocomplete_GetCount_143);
            } else mpc.Autocomplete_GetCount_143 = IntPtr.Zero;

            if (this.GetType().GetMethod("Autocomplete_GetDisplayString", new Type[] {typeof(SHADERedCLR.Wrapper.ShaderStage), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Autocomplete_GetDisplayString_144 = new Delegates.Autocomplete_GetDisplayStringDelegate_144(this.Autocomplete_GetDisplayString);
                mpc.Autocomplete_GetDisplayString_144 = Marshal.GetFunctionPointerForDelegate(__delegates.Autocomplete_GetDisplayString_144);
            } else mpc.Autocomplete_GetDisplayString_144 = IntPtr.Zero;

            if (this.GetType().GetMethod("Autocomplete_GetSearchString", new Type[] {typeof(SHADERedCLR.Wrapper.ShaderStage), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Autocomplete_GetSearchString_145 = new Delegates.Autocomplete_GetSearchStringDelegate_145(this.Autocomplete_GetSearchString);
                mpc.Autocomplete_GetSearchString_145 = Marshal.GetFunctionPointerForDelegate(__delegates.Autocomplete_GetSearchString_145);
            } else mpc.Autocomplete_GetSearchString_145 = IntPtr.Zero;

            if (this.GetType().GetMethod("Autocomplete_GetValue", new Type[] {typeof(SHADERedCLR.Wrapper.ShaderStage), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.Autocomplete_GetValue_146 = new Delegates.Autocomplete_GetValueDelegate_146(this.Autocomplete_GetValue);
                mpc.Autocomplete_GetValue_146 = Marshal.GetFunctionPointerForDelegate(__delegates.Autocomplete_GetValue_146);
            } else mpc.Autocomplete_GetValue_146 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderFilePath_GetCount", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderFilePath_GetCount_147 = new Delegates.ShaderFilePath_GetCountDelegate_147(this.ShaderFilePath_GetCount);
                mpc.ShaderFilePath_GetCount_147 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderFilePath_GetCount_147);
            } else mpc.ShaderFilePath_GetCount_147 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderFilePath_Get", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderFilePath_Get_148 = new Delegates.ShaderFilePath_GetDelegate_148(this.ShaderFilePath_Get);
                mpc.ShaderFilePath_Get_148 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderFilePath_Get_148);
            } else mpc.ShaderFilePath_Get_148 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderFilePath_HasChanged", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderFilePath_HasChanged_149 = new Delegates.ShaderFilePath_HasChangedDelegate_149(this.ShaderFilePath_HasChanged);
                mpc.ShaderFilePath_HasChanged_149 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderFilePath_HasChanged_149);
            } else mpc.ShaderFilePath_HasChanged_149 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderFilePath_Update", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderFilePath_Update_150 = new Delegates.ShaderFilePath_UpdateDelegate_150(this.ShaderFilePath_Update);
                mpc.ShaderFilePath_Update_150 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderFilePath_Update_150);
            } else mpc.ShaderFilePath_Update_150 = IntPtr.Zero;

            if (this.GetType().GetMethod("HandleDropFile", new Type[] {typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.HandleDropFile_151 = new Delegates.HandleDropFileDelegate_151(this.HandleDropFile);
                mpc.HandleDropFile_151 = Marshal.GetFunctionPointerForDelegate(__delegates.HandleDropFile_151);
            } else mpc.HandleDropFile_151 = IntPtr.Zero;

            if (this.GetType().GetMethod("HandleRecompile", new Type[] {typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.HandleRecompile_152 = new Delegates.HandleRecompileDelegate_152(this.HandleRecompile);
                mpc.HandleRecompile_152 = Marshal.GetFunctionPointerForDelegate(__delegates.HandleRecompile_152);
            } else mpc.HandleRecompile_152 = IntPtr.Zero;

            if (this.GetType().GetMethod("HandleRecompileFromSource", new Type[] {typeof(IntPtr), typeof(Int32), typeof(IntPtr), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.HandleRecompileFromSource_153 = new Delegates.HandleRecompileFromSourceDelegate_153(this.HandleRecompileFromSource);
                mpc.HandleRecompileFromSource_153 = Marshal.GetFunctionPointerForDelegate(__delegates.HandleRecompileFromSource_153);
            } else mpc.HandleRecompileFromSource_153 = IntPtr.Zero;

            if (this.GetType().GetMethod("HandleShortcut", new Type[] {typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.HandleShortcut_154 = new Delegates.HandleShortcutDelegate_154(this.HandleShortcut);
                mpc.HandleShortcut_154 = Marshal.GetFunctionPointerForDelegate(__delegates.HandleShortcut_154);
            } else mpc.HandleShortcut_154 = IntPtr.Zero;

            if (this.GetType().GetMethod("HandlePluginMessage", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.HandlePluginMessage_155 = new Delegates.HandlePluginMessageDelegate_155(this.HandlePluginMessage);
                mpc.HandlePluginMessage_155 = Marshal.GetFunctionPointerForDelegate(__delegates.HandlePluginMessage_155);
            } else mpc.HandlePluginMessage_155 = IntPtr.Zero;

            if (this.GetType().GetMethod("HandleApplicationEvent", new Type[] {typeof(SHADERedCLR.Wrapper.ApplicationEvent), typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.HandleApplicationEvent_156 = new Delegates.HandleApplicationEventDelegate_156(this.HandleApplicationEvent);
                mpc.HandleApplicationEvent_156 = Marshal.GetFunctionPointerForDelegate(__delegates.HandleApplicationEvent_156);
            } else mpc.HandleApplicationEvent_156 = IntPtr.Zero;

            if (this.GetType().GetMethod("HandleNotification", new Type[] {typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.HandleNotification_157 = new Delegates.HandleNotificationDelegate_157(this.HandleNotification);
                mpc.HandleNotification_157 = Marshal.GetFunctionPointerForDelegate(__delegates.HandleNotification_157);
            } else mpc.HandleNotification_157 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_SupportsImmediateMode", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(SHADERedCLR.Wrapper.ShaderStage) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_SupportsImmediateMode_158 = new Delegates.PipelineItem_SupportsImmediateModeDelegate_158(this.PipelineItem_SupportsImmediateMode);
                mpc.PipelineItem_SupportsImmediateMode_158 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_SupportsImmediateMode_158);
            } else mpc.PipelineItem_SupportsImmediateMode_158 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_HasCustomImmediateModeCompiler", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(SHADERedCLR.Wrapper.ShaderStage) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_HasCustomImmediateModeCompiler_159 = new Delegates.PipelineItem_HasCustomImmediateModeCompilerDelegate_159(this.PipelineItem_HasCustomImmediateModeCompiler);
                mpc.PipelineItem_HasCustomImmediateModeCompiler_159 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_HasCustomImmediateModeCompiler_159);
            } else mpc.PipelineItem_HasCustomImmediateModeCompiler_159 = IntPtr.Zero;

            if (this.GetType().GetMethod("PipelineItem_ImmediateModeCompile", new Type[] {typeof(IntPtr), typeof(IntPtr), typeof(SHADERedCLR.Wrapper.ShaderStage), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PipelineItem_ImmediateModeCompile_160 = new Delegates.PipelineItem_ImmediateModeCompileDelegate_160(this.PipelineItem_ImmediateModeCompile);
                mpc.PipelineItem_ImmediateModeCompile_160 = Marshal.GetFunctionPointerForDelegate(__delegates.PipelineItem_ImmediateModeCompile_160);
            } else mpc.PipelineItem_ImmediateModeCompile_160 = IntPtr.Zero;

            if (this.GetType().GetMethod("ImmediateMode_GetSPIRVSize", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ImmediateMode_GetSPIRVSize_161 = new Delegates.ImmediateMode_GetSPIRVSizeDelegate_161(this.ImmediateMode_GetSPIRVSize);
                mpc.ImmediateMode_GetSPIRVSize_161 = Marshal.GetFunctionPointerForDelegate(__delegates.ImmediateMode_GetSPIRVSize_161);
            } else mpc.ImmediateMode_GetSPIRVSize_161 = IntPtr.Zero;

            if (this.GetType().GetMethod("ImmediateMode_GetSPIRV", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ImmediateMode_GetSPIRV_162 = new Delegates.ImmediateMode_GetSPIRVDelegate_162(this.ImmediateMode_GetSPIRV);
                mpc.ImmediateMode_GetSPIRV_162 = Marshal.GetFunctionPointerForDelegate(__delegates.ImmediateMode_GetSPIRV_162);
            } else mpc.ImmediateMode_GetSPIRV_162 = IntPtr.Zero;

            if (this.GetType().GetMethod("ImmediateMode_GetVariableCount", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ImmediateMode_GetVariableCount_163 = new Delegates.ImmediateMode_GetVariableCountDelegate_163(this.ImmediateMode_GetVariableCount);
                mpc.ImmediateMode_GetVariableCount_163 = Marshal.GetFunctionPointerForDelegate(__delegates.ImmediateMode_GetVariableCount_163);
            } else mpc.ImmediateMode_GetVariableCount_163 = IntPtr.Zero;

            if (this.GetType().GetMethod("ImmediateMode_GetVariableName", new Type[] {typeof(UInt32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ImmediateMode_GetVariableName_164 = new Delegates.ImmediateMode_GetVariableNameDelegate_164(this.ImmediateMode_GetVariableName);
                mpc.ImmediateMode_GetVariableName_164 = Marshal.GetFunctionPointerForDelegate(__delegates.ImmediateMode_GetVariableName_164);
            } else mpc.ImmediateMode_GetVariableName_164 = IntPtr.Zero;

            if (this.GetType().GetMethod("ImmediateMode_GetResultID", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ImmediateMode_GetResultID_165 = new Delegates.ImmediateMode_GetResultIDDelegate_165(this.ImmediateMode_GetResultID);
                mpc.ImmediateMode_GetResultID_165 = Marshal.GetFunctionPointerForDelegate(__delegates.ImmediateMode_GetResultID_165);
            } else mpc.ImmediateMode_GetResultID_165 = IntPtr.Zero;

            if (this.GetType().GetMethod("PluginManager_RegisterPlugins", new Type[] { }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.PluginManager_RegisterPlugins_166 = new Delegates.PluginManager_RegisterPluginsDelegate_166(this.PluginManager_RegisterPlugins);
                mpc.PluginManager_RegisterPlugins_166 = Marshal.GetFunctionPointerForDelegate(__delegates.PluginManager_RegisterPlugins_166);
            } else mpc.PluginManager_RegisterPlugins_166 = IntPtr.Zero;

            if (this.GetType().GetMethod("CustomLanguage_CompileToSPIRV2", new Type[] {typeof(IntPtr), typeof(Int32), typeof(IntPtr), typeof(UInt64), typeof(SHADERedCLR.Wrapper.ShaderStage), typeof(IntPtr), typeof(IntPtr), typeof(UInt64), typeof(IntPtr), typeof(IntPtr) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.CustomLanguage_CompileToSPIRV2_167 = new Delegates.CustomLanguage_CompileToSPIRV2Delegate_167(this.CustomLanguage_CompileToSPIRV2);
                mpc.CustomLanguage_CompileToSPIRV2_167 = Marshal.GetFunctionPointerForDelegate(__delegates.CustomLanguage_CompileToSPIRV2_167);
            } else mpc.CustomLanguage_CompileToSPIRV2_167 = IntPtr.Zero;

            if (this.GetType().GetMethod("ShaderEditor_SetLineIndicator", new Type[] {typeof(Int32), typeof(Int32), typeof(Int32) }).DeclaringType != typeof(PluginWrapper)) {
                __delegates.ShaderEditor_SetLineIndicator_168 = new Delegates.ShaderEditor_SetLineIndicatorDelegate_168(this.ShaderEditor_SetLineIndicator);
                mpc.ShaderEditor_SetLineIndicator_168 = Marshal.GetFunctionPointerForDelegate(__delegates.ShaderEditor_SetLineIndicator_168);
            } else mpc.ShaderEditor_SetLineIndicator_168 = IntPtr.Zero;

            return mpc;
        }
    }
}
