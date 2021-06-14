#pragma once
#include <PluginAPI/Plugin.h>

class PluginWrapper : public ed::IPlugin3 {
public:
    struct UnmanagedPointerCollection {
        void* Renderer_000 = nullptr;
        void* Messages_001 = nullptr;
        void* Project_002 = nullptr;
        void* UI_003 = nullptr;
        void* ObjectManager_004 = nullptr;
        void* PipelineManager_005 = nullptr;
        void* Plugins_006 = nullptr;
        void* Debugger_007 = nullptr;
        void* AddObject_008 = nullptr;
        void* AddCustomPipelineItem_009 = nullptr;
        void* AddMessage_010 = nullptr;
        void* CreateRenderTexture_011 = nullptr;
        void* CreateImage_012 = nullptr;
        void* ResizeRenderTexture_013 = nullptr;
        void* ResizeImage_014 = nullptr;
        void* ExistsObject_015 = nullptr;
        void* RemoveGlobalObject_016 = nullptr;
        void* GetProjectPath_017 = nullptr;
        void* GetRelativePath_018 = nullptr;
        void* GetProjectFilename_019 = nullptr;
        void* GetProjectDirectory_020 = nullptr;
        void* IsProjectModified_021 = nullptr;
        void* ModifyProject_022 = nullptr;
        void* OpenProject_023 = nullptr;
        void* SaveProject_024 = nullptr;
        void* SaveAsProject_025 = nullptr;
        void* IsPaused_026 = nullptr;
        void* Pause_027 = nullptr;
        void* GetWindowColorTexture_028 = nullptr;
        void* GetWindowDepthTexture_029 = nullptr;
        void* GetLastRenderSize_030 = nullptr;
        void* Render_031 = nullptr;
        void* ExistsPipelineItem_032 = nullptr;
        void* GetPipelineItem_033 = nullptr;
        void* BindShaderPassVariables_034 = nullptr;
        void* GetViewMatrix_035 = nullptr;
        void* GetProjectionMatrix_036 = nullptr;
        void* GetOrthographicMatrix_037 = nullptr;
        void* GetViewportSize_038 = nullptr;
        void* AdvanceTimer_039 = nullptr;
        void* GetMousePosition_040 = nullptr;
        void* GetFrameIndex_041 = nullptr;
        void* GetTime_042 = nullptr;
        void* SetTime_043 = nullptr;
        void* SetGeometryTransform_044 = nullptr;
        void* SetMousePosition_045 = nullptr;
        void* SetKeysWASD_046 = nullptr;
        void* SetFrameIndex_047 = nullptr;
        void* GetDPI_048 = nullptr;
        void* FileExists_049 = nullptr;
        void* ClearMessageGroup_050 = nullptr;
        void* Log_051 = nullptr;
        void* GetObjectCount_052 = nullptr;
        void* GetObjectName_053 = nullptr;
        void* IsTexture_054 = nullptr;
        void* GetTexture_055 = nullptr;
        void* GetFlippedTexture_056 = nullptr;
        void* GetTextureSize_057 = nullptr;
        void* BindDefaultState_058 = nullptr;
        void* OpenInCodeEditor_059 = nullptr;
        void* GetPipelineItemCount_060 = nullptr;
        void* GetPipelineItemType_061 = nullptr;
        void* GetPipelineItemByIndex_062 = nullptr;
        void* GetPipelineItemName_063 = nullptr;
        void* GetPipelineItemPluginOwner_064 = nullptr;
        void* GetPipelineItemVariableCount_065 = nullptr;
        void* GetPipelineItemVariableName_066 = nullptr;
        void* GetPipelineItemVariableValue_067 = nullptr;
        void* GetPipelineItemVariableType_068 = nullptr;
        void* AddPipelineItemVariable_069 = nullptr;
        void* GetPipelineItemChildrenCount_070 = nullptr;
        void* GetPipelineItemChild_071 = nullptr;
        void* SetPipelineItemPosition_072 = nullptr;
        void* SetPipelineItemRotation_073 = nullptr;
        void* SetPipelineItemScale_074 = nullptr;
        void* GetPipelineItemPosition_075 = nullptr;
        void* GetPipelineItemRotation_076 = nullptr;
        void* GetPipelineItemScale_077 = nullptr;
        void* DEPRECATED_GetOpenDirectoryDialog_078 = nullptr;
        void* DEPRECATED_GetOpenFileDialog_079 = nullptr;
        void* DEPRECATED_GetSaveFileDialog_080 = nullptr;
        void* GetIncludePathCount_081 = nullptr;
        void* GetIncludePath_082 = nullptr;
        void* GetMessagesCurrentItem_083 = nullptr;
        void* OnEditorContentChange_084 = nullptr;
        void* GetPipelineItemSPIRV_085 = nullptr;
        void* RegisterShortcut_086 = nullptr;
        void* GetSettingsBoolean_087 = nullptr;
        void* GetSettingsString_088 = nullptr;
        void* GetSettingsInteger_089 = nullptr;
        void* GetSettingsFloat_090 = nullptr;
        void* GetPreviewUIRect_091 = nullptr;
        void* GetPlugin_092 = nullptr;
        void* GetPluginListSize_093 = nullptr;
        void* GetPluginName_094 = nullptr;
        void* SendPluginMessage_095 = nullptr;
        void* BroadcastPluginMessage_096 = nullptr;
        void* ToggleFullscreen_097 = nullptr;
        void* IsFullscreen_098 = nullptr;
        void* TogglePerformanceMode_099 = nullptr;
        void* IsInPerformanceMode_100 = nullptr;
        void* PushNotification_101 = nullptr;
        void* DebuggerJump_102 = nullptr;
        void* DebuggerContinue_103 = nullptr;
        void* DebuggerStep_104 = nullptr;
        void* DebuggerStepInto_105 = nullptr;
        void* DebuggerStepOut_106 = nullptr;
        void* DebuggerCheckBreakpoint_107 = nullptr;
        void* DebuggerIsDebugging_108 = nullptr;
        void* DebuggerGetCurrentLine_109 = nullptr;
        void* IsRenderTexture_110 = nullptr;
        void* GetRenderTextureSize_111 = nullptr;
        void* GetDepthTexture_112 = nullptr;
        void* ScaleSize_113 = nullptr;
        void* GetHostIPluginMaxVersion_114 = nullptr;
        void* ImGuiFileDialogOpen_115 = nullptr;
        void* ImGuiDirectoryDialogOpen_116 = nullptr;
        void* ImGuiFileDialogIsDone_117 = nullptr;
        void* ImGuiFileDialogClose_118 = nullptr;
        void* ImGuiFileDialogGetResult_119 = nullptr;
        void* ImGuiFileDialogGetPath_120 = nullptr;
        void* DebuggerImmediate_121 = nullptr;
        void* RegisterPlugin_122 = nullptr;
        void* PluginInstance = nullptr;
    };
    struct ManagedPointerCollection {
        void* Init_000 = nullptr;
        void* InitUI_001 = nullptr;
        void* OnEvent_002 = nullptr;
        void* Update_003 = nullptr;
        void* Destroy_004 = nullptr;
        void* IsRequired_005 = nullptr;
        void* IsVersionCompatible_006 = nullptr;
        void* BeginRender_007 = nullptr;
        void* EndRender_008 = nullptr;
        void* Project_BeginLoad_009 = nullptr;
        void* Project_EndLoad_010 = nullptr;
        void* Project_BeginSave_011 = nullptr;
        void* Project_EndSave_012 = nullptr;
        void* Project_HasAdditionalData_013 = nullptr;
        void* Project_ExportAdditionalData_014 = nullptr;
        void* Project_ImportAdditionalData_015 = nullptr;
        void* Project_CopyFilesOnSave_016 = nullptr;
        void* HasCustomMenuItem_017 = nullptr;
        void* HasMenuItems_018 = nullptr;
        void* ShowMenuItems_019 = nullptr;
        void* HasContextItems_020 = nullptr;
        void* ShowContextItems_021 = nullptr;
        void* SystemVariables_GetNameCount_022 = nullptr;
        void* SystemVariables_GetName_023 = nullptr;
        void* SystemVariables_HasLastFrame_024 = nullptr;
        void* SystemVariables_UpdateValue_025 = nullptr;
        void* VariableFunctions_GetNameCount_026 = nullptr;
        void* VariableFunctions_GetName_027 = nullptr;
        void* VariableFunctions_ShowArgumentEdit_028 = nullptr;
        void* VariableFunctions_UpdateValue_029 = nullptr;
        void* VariableFunctions_GetArgsSize_030 = nullptr;
        void* VariableFunctions_InitArguments_031 = nullptr;
        void* VariableFunctions_ExportArguments_032 = nullptr;
        void* VariableFunctions_ImportArguments_033 = nullptr;
        void* Object_HasPreview_034 = nullptr;
        void* Object_ShowPreview_035 = nullptr;
        void* Object_IsBindable_036 = nullptr;
        void* Object_IsBindableUAV_037 = nullptr;
        void* Object_Remove_038 = nullptr;
        void* Object_HasExtendedPreview_039 = nullptr;
        void* Object_ShowExtendedPreview_040 = nullptr;
        void* Object_HasProperties_041 = nullptr;
        void* Object_ShowProperties_042 = nullptr;
        void* Object_Bind_043 = nullptr;
        void* Object_Export_044 = nullptr;
        void* Object_Import_045 = nullptr;
        void* Object_HasContext_046 = nullptr;
        void* Object_ShowContext_047 = nullptr;
        void* PipelineItem_HasProperties_048 = nullptr;
        void* PipelineItem_ShowProperties_049 = nullptr;
        void* PipelineItem_IsPickable_050 = nullptr;
        void* PipelineItem_HasShaders_051 = nullptr;
        void* PipelineItem_OpenInEditor_052 = nullptr;
        void* PipelineItem_CanHaveChild_053 = nullptr;
        void* PipelineItem_GetInputLayoutSize_054 = nullptr;
        void* PipelineItem_GetInputLayoutItem_055 = nullptr;
        void* PipelineItem_Remove_056 = nullptr;
        void* PipelineItem_Rename_057 = nullptr;
        void* PipelineItem_AddChild_058 = nullptr;
        void* PipelineItem_CanHaveChildren_059 = nullptr;
        void* PipelineItem_CopyData_060 = nullptr;
        void* PipelineItem_Execute_061 = nullptr;
        void* PipelineItem_Execute_062 = nullptr;
        void* PipelineItem_GetWorldMatrix_063 = nullptr;
        void* PipelineItem_Intersect_064 = nullptr;
        void* PipelineItem_GetBoundingBox_065 = nullptr;
        void* PipelineItem_HasContext_066 = nullptr;
        void* PipelineItem_ShowContext_067 = nullptr;
        void* PipelineItem_Export_068 = nullptr;
        void* PipelineItem_Import_069 = nullptr;
        void* PipelineItem_MoveDown_070 = nullptr;
        void* PipelineItem_MoveUp_071 = nullptr;
        void* PipelineItem_ApplyGizmoTransform_072 = nullptr;
        void* PipelineItem_GetTransform_073 = nullptr;
        void* PipelineItem_DebugVertexExecute_074 = nullptr;
        void* PipelineItem_DebugVertexExecute_075 = nullptr;
        void* PipelineItem_DebugInstanceExecute_076 = nullptr;
        void* PipelineItem_DebugInstanceExecute_077 = nullptr;
        void* PipelineItem_GetVBO_078 = nullptr;
        void* PipelineItem_GetVBOStride_079 = nullptr;
        void* PipelineItem_CanChangeVariables_080 = nullptr;
        void* PipelineItem_IsDebuggable_081 = nullptr;
        void* PipelineItem_IsStageDebuggable_082 = nullptr;
        void* PipelineItem_DebugExecute_083 = nullptr;
        void* PipelineItem_GetTopology_084 = nullptr;
        void* PipelineItem_GetVariableCount_085 = nullptr;
        void* PipelineItem_GetVariableName_086 = nullptr;
        void* PipelineItem_GetVariableType_087 = nullptr;
        void* PipelineItem_GetVariableValueFloat_088 = nullptr;
        void* PipelineItem_GetVariableValueInteger_089 = nullptr;
        void* PipelineItem_GetVariableValueBoolean_090 = nullptr;
        void* PipelineItem_GetSPIRVSize_091 = nullptr;
        void* PipelineItem_GetSPIRV_092 = nullptr;
        void* PipelineItem_DebugPrepareVariables_093 = nullptr;
        void* PipelineItem_DebugUsesCustomTextures_094 = nullptr;
        void* PipelineItem_DebugGetTexture_095 = nullptr;
        void* PipelineItem_DebugGetTextureSize_096 = nullptr;
        void* Options_HasSection_097 = nullptr;
        void* Options_RenderSection_098 = nullptr;
        void* Options_Parse_099 = nullptr;
        void* Options_GetCount_100 = nullptr;
        void* Options_GetKey_101 = nullptr;
        void* Options_GetValue_102 = nullptr;
        void* CustomLanguage_GetCount_103 = nullptr;
        void* CustomLanguage_GetName_104 = nullptr;
        void* CustomLanguage_CompileToSPIRV_105 = nullptr;
        void* CustomLanguage_ProcessGeneratedGLSL_106 = nullptr;
        void* CustomLanguage_SupportsAutoUniforms_107 = nullptr;
        void* CustomLanguage_IsDebuggable_108 = nullptr;
        void* CustomLanguage_GetDefaultExtension_109 = nullptr;
        void* ShaderEditor_Supports_110 = nullptr;
        void* ShaderEditor_Open_111 = nullptr;
        void* ShaderEditor_Render_112 = nullptr;
        void* ShaderEditor_Close_113 = nullptr;
        void* ShaderEditor_GetContent_114 = nullptr;
        void* ShaderEditor_IsChanged_115 = nullptr;
        void* ShaderEditor_ResetChangeState_116 = nullptr;
        void* ShaderEditor_CanUndo_117 = nullptr;
        void* ShaderEditor_CanRedo_118 = nullptr;
        void* ShaderEditor_Undo_119 = nullptr;
        void* ShaderEditor_Redo_120 = nullptr;
        void* ShaderEditor_Cut_121 = nullptr;
        void* ShaderEditor_Paste_122 = nullptr;
        void* ShaderEditor_Copy_123 = nullptr;
        void* ShaderEditor_SelectAll_124 = nullptr;
        void* ShaderEditor_HasStats_125 = nullptr;
        void* CodeEditor_SaveItem_126 = nullptr;
        void* CodeEditor_CloseItem_127 = nullptr;
        void* LanguageDefinition_Exists_128 = nullptr;
        void* LanguageDefinition_GetKeywordCount_129 = nullptr;
        void* LanguageDefinition_GetKeywords_130 = nullptr;
        void* LanguageDefinition_GetTokenRegexCount_131 = nullptr;
        void* LanguageDefinition_GetTokenRegex_132 = nullptr;
        void* LanguageDefinition_GetIdentifierCount_133 = nullptr;
        void* LanguageDefinition_GetIdentifier_134 = nullptr;
        void* LanguageDefinition_GetIdentifierDesc_135 = nullptr;
        void* LanguageDefinition_GetCommentStart_136 = nullptr;
        void* LanguageDefinition_GetCommentEnd_137 = nullptr;
        void* LanguageDefinition_GetLineComment_138 = nullptr;
        void* LanguageDefinition_IsCaseSensitive_139 = nullptr;
        void* LanguageDefinition_GetAutoIndent_140 = nullptr;
        void* LanguageDefinition_GetName_141 = nullptr;
        void* LanguageDefinition_GetNameAbbreviation_142 = nullptr;
        void* Autocomplete_GetCount_143 = nullptr;
        void* Autocomplete_GetDisplayString_144 = nullptr;
        void* Autocomplete_GetSearchString_145 = nullptr;
        void* Autocomplete_GetValue_146 = nullptr;
        void* ShaderFilePath_GetCount_147 = nullptr;
        void* ShaderFilePath_Get_148 = nullptr;
        void* ShaderFilePath_HasChanged_149 = nullptr;
        void* ShaderFilePath_Update_150 = nullptr;
        void* HandleDropFile_151 = nullptr;
        void* HandleRecompile_152 = nullptr;
        void* HandleRecompileFromSource_153 = nullptr;
        void* HandleShortcut_154 = nullptr;
        void* HandlePluginMessage_155 = nullptr;
        void* HandleApplicationEvent_156 = nullptr;
        void* HandleNotification_157 = nullptr;
        void* PipelineItem_SupportsImmediateMode_158 = nullptr;
        void* PipelineItem_HasCustomImmediateModeCompiler_159 = nullptr;
        void* PipelineItem_ImmediateModeCompile_160 = nullptr;
        void* ImmediateMode_GetSPIRVSize_161 = nullptr;
        void* ImmediateMode_GetSPIRV_162 = nullptr;
        void* ImmediateMode_GetVariableCount_163 = nullptr;
        void* ImmediateMode_GetVariableName_164 = nullptr;
        void* ImmediateMode_GetResultID_165 = nullptr;
        void* PluginManager_RegisterPlugins_166 = nullptr;
        void* __SetUPC = nullptr;
    };


