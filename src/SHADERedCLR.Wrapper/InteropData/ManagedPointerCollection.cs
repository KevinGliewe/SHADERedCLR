using System;
using System.Runtime.InteropServices;

namespace SHADERedCLR.Wrapper.InteropData {
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct ManagedPointerCollection {
        [FieldOffset(0)] public IntPtr Init_000;
        [FieldOffset(8)] public IntPtr InitUI_001;
        [FieldOffset(16)] public IntPtr OnEvent_002;
        [FieldOffset(24)] public IntPtr Update_003;
        [FieldOffset(32)] public IntPtr Destroy_004;
        [FieldOffset(40)] public IntPtr IsRequired_005;
        [FieldOffset(48)] public IntPtr IsVersionCompatible_006;
        [FieldOffset(56)] public IntPtr BeginRender_007;
        [FieldOffset(64)] public IntPtr EndRender_008;
        [FieldOffset(72)] public IntPtr Project_BeginLoad_009;
        [FieldOffset(80)] public IntPtr Project_EndLoad_010;
        [FieldOffset(88)] public IntPtr Project_BeginSave_011;
        [FieldOffset(96)] public IntPtr Project_EndSave_012;
        [FieldOffset(104)] public IntPtr Project_HasAdditionalData_013;
        [FieldOffset(112)] public IntPtr Project_ExportAdditionalData_014;
        [FieldOffset(120)] public IntPtr Project_ImportAdditionalData_015;
        [FieldOffset(128)] public IntPtr Project_CopyFilesOnSave_016;
        [FieldOffset(136)] public IntPtr HasCustomMenuItem_017;
        [FieldOffset(144)] public IntPtr HasMenuItems_018;
        [FieldOffset(152)] public IntPtr ShowMenuItems_019;
        [FieldOffset(160)] public IntPtr HasContextItems_020;
        [FieldOffset(168)] public IntPtr ShowContextItems_021;
        [FieldOffset(176)] public IntPtr SystemVariables_GetNameCount_022;
        [FieldOffset(184)] public IntPtr SystemVariables_GetName_023;
        [FieldOffset(192)] public IntPtr SystemVariables_HasLastFrame_024;
        [FieldOffset(200)] public IntPtr SystemVariables_UpdateValue_025;
        [FieldOffset(208)] public IntPtr VariableFunctions_GetNameCount_026;
        [FieldOffset(216)] public IntPtr VariableFunctions_GetName_027;
        [FieldOffset(224)] public IntPtr VariableFunctions_ShowArgumentEdit_028;
        [FieldOffset(232)] public IntPtr VariableFunctions_UpdateValue_029;
        [FieldOffset(240)] public IntPtr VariableFunctions_GetArgsSize_030;
        [FieldOffset(248)] public IntPtr VariableFunctions_InitArguments_031;
        [FieldOffset(256)] public IntPtr VariableFunctions_ExportArguments_032;
        [FieldOffset(264)] public IntPtr VariableFunctions_ImportArguments_033;
        [FieldOffset(272)] public IntPtr Object_HasPreview_034;
        [FieldOffset(280)] public IntPtr Object_ShowPreview_035;
        [FieldOffset(288)] public IntPtr Object_IsBindable_036;
        [FieldOffset(296)] public IntPtr Object_IsBindableUAV_037;
        [FieldOffset(304)] public IntPtr Object_Remove_038;
        [FieldOffset(312)] public IntPtr Object_HasExtendedPreview_039;
        [FieldOffset(320)] public IntPtr Object_ShowExtendedPreview_040;
        [FieldOffset(328)] public IntPtr Object_HasProperties_041;
        [FieldOffset(336)] public IntPtr Object_ShowProperties_042;
        [FieldOffset(344)] public IntPtr Object_Bind_043;
        [FieldOffset(352)] public IntPtr Object_Export_044;
        [FieldOffset(360)] public IntPtr Object_Import_045;
        [FieldOffset(368)] public IntPtr Object_HasContext_046;
        [FieldOffset(376)] public IntPtr Object_ShowContext_047;
        [FieldOffset(384)] public IntPtr PipelineItem_HasProperties_048;
        [FieldOffset(392)] public IntPtr PipelineItem_ShowProperties_049;
        [FieldOffset(400)] public IntPtr PipelineItem_IsPickable_050;
        [FieldOffset(408)] public IntPtr PipelineItem_HasShaders_051;
        [FieldOffset(416)] public IntPtr PipelineItem_OpenInEditor_052;
        [FieldOffset(424)] public IntPtr PipelineItem_CanHaveChild_053;
        [FieldOffset(432)] public IntPtr PipelineItem_GetInputLayoutSize_054;
        [FieldOffset(440)] public IntPtr PipelineItem_GetInputLayoutItem_055;
        [FieldOffset(448)] public IntPtr PipelineItem_Remove_056;
        [FieldOffset(456)] public IntPtr PipelineItem_Rename_057;
        [FieldOffset(464)] public IntPtr PipelineItem_AddChild_058;
        [FieldOffset(472)] public IntPtr PipelineItem_CanHaveChildren_059;
        [FieldOffset(480)] public IntPtr PipelineItem_CopyData_060;
        [FieldOffset(488)] public IntPtr PipelineItem_Execute_061;
        [FieldOffset(496)] public IntPtr PipelineItem_Execute_062;
        [FieldOffset(504)] public IntPtr PipelineItem_GetWorldMatrix_063;
        [FieldOffset(512)] public IntPtr PipelineItem_Intersect_064;
        [FieldOffset(520)] public IntPtr PipelineItem_GetBoundingBox_065;
        [FieldOffset(528)] public IntPtr PipelineItem_HasContext_066;
        [FieldOffset(536)] public IntPtr PipelineItem_ShowContext_067;
        [FieldOffset(544)] public IntPtr PipelineItem_Export_068;
        [FieldOffset(552)] public IntPtr PipelineItem_Import_069;
        [FieldOffset(560)] public IntPtr PipelineItem_MoveDown_070;
        [FieldOffset(568)] public IntPtr PipelineItem_MoveUp_071;
        [FieldOffset(576)] public IntPtr PipelineItem_ApplyGizmoTransform_072;
        [FieldOffset(584)] public IntPtr PipelineItem_GetTransform_073;
        [FieldOffset(592)] public IntPtr PipelineItem_DebugVertexExecute_074;
        [FieldOffset(600)] public IntPtr PipelineItem_DebugVertexExecute_075;
        [FieldOffset(608)] public IntPtr PipelineItem_DebugInstanceExecute_076;
        [FieldOffset(616)] public IntPtr PipelineItem_DebugInstanceExecute_077;
        [FieldOffset(624)] public IntPtr PipelineItem_GetVBO_078;
        [FieldOffset(632)] public IntPtr PipelineItem_GetVBOStride_079;
        [FieldOffset(640)] public IntPtr PipelineItem_CanChangeVariables_080;
        [FieldOffset(648)] public IntPtr PipelineItem_IsDebuggable_081;
        [FieldOffset(656)] public IntPtr PipelineItem_IsStageDebuggable_082;
        [FieldOffset(664)] public IntPtr PipelineItem_DebugExecute_083;
        [FieldOffset(672)] public IntPtr PipelineItem_GetTopology_084;
        [FieldOffset(680)] public IntPtr PipelineItem_GetVariableCount_085;
        [FieldOffset(688)] public IntPtr PipelineItem_GetVariableName_086;
        [FieldOffset(696)] public IntPtr PipelineItem_GetVariableType_087;
        [FieldOffset(704)] public IntPtr PipelineItem_GetVariableValueFloat_088;
        [FieldOffset(712)] public IntPtr PipelineItem_GetVariableValueInteger_089;
        [FieldOffset(720)] public IntPtr PipelineItem_GetVariableValueBoolean_090;
        [FieldOffset(728)] public IntPtr PipelineItem_GetSPIRVSize_091;
        [FieldOffset(736)] public IntPtr PipelineItem_GetSPIRV_092;
        [FieldOffset(744)] public IntPtr PipelineItem_DebugPrepareVariables_093;
        [FieldOffset(752)] public IntPtr PipelineItem_DebugUsesCustomTextures_094;
        [FieldOffset(760)] public IntPtr PipelineItem_DebugGetTexture_095;
        [FieldOffset(768)] public IntPtr PipelineItem_DebugGetTextureSize_096;
        [FieldOffset(776)] public IntPtr Options_HasSection_097;
        [FieldOffset(784)] public IntPtr Options_RenderSection_098;
        [FieldOffset(792)] public IntPtr Options_Parse_099;
        [FieldOffset(800)] public IntPtr Options_GetCount_100;
        [FieldOffset(808)] public IntPtr Options_GetKey_101;
        [FieldOffset(816)] public IntPtr Options_GetValue_102;
        [FieldOffset(824)] public IntPtr CustomLanguage_GetCount_103;
        [FieldOffset(832)] public IntPtr CustomLanguage_GetName_104;
        [FieldOffset(840)] public IntPtr CustomLanguage_CompileToSPIRV_105;
        [FieldOffset(848)] public IntPtr CustomLanguage_ProcessGeneratedGLSL_106;
        [FieldOffset(856)] public IntPtr CustomLanguage_SupportsAutoUniforms_107;
        [FieldOffset(864)] public IntPtr CustomLanguage_IsDebuggable_108;
        [FieldOffset(872)] public IntPtr CustomLanguage_GetDefaultExtension_109;
        [FieldOffset(880)] public IntPtr ShaderEditor_Supports_110;
        [FieldOffset(888)] public IntPtr ShaderEditor_Open_111;
        [FieldOffset(896)] public IntPtr ShaderEditor_Render_112;
        [FieldOffset(904)] public IntPtr ShaderEditor_Close_113;
        [FieldOffset(912)] public IntPtr ShaderEditor_GetContent_114;
        [FieldOffset(920)] public IntPtr ShaderEditor_IsChanged_115;
        [FieldOffset(928)] public IntPtr ShaderEditor_ResetChangeState_116;
        [FieldOffset(936)] public IntPtr ShaderEditor_CanUndo_117;
        [FieldOffset(944)] public IntPtr ShaderEditor_CanRedo_118;
        [FieldOffset(952)] public IntPtr ShaderEditor_Undo_119;
        [FieldOffset(960)] public IntPtr ShaderEditor_Redo_120;
        [FieldOffset(968)] public IntPtr ShaderEditor_Cut_121;
        [FieldOffset(976)] public IntPtr ShaderEditor_Paste_122;
        [FieldOffset(984)] public IntPtr ShaderEditor_Copy_123;
        [FieldOffset(992)] public IntPtr ShaderEditor_SelectAll_124;
        [FieldOffset(1000)] public IntPtr ShaderEditor_HasStats_125;
        [FieldOffset(1008)] public IntPtr CodeEditor_SaveItem_126;
        [FieldOffset(1016)] public IntPtr CodeEditor_CloseItem_127;
        [FieldOffset(1024)] public IntPtr LanguageDefinition_Exists_128;
        [FieldOffset(1032)] public IntPtr LanguageDefinition_GetKeywordCount_129;
        [FieldOffset(1040)] public IntPtr LanguageDefinition_GetKeywords_130;
        [FieldOffset(1048)] public IntPtr LanguageDefinition_GetTokenRegexCount_131;
        [FieldOffset(1056)] public IntPtr LanguageDefinition_GetTokenRegex_132;
        [FieldOffset(1064)] public IntPtr LanguageDefinition_GetIdentifierCount_133;
        [FieldOffset(1072)] public IntPtr LanguageDefinition_GetIdentifier_134;
        [FieldOffset(1080)] public IntPtr LanguageDefinition_GetIdentifierDesc_135;
        [FieldOffset(1088)] public IntPtr LanguageDefinition_GetCommentStart_136;
        [FieldOffset(1096)] public IntPtr LanguageDefinition_GetCommentEnd_137;
        [FieldOffset(1104)] public IntPtr LanguageDefinition_GetLineComment_138;
        [FieldOffset(1112)] public IntPtr LanguageDefinition_IsCaseSensitive_139;
        [FieldOffset(1120)] public IntPtr LanguageDefinition_GetAutoIndent_140;
        [FieldOffset(1128)] public IntPtr LanguageDefinition_GetName_141;
        [FieldOffset(1136)] public IntPtr LanguageDefinition_GetNameAbbreviation_142;
        [FieldOffset(1144)] public IntPtr Autocomplete_GetCount_143;
        [FieldOffset(1152)] public IntPtr Autocomplete_GetDisplayString_144;
        [FieldOffset(1160)] public IntPtr Autocomplete_GetSearchString_145;
        [FieldOffset(1168)] public IntPtr Autocomplete_GetValue_146;
        [FieldOffset(1176)] public IntPtr ShaderFilePath_GetCount_147;
        [FieldOffset(1184)] public IntPtr ShaderFilePath_Get_148;
        [FieldOffset(1192)] public IntPtr ShaderFilePath_HasChanged_149;
        [FieldOffset(1200)] public IntPtr ShaderFilePath_Update_150;
        [FieldOffset(1208)] public IntPtr HandleDropFile_151;
        [FieldOffset(1216)] public IntPtr HandleRecompile_152;
        [FieldOffset(1224)] public IntPtr HandleRecompileFromSource_153;
        [FieldOffset(1232)] public IntPtr HandleShortcut_154;
        [FieldOffset(1240)] public IntPtr HandlePluginMessage_155;
        [FieldOffset(1248)] public IntPtr HandleApplicationEvent_156;
        [FieldOffset(1256)] public IntPtr HandleNotification_157;
        [FieldOffset(1264)] public IntPtr PipelineItem_SupportsImmediateMode_158;
        [FieldOffset(1272)] public IntPtr PipelineItem_HasCustomImmediateModeCompiler_159;
        [FieldOffset(1280)] public IntPtr PipelineItem_ImmediateModeCompile_160;
        [FieldOffset(1288)] public IntPtr ImmediateMode_GetSPIRVSize_161;
        [FieldOffset(1296)] public IntPtr ImmediateMode_GetSPIRV_162;
        [FieldOffset(1304)] public IntPtr ImmediateMode_GetVariableCount_163;
        [FieldOffset(1312)] public IntPtr ImmediateMode_GetVariableName_164;
        [FieldOffset(1320)] public IntPtr ImmediateMode_GetResultID_165;
        [FieldOffset(1328)] public IntPtr PluginManager_RegisterPlugins_166;
    [FieldOffset(1336)] public IntPtr __SetUPC;
    }
}