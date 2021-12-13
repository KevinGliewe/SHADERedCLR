#include "pch.h"
#include <assert.h>
#include "PluginWrapper.h"

bool PluginWrapper::Init(bool isWeb, int sedVersion) {
    this->InitUPC();
    ((void(*)(UnmanagedPointerCollection))this->m_pMPC.__SetUPC)(this->m_sUPC);
    if(!this->m_pMPC.Init_000)
        return 0;
    return ((bool(*)(bool, int))this->m_pMPC.Init_000)(isWeb, sedVersion);
} // Function Init

void PluginWrapper::InitUI(void* ctx) {
    if(!this->m_pMPC.InitUI_001)
        return;
    ((void(*)(void*))this->m_pMPC.InitUI_001)(ctx);
} // Function InitUI

void PluginWrapper::OnEvent(void* e) {
    if(!this->m_pMPC.OnEvent_002)
        return;
    ((void(*)(void*))this->m_pMPC.OnEvent_002)(e);
} // Function OnEvent

void PluginWrapper::Update(float delta) {
    if(!this->m_pMPC.Update_003)
        return;
    ((void(*)(float))this->m_pMPC.Update_003)(delta);
} // Function Update

void PluginWrapper::Destroy() {
    if(!this->m_pMPC.Destroy_004)
        return;
    ((void(*)())this->m_pMPC.Destroy_004)();
} // Function Destroy

bool PluginWrapper::IsRequired() {
    if(!this->m_pMPC.IsRequired_005)
        return 0;
    return ((bool(*)())this->m_pMPC.IsRequired_005)();
} // Function IsRequired

bool PluginWrapper::IsVersionCompatible(int version) {
    if(!this->m_pMPC.IsVersionCompatible_006)
        return 0;
    return ((bool(*)(int))this->m_pMPC.IsVersionCompatible_006)(version);
} // Function IsVersionCompatible

void PluginWrapper::BeginRender() {
    if(!this->m_pMPC.BeginRender_007)
        return;
    ((void(*)())this->m_pMPC.BeginRender_007)();
} // Function BeginRender

void PluginWrapper::EndRender() {
    if(!this->m_pMPC.EndRender_008)
        return;
    ((void(*)())this->m_pMPC.EndRender_008)();
} // Function EndRender

void PluginWrapper::Project_BeginLoad() {
    if(!this->m_pMPC.Project_BeginLoad_009)
        return;
    ((void(*)())this->m_pMPC.Project_BeginLoad_009)();
} // Function Project_BeginLoad

void PluginWrapper::Project_EndLoad() {
    if(!this->m_pMPC.Project_EndLoad_010)
        return;
    ((void(*)())this->m_pMPC.Project_EndLoad_010)();
} // Function Project_EndLoad

void PluginWrapper::Project_BeginSave() {
    if(!this->m_pMPC.Project_BeginSave_011)
        return;
    ((void(*)())this->m_pMPC.Project_BeginSave_011)();
} // Function Project_BeginSave

void PluginWrapper::Project_EndSave() {
    if(!this->m_pMPC.Project_EndSave_012)
        return;
    ((void(*)())this->m_pMPC.Project_EndSave_012)();
} // Function Project_EndSave

bool PluginWrapper::Project_HasAdditionalData() {
    if(!this->m_pMPC.Project_HasAdditionalData_013)
        return 0;
    return ((bool(*)())this->m_pMPC.Project_HasAdditionalData_013)();
} // Function Project_HasAdditionalData

const char* PluginWrapper::Project_ExportAdditionalData() {
    if(!this->m_pMPC.Project_ExportAdditionalData_014)
        return nullptr;
    return ((const char*(*)())this->m_pMPC.Project_ExportAdditionalData_014)();
} // Function Project_ExportAdditionalData

void PluginWrapper::Project_ImportAdditionalData(const char* xml) {
    if(!this->m_pMPC.Project_ImportAdditionalData_015)
        return;
    ((void(*)(const char*))this->m_pMPC.Project_ImportAdditionalData_015)(xml);
} // Function Project_ImportAdditionalData

void PluginWrapper::Project_CopyFilesOnSave(const char* dir) {
    if(!this->m_pMPC.Project_CopyFilesOnSave_016)
        return;
    ((void(*)(const char*))this->m_pMPC.Project_CopyFilesOnSave_016)(dir);
} // Function Project_CopyFilesOnSave

bool PluginWrapper::HasCustomMenuItem() {
    if(!this->m_pMPC.HasCustomMenuItem_017)
        return 0;
    return ((bool(*)())this->m_pMPC.HasCustomMenuItem_017)();
} // Function HasCustomMenuItem

bool PluginWrapper::HasMenuItems(const char* name) {
    if(!this->m_pMPC.HasMenuItems_018)
        return 0;
    return ((bool(*)(const char*))this->m_pMPC.HasMenuItems_018)(name);
} // Function HasMenuItems

void PluginWrapper::ShowMenuItems(const char* name) {
    if(!this->m_pMPC.ShowMenuItems_019)
        return;
    ((void(*)(const char*))this->m_pMPC.ShowMenuItems_019)(name);
} // Function ShowMenuItems

bool PluginWrapper::HasContextItems(const char* name) {
    if(!this->m_pMPC.HasContextItems_020)
        return 0;
    return ((bool(*)(const char*))this->m_pMPC.HasContextItems_020)(name);
} // Function HasContextItems

void PluginWrapper::ShowContextItems(const char* name, void* owner, void* extraData) {
    if(!this->m_pMPC.ShowContextItems_021)
        return;
    ((void(*)(const char*, void*, void*))this->m_pMPC.ShowContextItems_021)(name, owner, extraData);
} // Function ShowContextItems

int PluginWrapper::SystemVariables_GetNameCount(ed::plugin::VariableType varType) {
    if(!this->m_pMPC.SystemVariables_GetNameCount_022)
        return 0;
    return ((int(*)(ed::plugin::VariableType))this->m_pMPC.SystemVariables_GetNameCount_022)(varType);
} // Function SystemVariables_GetNameCount

const char* PluginWrapper::SystemVariables_GetName(ed::plugin::VariableType varType, int index) {
    if(!this->m_pMPC.SystemVariables_GetName_023)
        return nullptr;
    return ((const char*(*)(ed::plugin::VariableType, int))this->m_pMPC.SystemVariables_GetName_023)(varType, index);
} // Function SystemVariables_GetName

bool PluginWrapper::SystemVariables_HasLastFrame(char* name, ed::plugin::VariableType varType) {
    if(!this->m_pMPC.SystemVariables_HasLastFrame_024)
        return 0;
    return ((bool(*)(char*, ed::plugin::VariableType))this->m_pMPC.SystemVariables_HasLastFrame_024)(name, varType);
} // Function SystemVariables_HasLastFrame

void PluginWrapper::SystemVariables_UpdateValue(char* data, char* name, ed::plugin::VariableType varType, bool isLastFrame) {
    if(!this->m_pMPC.SystemVariables_UpdateValue_025)
        return;
    ((void(*)(char*, char*, ed::plugin::VariableType, bool))this->m_pMPC.SystemVariables_UpdateValue_025)(data, name, varType, isLastFrame);
} // Function SystemVariables_UpdateValue

int PluginWrapper::VariableFunctions_GetNameCount(ed::plugin::VariableType vtype) {
    if(!this->m_pMPC.VariableFunctions_GetNameCount_026)
        return 0;
    return ((int(*)(ed::plugin::VariableType))this->m_pMPC.VariableFunctions_GetNameCount_026)(vtype);
} // Function VariableFunctions_GetNameCount

const char* PluginWrapper::VariableFunctions_GetName(ed::plugin::VariableType varType, int index) {
    if(!this->m_pMPC.VariableFunctions_GetName_027)
        return nullptr;
    return ((const char*(*)(ed::plugin::VariableType, int))this->m_pMPC.VariableFunctions_GetName_027)(varType, index);
} // Function VariableFunctions_GetName

bool PluginWrapper::VariableFunctions_ShowArgumentEdit(char* fname, char* args, ed::plugin::VariableType vtype) {
    if(!this->m_pMPC.VariableFunctions_ShowArgumentEdit_028)
        return 0;
    return ((bool(*)(char*, char*, ed::plugin::VariableType))this->m_pMPC.VariableFunctions_ShowArgumentEdit_028)(fname, args, vtype);
} // Function VariableFunctions_ShowArgumentEdit

void PluginWrapper::VariableFunctions_UpdateValue(char* data, char* args, char* fname, ed::plugin::VariableType varType) {
    if(!this->m_pMPC.VariableFunctions_UpdateValue_029)
        return;
    ((void(*)(char*, char*, char*, ed::plugin::VariableType))this->m_pMPC.VariableFunctions_UpdateValue_029)(data, args, fname, varType);
} // Function VariableFunctions_UpdateValue

