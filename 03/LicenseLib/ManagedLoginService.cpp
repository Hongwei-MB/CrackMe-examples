#include "pch.h"
#include "ManagedLoginService.h"
#include "NativeLoginService.h"
#include <msclr/marshal_cppstd.h>

using namespace System::Runtime::InteropServices;

namespace LoginWrapper {
    ManagedLoginService::ManagedLoginService()
    {
        nativeService = new NativeLoginService();
    }

    ManagedLoginService::~ManagedLoginService()
    {
        this->!ManagedLoginService();
    }

    ManagedLoginService::!ManagedLoginService()
    {
        delete nativeService;
    }

    void ManagedLoginService::CheckPermission(String^ userName, String^ password)
    {
        std::string nativeUserName = msclr::interop::marshal_as<std::string>(userName);
        std::string nativePassword = msclr::interop::marshal_as<std::string>(password);
        nativeService->CheckPermission(nativeUserName, nativePassword);
    }
}