    UnmanagedPointerCollection  m_sUPC;
    ManagedPointerCollection    m_pMPC;

    void InitUPC();

    PluginWrapper(ManagedPointerCollection& a_pMPC);
    ~PluginWrapper();
    bool Init(bool isWeb, int sedVersion) override;

    void InitUI(void* ctx) override;

    void OnEvent(void* e) override;

    void Update(float delta) override;

    void Destroy() override;

    bool IsRequired() override;

    bool IsVersionCompatible(int version) override;

    void BeginRender() override;

    void EndRender() override;

    void Project_BeginLoad() override;

    void Project_EndLoad() override;

    void Project_BeginSave() override;

    void Project_EndSave() override;

    bool Project_HasAdditionalData() override;

    const char* Project_ExportAdditionalData() override;

    void Project_ImportAdditionalData(const char* xml) override;

    void Project_CopyFilesOnSave(const char* dir) override;

    bool HasCustomMenuItem() override;

    bool HasMenuItems(const char* name) override;

    void ShowMenuItems(const char* name) override;

    bool HasContextItems(const char* name) override;

    void ShowContextItems(const char* name, void* owner, void* extraData) override;

    int SystemVariables_GetNameCount(ed::plugin::VariableType varType) override;

    const char* SystemVariables_GetName(ed::plugin::VariableType varType, int index) override;