int PluginWrapper::VariableFunctions_GetArgsSize(char* fname, ed::plugin::VariableType varType) {
    if(!this->m_pMPC.VariableFunctions_GetArgsSize_030)
        return 0;
    return ((int(*)(char*, ed::plugin::VariableType))this->m_pMPC.VariableFunctions_GetArgsSize_030)(fname, varType);
} // Function VariableFunctions_GetArgsSize

void PluginWrapper::VariableFunctions_InitArguments(char* args, char* fname, ed::plugin::VariableType vtype) {
    if(!this->m_pMPC.VariableFunctions_InitArguments_031)
        return;
    ((void(*)(char*, char*, ed::plugin::VariableType))this->m_pMPC.VariableFunctions_InitArguments_031)(args, fname, vtype);
} // Function VariableFunctions_InitArguments

const char* PluginWrapper::VariableFunctions_ExportArguments(char* fname, ed::plugin::VariableType vtype, char* args) {
    if(!this->m_pMPC.VariableFunctions_ExportArguments_032)
        return nullptr;
    return ((const char*(*)(char*, ed::plugin::VariableType, char*))this->m_pMPC.VariableFunctions_ExportArguments_032)(fname, vtype, args);
} // Function VariableFunctions_ExportArguments

void PluginWrapper::VariableFunctions_ImportArguments(char* fname, ed::plugin::VariableType vtype, char* args, const char* argsString) {
    if(!this->m_pMPC.VariableFunctions_ImportArguments_033)
        return;
    ((void(*)(char*, ed::plugin::VariableType, char*, const char*))this->m_pMPC.VariableFunctions_ImportArguments_033)(fname, vtype, args, argsString);
} // Function VariableFunctions_ImportArguments

bool PluginWrapper::Object_HasPreview(const char* type) {
    if(!this->m_pMPC.Object_HasPreview_034)
        return 0;
    return ((bool(*)(const char*))this->m_pMPC.Object_HasPreview_034)(type);
} // Function Object_HasPreview

void PluginWrapper::Object_ShowPreview(const char* type, void* data, unsigned int id) {
    if(!this->m_pMPC.Object_ShowPreview_035)
        return;
    ((void(*)(const char*, void*, unsigned int))this->m_pMPC.Object_ShowPreview_035)(type, data, id);
} // Function Object_ShowPreview

bool PluginWrapper::Object_IsBindable(const char* type) {
    if(!this->m_pMPC.Object_IsBindable_036)
        return 0;
    return ((bool(*)(const char*))this->m_pMPC.Object_IsBindable_036)(type);
} // Function Object_IsBindable

bool PluginWrapper::Object_IsBindableUAV(const char* type) {
    if(!this->m_pMPC.Object_IsBindableUAV_037)
        return 0;
    return ((bool(*)(const char*))this->m_pMPC.Object_IsBindableUAV_037)(type);
} // Function Object_IsBindableUAV

void PluginWrapper::Object_Remove(const char* name, const char* type, void* data, unsigned int id) {
    if(!this->m_pMPC.Object_Remove_038)
        return;
    ((void(*)(const char*, const char*, void*, unsigned int))this->m_pMPC.Object_Remove_038)(name, type, data, id);
} // Function Object_Remove

bool PluginWrapper::Object_HasExtendedPreview(const char* type) {
    if(!this->m_pMPC.Object_HasExtendedPreview_039)
        return 0;
    return ((bool(*)(const char*))this->m_pMPC.Object_HasExtendedPreview_039)(type);
} // Function Object_HasExtendedPreview

void PluginWrapper::Object_ShowExtendedPreview(const char* type, void* data, unsigned int id) {
    if(!this->m_pMPC.Object_ShowExtendedPreview_040)
        return;
    ((void(*)(const char*, void*, unsigned int))this->m_pMPC.Object_ShowExtendedPreview_040)(type, data, id);
} // Function Object_ShowExtendedPreview

bool PluginWrapper::Object_HasProperties(const char* type) {
    if(!this->m_pMPC.Object_HasProperties_041)
        return 0;
    return ((bool(*)(const char*))this->m_pMPC.Object_HasProperties_041)(type);
} // Function Object_HasProperties

void PluginWrapper::Object_ShowProperties(const char* type, void* data, unsigned int id) {
    if(!this->m_pMPC.Object_ShowProperties_042)
        return;
    ((void(*)(const char*, void*, unsigned int))this->m_pMPC.Object_ShowProperties_042)(type, data, id);
} // Function Object_ShowProperties

void PluginWrapper::Object_Bind(const char* type, void* data, unsigned int id) {
    if(!this->m_pMPC.Object_Bind_043)
        return;
    ((void(*)(const char*, void*, unsigned int))this->m_pMPC.Object_Bind_043)(type, data, id);
} // Function Object_Bind

const char* PluginWrapper::Object_Export(char* type, void* data, unsigned int id) {
    if(!this->m_pMPC.Object_Export_044)
        return nullptr;
    return ((const char*(*)(char*, void*, unsigned int))this->m_pMPC.Object_Export_044)(type, data, id);
} // Function Object_Export

void PluginWrapper::Object_Import(const char* name, const char* type, const char* argsString) {
    if(!this->m_pMPC.Object_Import_045)
        return;
    ((void(*)(const char*, const char*, const char*))this->m_pMPC.Object_Import_045)(name, type, argsString);
} // Function Object_Import

bool PluginWrapper::Object_HasContext(const char* type) {
    if(!this->m_pMPC.Object_HasContext_046)
        return 0;
    return ((bool(*)(const char*))this->m_pMPC.Object_HasContext_046)(type);
} // Function Object_HasContext

void PluginWrapper::Object_ShowContext(const char* type, void* data) {
    if(!this->m_pMPC.Object_ShowContext_047)
        return;
    ((void(*)(const char*, void*))this->m_pMPC.Object_ShowContext_047)(type, data);
} // Function Object_ShowContext

bool PluginWrapper::PipelineItem_HasProperties(const char* type, void* data) {
    if(!this->m_pMPC.PipelineItem_HasProperties_048)
        return 0;
    return ((bool(*)(const char*, void*))this->m_pMPC.PipelineItem_HasProperties_048)(type, data);
} // Function PipelineItem_HasProperties

void PluginWrapper::PipelineItem_ShowProperties(const char* type, void* data) {
    if(!this->m_pMPC.PipelineItem_ShowProperties_049)
        return;
    ((void(*)(const char*, void*))this->m_pMPC.PipelineItem_ShowProperties_049)(type, data);
} // Function PipelineItem_ShowProperties

bool PluginWrapper::PipelineItem_IsPickable(const char* type, void* data) {
    if(!this->m_pMPC.PipelineItem_IsPickable_050)
        return 0;
    return ((bool(*)(const char*, void*))this->m_pMPC.PipelineItem_IsPickable_050)(type, data);
} // Function PipelineItem_IsPickable

bool PluginWrapper::PipelineItem_HasShaders(const char* type, void* data) {
    if(!this->m_pMPC.PipelineItem_HasShaders_051)
        return 0;
    return ((bool(*)(const char*, void*))this->m_pMPC.PipelineItem_HasShaders_051)(type, data);
} // Function PipelineItem_HasShaders

void PluginWrapper::PipelineItem_OpenInEditor(const char* type, void* data) {
    if(!this->m_pMPC.PipelineItem_OpenInEditor_052)
        return;
    ((void(*)(const char*, void*))this->m_pMPC.PipelineItem_OpenInEditor_052)(type, data);
} // Function PipelineItem_OpenInEditor

bool PluginWrapper::PipelineItem_CanHaveChild(const char* type, void* data, ed::plugin::PipelineItemType itemType) {
    if(!this->m_pMPC.PipelineItem_CanHaveChild_053)
        return 0;
    return ((bool(*)(const char*, void*, ed::plugin::PipelineItemType))this->m_pMPC.PipelineItem_CanHaveChild_053)(type, data, itemType);
} // Function PipelineItem_CanHaveChild

int PluginWrapper::PipelineItem_GetInputLayoutSize(const char* type, void* data) {
    if(!this->m_pMPC.PipelineItem_GetInputLayoutSize_054)
        return 0;
    return ((int(*)(const char*, void*))this->m_pMPC.PipelineItem_GetInputLayoutSize_054)(type, data);
} // Function PipelineItem_GetInputLayoutSize

void PluginWrapper::PipelineItem_GetInputLayoutItem(const char* type, void* data, int index, ed::plugin::InputLayoutItem& out) {
    if(!this->m_pMPC.PipelineItem_GetInputLayoutItem_055)
        return;
    ((void(*)(const char*, void*, int, ed::plugin::InputLayoutItem&))this->m_pMPC.PipelineItem_GetInputLayoutItem_055)(type, data, index, out);
} // Function PipelineItem_GetInputLayoutItem

void PluginWrapper::PipelineItem_Remove(const char* itemName, const char* type, void* data) {
    if(!this->m_pMPC.PipelineItem_Remove_056)
        return;
    ((void(*)(const char*, const char*, void*))this->m_pMPC.PipelineItem_Remove_056)(itemName, type, data);
} // Function PipelineItem_Remove

