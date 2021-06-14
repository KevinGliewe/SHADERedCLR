#include "pch.h"
#include "PluginCLR.h"
#include "PluginWrapper.h"

#include <dotnet_runtime.h>

#include <fstream>

#define STR DOTNET_RUNTIME_STR
#define DIR_SEPARATOR DOTNET_RUNTIME_DIR_SEPARATOR

using wstring_t = std::basic_string<wchar_t>;

inline bool exists (string_t name) {
    std::ifstream f(name.c_str());
    return f.good();
}

void* sc::p_pModuleHandle;

void* FP_CreateNativePlugin(PluginWrapper::ManagedPointerCollection a_sMPC)
{
    auto* plugin = new PluginWrapper(a_sMPC);
    return plugin;
}

void FP_DestroyNativePlugin(void* a_pPlugin)
{
    auto plugin = (PluginWrapper*)(a_pPlugin);
    delete(plugin);
}

bool sc::PluginCLR::Init(bool isWeb, int sedVersion)
{
    string_t plugin_path =
        STR("plugins")
        DIR_SEPARATOR
        STR("SHADERedCLR")
        DIR_SEPARATOR;

    string_t hostfxr_path = 
        plugin_path +
        DOTNET_RUNTIME_PATH_HOSTFXR;

    string_t lib_path =
        plugin_path +
        STR("PluginManager")
        DIR_SEPARATOR;

    string_t libDll_path = 
        lib_path + 
        STR("PluginManager.dll");

    string_t libRuntimeconfig_path = 
        lib_path + 
        STR("PluginManager.runtimeconfig.json");


    assert(exists(hostfxr_path));
    assert(exists(libDll_path));
    assert(exists(libRuntimeconfig_path));

    auto pRuntime = new dotnet_runtime::Runtime(hostfxr_path, libRuntimeconfig_path);
    this->m_netRuntime = pRuntime;

    auto pLibrary = new dotnet_runtime::Library(pRuntime, libDll_path, STR("PluginManager"));
    this->m_netLibrary = pLibrary;

    auto _initHost = pLibrary->GetComponentEntrypoint(
        STR("PluginManager.NativeInterop"),
        STR("InitHost")
    );

    struct
    {
        void* m_hostHandle;
        void* m_pluginPtr;
        void* m_createNativePlugin;
        void* m_destroyNativePlugin;
    } _initHost_arg;

    _initHost_arg.m_hostHandle = p_pModuleHandle;
    _initHost_arg.m_pluginPtr = this;
    _initHost_arg.m_createNativePlugin = &FP_CreateNativePlugin;
    _initHost_arg.m_destroyNativePlugin = &FP_DestroyNativePlugin;

    _initHost(&_initHost_arg, sizeof(_initHost_arg));

    this->m_pManagedPluginManager = _initHost_arg.m_pluginPtr;


    return true;
}

void sc::PluginCLR::PluginManager_RegisterPlugins()
{
    this->RegisterPlugin(this->Plugins, this->m_pManagedPluginManager, "ManagedPluginManager", 3, 1, 0);
}

sc::PluginCLR::~PluginCLR()
{
    delete (dotnet_runtime::Library*)this->m_netLibrary;
    delete (dotnet_runtime::Runtime*)this->m_netRuntime;
}
