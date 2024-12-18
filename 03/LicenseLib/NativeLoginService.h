#pragma once
#include <string>
#include <stdexcept>

class InvalidCredentialsException : public std::runtime_error {
public:
    InvalidCredentialsException() : std::runtime_error("Invalid credentials") {}
};

class NativeLoginService
{
public:
    void CheckPermission(const std::string& userName, const std::string& password);
};