void PluginWrapper::PipelineItem_Rename(const char* oldName, const char* newName) {
    if(!this->m_pMPC.PipelineItem_Rename_057)
        return;
    ((void(*)(const char*, const char*))this->m_pMPC.PipelineItem_Rename_057)(oldName, newName);
} // Function PipelineItem_Rename

void PluginWrapper::PipelineItem_AddChild(const char* owner, const char* name, ed::plugin::PipelineItemType type, void* data) {
    if(!this->m_pMPC.PipelineItem_AddChild_058)
        return;
    ((void(*)(const char*, const char*, ed::plugin::PipelineItemType, void*))this->m_pMPC.PipelineItem_AddChild_058)(owner, name, type, data);
} // Function PipelineItem_AddChild

bool PluginWrapper::PipelineItem_CanHaveChildren(const char* type, void* data) {
    if(!this->m_pMPC.PipelineItem_CanHaveChildren_059)
        return 0;
    return ((bool(*)(const char*, void*))this->m_pMPC.PipelineItem_CanHaveChildren_059)(type, data);
} // Function PipelineItem_CanHaveChildren

void* PluginWrapper::PipelineItem_CopyData(const char* type, void* data) {
    if(!this->m_pMPC.PipelineItem_CopyData_060)
        return nullptr;
    return ((void*(*)(const char*, void*))this->m_pMPC.PipelineItem_CopyData_060)(type, data);
} // Function PipelineItem_CopyData

void PluginWrapper::PipelineItem_Execute(void* Owner, ed::plugin::PipelineItemType OwnerType, const char* type, void* data) {
    if(!this->m_pMPC.PipelineItem_Execute_061)
        return;
    ((void(*)(void*, ed::plugin::PipelineItemType, const char*, void*))this->m_pMPC.PipelineItem_Execute_061)(Owner, OwnerType, type, data);
} // Function PipelineItem_Execute

void PluginWrapper::PipelineItem_Execute(const char* type, void* data, void* children, int count) {
    if(!this->m_pMPC.PipelineItem_Execute_062)
        return;
    ((void(*)(const char*, void*, void*, int))this->m_pMPC.PipelineItem_Execute_062)(type, data, children, count);
} // Function PipelineItem_Execute

void PluginWrapper::PipelineItem_GetWorldMatrix(const char* type, void* data, float (&pMat)[16]) {
    if(!this->m_pMPC.PipelineItem_GetWorldMatrix_063)
        return;
    ((void(*)(const char*, void*, float*))this->m_pMPC.PipelineItem_GetWorldMatrix_063)(type, data, pMat);
} // Function PipelineItem_GetWorldMatrix

bool PluginWrapper::PipelineItem_Intersect(const char* type, void* data, const float* rayOrigin, const float* rayDir, float& hitDist) {
    if(!this->m_pMPC.PipelineItem_Intersect_064)
        return 0;
    return ((bool(*)(const char*, void*, const float*, const float*, float&))this->m_pMPC.PipelineItem_Intersect_064)(type, data, rayOrigin, rayDir, hitDist);
} // Function PipelineItem_Intersect

void PluginWrapper::PipelineItem_GetBoundingBox(const char* type, void* data, float (&minPos)[3], float (&maxPos)[3]) {
    if(!this->m_pMPC.PipelineItem_GetBoundingBox_065)
        return;
    ((void(*)(const char*, void*, float*, float*))this->m_pMPC.PipelineItem_GetBoundingBox_065)(type, data, minPos, maxPos);
} // Function PipelineItem_GetBoundingBox

bool PluginWrapper::PipelineItem_HasContext(const char* type, void* data) {
    if(!this->m_pMPC.PipelineItem_HasContext_066)
        return 0;
    return ((bool(*)(const char*, void*))this->m_pMPC.PipelineItem_HasContext_066)(type, data);
} // Function PipelineItem_HasContext

void PluginWrapper::PipelineItem_ShowContext(const char* type, void* data) {
    if(!this->m_pMPC.PipelineItem_ShowContext_067)
        return;
    ((void(*)(const char*, void*))this->m_pMPC.PipelineItem_ShowContext_067)(type, data);
} // Function PipelineItem_ShowContext

const char* PluginWrapper::PipelineItem_Export(const char* type, void* data) {
    if(!this->m_pMPC.PipelineItem_Export_068)
        return nullptr;
    return ((const char*(*)(const char*, void*))this->m_pMPC.PipelineItem_Export_068)(type, data);
} // Function PipelineItem_Export

void* PluginWrapper::PipelineItem_Import(const char* ownerName, const char* name, const char* type, const char* argsString) {
    if(!this->m_pMPC.PipelineItem_Import_069)
        return nullptr;
    return ((void*(*)(const char*, const char*, const char*, const char*))this->m_pMPC.PipelineItem_Import_069)(ownerName, name, type, argsString);
} // Function PipelineItem_Import

void PluginWrapper::PipelineItem_MoveDown(void* ownerData, const char* ownerType, const char* itemName) {
    if(!this->m_pMPC.PipelineItem_MoveDown_070)
        return;
    ((void(*)(void*, const char*, const char*))this->m_pMPC.PipelineItem_MoveDown_070)(ownerData, ownerType, itemName);
} // Function PipelineItem_MoveDown

void PluginWrapper::PipelineItem_MoveUp(void* ownerData, const char* ownerType, const char* itemName) {
    if(!this->m_pMPC.PipelineItem_MoveUp_071)
        return;
    ((void(*)(void*, const char*, const char*))this->m_pMPC.PipelineItem_MoveUp_071)(ownerData, ownerType, itemName);
} // Function PipelineItem_MoveUp

void PluginWrapper::PipelineItem_ApplyGizmoTransform(const char* type, void* data, float* transl, float* scale, float* rota) {
    if(!this->m_pMPC.PipelineItem_ApplyGizmoTransform_072)
        return;
    ((void(*)(const char*, void*, float*, float*, float*))this->m_pMPC.PipelineItem_ApplyGizmoTransform_072)(type, data, transl, scale, rota);
} // Function PipelineItem_ApplyGizmoTransform

void PluginWrapper::PipelineItem_GetTransform(const char* type, void* data, float* transl, float* scale, float* rota) {
    if(!this->m_pMPC.PipelineItem_GetTransform_073)
        return;
    ((void(*)(const char*, void*, float*, float*, float*))this->m_pMPC.PipelineItem_GetTransform_073)(type, data, transl, scale, rota);
} // Function PipelineItem_GetTransform

void PluginWrapper::PipelineItem_DebugVertexExecute(void* Owner, ed::plugin::PipelineItemType OwnerType, const char* type, void* data, unsigned int colorVarLoc) {
    if(!this->m_pMPC.PipelineItem_DebugVertexExecute_074)
        return;
    ((void(*)(void*, ed::plugin::PipelineItemType, const char*, void*, unsigned int))this->m_pMPC.PipelineItem_DebugVertexExecute_074)(Owner, OwnerType, type, data, colorVarLoc);
} // Function PipelineItem_DebugVertexExecute

int PluginWrapper::PipelineItem_DebugVertexExecute(const char* type, void* data, const char* childName, float rx, float ry, int vertexGroup) {
    if(!this->m_pMPC.PipelineItem_DebugVertexExecute_075)
        return 0;
    return ((int(*)(const char*, void*, const char*, float, float, int))this->m_pMPC.PipelineItem_DebugVertexExecute_075)(type, data, childName, rx, ry, vertexGroup);
} // Function PipelineItem_DebugVertexExecute

void PluginWrapper::PipelineItem_DebugInstanceExecute(void* Owner, ed::plugin::PipelineItemType OwnerType, const char* type, void* data, unsigned int colorVarLoc) {
    if(!this->m_pMPC.PipelineItem_DebugInstanceExecute_076)
        return;
    ((void(*)(void*, ed::plugin::PipelineItemType, const char*, void*, unsigned int))this->m_pMPC.PipelineItem_DebugInstanceExecute_076)(Owner, OwnerType, type, data, colorVarLoc);
} // Function PipelineItem_DebugInstanceExecute

int PluginWrapper::PipelineItem_DebugInstanceExecute(const char* type, void* data, const char* childName, float rx, float ry, int vertexGroup) {
    if(!this->m_pMPC.PipelineItem_DebugInstanceExecute_077)
        return 0;
    return ((int(*)(const char*, void*, const char*, float, float, int))this->m_pMPC.PipelineItem_DebugInstanceExecute_077)(type, data, childName, rx, ry, vertexGroup);
} // Function PipelineItem_DebugInstanceExecute

unsigned int PluginWrapper::PipelineItem_GetVBO(const char* type, void* data) {
    if(!this->m_pMPC.PipelineItem_GetVBO_078)
        return 0;
    return ((unsigned int(*)(const char*, void*))this->m_pMPC.PipelineItem_GetVBO_078)(type, data);
} // Function PipelineItem_GetVBO

