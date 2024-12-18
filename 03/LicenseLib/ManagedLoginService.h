#pragma once

#include "NativeLoginService.h"
#include <msclr/marshal_cppstd.h>

using namespace System;

namespace LoginWrapper {
    public ref class ManagedLoginService
    {
    public:
        ManagedLoginService();
        ~ManagedLoginService();
        !ManagedLoginService();
        void CheckPermission(String^ userName, String^ password);
    private:
        NativeLoginService* nativeService;
    };
}