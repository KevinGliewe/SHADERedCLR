using System;
using System.Runtime.InteropServices;

namespace PluginManager.InteropData {
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct UnmanagedPointerCollection {
        public IntPtr GetVersion_000;
        public IntPtr Init_001;
        public IntPtr InitUI_002;
        public IntPtr OnEvent_003;
        public IntPtr Update_004;
        public IntPtr Destroy_005;
        public IntPtr IsRequired_006;
        public IntPtr IsVersionCompatible_007;
        public IntPtr BeginRender_008;
        public IntPtr EndRender_009;
        public IntPtr Project_BeginLoad_010;
        public IntPtr Project_EndLoad_011;
        public IntPtr Project_BeginSave_012;
        public IntPtr Project_EndSave_013;
        public IntPtr Project_HasAdditionalData_014;
        public IntPtr Project_ExportAdditionalData_015;
        public IntPtr Project_ImportAdditionalData_016;
        public IntPtr Project_CopyFilesOnSave_017;
        public IntPtr HasCustomMenuItem_018;
        public IntPtr HasMenuItems_019;
        public IntPtr ShowMenuItems_020;
        public IntPtr HasContextItems_021;
        public IntPtr ShowContextItems_022;
        public IntPtr SystemVariables_GetNameCount_023;
        public IntPtr SystemVariables_GetName_024;
        public IntPtr SystemVariables_HasLastFrame_025;
        public IntPtr SystemVariables_UpdateValue_026;
        public IntPtr VariableFunctions_GetNameCount_027;
        public IntPtr VariableFunctions_GetName_028;
        public IntPtr VariableFunctions_ShowArgumentEdit_029;
        public IntPtr VariableFunctions_UpdateValue_030;
        public IntPtr VariableFunctions_GetArgsSize_031;
        public IntPtr VariableFunctions_InitArguments_032;
        public IntPtr VariableFunctions_ExportArguments_033;
        public IntPtr VariableFunctions_ImportArguments_034;
        public IntPtr Object_HasPreview_035;
        public IntPtr Object_ShowPreview_036;
        public IntPtr Object_IsBindable_037;
        public IntPtr Object_IsBindableUAV_038;
        public IntPtr Object_Remove_039;
        public IntPtr Object_HasExtendedPreview_040;
        public IntPtr Object_ShowExtendedPreview_041;
        public IntPtr Object_HasProperties_042;
        public IntPtr Object_ShowProperties_043;
        public IntPtr Object_Bind_044;
        public IntPtr Object_Export_045;
        public IntPtr Object_Import_046;
        public IntPtr Object_HasContext_047;
        public IntPtr Object_ShowContext_048;
        public IntPtr PipelineItem_HasProperties_049;
        public IntPtr PipelineItem_ShowProperties_050;
        public IntPtr PipelineItem_IsPickable_051;
        public IntPtr PipelineItem_HasShaders_052;
        public IntPtr PipelineItem_OpenInEditor_053;
        public IntPtr PipelineItem_CanHaveChild_054;
        public IntPtr PipelineItem_GetInputLayoutSize_055;
        public IntPtr PipelineItem_GetInputLayoutItem_056;
        public IntPtr PipelineItem_Remove_057;
        public IntPtr PipelineItem_Rename_058;
        public IntPtr PipelineItem_AddChild_059;
        public IntPtr PipelineItem_CanHaveChildren_060;
        public IntPtr PipelineItem_CopyData_061;
        public IntPtr PipelineItem_Execute_062;
        public IntPtr PipelineItem_Execute_063;
        public IntPtr PipelineItem_GetWorldMatrix_064;
        public IntPtr PipelineItem_Intersect_065;
        public IntPtr PipelineItem_GetBoundingBox_066;
        public IntPtr PipelineItem_HasContext_067;
        public IntPtr PipelineItem_ShowContext_068;
        public IntPtr PipelineItem_Export_069;
        public IntPtr PipelineItem_Import_070;
        public IntPtr PipelineItem_MoveDown_071;
        public IntPtr PipelineItem_MoveUp_072;
        public IntPtr PipelineItem_ApplyGizmoTransform_073;
        public IntPtr PipelineItem_GetTransform_074;
        public IntPtr PipelineItem_DebugVertexExecute_075;
        public IntPtr PipelineItem_DebugVertexExecute_076;
        public IntPtr PipelineItem_DebugInstanceExecute_077;
        public IntPtr PipelineItem_DebugInstanceExecute_078;
        public IntPtr PipelineItem_GetVBO_079;
        public IntPtr PipelineItem_GetVBOStride_080;
        public IntPtr PipelineItem_CanChangeVariables_081;
        public IntPtr PipelineItem_IsDebuggable_082;
        public IntPtr PipelineItem_IsStageDebuggable_083;
        public IntPtr PipelineItem_DebugExecute_084;
        public IntPtr PipelineItem_GetTopology_085;
        public IntPtr PipelineItem_GetVariableCount_086;
        public IntPtr PipelineItem_GetVariableName_087;
        public IntPtr PipelineItem_GetVariableType_088;
        public IntPtr PipelineItem_GetVariableValueFloat_089;
        public IntPtr PipelineItem_GetVariableValueInteger_090;
        public IntPtr PipelineItem_GetVariableValueBoolean_091;
        public IntPtr PipelineItem_GetSPIRVSize_092;
        public IntPtr PipelineItem_GetSPIRV_093;
        public IntPtr PipelineItem_DebugPrepareVariables_094;
        public IntPtr PipelineItem_DebugUsesCustomTextures_095;
        public IntPtr PipelineItem_DebugGetTexture_096;
        public IntPtr PipelineItem_DebugGetTextureSize_097;
        public IntPtr Options_HasSection_098;
        public IntPtr Options_RenderSection_099;
        public IntPtr Options_Parse_100;
        public IntPtr Options_GetCount_101;
        public IntPtr Options_GetKey_102;
        public IntPtr Options_GetValue_103;
        public IntPtr CustomLanguage_GetCount_104;
        public IntPtr CustomLanguage_GetName_105;
        public IntPtr CustomLanguage_CompileToSPIRV_106;
        public IntPtr CustomLanguage_ProcessGeneratedGLSL_107;
        public IntPtr CustomLanguage_SupportsAutoUniforms_108;
        public IntPtr CustomLanguage_IsDebuggable_109;
        public IntPtr CustomLanguage_GetDefaultExtension_110;
        public IntPtr ShaderEditor_Supports_111;
        public IntPtr ShaderEditor_Open_112;
        public IntPtr ShaderEditor_Render_113;
        public IntPtr ShaderEditor_Close_114;
        public IntPtr ShaderEditor_GetContent_115;
        public IntPtr ShaderEditor_IsChanged_116;
        public IntPtr ShaderEditor_ResetChangeState_117;
        public IntPtr ShaderEditor_CanUndo_118;
        public IntPtr ShaderEditor_CanRedo_119;
        public IntPtr ShaderEditor_Undo_120;
        public IntPtr ShaderEditor_Redo_121;
        public IntPtr ShaderEditor_Cut_122;
        public IntPtr ShaderEditor_Paste_123;
        public IntPtr ShaderEditor_Copy_124;
        public IntPtr ShaderEditor_SelectAll_125;
        public IntPtr ShaderEditor_HasStats_126;
        public IntPtr CodeEditor_SaveItem_127;
        public IntPtr CodeEditor_CloseItem_128;
        public IntPtr LanguageDefinition_Exists_129;
        public IntPtr LanguageDefinition_GetKeywordCount_130;
        public IntPtr LanguageDefinition_GetKeywords_131;
        public IntPtr LanguageDefinition_GetTokenRegexCount_132;
        public IntPtr LanguageDefinition_GetTokenRegex_133;
        public IntPtr LanguageDefinition_GetIdentifierCount_134;
        public IntPtr LanguageDefinition_GetIdentifier_135;
        public IntPtr LanguageDefinition_GetIdentifierDesc_136;
        public IntPtr LanguageDefinition_GetCommentStart_137;
        public IntPtr LanguageDefinition_GetCommentEnd_138;
        public IntPtr LanguageDefinition_GetLineComment_139;
        public IntPtr LanguageDefinition_IsCaseSensitive_140;
        public IntPtr LanguageDefinition_GetAutoIndent_141;
        public IntPtr LanguageDefinition_GetName_142;
        public IntPtr LanguageDefinition_GetNameAbbreviation_143;
        public IntPtr Autocomplete_GetCount_144;
        public IntPtr Autocomplete_GetDisplayString_145;
        public IntPtr Autocomplete_GetSearchString_146;
        public IntPtr Autocomplete_GetValue_147;
        public IntPtr ShaderFilePath_GetCount_148;
        public IntPtr ShaderFilePath_Get_149;
        public IntPtr ShaderFilePath_HasChanged_150;
        public IntPtr ShaderFilePath_Update_151;
        public IntPtr HandleDropFile_152;
        public IntPtr HandleRecompile_153;
        public IntPtr HandleRecompileFromSource_154;
        public IntPtr HandleShortcut_155;
        public IntPtr HandlePluginMessage_156;
        public IntPtr HandleApplicationEvent_157;
        public IntPtr HandleNotification_158;
        public IntPtr GetVersion_159;
        public IntPtr PipelineItem_SupportsImmediateMode_160;
        public IntPtr PipelineItem_HasCustomImmediateModeCompiler_161;
        public IntPtr PipelineItem_ImmediateModeCompile_162;
        public IntPtr ImmediateMode_GetSPIRVSize_163;
        public IntPtr ImmediateMode_GetSPIRV_164;
        public IntPtr ImmediateMode_GetVariableCount_165;
        public IntPtr ImmediateMode_GetVariableName_166;
        public IntPtr ImmediateMode_GetResultID_167;
        public IntPtr GetVersion_168;
        public IntPtr PluginManager_RegisterPlugins_169;
        public IntPtr PluginInstance;
    }
}