unsigned int PluginWrapper::PipelineItem_GetVBOStride(const char* type, void* data) {
    if(!this->m_pMPC.PipelineItem_GetVBOStride_079)
        return 0;
    return ((unsigned int(*)(const char*, void*))this->m_pMPC.PipelineItem_GetVBOStride_079)(type, data);
} // Function PipelineItem_GetVBOStride

bool PluginWrapper::PipelineItem_CanChangeVariables(const char* type, void* data) {
    if(!this->m_pMPC.PipelineItem_CanChangeVariables_080)
        return 0;
    return ((bool(*)(const char*, void*))this->m_pMPC.PipelineItem_CanChangeVariables_080)(type, data);
} // Function PipelineItem_CanChangeVariables

bool PluginWrapper::PipelineItem_IsDebuggable(const char* type, void* data) {
    if(!this->m_pMPC.PipelineItem_IsDebuggable_081)
        return 0;
    return ((bool(*)(const char*, void*))this->m_pMPC.PipelineItem_IsDebuggable_081)(type, data);
} // Function PipelineItem_IsDebuggable

bool PluginWrapper::PipelineItem_IsStageDebuggable(const char* type, void* data, ed::plugin::ShaderStage stage) {
    if(!this->m_pMPC.PipelineItem_IsStageDebuggable_082)
        return 0;
    return ((bool(*)(const char*, void*, ed::plugin::ShaderStage))this->m_pMPC.PipelineItem_IsStageDebuggable_082)(type, data, stage);
} // Function PipelineItem_IsStageDebuggable

void PluginWrapper::PipelineItem_DebugExecute(const char* type, void* data, void* children, int count, int* debugID) {
    if(!this->m_pMPC.PipelineItem_DebugExecute_083)
        return;
    ((void(*)(const char*, void*, void*, int, int*))this->m_pMPC.PipelineItem_DebugExecute_083)(type, data, children, count, debugID);
} // Function PipelineItem_DebugExecute

unsigned int PluginWrapper::PipelineItem_GetTopology(const char* type, void* data) {
    if(!this->m_pMPC.PipelineItem_GetTopology_084)
        return 0;
    return ((unsigned int(*)(const char*, void*))this->m_pMPC.PipelineItem_GetTopology_084)(type, data);
} // Function PipelineItem_GetTopology

unsigned int PluginWrapper::PipelineItem_GetVariableCount(const char* type, void* data) {
    if(!this->m_pMPC.PipelineItem_GetVariableCount_085)
        return 0;
    return ((unsigned int(*)(const char*, void*))this->m_pMPC.PipelineItem_GetVariableCount_085)(type, data);
} // Function PipelineItem_GetVariableCount

const char* PluginWrapper::PipelineItem_GetVariableName(const char* type, void* data, unsigned int variable) {
    if(!this->m_pMPC.PipelineItem_GetVariableName_086)
        return nullptr;
    return ((const char*(*)(const char*, void*, unsigned int))this->m_pMPC.PipelineItem_GetVariableName_086)(type, data, variable);
} // Function PipelineItem_GetVariableName

ed::plugin::VariableType PluginWrapper::PipelineItem_GetVariableType(const char* type, void* data, unsigned int variable) {
    if(!this->m_pMPC.PipelineItem_GetVariableType_087)
        return (ed::plugin::VariableType)0;
    return ((ed::plugin::VariableType(*)(const char*, void*, unsigned int))this->m_pMPC.PipelineItem_GetVariableType_087)(type, data, variable);
} // Function PipelineItem_GetVariableType

float PluginWrapper::PipelineItem_GetVariableValueFloat(const char* type, void* data, unsigned int variable, int col, int row) {
    if(!this->m_pMPC.PipelineItem_GetVariableValueFloat_088)
        return 0;
    return ((float(*)(const char*, void*, unsigned int, int, int))this->m_pMPC.PipelineItem_GetVariableValueFloat_088)(type, data, variable, col, row);
} // Function PipelineItem_GetVariableValueFloat

int PluginWrapper::PipelineItem_GetVariableValueInteger(const char* type, void* data, unsigned int variable, int col) {
    if(!this->m_pMPC.PipelineItem_GetVariableValueInteger_089)
        return 0;
    return ((int(*)(const char*, void*, unsigned int, int))this->m_pMPC.PipelineItem_GetVariableValueInteger_089)(type, data, variable, col);
} // Function PipelineItem_GetVariableValueInteger

bool PluginWrapper::PipelineItem_GetVariableValueBoolean(const char* type, void* data, unsigned int variable, int col) {
    if(!this->m_pMPC.PipelineItem_GetVariableValueBoolean_090)
        return 0;
    return ((bool(*)(const char*, void*, unsigned int, int))this->m_pMPC.PipelineItem_GetVariableValueBoolean_090)(type, data, variable, col);
} // Function PipelineItem_GetVariableValueBoolean

unsigned int PluginWrapper::PipelineItem_GetSPIRVSize(const char* type, void* data, ed::plugin::ShaderStage stage) {
    if(!this->m_pMPC.PipelineItem_GetSPIRVSize_091)
        return 0;
    return ((unsigned int(*)(const char*, void*, ed::plugin::ShaderStage))this->m_pMPC.PipelineItem_GetSPIRVSize_091)(type, data, stage);
} // Function PipelineItem_GetSPIRVSize

unsigned int* PluginWrapper::PipelineItem_GetSPIRV(const char* type, void* data, ed::plugin::ShaderStage stage) {
    if(!this->m_pMPC.PipelineItem_GetSPIRV_092)
        return nullptr;
    return ((unsigned int*(*)(const char*, void*, ed::plugin::ShaderStage))this->m_pMPC.PipelineItem_GetSPIRV_092)(type, data, stage);
} // Function PipelineItem_GetSPIRV

void PluginWrapper::PipelineItem_DebugPrepareVariables(const char* type, void* data, const char* name) {
    if(!this->m_pMPC.PipelineItem_DebugPrepareVariables_093)
        return;
    ((void(*)(const char*, void*, const char*))this->m_pMPC.PipelineItem_DebugPrepareVariables_093)(type, data, name);
} // Function PipelineItem_DebugPrepareVariables

bool PluginWrapper::PipelineItem_DebugUsesCustomTextures(const char* type, void* data) {
    if(!this->m_pMPC.PipelineItem_DebugUsesCustomTextures_094)
        return 0;
    return ((bool(*)(const char*, void*))this->m_pMPC.PipelineItem_DebugUsesCustomTextures_094)(type, data);
} // Function PipelineItem_DebugUsesCustomTextures

unsigned int PluginWrapper::PipelineItem_DebugGetTexture(const char* type, void* data, int loc, const char* variableName) {
    if(!this->m_pMPC.PipelineItem_DebugGetTexture_095)
        return 0;
    return ((unsigned int(*)(const char*, void*, int, const char*))this->m_pMPC.PipelineItem_DebugGetTexture_095)(type, data, loc, variableName);
} // Function PipelineItem_DebugGetTexture

void PluginWrapper::PipelineItem_DebugGetTextureSize(const char* type, void* data, int loc, const char* variableName, int& x, int& y, int& z) {
    if(!this->m_pMPC.PipelineItem_DebugGetTextureSize_096)
        return;
    ((void(*)(const char*, void*, int, const char*, int&, int&, int&))this->m_pMPC.PipelineItem_DebugGetTextureSize_096)(type, data, loc, variableName, x, y, z);
} // Function PipelineItem_DebugGetTextureSize

bool PluginWrapper::Options_HasSection() {
    if(!this->m_pMPC.Options_HasSection_097)
        return 0;
    return ((bool(*)())this->m_pMPC.Options_HasSection_097)();
} // Function Options_HasSection

void PluginWrapper::Options_RenderSection() {
    if(!this->m_pMPC.Options_RenderSection_098)
        return;
    ((void(*)())this->m_pMPC.Options_RenderSection_098)();
} // Function Options_RenderSection

void PluginWrapper::Options_Parse(const char* key, const char* val) {
    if(!this->m_pMPC.Options_Parse_099)
        return;
    ((void(*)(const char*, const char*))this->m_pMPC.Options_Parse_099)(key, val);
} // Function Options_Parse

int PluginWrapper::Options_GetCount() {
    if(!this->m_pMPC.Options_GetCount_100)
        return 0;
    return ((int(*)())this->m_pMPC.Options_GetCount_100)();
} // Function Options_GetCount

const char* PluginWrapper::Options_GetKey(int index) {
    if(!this->m_pMPC.Options_GetKey_101)
        return nullptr;
    return ((const char*(*)(int))this->m_pMPC.Options_GetKey_101)(index);
} // Function Options_GetKey

const char* PluginWrapper::Options_GetValue(int index) {
    if(!this->m_pMPC.Options_GetValue_102)
        return nullptr;
    return ((const char*(*)(int))this->m_pMPC.Options_GetValue_102)(index);
} // Function Options_GetValue

int PluginWrapper::CustomLanguage_GetCount() {
    if(!this->m_pMPC.CustomLanguage_GetCount_103)
        return 0;
    return ((int(*)())this->m_pMPC.CustomLanguage_GetCount_103)();
} // Function CustomLanguage_GetCount