    bool SystemVariables_HasLastFrame(char* name, ed::plugin::VariableType varType) override;

    void SystemVariables_UpdateValue(char* data, char* name, ed::plugin::VariableType varType, bool isLastFrame) override;

    int VariableFunctions_GetNameCount(ed::plugin::VariableType vtype) override;

    const char* VariableFunctions_GetName(ed::plugin::VariableType varType, int index) override;

    bool VariableFunctions_ShowArgumentEdit(char* fname, char* args, ed::plugin::VariableType vtype) override;

    void VariableFunctions_UpdateValue(char* data, char* args, char* fname, ed::plugin::VariableType varType) override;

    int VariableFunctions_GetArgsSize(char* fname, ed::plugin::VariableType varType) override;

    void VariableFunctions_InitArguments(char* args, char* fname, ed::plugin::VariableType vtype) override;

    const char* VariableFunctions_ExportArguments(char* fname, ed::plugin::VariableType vtype, char* args) override;

    void VariableFunctions_ImportArguments(char* fname, ed::plugin::VariableType vtype, char* args, const char* argsString) override;

    bool Object_HasPreview(const char* type) override;

    void Object_ShowPreview(const char* type, void* data, unsigned int id) override;

    bool Object_IsBindable(const char* type) override;

    bool Object_IsBindableUAV(const char* type) override;

