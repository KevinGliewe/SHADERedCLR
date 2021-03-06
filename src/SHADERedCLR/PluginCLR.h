#pragma once

#include <PluginAPI/Plugin.h>

#include <vector>
#include <string>

namespace sc
{
	extern void* p_pModuleHandle;

    class PluginCLR : public ed::IPlugin3
    {
		void* m_pManagedPluginManager = nullptr;
    public:
		virtual bool Init(bool isWeb, int sedVersion);
		virtual void InitUI(void* ctx) { }
		virtual void OnEvent(void* e) { }
		virtual void Update(float delta) { }
		virtual void Destroy() { printf("PluginCLR::Destroy()"); }

		virtual bool IsRequired() { return 0; }
		virtual bool IsVersionCompatible(int version) { return 0; }

		virtual void BeginRender() { }
		virtual void EndRender() { }

		virtual void Project_BeginLoad() { }
		virtual void Project_EndLoad() { }
		virtual void Project_BeginSave() { }
		virtual void Project_EndSave() { }
		virtual bool Project_HasAdditionalData() { return 0; }
		virtual const char* Project_ExportAdditionalData() { return 0; }
		virtual void Project_ImportAdditionalData(const char* xml) { }
		virtual void Project_CopyFilesOnSave(const char* dir) { }

		/* list: file, newproject, project, createitem, window, custom */
		virtual bool HasCustomMenuItem() { return false; }
		virtual bool HasMenuItems(const char* name) { return false; }
		virtual void ShowMenuItems(const char* name) { }

		/* list: pipeline, shaderpass_add (owner = ShaderPass), pluginitem_add (owner = char* ItemType, extraData = PluginItemData) objects, editcode (owner = char* ItemName) */
		virtual bool HasContextItems(const char* name) { return 0; }
		virtual void ShowContextItems(const char* name, void* owner = nullptr, void* extraData = nullptr) { }

		// system variable methods
		virtual int SystemVariables_GetNameCount(ed::plugin::VariableType varType) { return 0; }
		virtual const char* SystemVariables_GetName(ed::plugin::VariableType varType, int index) { return 0; }
		virtual bool SystemVariables_HasLastFrame(char* name, ed::plugin::VariableType varType) { return 0; }
		virtual void SystemVariables_UpdateValue(char* data, char* name, ed::plugin::VariableType varType, bool isLastFrame) { }

		// function variables
		virtual int VariableFunctions_GetNameCount(ed::plugin::VariableType vtype) { return 0; }
		virtual const char* VariableFunctions_GetName(ed::plugin::VariableType varType, int index) { return 0; }
		virtual bool VariableFunctions_ShowArgumentEdit(char* fname, char* args, ed::plugin::VariableType vtype) { return 0; }
		virtual void VariableFunctions_UpdateValue(char* data, char* args, char* fname, ed::plugin::VariableType varType) { }
		virtual int VariableFunctions_GetArgsSize(char* fname, ed::plugin::VariableType varType) { return 0; }
		virtual void VariableFunctions_InitArguments(char* args, char* fname, ed::plugin::VariableType vtype) { }
		virtual const char* VariableFunctions_ExportArguments(char* fname, ed::plugin::VariableType vtype, char* args) { return 0; }
		virtual void VariableFunctions_ImportArguments(char* fname, ed::plugin::VariableType vtype, char* args, const char* argsString) { }

		// object manager stuff
		virtual bool Object_HasPreview(const char* type) { return 0; }
		virtual void Object_ShowPreview(const char* type, void* data, unsigned int id) { }
		virtual bool Object_IsBindable(const char* type) { return 0; }
		virtual bool Object_IsBindableUAV(const char* type) { return 0; }
		virtual void Object_Remove(const char* name, const char* type, void* data, unsigned int id) { }
		virtual bool Object_HasExtendedPreview(const char* type) { return 0; }
		virtual void Object_ShowExtendedPreview(const char* type, void* data, unsigned int id) { }
		virtual bool Object_HasProperties(const char* type) { return 0; }
		virtual void Object_ShowProperties(const char* type, void* data, unsigned int id) { }
		virtual void Object_Bind(const char* type, void* data, unsigned int id) { }
		virtual const char* Object_Export(char* type, void* data, unsigned int id) { return 0; }
		virtual void Object_Import(const char* name, const char* type, const char* argsString) { }
		virtual bool Object_HasContext(const char* type) { return 0; }
		virtual void Object_ShowContext(const char* type, void* data) { }