const char* PluginWrapper::CustomLanguage_GetName(int langID) {
    if(!this->m_pMPC.CustomLanguage_GetName_104)
        return nullptr;
    return ((const char*(*)(int))this->m_pMPC.CustomLanguage_GetName_104)(langID);
} // Function CustomLanguage_GetName

const unsigned int* PluginWrapper::CustomLanguage_CompileToSPIRV(int langID, const char* src, size_t src_len, ed::plugin::ShaderStage stage, const char* entry, ed::plugin::ShaderMacro* macros, size_t macroCount, size_t* spv_length, bool* compiled) {
    if(!this->m_pMPC.CustomLanguage_CompileToSPIRV_105)
        return nullptr;
    return ((const unsigned int*(*)(int, const char*, size_t, ed::plugin::ShaderStage, const char*, ed::plugin::ShaderMacro*, size_t, size_t*, bool*))this->m_pMPC.CustomLanguage_CompileToSPIRV_105)(langID, src, src_len, stage, entry, macros, macroCount, spv_length, compiled);
} // Function CustomLanguage_CompileToSPIRV

const char* PluginWrapper::CustomLanguage_ProcessGeneratedGLSL(int langID, const char* src) {
    if(!this->m_pMPC.CustomLanguage_ProcessGeneratedGLSL_106)
        return nullptr;
    return ((const char*(*)(int, const char*))this->m_pMPC.CustomLanguage_ProcessGeneratedGLSL_106)(langID, src);
} // Function CustomLanguage_ProcessGeneratedGLSL

bool PluginWrapper::CustomLanguage_SupportsAutoUniforms(int langID) {
    if(!this->m_pMPC.CustomLanguage_SupportsAutoUniforms_107)
        return 0;
    return ((bool(*)(int))this->m_pMPC.CustomLanguage_SupportsAutoUniforms_107)(langID);
} // Function CustomLanguage_SupportsAutoUniforms

bool PluginWrapper::CustomLanguage_IsDebuggable(int langID) {
    if(!this->m_pMPC.CustomLanguage_IsDebuggable_108)
        return 0;
    return ((bool(*)(int))this->m_pMPC.CustomLanguage_IsDebuggable_108)(langID);
} // Function CustomLanguage_IsDebuggable

const char* PluginWrapper::CustomLanguage_GetDefaultExtension(int langID) {
    if(!this->m_pMPC.CustomLanguage_GetDefaultExtension_109)
        return nullptr;
    return ((const char*(*)(int))this->m_pMPC.CustomLanguage_GetDefaultExtension_109)(langID);
} // Function CustomLanguage_GetDefaultExtension

bool PluginWrapper::ShaderEditor_Supports(int langID) {
    if(!this->m_pMPC.ShaderEditor_Supports_110)
        return 0;
    return ((bool(*)(int))this->m_pMPC.ShaderEditor_Supports_110)(langID);
} // Function ShaderEditor_Supports

void PluginWrapper::ShaderEditor_Open(int langID, int editorID, const char* data, int dataLen) {
    if(!this->m_pMPC.ShaderEditor_Open_111)
        return;
    ((void(*)(int, int, const char*, int))this->m_pMPC.ShaderEditor_Open_111)(langID, editorID, data, dataLen);
} // Function ShaderEditor_Open

void PluginWrapper::ShaderEditor_Render(int langID, int editorID) {
    if(!this->m_pMPC.ShaderEditor_Render_112)
        return;
    ((void(*)(int, int))this->m_pMPC.ShaderEditor_Render_112)(langID, editorID);
} // Function ShaderEditor_Render

void PluginWrapper::ShaderEditor_Close(int langID, int editorID) {
    if(!this->m_pMPC.ShaderEditor_Close_113)
        return;
    ((void(*)(int, int))this->m_pMPC.ShaderEditor_Close_113)(langID, editorID);
} // Function ShaderEditor_Close

const char* PluginWrapper::ShaderEditor_GetContent(int langID, int editorID, size_t* dataLength) {
    if(!this->m_pMPC.ShaderEditor_GetContent_114)
        return nullptr;
    return ((const char*(*)(int, int, size_t*))this->m_pMPC.ShaderEditor_GetContent_114)(langID, editorID, dataLength);
} // Function ShaderEditor_GetContent

bool PluginWrapper::ShaderEditor_IsChanged(int langID, int editorID) {
    if(!this->m_pMPC.ShaderEditor_IsChanged_115)
        return 0;
    return ((bool(*)(int, int))this->m_pMPC.ShaderEditor_IsChanged_115)(langID, editorID);
} // Function ShaderEditor_IsChanged

void PluginWrapper::ShaderEditor_ResetChangeState(int langID, int editorID) {
    if(!this->m_pMPC.ShaderEditor_ResetChangeState_116)
        return;
    ((void(*)(int, int))this->m_pMPC.ShaderEditor_ResetChangeState_116)(langID, editorID);
} // Function ShaderEditor_ResetChangeState

bool PluginWrapper::ShaderEditor_CanUndo(int langID, int editorID) {
    if(!this->m_pMPC.ShaderEditor_CanUndo_117)
        return 0;
    return ((bool(*)(int, int))this->m_pMPC.ShaderEditor_CanUndo_117)(langID, editorID);
} // Function ShaderEditor_CanUndo

bool PluginWrapper::ShaderEditor_CanRedo(int langID, int editorID) {
    if(!this->m_pMPC.ShaderEditor_CanRedo_118)
        return 0;
    return ((bool(*)(int, int))this->m_pMPC.ShaderEditor_CanRedo_118)(langID, editorID);
} // Function ShaderEditor_CanRedo

void PluginWrapper::ShaderEditor_Undo(int langID, int editorID) {
    if(!this->m_pMPC.ShaderEditor_Undo_119)
        return;
    ((void(*)(int, int))this->m_pMPC.ShaderEditor_Undo_119)(langID, editorID);
} // Function ShaderEditor_Undo

void PluginWrapper::ShaderEditor_Redo(int langID, int editorID) {
    if(!this->m_pMPC.ShaderEditor_Redo_120)
        return;
    ((void(*)(int, int))this->m_pMPC.ShaderEditor_Redo_120)(langID, editorID);
} // Function ShaderEditor_Redo

void PluginWrapper::ShaderEditor_Cut(int langID, int editorID) {
    if(!this->m_pMPC.ShaderEditor_Cut_121)
        return;
    ((void(*)(int, int))this->m_pMPC.ShaderEditor_Cut_121)(langID, editorID);
} // Function ShaderEditor_Cut

void PluginWrapper::ShaderEditor_Paste(int langID, int editorID) {
    if(!this->m_pMPC.ShaderEditor_Paste_122)
        return;
    ((void(*)(int, int))this->m_pMPC.ShaderEditor_Paste_122)(langID, editorID);
} // Function ShaderEditor_Paste

void PluginWrapper::ShaderEditor_Copy(int langID, int editorID) {
    if(!this->m_pMPC.ShaderEditor_Copy_123)
        return;
    ((void(*)(int, int))this->m_pMPC.ShaderEditor_Copy_123)(langID, editorID);
} // Function ShaderEditor_Copy

void PluginWrapper::ShaderEditor_SelectAll(int langID, int editorID) {
    if(!this->m_pMPC.ShaderEditor_SelectAll_124)
        return;
    ((void(*)(int, int))this->m_pMPC.ShaderEditor_SelectAll_124)(langID, editorID);
} // Function ShaderEditor_SelectAll

bool PluginWrapper::ShaderEditor_HasStats(int langID, int editorID) {
    if(!this->m_pMPC.ShaderEditor_HasStats_125)
        return 0;
    return ((bool(*)(int, int))this->m_pMPC.ShaderEditor_HasStats_125)(langID, editorID);
} // Function ShaderEditor_HasStats

void PluginWrapper::CodeEditor_SaveItem(const char* src, int srcLen, const char* path) {
    if(!this->m_pMPC.CodeEditor_SaveItem_126)
        return;
    ((void(*)(const char*, int, const char*))this->m_pMPC.CodeEditor_SaveItem_126)(src, srcLen, path);
} // Function CodeEditor_SaveItem

void PluginWrapper::CodeEditor_CloseItem(const char* path) {
    if(!this->m_pMPC.CodeEditor_CloseItem_127)
        return;
    ((void(*)(const char*))this->m_pMPC.CodeEditor_CloseItem_127)(path);
} // Function CodeEditor_CloseItem

bool PluginWrapper::LanguageDefinition_Exists(int id) {
    if(!this->m_pMPC.LanguageDefinition_Exists_128)
        return 0;
    return ((bool(*)(int))this->m_pMPC.LanguageDefinition_Exists_128)(id);
} // Function LanguageDefinition_Exists

int PluginWrapper::LanguageDefinition_GetKeywordCount(int id) {
    if(!this->m_pMPC.LanguageDefinition_GetKeywordCount_129)
        return 0;
    return ((int(*)(int))this->m_pMPC.LanguageDefinition_GetKeywordCount_129)(id);
} // Function LanguageDefinition_GetKeywordCount