    void Object_Remove(const char* name, const char* type, void* data, unsigned int id) override;

    bool Object_HasExtendedPreview(const char* type) override;

    void Object_ShowExtendedPreview(const char* type, void* data, unsigned int id) override;

    bool Object_HasProperties(const char* type) override;

    void Object_ShowProperties(const char* type, void* data, unsigned int id) override;

    void Object_Bind(const char* type, void* data, unsigned int id) override;

    const char* Object_Export(char* type, void* data, unsigned int id) override;

    void Object_Import(const char* name, const char* type, const char* argsString) override;

    bool Object_HasContext(const char* type) override;

    void Object_ShowContext(const char* type, void* data) override;

    bool PipelineItem_HasProperties(const char* type, void* data) override;

    void PipelineItem_ShowProperties(const char* type, void* data) override;

    bool PipelineItem_IsPickable(const char* type, void* data) override;

    bool PipelineItem_HasShaders(const char* type, void* data) override;

    void PipelineItem_OpenInEditor(const char* type, void* data) override;

    bool PipelineItem_CanHaveChild(const char* type, void* data, ed::plugin::PipelineItemType itemType) override;

    int PipelineItem_GetInputLayoutSize(const char* type, void* data) override;

    void PipelineItem_GetInputLayoutItem(const char* type, void* data, int index, ed::plugin::InputLayoutItem& out) override;