		// pipeline item stuff
		virtual bool PipelineItem_HasProperties(const char* type, void* data) { return 0; }
		virtual void PipelineItem_ShowProperties(const char* type, void* data) { }
		virtual bool PipelineItem_IsPickable(const char* type, void* data) { return 0; }
		virtual bool PipelineItem_HasShaders(const char* type, void* data) { return 0; }
		virtual void PipelineItem_OpenInEditor(const char* type, void* data) { }
		virtual bool PipelineItem_CanHaveChild(const char* type, void* data, ed::plugin::PipelineItemType itemType) { return 0; }
		virtual int PipelineItem_GetInputLayoutSize(const char* type, void* data) { return 0; }
		virtual void PipelineItem_GetInputLayoutItem(const char* type, void* data, int index, ed::plugin::InputLayoutItem& out) { }
		virtual void PipelineItem_Remove(const char* itemName, const char* type, void* data) { }
		virtual void PipelineItem_Rename(const char* oldName, const char* newName) { }
		virtual void PipelineItem_AddChild(const char* owner, const char* name, ed::plugin::PipelineItemType type, void* data) { }
		virtual bool PipelineItem_CanHaveChildren(const char* type, void* data) { return 0; }
		virtual void* PipelineItem_CopyData(const char* type, void* data) { return 0; }
		virtual void PipelineItem_Execute(void* Owner, ed::plugin::PipelineItemType OwnerType, const char* type, void* data) { }
		virtual void PipelineItem_Execute(const char* type, void* data, void* children, int count) { }
		virtual void PipelineItem_GetWorldMatrix(const char* type, void* data, float(&pMat)[16]) { }
		virtual bool PipelineItem_Intersect(const char* type, void* data, const float* rayOrigin, const float* rayDir, float& hitDist) { return 0; }
		virtual void PipelineItem_GetBoundingBox(const char* type, void* data, float(&minPos)[3], float(&maxPos)[3]) { }
		virtual bool PipelineItem_HasContext(const char* type, void* data) { return 0; }
		virtual void PipelineItem_ShowContext(const char* type, void* data) { }
		virtual const char* PipelineItem_Export(const char* type, void* data) { return 0; }
		virtual void* PipelineItem_Import(const char* ownerName, const char* name, const char* type, const char* argsString) { return 0; }
		virtual void PipelineItem_MoveDown(void* ownerData, const char* ownerType, const char* itemName) { }
		virtual void PipelineItem_MoveUp(void* ownerData, const char* ownerType, const char* itemName) { }
		virtual void PipelineItem_ApplyGizmoTransform(const char* type, void* data, float* transl, float* scale, float* rota) { }
		virtual void PipelineItem_GetTransform(const char* type, void* data, float* transl, float* scale, float* rota) { }
		virtual void PipelineItem_DebugVertexExecute(void* Owner, ed::plugin::PipelineItemType OwnerType, const char* type, void* data, unsigned int colorVarLoc) { }
		virtual int PipelineItem_DebugVertexExecute(const char* type, void* data, const char* childName, float rx, float ry, int vertexGroup) { return 0; }
		virtual void PipelineItem_DebugInstanceExecute(void* Owner, ed::plugin::PipelineItemType OwnerType, const char* type, void* data, unsigned int colorVarLoc) { }
		virtual int PipelineItem_DebugInstanceExecute(const char* type, void* data, const char* childName, float rx, float ry, int vertexGroup) { return 0; }
		virtual unsigned int PipelineItem_GetVBO(const char* type, void* data) { return 0; }
		virtual unsigned int PipelineItem_GetVBOStride(const char* type, void* data) { return 0; }
		virtual bool PipelineItem_CanChangeVariables(const char* type, void* data) { return 0; }
		virtual bool PipelineItem_IsDebuggable(const char* type, void* data) { return 0; }
		virtual bool PipelineItem_IsStageDebuggable(const char* type, void* data, ed::plugin::ShaderStage stage) { return 0; }
		virtual void PipelineItem_DebugExecute(const char* type, void* data, void* children, int count, int* debugID) { }
		virtual unsigned int PipelineItem_GetTopology(const char* type, void* data) { return 0; }
		virtual unsigned int PipelineItem_GetVariableCount(const char* type, void* data) { return 0; }
		virtual const char* PipelineItem_GetVariableName(const char* type, void* data, unsigned int variable) { return 0; }
		virtual ed::plugin::VariableType PipelineItem_GetVariableType(const char* type, void* data, unsigned int variable) { return ed::plugin::VariableType::Count; }
		virtual float PipelineItem_GetVariableValueFloat(const char* type, void* data, unsigned int variable, int col, int row) { return 0; }
		virtual int PipelineItem_GetVariableValueInteger(const char* type, void* data, unsigned int variable, int col) { return 0; }
		virtual bool PipelineItem_GetVariableValueBoolean(const char* type, void* data, unsigned int variable, int col) { return 0; }
		virtual unsigned int PipelineItem_GetSPIRVSize(const char* type, void* data, ed::plugin::ShaderStage stage) { return 0; }
		virtual unsigned int* PipelineItem_GetSPIRV(const char* type, void* data, ed::plugin::ShaderStage stage) { return 0; }
		virtual void PipelineItem_DebugPrepareVariables(const char* type, void* data, const char* name) { }
		virtual bool PipelineItem_DebugUsesCustomTextures(const char* type, void* data) { return 0; }
		virtual unsigned int PipelineItem_DebugGetTexture(const char* type, void* data, int loc, const char* variableName) { return 0; }
		virtual void PipelineItem_DebugGetTextureSize(const char* type, void* data, int loc, const char* variableName, int& x, int& y, int& z) { }

