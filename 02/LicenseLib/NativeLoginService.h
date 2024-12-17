#pragma once
#include <string>

class NativeLoginService
{
public:
    bool CheckPermission(const std::string& userName, const std::string& password);
};