    void PipelineItem_Remove(const char* itemName, const char* type, void* data) override;

    void PipelineItem_Rename(const char* oldName, const char* newName) override;

    void PipelineItem_AddChild(const char* owner, const char* name, ed::plugin::PipelineItemType type, void* data) override;

    bool PipelineItem_CanHaveChildren(const char* type, void* data) override;

    void* PipelineItem_CopyData(const char* type, void* data) override;

    void PipelineItem_Execute(void* Owner, ed::plugin::PipelineItemType OwnerType, const char* type, void* data) override;

    void PipelineItem_Execute(const char* type, void* data, void* children, int count) override;

    void PipelineItem_GetWorldMatrix(const char* type, void* data, float (&pMat)[16]) override;

    bool PipelineItem_Intersect(const char* type, void* data, const float* rayOrigin, const float* rayDir, float& hitDist) override;

    void PipelineItem_GetBoundingBox(const char* type, void* data, float (&minPos)[3], float (&maxPos)[3]) override;

    bool PipelineItem_HasContext(const char* type, void* data) override;

    void PipelineItem_ShowContext(const char* type, void* data) override;

    const char* PipelineItem_Export(const char* type, void* data) override;

    void* PipelineItem_Import(const char* ownerName, const char* name, const char* type, const char* argsString) override;