		// options
		virtual bool Options_HasSection() { return false; }
		virtual void Options_RenderSection() { }
		virtual void Options_Parse(const char* key, const char* val) { }
		virtual int Options_GetCount() { return 0; }
		virtual const char* Options_GetKey(int index) { return nullptr; }
		virtual const char* Options_GetValue(int index) { return nullptr; }

		// languages
		virtual int CustomLanguage_GetCount() { return 0; }
		virtual const char* CustomLanguage_GetName(int langID) { return 0; }
		virtual const unsigned int* CustomLanguage_CompileToSPIRV(int langID, const char* src, size_t src_len, ed::plugin::ShaderStage stage, const char* entry, ed::plugin::ShaderMacro* macros, size_t macroCount, size_t* spv_length, bool* compiled) { return 0; }
		virtual const char* CustomLanguage_ProcessGeneratedGLSL(int langID, const char* src) { return 0; }
		virtual bool CustomLanguage_SupportsAutoUniforms(int langID) { return 0; }
		virtual bool CustomLanguage_IsDebuggable(int langID) { return 0; }
		virtual const char* CustomLanguage_GetDefaultExtension(int langID) { return 0; }

		// language text editor
		virtual bool ShaderEditor_Supports(int langID) { return 0; }
		virtual void ShaderEditor_Open(int langID, int editorID, const char* data, int dataLen) { }
		virtual void ShaderEditor_Render(int langID, int editorID) { }
		virtual void ShaderEditor_Close(int langID, int editorID) { }
		virtual const char* ShaderEditor_GetContent(int langID, int editorID, size_t* dataLength) { return 0; }
		virtual bool ShaderEditor_IsChanged(int langID, int editorID) { return 0; }
		virtual void ShaderEditor_ResetChangeState(int langID, int editorID) { }
		virtual bool ShaderEditor_CanUndo(int langID, int editorID) { return 0; }
		virtual bool ShaderEditor_CanRedo(int langID, int editorID) { return 0; }
		virtual void ShaderEditor_Undo(int langID, int editorID) { }
		virtual void ShaderEditor_Redo(int langID, int editorID) { }
		virtual void ShaderEditor_Cut(int langID, int editorID) { }
		virtual void ShaderEditor_Paste(int langID, int editorID) { }
		virtual void ShaderEditor_Copy(int langID, int editorID) { }
		virtual void ShaderEditor_SelectAll(int langID, int editorID) { }
		virtual bool ShaderEditor_HasStats(int langID, int editorID) { return 0; }

