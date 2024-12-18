#include "pch.h"
#include "NativeLoginService.h"




void NativeLoginService::CheckPermission(const std::string& userName, const std::string& password) {
    if (userName != "admin" || password != "My333") {
        throw InvalidCredentialsException();
    }
}