    void PipelineItem_MoveDown(void* ownerData, const char* ownerType, const char* itemName) override;

    void PipelineItem_MoveUp(void* ownerData, const char* ownerType, const char* itemName) override;

    void PipelineItem_ApplyGizmoTransform(const char* type, void* data, float* transl, float* scale, float* rota) override;

    void PipelineItem_GetTransform(const char* type, void* data, float* transl, float* scale, float* rota) override;

    void PipelineItem_DebugVertexExecute(void* Owner, ed::plugin::PipelineItemType OwnerType, const char* type, void* data, unsigned int colorVarLoc) override;

    int PipelineItem_DebugVertexExecute(const char* type, void* data, const char* childName, float rx, float ry, int vertexGroup) override;

    void PipelineItem_DebugInstanceExecute(void* Owner, ed::plugin::PipelineItemType OwnerType, const char* type, void* data, unsigned int colorVarLoc) override;

    int PipelineItem_DebugInstanceExecute(const char* type, void* data, const char* childName, float rx, float ry, int vertexGroup) override;

    unsigned int PipelineItem_GetVBO(const char* type, void* data) override;

    unsigned int PipelineItem_GetVBOStride(const char* type, void* data) override;

    bool PipelineItem_CanChangeVariables(const char* type, void* data) override;