const char** PluginWrapper::LanguageDefinition_GetKeywords(int id) {
    if(!this->m_pMPC.LanguageDefinition_GetKeywords_130)
        return nullptr;
    return ((const char**(*)(int))this->m_pMPC.LanguageDefinition_GetKeywords_130)(id);
} // Function LanguageDefinition_GetKeywords

int PluginWrapper::LanguageDefinition_GetTokenRegexCount(int id) {
    if(!this->m_pMPC.LanguageDefinition_GetTokenRegexCount_131)
        return 0;
    return ((int(*)(int))this->m_pMPC.LanguageDefinition_GetTokenRegexCount_131)(id);
} // Function LanguageDefinition_GetTokenRegexCount

const char* PluginWrapper::LanguageDefinition_GetTokenRegex(int index, ed::plugin::TextEditorPaletteIndex& palIndex, int id) {
    if(!this->m_pMPC.LanguageDefinition_GetTokenRegex_132)
        return nullptr;
    return ((const char*(*)(int, ed::plugin::TextEditorPaletteIndex&, int))this->m_pMPC.LanguageDefinition_GetTokenRegex_132)(index, palIndex, id);
} // Function LanguageDefinition_GetTokenRegex

int PluginWrapper::LanguageDefinition_GetIdentifierCount(int id) {
    if(!this->m_pMPC.LanguageDefinition_GetIdentifierCount_133)
        return 0;
    return ((int(*)(int))this->m_pMPC.LanguageDefinition_GetIdentifierCount_133)(id);
} // Function LanguageDefinition_GetIdentifierCount

const char* PluginWrapper::LanguageDefinition_GetIdentifier(int index, int id) {
    if(!this->m_pMPC.LanguageDefinition_GetIdentifier_134)
        return nullptr;
    return ((const char*(*)(int, int))this->m_pMPC.LanguageDefinition_GetIdentifier_134)(index, id);
} // Function LanguageDefinition_GetIdentifier

const char* PluginWrapper::LanguageDefinition_GetIdentifierDesc(int index, int id) {
    if(!this->m_pMPC.LanguageDefinition_GetIdentifierDesc_135)
        return nullptr;
    return ((const char*(*)(int, int))this->m_pMPC.LanguageDefinition_GetIdentifierDesc_135)(index, id);
} // Function LanguageDefinition_GetIdentifierDesc

const char* PluginWrapper::LanguageDefinition_GetCommentStart(int id) {
    if(!this->m_pMPC.LanguageDefinition_GetCommentStart_136)
        return nullptr;
    return ((const char*(*)(int))this->m_pMPC.LanguageDefinition_GetCommentStart_136)(id);
} // Function LanguageDefinition_GetCommentStart

const char* PluginWrapper::LanguageDefinition_GetCommentEnd(int id) {
    if(!this->m_pMPC.LanguageDefinition_GetCommentEnd_137)
        return nullptr;
    return ((const char*(*)(int))this->m_pMPC.LanguageDefinition_GetCommentEnd_137)(id);
} // Function LanguageDefinition_GetCommentEnd

const char* PluginWrapper::LanguageDefinition_GetLineComment(int id) {
    if(!this->m_pMPC.LanguageDefinition_GetLineComment_138)
        return nullptr;
    return ((const char*(*)(int))this->m_pMPC.LanguageDefinition_GetLineComment_138)(id);
} // Function LanguageDefinition_GetLineComment

bool PluginWrapper::LanguageDefinition_IsCaseSensitive(int id) {
    if(!this->m_pMPC.LanguageDefinition_IsCaseSensitive_139)
        return 0;
    return ((bool(*)(int))this->m_pMPC.LanguageDefinition_IsCaseSensitive_139)(id);
} // Function LanguageDefinition_IsCaseSensitive

bool PluginWrapper::LanguageDefinition_GetAutoIndent(int id) {
    if(!this->m_pMPC.LanguageDefinition_GetAutoIndent_140)
        return 0;
    return ((bool(*)(int))this->m_pMPC.LanguageDefinition_GetAutoIndent_140)(id);
} // Function LanguageDefinition_GetAutoIndent

const char* PluginWrapper::LanguageDefinition_GetName(int id) {
    if(!this->m_pMPC.LanguageDefinition_GetName_141)
        return nullptr;
    return ((const char*(*)(int))this->m_pMPC.LanguageDefinition_GetName_141)(id);
} // Function LanguageDefinition_GetName

const char* PluginWrapper::LanguageDefinition_GetNameAbbreviation(int id) {
    if(!this->m_pMPC.LanguageDefinition_GetNameAbbreviation_142)
        return nullptr;
    return ((const char*(*)(int))this->m_pMPC.LanguageDefinition_GetNameAbbreviation_142)(id);
} // Function LanguageDefinition_GetNameAbbreviation

int PluginWrapper::Autocomplete_GetCount(ed::plugin::ShaderStage stage) {
    if(!this->m_pMPC.Autocomplete_GetCount_143)
        return 0;
    return ((int(*)(ed::plugin::ShaderStage))this->m_pMPC.Autocomplete_GetCount_143)(stage);
} // Function Autocomplete_GetCount

const char* PluginWrapper::Autocomplete_GetDisplayString(ed::plugin::ShaderStage stage, int index) {
    if(!this->m_pMPC.Autocomplete_GetDisplayString_144)
        return nullptr;
    return ((const char*(*)(ed::plugin::ShaderStage, int))this->m_pMPC.Autocomplete_GetDisplayString_144)(stage, index);
} // Function Autocomplete_GetDisplayString

const char* PluginWrapper::Autocomplete_GetSearchString(ed::plugin::ShaderStage stage, int index) {
    if(!this->m_pMPC.Autocomplete_GetSearchString_145)
        return nullptr;
    return ((const char*(*)(ed::plugin::ShaderStage, int))this->m_pMPC.Autocomplete_GetSearchString_145)(stage, index);
} // Function Autocomplete_GetSearchString

const char* PluginWrapper::Autocomplete_GetValue(ed::plugin::ShaderStage stage, int index) {
    if(!this->m_pMPC.Autocomplete_GetValue_146)
        return nullptr;
    return ((const char*(*)(ed::plugin::ShaderStage, int))this->m_pMPC.Autocomplete_GetValue_146)(stage, index);
} // Function Autocomplete_GetValue

int PluginWrapper::ShaderFilePath_GetCount() {
    if(!this->m_pMPC.ShaderFilePath_GetCount_147)
        return 0;
    return ((int(*)())this->m_pMPC.ShaderFilePath_GetCount_147)();
} // Function ShaderFilePath_GetCount

const char* PluginWrapper::ShaderFilePath_Get(int index) {
    if(!this->m_pMPC.ShaderFilePath_Get_148)
        return nullptr;
    return ((const char*(*)(int))this->m_pMPC.ShaderFilePath_Get_148)(index);
} // Function ShaderFilePath_Get

bool PluginWrapper::ShaderFilePath_HasChanged() {
    if(!this->m_pMPC.ShaderFilePath_HasChanged_149)
        return 0;
    return ((bool(*)())this->m_pMPC.ShaderFilePath_HasChanged_149)();
} // Function ShaderFilePath_HasChanged

void PluginWrapper::ShaderFilePath_Update() {
    if(!this->m_pMPC.ShaderFilePath_Update_150)
        return;
    ((void(*)())this->m_pMPC.ShaderFilePath_Update_150)();
} // Function ShaderFilePath_Update

bool PluginWrapper::HandleDropFile(const char* filename) {
    if(!this->m_pMPC.HandleDropFile_151)
        return 0;
    return ((bool(*)(const char*))this->m_pMPC.HandleDropFile_151)(filename);
} // Function HandleDropFile

void PluginWrapper::HandleRecompile(const char* itemName) {
    if(!this->m_pMPC.HandleRecompile_152)
        return;
    ((void(*)(const char*))this->m_pMPC.HandleRecompile_152)(itemName);
} // Function HandleRecompile

void PluginWrapper::HandleRecompileFromSource(const char* itemName, int sid, const char* shaderCode, int shaderSize) {
    if(!this->m_pMPC.HandleRecompileFromSource_153)
        return;
    ((void(*)(const char*, int, const char*, int))this->m_pMPC.HandleRecompileFromSource_153)(itemName, sid, shaderCode, shaderSize);
} // Function HandleRecompileFromSource

void PluginWrapper::HandleShortcut(const char* name) {
    if(!this->m_pMPC.HandleShortcut_154)
        return;
    ((void(*)(const char*))this->m_pMPC.HandleShortcut_154)(name);
} // Function HandleShortcut

void PluginWrapper::HandlePluginMessage(const char* sender, char* msg, int msgLen) {
    if(!this->m_pMPC.HandlePluginMessage_155)
        return;
    ((void(*)(const char*, char*, int))this->m_pMPC.HandlePluginMessage_155)(sender, msg, msgLen);
} // Function HandlePluginMessage