		// code editor
		virtual void CodeEditor_SaveItem(const char* src, int srcLen, const char* path) { }
		virtual void CodeEditor_CloseItem(const char* path) { }
		virtual bool LanguageDefinition_Exists(int id) { return 0; }
		virtual int LanguageDefinition_GetKeywordCount(int id) { return 0; }
		virtual const char** LanguageDefinition_GetKeywords(int id) { return 0; }
		virtual int LanguageDefinition_GetTokenRegexCount(int id) { return 0; }
		virtual const char* LanguageDefinition_GetTokenRegex(int index, ed::plugin::TextEditorPaletteIndex& palIndex, int id) { return 0; }
		virtual int LanguageDefinition_GetIdentifierCount(int id) { return 0; }
		virtual const char* LanguageDefinition_GetIdentifier(int index, int id) { return 0; }
		virtual const char* LanguageDefinition_GetIdentifierDesc(int index, int id) { return 0; }
		virtual const char* LanguageDefinition_GetCommentStart(int id) { return 0; }
		virtual const char* LanguageDefinition_GetCommentEnd(int id) { return 0; }
		virtual const char* LanguageDefinition_GetLineComment(int id) { return 0; }
		virtual bool LanguageDefinition_IsCaseSensitive(int id) { return 0; }
		virtual bool LanguageDefinition_GetAutoIndent(int id) { return 0; }
		virtual const char* LanguageDefinition_GetName(int id) { return 0; }
		virtual const char* LanguageDefinition_GetNameAbbreviation(int id) { return 0; }

		// autocomplete
		virtual int Autocomplete_GetCount(ed::plugin::ShaderStage stage) { return 0; }
		virtual const char* Autocomplete_GetDisplayString(ed::plugin::ShaderStage stage, int index) { return 0; }
		virtual const char* Autocomplete_GetSearchString(ed::plugin::ShaderStage stage, int index) { return 0; }
		virtual const char* Autocomplete_GetValue(ed::plugin::ShaderStage stage, int index) { return 0; }

		// file change checks
		virtual int ShaderFilePath_GetCount() { return 0; }
		virtual const char* ShaderFilePath_Get(int index) { return 0; }
		virtual bool ShaderFilePath_HasChanged() { return 0; }
		virtual void ShaderFilePath_Update() { }

		// misc
		virtual bool HandleDropFile(const char* filename) { return 0; }
		virtual void HandleRecompile(const char* itemName) { }
		virtual void HandleRecompileFromSource(const char* itemName, int sid, const char* shaderCode, int shaderSize) { }
		virtual void HandleShortcut(const char* name) { }
		virtual void HandlePluginMessage(const char* sender, char* msg, int msgLen) { }
		virtual void HandleApplicationEvent(ed::plugin::ApplicationEvent event, void* data1, void* data2) { }
		virtual void HandleNotification(int id) { }

		// IPlugin2
		virtual bool PipelineItem_SupportsImmediateMode(const char* type, void* data, ed::plugin::ShaderStage stage) { return false; }
		virtual bool PipelineItem_HasCustomImmediateModeCompiler(const char* type, void* data, ed::plugin::ShaderStage stage) { return false; }
		virtual bool PipelineItem_ImmediateModeCompile(const char* type, void* data, ed::plugin::ShaderStage stage, const char* expression) { return false; }

		// Immediate mode
		virtual unsigned int ImmediateMode_GetSPIRVSize() { return 0; }
		virtual unsigned int* ImmediateMode_GetSPIRV() { return 0; }
		virtual unsigned int ImmediateMode_GetVariableCount() { return 0; }
		virtual const char* ImmediateMode_GetVariableName(unsigned int index) { return 0; }
		virtual int ImmediateMode_GetResultID() { return 0; }

		// IPlugin3
		virtual void PluginManager_RegisterPlugins();
		virtual const unsigned int* CustomLanguage_CompileToSPIRV2(void* item, int langID, const char* src, size_t src_len, ed::plugin::ShaderStage stage, const char* entry, ed::plugin::ShaderMacro* macros, size_t macroCount, size_t* spv_length, bool* compiled) { return nullptr; }
		virtual void ShaderEditor_SetLineIndicator(int langID, int editorID, int line) { }

		PluginCLR() { }
		~PluginCLR();

    private:
		void* m_netRuntime { nullptr };
		void* m_netLibrary { nullptr };
	};
};