    bool PipelineItem_IsDebuggable(const char* type, void* data) override;

    bool PipelineItem_IsStageDebuggable(const char* type, void* data, ed::plugin::ShaderStage stage) override;

    void PipelineItem_DebugExecute(const char* type, void* data, void* children, int count, int* debugID) override;

    unsigned int PipelineItem_GetTopology(const char* type, void* data) override;

    unsigned int PipelineItem_GetVariableCount(const char* type, void* data) override;

    const char* PipelineItem_GetVariableName(const char* type, void* data, unsigned int variable) override;

    ed::plugin::VariableType PipelineItem_GetVariableType(const char* type, void* data, unsigned int variable) override;

    float PipelineItem_GetVariableValueFloat(const char* type, void* data, unsigned int variable, int col, int row) override;

    int PipelineItem_GetVariableValueInteger(const char* type, void* data, unsigned int variable, int col) override;

    bool PipelineItem_GetVariableValueBoolean(const char* type, void* data, unsigned int variable, int col) override;

    unsigned int PipelineItem_GetSPIRVSize(const char* type, void* data, ed::plugin::ShaderStage stage) override;

    unsigned int* PipelineItem_GetSPIRV(const char* type, void* data, ed::plugin::ShaderStage stage) override;

    void PipelineItem_DebugPrepareVariables(const char* type, void* data, const char* name) override;

    bool PipelineItem_DebugUsesCustomTextures(const char* type, void* data) override;

    unsigned int PipelineItem_DebugGetTexture(const char* type, void* data, int loc, const char* variableName) override;

    void PipelineItem_DebugGetTextureSize(const char* type, void* data, int loc, const char* variableName, int& x, int& y, int& z) override;

    bool Options_HasSection() override;

    void Options_RenderSection() override;

    void Options_Parse(const char* key, const char* val) override;

    int Options_GetCount() override;

    const char* Options_GetKey(int index) override;

    const char* Options_GetValue(int index) override;

    int CustomLanguage_GetCount() override;

    const char* CustomLanguage_GetName(int langID) override;

    const unsigned int* CustomLanguage_CompileToSPIRV(int langID, const char* src, size_t src_len, ed::plugin::ShaderStage stage, const char* entry, ed::plugin::ShaderMacro* macros, size_t macroCount, size_t* spv_length, bool* compiled) override;

    const char* CustomLanguage_ProcessGeneratedGLSL(int langID, const char* src) override;

    bool CustomLanguage_SupportsAutoUniforms(int langID) override;

    bool CustomLanguage_IsDebuggable(int langID) override;

    const char* CustomLanguage_GetDefaultExtension(int langID) override;

    bool ShaderEditor_Supports(int langID) override;

    void ShaderEditor_Open(int langID, int editorID, const char* data, int dataLen) override;

    void ShaderEditor_Render(int langID, int editorID) override;

    void ShaderEditor_Close(int langID, int editorID) override;

    const char* ShaderEditor_GetContent(int langID, int editorID, size_t* dataLength) override;