void PluginWrapper::HandleApplicationEvent(ed::plugin::ApplicationEvent event, void* data1, void* data2) {
    if(!this->m_pMPC.HandleApplicationEvent_156)
        return;
    ((void(*)(ed::plugin::ApplicationEvent, void*, void*))this->m_pMPC.HandleApplicationEvent_156)(event, data1, data2);
} // Function HandleApplicationEvent

void PluginWrapper::HandleNotification(int id) {
    if(!this->m_pMPC.HandleNotification_157)
        return;
    ((void(*)(int))this->m_pMPC.HandleNotification_157)(id);
} // Function HandleNotification

bool PluginWrapper::PipelineItem_SupportsImmediateMode(const char* type, void* data, ed::plugin::ShaderStage stage) {
    if(!this->m_pMPC.PipelineItem_SupportsImmediateMode_158)
        return 0;
    return ((bool(*)(const char*, void*, ed::plugin::ShaderStage))this->m_pMPC.PipelineItem_SupportsImmediateMode_158)(type, data, stage);
} // Function PipelineItem_SupportsImmediateMode

bool PluginWrapper::PipelineItem_HasCustomImmediateModeCompiler(const char* type, void* data, ed::plugin::ShaderStage stage) {
    if(!this->m_pMPC.PipelineItem_HasCustomImmediateModeCompiler_159)
        return 0;
    return ((bool(*)(const char*, void*, ed::plugin::ShaderStage))this->m_pMPC.PipelineItem_HasCustomImmediateModeCompiler_159)(type, data, stage);
} // Function PipelineItem_HasCustomImmediateModeCompiler

bool PluginWrapper::PipelineItem_ImmediateModeCompile(const char* type, void* data, ed::plugin::ShaderStage stage, const char* expression) {
    if(!this->m_pMPC.PipelineItem_ImmediateModeCompile_160)
        return 0;
    return ((bool(*)(const char*, void*, ed::plugin::ShaderStage, const char*))this->m_pMPC.PipelineItem_ImmediateModeCompile_160)(type, data, stage, expression);
} // Function PipelineItem_ImmediateModeCompile

unsigned int PluginWrapper::ImmediateMode_GetSPIRVSize() {
    if(!this->m_pMPC.ImmediateMode_GetSPIRVSize_161)
        return 0;
    return ((unsigned int(*)())this->m_pMPC.ImmediateMode_GetSPIRVSize_161)();
} // Function ImmediateMode_GetSPIRVSize

unsigned int* PluginWrapper::ImmediateMode_GetSPIRV() {
    if(!this->m_pMPC.ImmediateMode_GetSPIRV_162)
        return nullptr;
    return ((unsigned int*(*)())this->m_pMPC.ImmediateMode_GetSPIRV_162)();
} // Function ImmediateMode_GetSPIRV

unsigned int PluginWrapper::ImmediateMode_GetVariableCount() {
    if(!this->m_pMPC.ImmediateMode_GetVariableCount_163)
        return 0;
    return ((unsigned int(*)())this->m_pMPC.ImmediateMode_GetVariableCount_163)();
} // Function ImmediateMode_GetVariableCount

const char* PluginWrapper::ImmediateMode_GetVariableName(unsigned int index) {
    if(!this->m_pMPC.ImmediateMode_GetVariableName_164)
        return nullptr;
    return ((const char*(*)(unsigned int))this->m_pMPC.ImmediateMode_GetVariableName_164)(index);
} // Function ImmediateMode_GetVariableName

int PluginWrapper::ImmediateMode_GetResultID() {
    if(!this->m_pMPC.ImmediateMode_GetResultID_165)
        return 0;
    return ((int(*)())this->m_pMPC.ImmediateMode_GetResultID_165)();
} // Function ImmediateMode_GetResultID

void PluginWrapper::PluginManager_RegisterPlugins() {
    if(!this->m_pMPC.PluginManager_RegisterPlugins_166)
        return;
    ((void(*)())this->m_pMPC.PluginManager_RegisterPlugins_166)();
} // Function PluginManager_RegisterPlugins

const unsigned int* PluginWrapper::CustomLanguage_CompileToSPIRV2(void* item, int langID, const char* src, size_t src_len, ed::plugin::ShaderStage stage, const char* entry, ed::plugin::ShaderMacro* macros, size_t macroCount, size_t* spv_length, bool* compiled) {
    if(!this->m_pMPC.CustomLanguage_CompileToSPIRV2_167)
        return nullptr;
    return ((const unsigned int*(*)(void*, int, const char*, size_t, ed::plugin::ShaderStage, const char*, ed::plugin::ShaderMacro*, size_t, size_t*, bool*))this->m_pMPC.CustomLanguage_CompileToSPIRV2_167)(item, langID, src, src_len, stage, entry, macros, macroCount, spv_length, compiled);
} // Function CustomLanguage_CompileToSPIRV2

void PluginWrapper::ShaderEditor_SetLineIndicator(int langID, int editorID, int line) {
    if(!this->m_pMPC.ShaderEditor_SetLineIndicator_168)
        return;
    ((void(*)(int, int, int))this->m_pMPC.ShaderEditor_SetLineIndicator_168)(langID, editorID, line);
} // Function ShaderEditor_SetLineIndicator

