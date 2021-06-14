// dllmain.cpp : Definiert den Einstiegspunkt für die DLL-Anwendung.
#include "pch.h"


#ifdef WIN32
# define FEXPORT __declspec(dllexport)
#else
# define FEXPORT // empty
#endif

#include "PluginCLR.h"

extern "C" {
	FEXPORT sc::PluginCLR* CreatePlugin() {
		return new sc::PluginCLR();
	}
	FEXPORT void DestroyPlugin(sc::PluginCLR* ptr) {
		delete ptr;
	}
	FEXPORT int GetPluginAPIVersion() {
		return 3;
	}
	FEXPORT int GetPluginVersion() {
		return 1;
	}
	FEXPORT const char* GetPluginName() {
		return "SHADERedCLR";
	}
}

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
                     )
{
    switch (ul_reason_for_call)
    {
    case DLL_PROCESS_ATTACH:
	    sc::p_pModuleHandle = hModule;
    case DLL_THREAD_ATTACH:
    case DLL_THREAD_DETACH:
    case DLL_PROCESS_DETACH:
        break;
    }
    return TRUE;
}

