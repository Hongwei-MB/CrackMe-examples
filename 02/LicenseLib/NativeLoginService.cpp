#include "pch.h"
#include "NativeLoginService.h"

bool NativeLoginService::CheckPermission(const std::string& userName, const std::string& password)
{
    return userName == "admin" && password == "MB";
}