void PluginWrapper::InitUPC() {
    m_sUPC.Renderer_000 = (void*)(this->Renderer);
    m_sUPC.Messages_001 = (void*)(this->Messages);
    m_sUPC.Project_002 = (void*)(this->Project);
    m_sUPC.UI_003 = (void*)(this->UI);
    m_sUPC.ObjectManager_004 = (void*)(this->ObjectManager);
    m_sUPC.PipelineManager_005 = (void*)(this->PipelineManager);
    m_sUPC.Plugins_006 = (void*)(this->Plugins);
    m_sUPC.Debugger_007 = (void*)(this->Debugger);
    m_sUPC.AddObject_008 = (void*)(this->AddObject);
    m_sUPC.AddCustomPipelineItem_009 = (void*)(this->AddCustomPipelineItem);
    m_sUPC.AddMessage_010 = (void*)(this->AddMessage);
    m_sUPC.CreateRenderTexture_011 = (void*)(this->CreateRenderTexture);
    m_sUPC.CreateImage_012 = (void*)(this->CreateImage);
    m_sUPC.ResizeRenderTexture_013 = (void*)(this->ResizeRenderTexture);
    m_sUPC.ResizeImage_014 = (void*)(this->ResizeImage);
    m_sUPC.ExistsObject_015 = (void*)(this->ExistsObject);
    m_sUPC.RemoveGlobalObject_016 = (void*)(this->RemoveGlobalObject);
    m_sUPC.GetProjectPath_017 = (void*)(this->GetProjectPath);
    m_sUPC.GetRelativePath_018 = (void*)(this->GetRelativePath);
    m_sUPC.GetProjectFilename_019 = (void*)(this->GetProjectFilename);
    m_sUPC.GetProjectDirectory_020 = (void*)(this->GetProjectDirectory);
    m_sUPC.IsProjectModified_021 = (void*)(this->IsProjectModified);
    m_sUPC.ModifyProject_022 = (void*)(this->ModifyProject);
    m_sUPC.OpenProject_023 = (void*)(this->OpenProject);
    m_sUPC.SaveProject_024 = (void*)(this->SaveProject);
    m_sUPC.SaveAsProject_025 = (void*)(this->SaveAsProject);
    m_sUPC.IsPaused_026 = (void*)(this->IsPaused);
    m_sUPC.Pause_027 = (void*)(this->Pause);
    m_sUPC.GetWindowColorTexture_028 = (void*)(this->GetWindowColorTexture);
    m_sUPC.GetWindowDepthTexture_029 = (void*)(this->GetWindowDepthTexture);
    m_sUPC.GetLastRenderSize_030 = (void*)(this->GetLastRenderSize);
    m_sUPC.Render_031 = (void*)(this->Render);
    m_sUPC.ExistsPipelineItem_032 = (void*)(this->ExistsPipelineItem);
    m_sUPC.GetPipelineItem_033 = (void*)(this->GetPipelineItem);
    m_sUPC.BindShaderPassVariables_034 = (void*)(this->BindShaderPassVariables);
    m_sUPC.GetViewMatrix_035 = (void*)(this->GetViewMatrix);
    m_sUPC.GetProjectionMatrix_036 = (void*)(this->GetProjectionMatrix);
    m_sUPC.GetOrthographicMatrix_037 = (void*)(this->GetOrthographicMatrix);
    m_sUPC.GetViewportSize_038 = (void*)(this->GetViewportSize);
    m_sUPC.AdvanceTimer_039 = (void*)(this->AdvanceTimer);
    m_sUPC.GetMousePosition_040 = (void*)(this->GetMousePosition);
    m_sUPC.GetFrameIndex_041 = (void*)(this->GetFrameIndex);
    m_sUPC.GetTime_042 = (void*)(this->GetTime);
    m_sUPC.SetTime_043 = (void*)(this->SetTime);
    m_sUPC.SetGeometryTransform_044 = (void*)(this->SetGeometryTransform);
    m_sUPC.SetMousePosition_045 = (void*)(this->SetMousePosition);
    m_sUPC.SetKeysWASD_046 = (void*)(this->SetKeysWASD);
    m_sUPC.SetFrameIndex_047 = (void*)(this->SetFrameIndex);
    m_sUPC.GetDPI_048 = (void*)(this->GetDPI);
    m_sUPC.FileExists_049 = (void*)(this->FileExists);
    m_sUPC.ClearMessageGroup_050 = (void*)(this->ClearMessageGroup);
    m_sUPC.Log_051 = (void*)(this->Log);
    m_sUPC.GetObjectCount_052 = (void*)(this->GetObjectCount);
    m_sUPC.GetObjectName_053 = (void*)(this->GetObjectName);
    m_sUPC.IsTexture_054 = (void*)(this->IsTexture);
    m_sUPC.GetTexture_055 = (void*)(this->GetTexture);
    m_sUPC.GetFlippedTexture_056 = (void*)(this->GetFlippedTexture);
    m_sUPC.GetTextureSize_057 = (void*)(this->GetTextureSize);
    m_sUPC.BindDefaultState_058 = (void*)(this->BindDefaultState);
    m_sUPC.OpenInCodeEditor_059 = (void*)(this->OpenInCodeEditor);
    m_sUPC.GetPipelineItemCount_060 = (void*)(this->GetPipelineItemCount);
    m_sUPC.GetPipelineItemType_061 = (void*)(this->GetPipelineItemType);
    m_sUPC.GetPipelineItemByIndex_062 = (void*)(this->GetPipelineItemByIndex);
    m_sUPC.GetPipelineItemName_063 = (void*)(this->GetPipelineItemName);
    m_sUPC.GetPipelineItemPluginOwner_064 = (void*)(this->GetPipelineItemPluginOwner);
    m_sUPC.GetPipelineItemVariableCount_065 = (void*)(this->GetPipelineItemVariableCount);
    m_sUPC.GetPipelineItemVariableName_066 = (void*)(this->GetPipelineItemVariableName);
    m_sUPC.GetPipelineItemVariableValue_067 = (void*)(this->GetPipelineItemVariableValue);
    m_sUPC.GetPipelineItemVariableType_068 = (void*)(this->GetPipelineItemVariableType);
    m_sUPC.AddPipelineItemVariable_069 = (void*)(this->AddPipelineItemVariable);
    m_sUPC.GetPipelineItemChildrenCount_070 = (void*)(this->GetPipelineItemChildrenCount);
    m_sUPC.GetPipelineItemChild_071 = (void*)(this->GetPipelineItemChild);
    m_sUPC.SetPipelineItemPosition_072 = (void*)(this->SetPipelineItemPosition);
    m_sUPC.SetPipelineItemRotation_073 = (void*)(this->SetPipelineItemRotation);
    m_sUPC.SetPipelineItemScale_074 = (void*)(this->SetPipelineItemScale);
    m_sUPC.GetPipelineItemPosition_075 = (void*)(this->GetPipelineItemPosition);
    m_sUPC.GetPipelineItemRotation_076 = (void*)(this->GetPipelineItemRotation);
    m_sUPC.GetPipelineItemScale_077 = (void*)(this->GetPipelineItemScale);
    m_sUPC.DEPRECATED_GetOpenDirectoryDialog_078 = (void*)(this->DEPRECATED_GetOpenDirectoryDialog);
    m_sUPC.DEPRECATED_GetOpenFileDialog_079 = (void*)(this->DEPRECATED_GetOpenFileDialog);
    m_sUPC.DEPRECATED_GetSaveFileDialog_080 = (void*)(this->DEPRECATED_GetSaveFileDialog);
    m_sUPC.GetIncludePathCount_081 = (void*)(this->GetIncludePathCount);
    m_sUPC.GetIncludePath_082 = (void*)(this->GetIncludePath);
    m_sUPC.GetMessagesCurrentItem_083 = (void*)(this->GetMessagesCurrentItem);
    m_sUPC.OnEditorContentChange_084 = (void*)(this->OnEditorContentChange);
    m_sUPC.GetPipelineItemSPIRV_085 = (void*)(this->GetPipelineItemSPIRV);
    m_sUPC.RegisterShortcut_086 = (void*)(this->RegisterShortcut);
    m_sUPC.GetSettingsBoolean_087 = (void*)(this->GetSettingsBoolean);
    m_sUPC.GetSettingsString_088 = (void*)(this->GetSettingsString);
    m_sUPC.GetSettingsInteger_089 = (void*)(this->GetSettingsInteger);
    m_sUPC.GetSettingsFloat_090 = (void*)(this->GetSettingsFloat);
    m_sUPC.GetPreviewUIRect_091 = (void*)(this->GetPreviewUIRect);
    m_sUPC.GetPlugin_092 = (void*)(this->GetPlugin);
    m_sUPC.GetPluginListSize_093 = (void*)(this->GetPluginListSize);
    m_sUPC.GetPluginName_094 = (void*)(this->GetPluginName);
    m_sUPC.SendPluginMessage_095 = (void*)(this->SendPluginMessage);
    m_sUPC.BroadcastPluginMessage_096 = (void*)(this->BroadcastPluginMessage);
    m_sUPC.ToggleFullscreen_097 = (void*)(this->ToggleFullscreen);
    m_sUPC.IsFullscreen_098 = (void*)(this->IsFullscreen);
    m_sUPC.TogglePerformanceMode_099 = (void*)(this->TogglePerformanceMode);
    m_sUPC.IsInPerformanceMode_100 = (void*)(this->IsInPerformanceMode);
    m_sUPC.PushNotification_101 = (void*)(this->PushNotification);
    m_sUPC.DebuggerJump_102 = (void*)(this->DebuggerJump);
    m_sUPC.DebuggerContinue_103 = (void*)(this->DebuggerContinue);
    m_sUPC.DebuggerStep_104 = (void*)(this->DebuggerStep);
    m_sUPC.DebuggerStepInto_105 = (void*)(this->DebuggerStepInto);
    m_sUPC.DebuggerStepOut_106 = (void*)(this->DebuggerStepOut);
    m_sUPC.DebuggerCheckBreakpoint_107 = (void*)(this->DebuggerCheckBreakpoint);
    m_sUPC.DebuggerIsDebugging_108 = (void*)(this->DebuggerIsDebugging);
    m_sUPC.DebuggerGetCurrentLine_109 = (void*)(this->DebuggerGetCurrentLine);
    m_sUPC.IsRenderTexture_110 = (void*)(this->IsRenderTexture);
    m_sUPC.GetRenderTextureSize_111 = (void*)(this->GetRenderTextureSize);
    m_sUPC.GetDepthTexture_112 = (void*)(this->GetDepthTexture);
    m_sUPC.ScaleSize_113 = (void*)(this->ScaleSize);
    m_sUPC.GetHostIPluginMaxVersion_114 = (void*)(this->GetHostIPluginMaxVersion);
    m_sUPC.ImGuiFileDialogOpen_115 = (void*)(this->ImGuiFileDialogOpen);
    m_sUPC.ImGuiDirectoryDialogOpen_116 = (void*)(this->ImGuiDirectoryDialogOpen);
    m_sUPC.ImGuiFileDialogIsDone_117 = (void*)(this->ImGuiFileDialogIsDone);
    m_sUPC.ImGuiFileDialogClose_118 = (void*)(this->ImGuiFileDialogClose);
    m_sUPC.ImGuiFileDialogGetResult_119 = (void*)(this->ImGuiFileDialogGetResult);
    m_sUPC.ImGuiFileDialogGetPath_120 = (void*)(this->ImGuiFileDialogGetPath);
    m_sUPC.DebuggerImmediate_121 = (void*)(this->DebuggerImmediate);
    m_sUPC.RegisterPlugin_122 = (void*)(this->RegisterPlugin);
    m_sUPC.GetEditorPipelineItem_123 = (void*)(this->GetEditorPipelineItem);
    m_sUPC.SetViewportSize_124 = (void*)(this->SetViewportSize);
    m_sUPC.IsObjectBound_125 = (void*)(this->IsObjectBound);
    m_sUPC.DebuggerStepIntoPluginEditor_126 = (void*)(this->DebuggerStepIntoPluginEditor);
    m_sUPC.DebuggerGetVariableValue_127 = (void*)(this->DebuggerGetVariableValue);
    m_sUPC.DebuggerStopPluginEditor_128 = (void*)(this->DebuggerStopPluginEditor);
    m_sUPC.DebuggerIsVMRunning_129 = (void*)(this->DebuggerIsVMRunning);
    m_sUPC.PluginInstance = (void*)this;
}

PluginWrapper::PluginWrapper(ManagedPointerCollection& a_pMPC) {
    this->m_pMPC = a_pMPC;
}

PluginWrapper::~PluginWrapper() {
}