    bool ShaderEditor_IsChanged(int langID, int editorID) override;

    void ShaderEditor_ResetChangeState(int langID, int editorID) override;

    bool ShaderEditor_CanUndo(int langID, int editorID) override;

    bool ShaderEditor_CanRedo(int langID, int editorID) override;

    void ShaderEditor_Undo(int langID, int editorID) override;

    void ShaderEditor_Redo(int langID, int editorID) override;

    void ShaderEditor_Cut(int langID, int editorID) override;

    void ShaderEditor_Paste(int langID, int editorID) override;

    void ShaderEditor_Copy(int langID, int editorID) override;

    void ShaderEditor_SelectAll(int langID, int editorID) override;

    bool ShaderEditor_HasStats(int langID, int editorID) override;

    void CodeEditor_SaveItem(const char* src, int srcLen, const char* path) override;

    void CodeEditor_CloseItem(const char* path) override;

    bool LanguageDefinition_Exists(int id) override;

    int LanguageDefinition_GetKeywordCount(int id) override;

    const char** LanguageDefinition_GetKeywords(int id) override;

    int LanguageDefinition_GetTokenRegexCount(int id) override;

    const char* LanguageDefinition_GetTokenRegex(int index, ed::plugin::TextEditorPaletteIndex& palIndex, int id) override;

    int LanguageDefinition_GetIdentifierCount(int id) override;

    const char* LanguageDefinition_GetIdentifier(int index, int id) override;

    const char* LanguageDefinition_GetIdentifierDesc(int index, int id) override;

    const char* LanguageDefinition_GetCommentStart(int id) override;

    const char* LanguageDefinition_GetCommentEnd(int id) override;

    const char* LanguageDefinition_GetLineComment(int id) override;

    bool LanguageDefinition_IsCaseSensitive(int id) override;

    bool LanguageDefinition_GetAutoIndent(int id) override;

    const char* LanguageDefinition_GetName(int id) override;

    const char* LanguageDefinition_GetNameAbbreviation(int id) override;

    int Autocomplete_GetCount(ed::plugin::ShaderStage stage) override;

    const char* Autocomplete_GetDisplayString(ed::plugin::ShaderStage stage, int index) override;

    const char* Autocomplete_GetSearchString(ed::plugin::ShaderStage stage, int index) override;

    const char* Autocomplete_GetValue(ed::plugin::ShaderStage stage, int index) override;

    int ShaderFilePath_GetCount() override;

    const char* ShaderFilePath_Get(int index) override;

    bool ShaderFilePath_HasChanged() override;

    void ShaderFilePath_Update() override;

    bool HandleDropFile(const char* filename) override;

    void HandleRecompile(const char* itemName) override;

    void HandleRecompileFromSource(const char* itemName, int sid, const char* shaderCode, int shaderSize) override;

    void HandleShortcut(const char* name) override;

    void HandlePluginMessage(const char* sender, char* msg, int msgLen) override;

    void HandleApplicationEvent(ed::plugin::ApplicationEvent event, void* data1, void* data2) override;

    void HandleNotification(int id) override;

    bool PipelineItem_SupportsImmediateMode(const char* type, void* data, ed::plugin::ShaderStage stage) override;

    bool PipelineItem_HasCustomImmediateModeCompiler(const char* type, void* data, ed::plugin::ShaderStage stage) override;

    bool PipelineItem_ImmediateModeCompile(const char* type, void* data, ed::plugin::ShaderStage stage, const char* expression) override;

    unsigned int ImmediateMode_GetSPIRVSize() override;

    unsigned int* ImmediateMode_GetSPIRV() override;

    unsigned int ImmediateMode_GetVariableCount() override;

    const char* ImmediateMode_GetVariableName(unsigned int index) override;

    int ImmediateMode_GetResultID() override;

    void PluginManager_RegisterPlugins() override;
}; // class PluginWrapper
